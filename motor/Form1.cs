using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Giao tiếp qua Serial
using System.IO;
using System.IO.Ports;
using System.Xml;

// Thêm ZedGraph
using ZedGraph;

namespace motor
{

    public partial class Form1 : Form
    {
        #region
        string c_mode;
        int setpoint = 0,setpoint1=0;
        string set_point = "0";
        string data;
        string Tam = "";
        double[] Data = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] Data_2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double set_1=0, set_0=0;
        long tickStart = 0;

        int status = 0; // Khai báo biến để xử lý sự kiện vẽ đồ thị
        double realtime = 0; //Khai báo biến thời gian để vẽ đồ thị
        #endregion

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.UART.DataReceived += new
            System.IO.Ports.SerialDataReceivedEventHandler(this.UART_DataReceived);
            tickStart = Environment.TickCount;


           

            // Khởi tạo ZedGraph
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Đồ thị dữ liệu theo thời gian";
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Dữ liệu";

            RollingPointPairList list1 = new RollingPointPairList(60000);
            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem curve1 = myPane.AddCurve("Dữ liệu", list1, Color.Red, SymbolType.None);
            LineItem curve2 = myPane.AddCurve("Dữ liệu", list2, Color.Blue, SymbolType.None);
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 3;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 5;
            myPane.YAxis.Scale.Min = -20;
            myPane.YAxis.Scale.Max = 20;

            myPane.AxisChange();

        }



        public void ClearTextBoxes(Form form)
        {
            foreach (Control control in form.Controls)
            {

                if (control.GetType() == typeof(TextBox))
                {

                    control.Text = "";

                }

            }
        }

        //Calling this Function
        

      




        private void Connect_Click(object sender, EventArgs e)
        { 
            if (btnConnect.Text == "CONNECT")
            {
                btnConnect.Text = "DISCONNECT";
                btnStart.Enabled = true;
                btnStop.Enabled = true;
                UART.Open();
                Status.Text = "Đã kết nối";
            }
            else
            {
                btnConnect.Text = "CONNECT";
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                Status.Text = "Dừng kết nối";
                UART.Close();
            }
        }

        private void btnStart_Clicked(object sender, EventArgs e)
        {
            if (cbxSpeed.Checked == false && cbxPosition.Checked == false)
            {
                MessageBox.Show(" Bạn chưa chọn chế độ");
                return;
            }
            if (cbxSpeed.Checked == true && cbxPosition.Checked == true)
            {
                MessageBox.Show(" Bạn không được chọn cả hai");
                return;
            }
            if (cbxSpeed.Checked == true)
            {
                GraphPane myPane = zedGraphControl1.GraphPane;
                myPane.Title.Text = "Đồ thị dữ liệu theo thời gian";
                myPane.XAxis.Title.Text = "Thời gian (s)";
                myPane.YAxis.Title.Text = "Tốc độ";
                zedGraphControl1.GraphPane.CurveList[0].Label.Text = "Tốc độ";
                zedGraphControl1.GraphPane.CurveList[1].Label.Text = "Tín hiệu dặt";

                myPane.XAxis.Scale.Max = 3;
                myPane.XAxis.Scale.MinorStep = 1;
                myPane.XAxis.Scale.MajorStep = 5;
                myPane.YAxis.Scale.Min = 0;
                myPane.YAxis.Scale.Max = 200;

                c_mode = "s";
                if (set.Text == "")
                {
                    setpoint = 0;
                    set_point = string.Format("{0:0000}", 0);
                   

                }
                else
                {
                    setpoint = int.Parse(set.Text);
                    set_point = string.Format("{0:0000}", setpoint);
                }
            }
            if (cbxPosition.Checked == true)
            {
                GraphPane myPane = zedGraphControl1.GraphPane;
                myPane.Title.Text = "Đồ thị dữ liệu theo thời gian";
                myPane.XAxis.Title.Text = "Thời gian (s)";
                myPane.YAxis.Title.Text = "Vị trí";
                zedGraphControl1.GraphPane.CurveList[0].Label.Text = "Ví trí";
                zedGraphControl1.GraphPane.CurveList[1].Label.Text="Tín hiệu dặt";
                
                myPane.XAxis.Scale.Max = 3;
                myPane.XAxis.Scale.MinorStep = 1;
                myPane.XAxis.Scale.MajorStep = 5;
                myPane.YAxis.Scale.Min = 0;
                myPane.YAxis.Scale.Max = 360;

                myPane.AxisChange();
                c_mode = "p";
                if (set.Text == "")
                {
                    setpoint = 0;
                    set_point = string.Format("{0:0000}", 0);
                }
                else
                {
                    
                    setpoint = int.Parse(set.Text);
                    setpoint1 = setpoint * 20 / 9;
                    set_point = string.Format("{0:0000}", setpoint1);
                }
            }
            data = c_mode + "" + set_point + "!";
            UART.Write(data);
        }

        private void btnStop_Clicked(object sender, EventArgs e)
        {
            try
            {
                data = "S" + "!";
                UART.Write(data);
            }
            catch (Exception)
            {

            }
        }

        private void btnRight_Clicked(object sender, EventArgs e)
        {
            UART.Write("R" + "!");
            btnRight.Enabled = false;
            btnLeft.Enabled = true;
        }

        private void btnLeft_Clicked(object sender, EventArgs e)
        {
            UART.Write("L" + "!");
            btnRight.Enabled = true;
            btnLeft.Enabled = false;
        }

        private void btnDegree_Clicked(object sender, EventArgs e)
        {
            UART.Write("D" + "!");
            btnStart_Clicked(sender, e);
            if (cbxSpeed.Checked == true)
            {
                set.Text = Convert.ToString(setpoint - 200);
            }
            else if (cbxPosition.Checked == true)
            { 
                set.Text = Convert.ToString(setpoint - 30);
            }
            setpoint = int.Parse(set.Text);
           

        }

        private void btnIncrease_Clicked(object sender, EventArgs e)
        {
            UART.Write("I" + "!");
            btnStart_Clicked(sender, e);
            if (cbxSpeed.Checked == true)
            {
                set.Text = Convert.ToString(setpoint + 200);
            }
            else if (cbxPosition.Checked == true)
            {
                set.Text = Convert.ToString(setpoint + 30);
            }
            setpoint = int.Parse(set.Text);
           
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            var fm1 = new Form1();
            ClearTextBoxes(fm1);
            UART.Write("C" + "!");
        }
        private void UART_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                Tam = UART.ReadTo("\r");
                Data[0] = Convert.ToDouble(Tam);
                status = 1;
                realtime += 0.1;
                BeginInvoke(new Action(() => { }));
            }
            catch(Exception)
            {

            }
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void set_TextChanged(object sender, EventArgs e)
        {

        }

        private void draw()
        {
            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;

            LineItem curve1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            LineItem curve2 = zedGraphControl1.GraphPane.CurveList[1] as LineItem;

            if (curve1 == null)
                return;

            IPointListEdit list1 = curve1.Points as IPointListEdit;

            if (curve2 == null)
                return;

            IPointListEdit list2 = curve2.Points as IPointListEdit;

            if (list1 == null)
                return;
            if (list2 == null)
                return;

            list1.Add(realtime, Data[0]); // Thêm điểm trên đồ thị
            list2.Add(realtime, setpoint); // Thêm điểm trên đồ thị

            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;
            Scale yScale = zedGraphControl1.GraphPane.YAxis.Scale;

            // Tự động Scale theo trục x
            if (realtime > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = realtime + xScale.MajorStep;
                xScale.Min = xScale.Max - 30;
            }

            // Tự động Scale theo trục y
            if (Data[0] > yScale.Max - yScale.MajorStep)
            {
                yScale.Max = Data[0] + yScale.MajorStep;
            }
            else if (Data[0] < yScale.Min + yScale.MajorStep)
            {
                yScale.Min = Data[0] - yScale.MajorStep;
            }
            // Tự động Scale theo trục y

            if (setpoint > yScale.Max - yScale.MajorStep)
            {
                yScale.Max = setpoint + yScale.MajorStep;
            }
            else if (setpoint < yScale.Min + yScale.MajorStep)
            {
                yScale.Min = setpoint - yScale.MajorStep;
            }

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

         
                if (!UART.IsOpen)
                {
                    
                }
                else if (UART.IsOpen)
                {
                   
                    draw();
                   
                    status = 0;
                }
            


            set_1 = Data[0];
            if (cbxSpeed.Checked==true)
            {
                txbSpeed.Text = " Speed: " + set_1.ToString() + "  RPM";

            }
            else
            {
                txbSpeed.Text = "Position: " + set_1.ToString() + "  Deg";
            }

        }
    }

}


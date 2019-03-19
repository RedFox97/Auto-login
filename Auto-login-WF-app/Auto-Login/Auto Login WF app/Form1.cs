using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Auto_Login_WF_app
{
    public partial class Form1 : Form
    {
        int soCongCOM;      // So cong COM ban dau

        public Form1()
        {
            InitializeComponent();
        }
        
        // Cập nhật COM theo chu kì 1 giây vào ComboBox
        private void timer_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); // Lấy danh sách công COM
            if (soCongCOM != ports.Length){
                soCongCOM = ports.Length;
                COMList.Items.Clear();
                for (int i = 0; i < soCongCOM; i++)
                    COMList.Items.Add(ports[i]);
            }
        }

        // Kết nối với cổng COM
        private void ketNoi_Click(object sender, EventArgs e)
        {
            if(ketNoi.Text == "Kết nối")        // Mở kết nối
            {
                if(COMList.Text == "")          // Chưa chọn cổng COM sẽ phải hiện thông báo để chọn lại cổng COM
                {
                    MessageBox.Show("Chọn lại cổng COM");
                }
                else
                {
                    COM.PortName = COMList.Text;    // Set tên cổng COM                              
                    COM.BaudRate = 9600;            // Set tốc độ baud, nên để mặc định 9600
                    COM.Open();                     // Mở cổng kết nối
                    ketNoi.Text  = "Ngắt kết nối";
                    psk.ReadOnly = false;
                }
            }
            else // Ngắt kết nối
            {
                COM.Close();
                psk.Text        = "";
                psk.ReadOnly    = true;
                ketNoi.Text     = "Kết nối";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            COM.WriteLine(psk.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActUtlTypeLib;     
                         
using ZedGraph;    
using System.IO;   // Khai báo namespace để sử dụng các lớp và phương thức liên quan đến
                   // những thao tác với file, như tạo và xóa file, đọc và ghi một file, đóng một file
using System.Threading;  //Sử dụng cho hàm Delay
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Code_WinForm
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
         public ActUtlType plc = new ActUtlType();

         //Nút nhấn kết nối/ngắt kết nối
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (btn_Connect.Text == "Connect")  //Nếu màn hình đang hiển thị Connect
            {
                plc.ActLogicalStationNumber = 1;     
                plc.Open();                     
                btn_Connect.Text = "Disconnect";//Nhấn Connect xong thì lập tức chuyển sang Disconnect
                btn_Connect.BackColor = Color.Red;
                pictureBox_tick_Ok.Show();  //Show icon là kết nối thành công

                //Gán giá trị ban đầu 1000 cho tốc độ JOG trục X
                double a = Convert.ToDouble(txt_Jog_SpeedX.Text);
                double a1 = Math.Round(a, 4);
                a1 = a1 * 100;
                int a2 = Convert.ToInt32(a1);  //Convert sang số nguyên
                int d103, d102;
                d103 = a2 / 65536;
                d102 = a2 % 65536;
                plc.SetDevice("D102", d102);
                plc.SetDevice("D103", d103);

                //Gán giá trị ban đầu 1000 cho tốc độ JOG trục Y
                double b = Convert.ToDouble(txt_Jog_SpeedY.Text);
                double b1 = Math.Round(b, 4);
                b1 = b1 * 100;
                int b2 = Convert.ToInt32(b1);  //Convert sang số nguyên
                int d202, d203;
                d203 = b2 / 65536;
                d202 = b2 % 65536;
                plc.SetDevice("D202", d202);
                plc.SetDevice("D203", d203);

                //Gán giá trị ban đầu 1000 cho tốc độ JOG trục Z
                double c = Convert.ToDouble(txt_Jog_SpeedZ.Text);
                double c1 = Math.Round(c, 4);
                c1 = c1 * 100;
                int c2 = Convert.ToInt32(c1);  //Convert sang số nguyên
                int d302, d303;
                d303 = c2 / 65536;
                d302 = c2 % 65536;
                plc.SetDevice("D302", d302);
                plc.SetDevice("D303", d303);

                //Tốc độ nội suy tới điểm 1 và tới điểm 2 
                //Tốc độ nội suy tới điểm 1 và tới điểm 2 ở D104, D105  bằng giá trị trong textbox tốc độ nội suy
                double n = Convert.ToDouble(txt_Speed_point1_to_point2.Text);
                double n1 = Math.Round(n, 4);
                n1 = n1 * 100;
                int n2 = Convert.ToInt32(n1);  //Convert sang số nguyên
                int d104, d105;
                d105 = n2 / 65536;
                d104 = n2 % 65536;
                plc.SetDevice("D104", d104);
                plc.SetDevice("D105", d105);

                //Tốc độ nội suy trục Z
                double l = Convert.ToDouble(txt_SpeedZ_nội_suy.Text);
                double l1 = Math.Round(l, 4);
                l1 = l1 * 100;
                int l2 = Convert.ToInt32(l1);  //Convert sang số nguyên
                int d304, d305;
                d305 = l2 / 65536;
                d304 = l2 % 65536;
                plc.SetDevice("D304", d304);
                plc.SetDevice("D305", d305);

                //Tọa độ đi xuống của trục Z trong nội suy
                double q = Convert.ToDouble(txt_Toa_độ_Z_nội_suy.Text);
                double q1 = Math.Round(q, 4);
                q1 = q1 * 10 * 1000;
                int q2 = Convert.ToInt32(q1);  //Convert sang số nguyên
                int d212, d213;
                d213 = q2 / 65536;
                d212 = q2 % 65536;
                plc.SetDevice("D212", d212);
                plc.SetDevice("D213", d213);

                //P1X trong nội suy
                double u = Convert.ToDouble(txt_P1_X.Text);
                double u1 = Math.Round(u, 4);
                u1 = u1 * 10 * 1000;
                int u2 = Convert.ToInt32(u1);  //Convert sang số nguyên
                int d106, d107;
                d107 = u2 / 65536;
                d106 = u2 % 65536;
                plc.SetDevice("D106", d106);
                plc.SetDevice("D107", d107);

                //P1Y trong nội suy
                double v = Convert.ToDouble(txt_P1_Y.Text);
                double v1 = Math.Round(v, 4);
                v1 = v1 * 10 * 1000;
                int v2 = Convert.ToInt32(v1);  //Convert sang số nguyên
                int d206, d207;
                d207 = v2 / 65536;
                d206 = v2 % 65536;
                plc.SetDevice("D206", d206);
                plc.SetDevice("D207", d207);

                //P2X trong nội suy
                double w = Convert.ToDouble(txt_P2_X.Text);
                double w1 = Math.Round(w, 4);
                w1 = w1 * 10 * 1000;
                int w2 = Convert.ToInt32(w1);  //Convert sang số nguyên
                int d108, d109;
                d109 = w2 / 65536;
                d108 = w2 % 65536;
                plc.SetDevice("D108", d108);
                plc.SetDevice("D109", d109);

                //P2Y trong nội suy
                double y = Convert.ToDouble(txt_P2_Y.Text);
                double y1 = Math.Round(y, 4);
                y1 = y1 * 10 * 1000;
                int y2 = Convert.ToInt32(y1);  //Convert sang số nguyên
                int d208, d209;
                d209 = y2 / 65536;
                d208 = y2 % 65536;
                plc.SetDevice("D208", d208);
                plc.SetDevice("D209", d209);

                //Arc Adress X trong nội suy
                double z = Convert.ToDouble(txt_Arc_Adress_X.Text);
                double z1 = Math.Round(z, 4);
                z1 = z1 * 10 * 1000;
                int z2 = Convert.ToInt32(z1);  //Convert sang số nguyên
                int d110, d111;
                d111 = z2 / 65536;
                d110 = z2 % 65536;
                plc.SetDevice("D110", d110);
                plc.SetDevice("D111", d111);

                //Arc Adress Y trong nội suy
                double i = Convert.ToDouble(txt_Arc_Adress_Y.Text);
                double i1 = Math.Round(i, 4);
                i1 = i1 * 10 * 1000;
                int i2 = Convert.ToInt32(i1);  //Convert sang số nguyên
                int d210, d211;
                d211 = i2 / 65536;
                d210 = i2 % 65536;
                plc.SetDevice("D210", d210);
                plc.SetDevice("D211", d211);

                //Bật timer để bắt đầu đọc dữ liệu từ PLC
                timer1.Start();
                timer1.Interval = 1;  //Độ phân giải 1ms - 1ms đọc dữ liệu từ PLC 1 lần
            }
            else if (btn_Connect.Text == "Disconnect")//Khi màn hình chuyển sang chế độ sẵn sàng Disconnect
            {
                plc.Close();
                btn_Connect.Text = "Connect"; //Nhấn Disconnect xong thì lập tức chuyển sang Connect
                btn_Connect.BackColor = Color.Lime;
                pictureBox_tick_Ok.Hide();  //Khi ngắt kết nối thì lại ẩn icon kết nối thành công

                //Dừng timer khi ngắt kết nối với PLC
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e) //Hàm thiết lập trạng thái ban đầu cho giao diện khi mới mở
        {
            pictureBox_tick_Ok.Hide(); //Ban đầu khi mới mở giao diện thì Hide (tức là ẩn) icon kết nối thành công
            txt_Jog_SpeedX.Text = 1000.ToString(); 
            txt_Jog_SpeedY.Text = 1000.ToString();
            txt_Jog_SpeedZ.Text = 1000.ToString(); 


            txt_Speed_point1_to_point2.Text = 1000.ToString();

            //Gán tốc độ trục Z trong nội suy là 500
            txt_SpeedZ_nội_suy.Text = 500.ToString();

            //Gán vị trí đi xuống cho trục Z trong nội suy
            txt_Toa_độ_Z_nội_suy.Text = 0.ToString();

            //Gán vị trí đi lên cho trục Z trong nội suy
            txt_Z_up.Text = 0.ToString();

            //Ban đầu khi mở giao diện vị trí các trục X,Y,Z đều là 0 (vị trí Home)
            txt_X_Position.Text = 0.ToString();
            txt_Y_Position.Text = 0.ToString();
            txt_Z_Position.Text = 0.ToString();

            txt_P1_X.Text = 0.ToString();
            txt_P1_Y.Text = 0.ToString();
            txt_P2_X.Text = 0.ToString();
            txt_P2_Y.Text = 0.ToString();
            txt_Arc_Adress_X.Text = 0.ToString();
            txt_Arc_Adress_Y.Text = 0.ToString();

            //Thiết lập timer dùng để tạo đồng hồ thời gian thực ngay khi chương trình vừa được mở lên
            timer2.Start(); //Khởi động timer2 dùng tạo đồng hồ thời gian thực
            timer2.Interval = 1000; //Thời gian được cập nhật mỗi 1000ms = 1s như đồng hồ thật


            //Khởi tạo ZedGraph - Đồ thị tọa độ XY
            GraphPane myPane = Đồ_thị_tọa_độ_XY.GraphPane;
            myPane.Title.IsVisible = false;  //vô hiệu title đồ thị

            myPane.X2Axis.Title.Text = "Tọa độ X (mm)";
            myPane.X2Axis.Title.FontSpec.Size = 18;  
            myPane.X2Axis.Title.FontSpec.FontColor = Color.Red;  

            //Tạo Axis X ở bên dưới đồ thị
            myPane.XAxis.Title.Text = "Qũy đạo XY";
            myPane.XAxis.Title.FontSpec.Size = 20;  
            myPane.XAxis.Title.FontSpec.FontColor = Color.Red;  

            myPane.YAxis.Title.Text = "Tọa độ Y (mm)"; 
            myPane.YAxis.Title.FontSpec.Size = 18; 
            myPane.YAxis.Title.FontSpec.FontColor = Color.Red; 

            //Thêm gridline (đường lưới - các ô lưới) vào đồ thị và cho cùng có màu đen
            //Đường lưới được thêm vào tại các điểm "MajorGrid": độ chia lớn nhất của đồ thị
            myPane.X2Axis.MajorGrid.IsVisible = true; //Cho phép nhìn thấy (IsVisible = true) các đường lưới (Grid) của trục X
            myPane.YAxis.MajorGrid.IsVisible = true; //Cho phép nhìn thấy (IsVisible = true) các đường lưới (Grid) của trục Y
            myPane.X2Axis.MajorGrid.Color = Color.Black; //Đặt màu đen (Black) cho đường lưới (grid) trục X
            myPane.YAxis.MajorGrid.Color = Color.Black;  //Đặt màu đen (Black) cho đường lưới (grid) trục Y

            //Thiết lập dải giá trị Max, Min và Scale cho đồ thị
            //Thiết lập cho trục X
            myPane.X2Axis.Scale.Min = 0; // Min = 0;
            myPane.X2Axis.Scale.Max = 400; // Max = 400;
            myPane.X2Axis.Scale.MinorStep = 10; // Đơn vị chia nhỏ nhất 1
            myPane.X2Axis.Scale.MajorStep = 50; // Đơn vị chia lớn nhất 50
            myPane.X2Axis.IsVisible = true;

            //Thiết lập trục X bên dưới đồ thị giống hệt thiết X2
            //Không muốn hiển thị đánh số tọa độ ở trục X bên dưới thì sử dụng IsVisible = false cho Scale trục X
            //Tuy nhiên vẫn có thể hiển thị các độ chia lớn nhất và độ chia nhỏ nhất của trục X
            myPane.XAxis.IsVisible = true;
            myPane.XAxis.Scale.IsVisible = false;
            myPane.XAxis.Scale.Min = 0; // Min = 0;
            myPane.XAxis.Scale.Max = 400; // Max = 400;
            myPane.XAxis.Scale.MinorStep = 10; // Đơn vị chia nhỏ nhất 10
            myPane.XAxis.Scale.MajorStep = 50; // Đơn vị chia lớn nhất 50

            //Thiết lập cho trục Y
            myPane.YAxis.Scale.Min = 0; // Min = 0;
            myPane.YAxis.Scale.Max = 300; // Max = 300;
            myPane.YAxis.Scale.MinorStep = 10; // Đơn vị chia nhỏ nhất 10
            myPane.YAxis.Scale.MajorStep = 50; // Đơn vị chia lớn 50
            myPane.YAxis.Scale.IsReverse = true;  // Đảo lại chiều trục Y hướng xuống dưới (chiều tăng giá trị từ trên xuống dưới)


            // Thay đổi màu và kích thước tiêu đề (title) của đồ thị myPane
            //FontSpec là 1 lớp chứa thông tin về kích thước, màu sắc, kiểu khung, nền,...của văn bản trên đồ thị
            myPane.Title.FontSpec.FontColor = Color.Red;
            myPane.Title.FontSpec.Size = 20;  //Kích thước chữ trong tiêu đề của đồ thị đặt là 20

            //Thiết lập màu nền cho đồ thị
            //Thêm 1 a background gradient fill (biến thiên màu nền của "Đồ_thị_XY") vào khung trục tọa độ
            //-45F là độ dốc biến thiên màu, giống hệt với 45F trong đổi màu vùng ngay dưới đường cong
            //Có thể thay -45F thành các độ dốc khác để được vùng màu background vừa ý nhất
            //Tương tự như việc tô màu vùng ngay dưới đồ thị thì màu sắc cùng biến thiên (gradient) từ trái sang phải
            //Màu biến đổi từ trắng (White) sang màu (255,255,210)
            //FromArgb(255, 255, 210): tạo 1 cấu trúc màu được tạo ra sau khi pha trộn cường độ 3 màu RGB (Red - Green - Blue)
            //Hoàn toàn có thể thay (255,255,210) thành 1 màu bất kì khác như Red, Blue,...
            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 220), -45F);


            //Khai báo list1 dùng để chứa tập hợp các cặp điểm (tọa độ X, tọa độ Y)
            //Dữ liệu trong cặp điểm này có kiểu Double
            //Với khai báo LineItem thì đường cong myCurve khi được vẽ ra sẽ có dạng là 1 đường
            PointPairList list1 = new PointPairList();
            LineItem myCurve = myPane.AddCurve("Qũy đạo", list1, Color.Red, SymbolType.None);

            //Thay đổi vị trí chú thích trong đồ thị xuống dưới cùng
            myPane.Legend.Position = ZedGraph.LegendPos.Bottom;

            //Tự động thay đổi kích thước trục
            Đồ_thị_tọa_độ_XY.AxisChange();
        }


        //Tạo hàm dùng để vẽ đồ thị
         public void Draw(double setpoint1, double setpoint2)
        {
            if (Đồ_thị_tọa_độ_XY.GraphPane.CurveList.Count <= 0)
                return;


            LineItem Curve1 = Đồ_thị_tọa_độ_XY.GraphPane.CurveList[0] as LineItem;

            //Đặt độ dày đường cong Curve1 trong đồ thị là 2.0 (F là kiểu Float)
            Curve1.Line.Width = 2.0F;

            //Kiểm tra xem nếu Curve1 mà không có giá trị nào thì sẽ thoát
            if (Curve1 == null)
                return;

            //Tạo 1 danh sách list1 chứa các điểm trên đường cong Curve1
            IPointListEdit list1 = Curve1.Points as IPointListEdit;

            //Nếu list1 không có giá trị nào thì thoát luôn
            if (list1 == null)
                return;
            

            //Add cặp tọa độ X(setpoint1) và Y(setpoint2) vào trong list1 để vẽ đồ thị
            list1.Add(setpoint1, setpoint2);

            //Mở khóa để vẽ lại
            //Control nào gọi nó thì vẽ lại control đó
            //Invalidate() Mỗi khi được gọi, hàm naỳ sẽ tự động cập nhật lại Control gọi nó ra. tạo hiệu ứng động
            Đồ_thị_tọa_độ_XY.Invalidate();
        }


        //Nút nhấn thoát khỏi giao diện
        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            //Nếu người dùng vẫn chưa ngắt kết nối với hệ thống
            if (btn_Connect.Text == "Disconnect")
                MessageBox.Show("Bạn vui lòng ngắt kết nối với hệ thống trước khi thoát", //Thông báo muốn hiển thị 
                "Thông báo"); //Tên của hộp thoại

            //Nếu người dùng đã ngắt kết nối với hệ thống, tức đã nhấn Disconnect
            else if (btn_Connect.Text == "Connect")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình không", //Thông báo muốn hiển thị 
                "Thông báo", //Tên của hộp thoại
                MessageBoxButtons.YesNo,  //Button lựa chọn cho người dùng nhấn
                MessageBoxIcon.Question);  //Icon Waring sẽ hiển thị phía trước dòng thông báo muốn hiển thị

                if (result == DialogResult.Yes) //Nếu kết quả trả về là người dùng chọn Yes tức đồng ý thoát chương trình
                    Close();                    //Nếu không chọn Yes tức chọn No thì không làm gì cả
            }
        }

        private void txt_Jog_SpeedX_TextChanged(object sender, EventArgs e)
        {
            if (txt_Jog_SpeedX.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }
           
            string str0 = "";  
            foreach (char c in txt_Jog_SpeedX.Text)  
            {
                if (char.IsDigit(c) == false && c != '.') 
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.')
                {
                    str0 = str0 + c; 
                }
            }
            if (str0 != "")
            {
                double a = Convert.ToDouble(str0);
                double a1 = Math.Round(a, 4);
                a1 = a1 * 100;
                int a2 = Convert.ToInt32(a1);  //Convert sang số nguyên
                int d103, d102;
                d103 = a2 / 65536;
                d102 = a2 % 65536;
                plc.SetDevice("D102", d102);
                plc.SetDevice("D103", d103);
            } 
        }

        //CÁCH LÀM GIỐNG HỆT VỚI txt_P1_X 
        private void txt_Jog_SpeedY_TextChanged(object sender, EventArgs e)
        {
            if (txt_Jog_SpeedY.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }

            string str0 = "";
            foreach (char c in txt_Jog_SpeedY.Text)
            {
                if (char.IsDigit(c) == false && c != '.')
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.')
                {
                    str0 = str0 + c;
                }
            }
            if (str0 != "")
            {
                double a = Convert.ToDouble(str0);
                double a1 = Math.Round(a, 4);
                a1 = a1 * 100;
                int a2 = Convert.ToInt32(a1);  //Convert sang số nguyên
                int d203, d202;
                d203 = a2 / 65536;
                d202 = a2 % 65536;
                plc.SetDevice("D202", d202);
                plc.SetDevice("D203", d203);
            }
        }

        //CÁCH LÀM GIỐNG HỆT txt_P1_X
        private void txt_Jog_SpeedZ_TextChanged(object sender, EventArgs e)
        {
             if (txt_Jog_SpeedZ.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }

            string str0 = "";
            foreach (char c in txt_Jog_SpeedZ.Text)
            {
                if (char.IsDigit(c) == false && c != '.')
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.')
                {
                    str0 = str0 + c;
                }
            }
            if (str0 != "")
            {
                double a = Convert.ToDouble(str0);
                double a1 = Math.Round(a, 4);
                a1 = a1 * 100;
                int a2 = Convert.ToInt32(a1);  //Convert sang số nguyên
                int d303, d302;
                d303 = a2 / 65536;
                d302 = a2 % 65536;
                plc.SetDevice("D302", d302);
                plc.SetDevice("D303", d303);
            }
        }

        //Hàm MouseUp là sự kiện xảy ra khi chuột được nhả ra khỏi button
        private void btn_JOG_X_sub_MouseUp(object sender, MouseEventArgs e)
        {
            //Khi nhả chuột thì M3 được trả về giá trị 0 làm cho dừng chạy JOG ngược trục X khi nhả button
            plc.SetDevice("M3", 0);
        }

        //Hàm MouseDown là sự kiện xảy ra khi chuột nhấn button.
        private void btn_JOG_X_sub_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M3", 1);
        }

        //Sự kiện nhấn nút JOG+X
        private void btn_Jog_X_add_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M2", 1);
        }

        //Sự kiện nhả nút JOG+X
        private void btn_Jog_X_add_MouseUp(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M2", 0);
        }

        //Sự kiện nhấn nút JOG-Y
        private void btn_JOG_Y_sub_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M5", 1);
        }

        //Sự kiện nhả nút JOG-Y
        private void btn_JOG_Y_sub_MouseUp(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M5", 0);
        }

        //Sự kiện nhấn nút JOG+Y
        private void btn_JOG_Y_add_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M4", 1);
        }

        //Sự kiện nhả nút JOG+Y
        private void btn_JOG_Y_add_MouseUp(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M4", 0);
        }

        //Sự kiện khi nhấn nút JOG-Z
        private void btn_JOG_Z_sub_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M7", 1);
        }

        //Sự kiện khi nhả nút JOG-Z
        private void btn_JOG_Z_sub_MouseUp(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M7", 0);
        }

        //Sự kiện khi nhấn nút JOG+Z
        private void btn_JOG_Z_add_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M6", 1);
        }

        //Sự kiện khi nhả nút JOG+Z
        private void btn_JOG_Z_add_MouseUp(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M6", 0);
        }


        //Sự kiện khi nhấn nút Reset lỗi trục
        private void btn_Reset_Error_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M0", 1);
        }

        //Sự kiện xảy ra khi nhả nút Reset lỗi trục
        private void btn_Reset_Error_MouseUp(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M0", 0);
        }

        private void btn_On_Off_Click(object sender, EventArgs e)
        {
            if (btn_On_Off.Text == "ON")  //Nếu màn hình đang hiển thị ON
            {
                plc.SetDevice("M1", 1);
                btn_On_Off.Text = "OFF";//Nhấn Connect xong thì lập tức chuyển sang Disconnect
                btn_On_Off.BackColor = Color.Red;
            }
            else if (btn_On_Off.Text == "OFF")//Khi màn hình chuyển sang chế độ sẵn sàng Disconnect
            {
                plc.SetDevice("M1", 0);
                btn_On_Off.Text = "ON"; //Nhấn OFF xong thì lập tức chuyển sang ON
                btn_On_Off.BackColor = Color.Lime;
            }
        }

        //Sự kiện nhấn nút Stop
        private void btn_Stop_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M8", 1);
        }

        //Sự kiện nhả nút Stop
        private void btn_Stop_MouseUp(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M8", 0);
        }


        //Sự kiện nhấn nút Home
        private void btn_Home_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M110", 1);
        }

        // Sự kiện nhả nút Home
        private void btn_Home_MouseUp(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M110", 0);
        }

        //Sự kiện nhấn nút dò gốc
        private void btn_find_Home_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M100", 1);
        }

        //Sự kiện nhả nút dò gốc
        private void btn_find_Home_MouseUp(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M100", 0);
        }

        //Nhập tọa độ X của điểm 1 trong nội suy
        private void txt_P1_X_TextChanged(object sender, EventArgs e)
        {
            if (txt_P1_X.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            } 
            
            string str0 = "";  //Bước 1
            foreach (char c in txt_P1_X.Text)  //Bước 2
            {
                if (char.IsDigit(c) == false && c != '.')  //Nếu kí tự c không phải số và không phải dấu '.'
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if(char.IsDigit(c) || c == '.')  //Bước 2
                {
                    str0 = str0 + c;  //Lưu số được nhập vào textbox vào chuỗi str0
                }
            }
            if (str0 != "")  //Nếu chuỗi str0 khác rỗng - tức có số nhập vào
            {
                double u = Convert.ToDouble(str0);  //Bước 3
                double u1 = Math.Round(u, 4);
                u1 = u1 * 10 * 1000;
                int u2 = Convert.ToInt32(u1);  //Convert sang số nguyên
                int d106, d107;
                d107 = u2 / 65536;
                d106 = u2 % 65536;
                plc.SetDevice("D106", d106);
                plc.SetDevice("D107", d107);

                // Nếu tọa độ nhập lớn hơn 380 (giới hạn hành trình trục X)
                if (txt_P1_X.Text != "" && Convert.ToDouble(str0) > 380)
                {
                    MessageBox.Show("Nhập quá giới hạn hành trình trục X. Vui lòng nhập lại nhỏ hơn 380", 
                                    "CẢNH BÁO",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }    
        }

                                    //Nhập tọa độ Y của điểm 1 trong nội suy
        private void txt_P1_Y_TextChanged(object sender, EventArgs e)
        {
            if (txt_P1_Y.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }
            string str0 = "";  
            foreach (char c in txt_P1_Y.Text)  
            {
                if (char.IsDigit(c) == false && c != '.')  //Nếu kí tự c không phải số và không phải dấu '.'
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.') 
                {
                    str0 = str0 + c;  //Lưu số được nhập vào textbox vào chuỗi str0
                }
            }
            if (str0 != "")  //Nếu chuỗi str0 khác rỗng - tức có số nhập vào
            {
                double u = Convert.ToDouble(str0);  //Bước 3
                double u1 = Math.Round(u, 4);
                u1 = u1 * 10 * 1000;
                int u2 = Convert.ToInt32(u1);  //Convert sang số nguyên
                int d206, d207;
                d207 = u2 / 65536;
                d206 = u2 % 65536;
                plc.SetDevice("D206", d206);
                plc.SetDevice("D207", d207);

                // Nếu tọa độ nhập lớn hơn 280 (giới hạn hành trình trục Y)
                if (txt_P1_Y.Text != "" && Convert.ToDouble(str0) > 280)
                {
                    MessageBox.Show("Nhập quá giới hạn hành trình trục Y. Vui lòng nhập lại nhỏ hơn 280",
                                    "CẢNH BÁO",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

                            //Nhập tọa độ X của điểm 2 trong nội suy
        private void txt_P2_X_TextChanged(object sender, EventArgs e)
        {
            if (txt_P2_X.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }
            string str0 = "";  
            foreach (char c in txt_P2_X.Text)  
            {
                if (char.IsDigit(c) == false && c != '.')  //Nếu kí tự c không phải số và không phải dấu '.'
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.')  
                {
                    str0 = str0 + c;  //Lưu số được nhập vào textbox vào chuỗi str0
                }
            }
            if (str0 != "")  //Nếu chuỗi str0 khác rỗng - tức có số nhập vào
            {
                double u = Convert.ToDouble(str0);  //Bước 3
                double u1 = Math.Round(u, 4);
                u1 = u1 * 10 * 1000;
                int u2 = Convert.ToInt32(u1);  //Convert sang số nguyên
                int d108, d109;
                d109 = u2 / 65536;
                d108 = u2 % 65536;
                plc.SetDevice("D108", d108);
                plc.SetDevice("D109", d109);

                // Nếu tọa độ nhập lớn hơn 380 (giới hạn hành trình trục X)
                if (txt_P2_X.Text != "" && Convert.ToDouble(str0) > 380)
                {
                    MessageBox.Show("Nhập quá giới hạn hành trình trục X. Vui lòng nhập lại nhỏ hơn 380",
                                    "CẢNH BÁO",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        //Nhập tọa độ Y của điểm 2 trong nội suy
        private void txt_P2_Y_TextChanged(object sender, EventArgs e)
        {
            if (txt_P2_Y.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }
            string str0 = "";
            foreach (char c in txt_P2_Y.Text)
            {
                if (char.IsDigit(c) == false && c != '.')  //Nếu kí tự c không phải số và không phải dấu '.'
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.')
                {
                    str0 = str0 + c;  //Lưu số được nhập vào textbox vào chuỗi str0
                }
            }
            if (str0 != "")  //Nếu chuỗi str0 khác rỗng - tức có số nhập vào
            {
                double u = Convert.ToDouble(str0);  //Bước 3
                double u1 = Math.Round(u, 4);
                u1 = u1 * 10 * 1000;
                int u2 = Convert.ToInt32(u1);  //Convert sang số nguyên
                int d208, d209;
                d209 = u2 / 65536;
                d208 = u2 % 65536;
                plc.SetDevice("D208", d208);
                plc.SetDevice("D209", d209);

                // Nếu tọa độ nhập lớn hơn 280 (giới hạn hành trình trục Y)
                if (txt_P2_Y.Text != "" && Convert.ToDouble(str0) > 280)
                {
                    MessageBox.Show("Nhập quá giới hạn hành trình trục Y. Vui lòng nhập lại nhỏ hơn 280",
                                    "CẢNH BÁO",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }


        //Nhập tọa độ X của điểm trung gian trong nội suy cung tròn
        private void txt_Arc_Adress_X_TextChanged(object sender, EventArgs e)
        {
            if (txt_Arc_Adress_X.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }
            string str0 = "";
            foreach (char c in txt_Arc_Adress_X.Text)
            {
                if (char.IsDigit(c) == false && c != '.')  //Nếu kí tự c không phải số và không phải dấu '.'
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.')
                {
                    str0 = str0 + c;  //Lưu số được nhập vào textbox vào chuỗi str0
                }
            }
            if (str0 != "")  //Nếu chuỗi str0 khác rỗng - tức có số nhập vào
            {
                double u = Convert.ToDouble(str0);  //Bước 3
                double u1 = Math.Round(u, 4);
                u1 = u1 * 10 * 1000;
                int u2 = Convert.ToInt32(u1);  //Convert sang số nguyên
                int d110, d111;
                d111 = u2 / 65536;
                d110 = u2 % 65536;
                plc.SetDevice("D110", d110);
                plc.SetDevice("D111", d111);

                // Nếu tọa độ nhập lớn hơn 380 (giới hạn hành trình trục X)
                if (txt_Arc_Adress_X.Text != "" && Convert.ToDouble(str0) > 380)
                {
                    MessageBox.Show("Nhập quá giới hạn hành trình trục X. Vui lòng nhập lại nhỏ hơn 380",
                                    "CẢNH BÁO",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        //Nhập tọa độ Y của điểm trung gian trong nội suy cung tròn
        private void txt_Arc_Adress_Y_TextChanged(object sender, EventArgs e)
        {
            if (txt_Arc_Adress_Y.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }
            string str0 = "";
            foreach (char c in txt_Arc_Adress_Y.Text)
            {
                if (char.IsDigit(c) == false && c != '.')  //Nếu kí tự c không phải số và không phải dấu '.'
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.')
                {
                    str0 = str0 + c;  //Lưu số được nhập vào textbox vào chuỗi str0
                }
            }
            if (str0 != "")  //Nếu chuỗi str0 khác rỗng - tức có số nhập vào
            {
                double u = Convert.ToDouble(str0);  
                double u1 = Math.Round(u, 4);
                u1 = u1 * 10 * 1000;
                int u2 = Convert.ToInt32(u1);  //Convert sang số nguyên
                int d210, d211;
                d211 = u2 / 65536;
                d210 = u2 % 65536;
                plc.SetDevice("D210", d210);
                plc.SetDevice("D211", d211);

                // Nếu tọa độ nhập lớn hơn 280 (giới hạn hành trình trục Y)
                if (txt_Arc_Adress_Y.Text != "" && Convert.ToDouble(str0) > 280)
                {
                    MessageBox.Show("Nhập quá giới hạn hành trình trục Y. Vui lòng nhập lại nhỏ hơn 280",
                                    "CẢNH BÁO",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        //Nhấn nút chọn chế độ nội suy theo đường thẳng
        private void btn_Line_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M40", 0);  //Chọn chế độ nội suy đường thẳng

            //Nếu chọn nội suy theo đường thẳng thì vô hiệu hóa việc chọn tọa độ trung gian
            txt_Arc_Adress_X.Enabled = false;
            txt_Arc_Adress_Y.Enabled = false;
            btn_Circle.BackColor = Color.Red;
            btn_Line.BackColor = Color.Lime;
        }

        //Nhấn nút chọn chế độ nội suy theo cung tròn
        private void btn_Circle_Click(object sender, EventArgs e)
        {
            plc.SetDevice("M40", 1);  //Chọn chế độ nội suy cung tròn
            //Nếu chọn kiểu nội suy cung tròn thì cho phép nhập vào tọa độ điểm trung gian Arc_Adress
            txt_Arc_Adress_X.Enabled = true;
            txt_Arc_Adress_Y.Enabled = true;
            btn_Line.BackColor = Color.Red;
            btn_Circle.BackColor = Color.Lime;
        }

        //Nhấn nút nhấn RUN khi đã chọn được kiểu nội suy là đường thẳng hay cung tròn
        private void btn_RUN_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M30", 1);
        }

        //Nhả nút nhấn RUN khi đã chọn được kiểu nội suy là đường thẳng hay cung tròn
        private void btn_RUN_MouseUp(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M30", 0);
        }

        private void txt_Speed_point1_to_point2_TextChanged(object sender, EventArgs e)
        {
            if (txt_Speed_point1_to_point2.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }
            string str0 = "";
            foreach (char c in txt_Speed_point1_to_point2.Text)
            {
                if (char.IsDigit(c) == false && c != '.')  //Nếu kí tự c không phải số và không phải dấu '.'
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.')
                {
                    str0 = str0 + c;  //Lưu số được nhập vào textbox vào chuỗi str0
                }
            }
            if (str0 != "")  //Nếu chuỗi str0 khác rỗng - tức có số nhập vào
            {
                double u = Convert.ToDouble(str0);
                double u1 = Math.Round(u, 4);
                u1 = u1 * 100;
                int u2 = Convert.ToInt32(u1);  //Convert sang số nguyên
                int d104, d105;
                d105 = u2 / 65536;
                d104 = u2 % 65536;
                plc.SetDevice("D104", d104);
                plc.SetDevice("D105", d105);
            }
        }

        //Sự kiện xảy ra khi timer1 hoạt động
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Đọc lỗi từ trục 1
            int read_result1;  // Khởi tạo biến đọc kết quả
            plc.GetDevice("U12\\G806", out read_result1); //Đọc giá trị trong vùng nhớ U12\G806 sau đó out kết quả đọc được ra biến read_result
            txt_Error_Code_Axis1.Text = read_result1.ToString(); //Giá trị đọc được tại địa chỉ sẽ được gán vào trường "Text" trong txt_Gía_trị để hiển thị ra ngoài màn hình

            //Đọc lỗi từ trục 2
            int read_result2;
            plc.GetDevice("U12\\G906", out read_result2);
            txt_Error_Code_Axis2.Text = read_result2.ToString();

            //Đọc lỗi từ trục 3
            int read_result3;
            plc.GetDevice("U12\\G1006", out read_result3);
            txt_Error_Code_Axis3.Text = read_result3.ToString();

                                        //ĐỌC VỊ TRÍ HIỆN TẠI CỦA TRỤC X
            int read_result4, m;
            double m1;
            plc.GetDevice("U12\\G800", out read_result4); //Đọc giá trị tại U12\\G800 và lưu vào read_result4
            plc.GetDevice("U12\\G801", out m);  //Đọc giá trị tại U12\G801 và lưu vào m
            //Vị trí hiện tại "m1" là 1 biến 32bit được kết hợp từ 2 Word có địa chỉ "U12\\G800" và "U12\\G801" sẽ được tính theo công thức sau
            m1 = (m * 65536 + read_result4) / 10;  //Chia 10 thì đọc trong 1.18 trong file lưu ý khi làm đồ án tốt nghiệp
            m1 = m1 / 1000;  //Chia 1000 vì đơn vị trên PLC là um, cần chia 1000 để đổi sang đơn vị mm
            txt_X_Position.Text = m1.ToString();

                                        //ĐỌC VỊ TRÍ HIỆN TẠI CỦA TRỤC Y
            int read_result5, m2;
            double m3;
            plc.GetDevice("U12\\G900", out read_result5); 
            plc.GetDevice("U12\\G901", out m2);          
            m3 = (m2 * 65536 + read_result5) / 10;
            m3 = m3 / 1000; 
            txt_Y_Position.Text = m3.ToString();

                                            //ĐỌC VỊ TRÍ HIỆN TẠI CỦA TRỤC Z
            int read_result6, m4;
            double m5;
            plc.GetDevice("U12\\G1000", out read_result6); 
            plc.GetDevice("U12\\G1001", out m4);            
            m5 = (m4 * 65536 + read_result6) / 10;
            m5 = m5 / 1000; 
            txt_Z_Position.Text = m5.ToString();

            double X = m1;
            double Y = m3;
            double Z = m5;
            double m10;  //Vị trí Z DOWN
            double.TryParse(txt_Toa_độ_Z_nội_suy.Text, out m10);
         
            //Chỉ khi nào trục Z đi xuống vị trí Z DOWN thì mới cho phép vẽ lại để bắt đầu vẽ đồ thị để tránh vẽ các đường thừa vào
            if (m10 == m5)
            {
                Draw(X, Y);   //Gọi hàm vẽ đồ thị ra để vẽ đồ thị tọa độ X,Y theo thời gian thực
            }
        }

        //Timer2 - dùng để tạo đồng hồ xem thời gian thực
        private void timer2_Tick(object sender, EventArgs e)
        {
            // DateTime là kiểu dữ liệu thôi - Kiểu dữ liệu ngày giờ
            //Now lấy ngày giờ hiện tại được đặt trên máy tính của mình.
            //Now trả về 1 đối tượng mà giá trị của nó là ngày giờ hiện tại
            // ToLongTimeString(): Phương thức Convert giá trị của đối tượng kiểu DateTime hiện tại sang hiển thị chuỗi thời gian
            //Gía trị trả về của ToLongTimeString là 1 chuỗi biểu diễn chuỗi thời gian hiện tại của đối tượng DateTime
            lbl_Đồng_hồ.Text = DateTime.Now.ToLongTimeString();
        }

        private void txt_SpeedZ_nội_suy_TextChanged(object sender, EventArgs e)
        {
            if (txt_SpeedZ_nội_suy.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }
            string str0 = "";
            foreach (char c in txt_SpeedZ_nội_suy.Text)
            {
                if (char.IsDigit(c) == false && c != '.')  //Nếu kí tự c không phải số và không phải dấu '.'
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.')
                {
                    str0 = str0 + c;  //Lưu số được nhập vào textbox vào chuỗi str0
                }
            }
            if (str0 != "")  //Nếu chuỗi str0 khác rỗng - tức có số nhập vào
            {
                double u = Convert.ToDouble(str0); 
                double u1 = Math.Round(u, 4);
                u1 = u1 * 100;
                int u2 = Convert.ToInt32(u1);  //Convert sang số nguyên
                int d304, d305;
                d305 = u2 / 65536;
                d304 = u2 % 65536;
                plc.SetDevice("D304", d304);
                plc.SetDevice("D305", d305);
            }
        }

        //Làm việc với file thì luồn cần khai báo using System.IO;
        private void btn_Open_File_Click(object sender, EventArgs e)
        {
            //Lọc ra các file có định dạng txt. "Text File (*.txt)" 
            //Chỉ cho phép mở các filw có định dạng .txt
            openFileDialog1.Filter = "Text File (*.txt)|*.txt";
            //Kiểm tra nếu có file được chọn
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  
            {
                Stream stream = openFileDialog1.OpenFile();
                StreamReader sr = new StreamReader(stream);

                //ReadToEnd là một phương thức của đối tượng StreamReader trong C#.
                //Khi được gọi, nó sẽ đọc tất cả các dữ liệu từ stream và trả về một chuỗi chứa toàn bộ nội dung của stream đó.
                //Trong bài này là toàn bộ nội dung của file được chọn và gán vào Rich TextBox
                rtbox_Nhập_code.Text = sr.ReadToEnd();  
                sr.Close();  //Đóng lại đối tượng StreamReader
            }
        }

        private void btn_Save_File_Click(object sender, EventArgs e)
        {
            //Lọc chọn phần đuôi tệp mở rộng là có dạng txt
            //Chỉ cho phép lưu các tệp với định dạng .txt
            saveFileDialog1.Filter = "Text File (*.txt)|*.txt";
            //saveFileDialog1 chính là Control được kéo ra
            //Kiểm tra nếu người dùng chọn file cho việc lưu
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)  
            {
                                      // Lưu file với hàm SaveFile
                rtbox_Nhập_code.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                //Khi thực hiện xong việc lưu file thì Show ra màn hình đã lưu thành công
                MessageBox.Show("Lưu thành công");  
            }
        }

        //Mã lỗi trục 1
        private void txt_Error_Code_Axis1_Click(object sender, EventArgs e)
        {
            if (txt_Error_Code_Axis1.Text == "0")
            {
                // Không có lỗi xảy ra thì không làm gì cả
            }
            else if (txt_Error_Code_Axis1.Text == "101")
            {
                MessageBox.Show("Tín hiệu PLC REDAY tắt trong quá trình hoạt động", //Thông báo muốn hiển thị 
                               "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis1.Text == "104")
            {
                MessageBox.Show("Cảnh báo va chạm trục, đã tới vị trí cảm biến giới hạn FLS",
                               "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis1.Text == "105")
            {
                MessageBox.Show("Cảnh báo va chạm trục, đã tới vị trí cảm biến giới hạn RLS",
                               "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis1.Text == "108")
            {
                MessageBox.Show("Servo chưa hoạt động",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis1.Text == "527")
            {
                MessageBox.Show("Trục đang chạy, không thể thao tác, chờ chạy xong",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis1.Text == "519")
            {
                MessageBox.Show("Tiến hành nội suy trong khi trục nội suy đang bận",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis1.Text == "526")
            {
                MessageBox.Show("Điểm đầu và điểm cuối trong nội suy cung tròn trùng nhau",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //Mã lỗi trục 2
        private void txt_Error_Code_Axis2_Click(object sender, EventArgs e)
        {
            if (txt_Error_Code_Axis2.Text == "0")
            {
                // Không có lỗi xảy ra thì không làm gì cả
            }
            else if (txt_Error_Code_Axis2.Text == "101")
            {
                MessageBox.Show("Tín hiệu PLC REDAY tắt trong quá trình hoạt động", //Thông báo muốn hiển thị 
                               "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis2.Text == "104")
            {
                MessageBox.Show("Cảnh báo va chạm trục, đã tới vị trí cảm biến giới hạn FLS",
                               "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis2.Text == "105")
            {
                MessageBox.Show("Cảnh báo va chạm trục, đã tới vị trí cảm biến giới hạn RLS",
                               "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis2.Text == "108")
            {
                MessageBox.Show("Servo chưa hoạt động",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis2.Text == "527")
            {
                MessageBox.Show("Trục đang chạy, không thể thao tác, chờ chạy xong",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis2.Text == "519")
            {
                MessageBox.Show("Tiến hành nội suy trong khi trục nội suy đang bận",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis2.Text == "526")
            {
                MessageBox.Show("Điểm đầu và điểm cuối trong nội suy cung tròn trùng nhau",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //Mã lỗi trục 3
        private void txt_Error_Code_Axis3_Click(object sender, EventArgs e)
        {
            if (txt_Error_Code_Axis3.Text == "0")
            {
                // Không có lỗi xảy ra thì không làm gì cả
            }
            else if (txt_Error_Code_Axis3.Text == "101")
            {
                MessageBox.Show("Tín hiệu PLC REDAY tắt trong quá trình hoạt động", //Thông báo muốn hiển thị 
                               "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis3.Text == "104")
            {
                MessageBox.Show("Cảnh báo va chạm trục, đã tới vị trí cảm biến giới hạn FLS",
                               "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis3.Text == "105")
            {
                MessageBox.Show("Cảnh báo va chạm trục, đã tới vị trí cảm biến giới hạn RLS",
                               "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis3.Text == "108")
            {
                MessageBox.Show("Servo chưa hoạt động",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis3.Text == "527")
            {
                MessageBox.Show("Trục đang chạy, không thể thao tác, chờ chạy xong",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis3.Text == "519")
            {
                MessageBox.Show("Tiến hành nội suy trong khi trục nội suy đang bận",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (txt_Error_Code_Axis3.Text == "526")
            {
                MessageBox.Show("Điểm đầu và điểm cuối trong nội suy cung tròn trùng nhau",
                              "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn_END_nội_suy_MouseDown(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M33", 1);
        }

        private void btn_END_nội_suy_MouseUp(object sender, MouseEventArgs e)
        {
            plc.SetDevice("M33", 0);
        }

        //Kích vào nút chạy tự động
        private void btn_RUN_Auto_Click(object sender, EventArgs e)
        {
            if(!backgroundWorker1.IsBusy)  //Nếu backgroundWorker1 không bận, yức chương trình đang không được chạy
            {
                string[] rtb_Lines = rtbox_Nhập_code.Lines;
                backgroundWorker1.RunWorkerAsync(rtb_Lines);
            } 
            else  //Trường hợp còn lại là khi chương trình đang chạy mà bấm RUN AUTO để chạy thêm lần nữa
            {
                MessageBox.Show("Chương trình đang chạy. Vui lòng đợi chương trình chạy xong", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }    
        }

        //Tọa độ Z đi lên trong nội suy
        private void txt_Z_up_TextChanged(object sender, EventArgs e)
        {
            if (txt_Z_up.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }
            string str0 = "";
            foreach (char c in txt_Z_up.Text)
            {
                if (char.IsDigit(c) == false && c != '.')  //Nếu kí tự c không phải số và không phải dấu '.'
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.')
                {
                    str0 = str0 + c;  //Lưu số được nhập vào textbox vào chuỗi str0
                }
            }
            if (str0 != "")  //Nếu chuỗi str0 khác rỗng - tức có số nhập vào
            {
                double u = Convert.ToDouble(str0); 
                double u1 = Math.Round(u, 4);
                u1 = u1 * 10 * 1000;
                int u2 = Convert.ToInt32(u1);  //Convert sang số nguyên
                int d214, d215;
                d215 = u2 / 65536;
                d214 = u2 % 65536;
                plc.SetDevice("D214", d214);
                plc.SetDevice("D215", d215);

                // Nếu tọa độ nhập lớn hơn 90 (giới hạn hành trình trục Z)
                if (txt_Z_up.Text != "" && Convert.ToDouble(str0) > 90)
                {
                    MessageBox.Show("Nhập quá giới hạn hành trình trục Y. Vui lòng nhập lại nhỏ hơn 280",
                                    "CẢNH BÁO",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Đồ_thị_tọa_độ_XY.GraphPane.CurveList.Clear();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Đồ_thị_tọa_độ_XY.Refresh();

            //Khởi tạo ZedGraph - Đồ thị tọa độ XY
            //Khởi tạo đối tượng myPane
            GraphPane myPane = Đồ_thị_tọa_độ_XY.GraphPane;
            PointPairList list1 = new PointPairList();  //Tạo list1 chưa tập các điểm tọa độ (X,Y)
            LineItem myCurve = myPane.AddCurve("Qũy đạo", list1, Color.Red, SymbolType.None);


            myPane.Legend.Position = ZedGraph.LegendPos.Bottom;

            myPane.X2Axis.Scale.Min = 0; // Min = 0;
            myPane.X2Axis.Scale.Max = 400; // Max = 400;
            myPane.X2Axis.Scale.MinorStep = 10; // Đơn vị chia nhỏ nhất 1
            myPane.X2Axis.Scale.MajorStep = 50; // Đơn vị chia lớn 50

            //Thiết lập lại cho trục X ở bên dưới
            myPane.XAxis.Scale.Min = 0; // Min = 0;
            myPane.XAxis.Scale.Max = 400; // Max = 400;
            myPane.XAxis.Scale.MinorStep = 10; // Đơn vị chia nhỏ nhất 1
            myPane.XAxis.Scale.MajorStep = 50; // Đơn vị chia lớn 50

            //Thiết lập cho trục Y
            myPane.YAxis.Scale.Min = 0; // Min = 0;
            myPane.YAxis.Scale.Max = 300; // Max = 300;
            myPane.YAxis.Scale.MinorStep = 10; // Đơn vị chia nhỏ nhất 1
            myPane.YAxis.Scale.MajorStep = 50; // Đơn vị chia lớn 50
        }

   
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] rtb_Lines = e.Argument as string[];
    
            string str0 = "";  //Tạo 1 string rỗng ban đầu chứa toàn các số được tách ra từ chuỗi "line"
            int n = 0;
            ////Duyệt từng dòng trong RichTextBox
            foreach (string line in rtb_Lines)
            {
                n = n + 1;

                //Nếu gặp dòng lệnh END thì cho trục Z đi lên, kết thúc 1 đoạn gia công và đưa dao đến vị trí gia công khác
                if (line == "END")
                {   
                    //Đưa Z đi lên vị trí Z_ UP
                    plc.SetDevice("M33", 1);
                    Thread.Sleep(300);  //Delay 300ms sau đó lại đưa M33 về 0 để tạo xung tín hiệu.
                                        //Nếu khoảng delay ngắn hơn thì không tạo được xung tín hiệu ghi vào M33 trong PLC
                                        //Nếu 300ms ngắn quá thì delay lâu hơn 1 chút
                    plc.SetDevice("M33", 0);

                    double n1 = 0;  //Khởi tạo biến n1 kiểu double = 0 để so sánh khi z về vị trí Z up rồi thì mới cho về Home
                                    //Để Double vì tọa độ có thể lẻ, không nhất thiết phải là nguyên int
                                    //Nếu Z chưa kịp về Z_UP mà đã về Home thì khi về Home chỉ có trục X,Y về Home thôi, do Z vẫn đang bận chạy về Z_UP
                    double a1;   //Lưu giá trị được nhập trong  txt_Zup
                    double.TryParse(txt_Z_up.Text, out a1);
                    //Mục đích của vòng While này là đợi Z về tới vị trí Zup đã rồi mới về Home
                    while (n1 != a1)   //Nếu vị trí hiện tại khác vị trí cần đến (robot chưa tới vị trí cần tới)
                    {
                        double.TryParse(txt_Z_Position.Text, out n1);

                        //Kiểm tra xem trong quá trình chạy người dùng có nhấn Cancel để hủy quá trình chạy hay không
                        if (backgroundWorker1.CancellationPending == true)
                        {
                            e.Cancel = true;
                            backgroundWorker1.ReportProgress(0);
                            return;
                        }
                    }
                    Thread.Sleep(450); //Đợi 400ms cho Z ổn định ở vị trí Z_Up đã rồi mới cho chạy tiếp hoặc về Home
                                       //Bắt buộc phải đợi Z ổn định ở bước Delay này thì mới về Home trục Z được
                                       //Sau khi trục Z đã về vị trí Zup thành công. Cần đợi 1 chút thời gian để Z ổn định ở vị trí đó thì mới cho về Home
                                       //Do đó cần delay 400ms trước khi về Home hoặc làm các thao tác viết chữ (Z hạ xuống tiếp)
                                       //Nếu không Delay 400ms mà cho về Home luôn thì X,Y vẫn về Home bình thường tuy nhiên Z sẽ vẫn ở vị trí Z_UP mà không về Hone
                }
                //Nếu gặp dòng lệnh HOME thì kích bit M110 để về HOME
                if (line == "HOME")
                {
                    plc.SetDevice("M110", 1);
                    Thread.Sleep(300);  //Delay 300ms sau đó lại đưa M33 về 0 để tạo xung tín hiệu.
                                        //Nếu khoảng delay ngắn hơn thì không tạo được xung tín hiệu ghi vào M33 trong PLC
                                        //Nếu 300ms ngắn quá thì delay lâu hơn 1 chút
                    plc.SetDevice("M110", 0);

                    //HOME sẽ ở dòng cuối cùng trong chương trình
                    //Cần kiểm tra xem X,Y,Z đã về đến vị trí X=0, Y=0, Z = 0 hay chưa. Nếu chưa thì cần phải đợi đến khi cả 3 trục về 0 thì mới thoát ra
                    //để có thông báo hoàn thành chương trình trong sự kiện Complete của backgroundworker
                    double b1, c1, d1;   //Lưu giá trị vị trí trục X,Y,Z hiện tại
                    double.TryParse(txt_X_Position.Text, out b1);
                    double.TryParse(txt_Y_Position.Text, out c1);
                    double.TryParse(txt_Z_Position.Text, out d1);
                    while (b1 != 0)  //kiểm tra xem trục X đã về vị trí 0 hay chưa
                                     //Chưa thi liên tục cập nhật vị trí hiện tại mới nhất trục X
                    {
                        double.TryParse(txt_X_Position.Text, out b1);

                        //Kiểm tra xem trong quá trình chạy người dùng có nhấn Cancel để hủy quá trình chạy hay không
                        if (backgroundWorker1.CancellationPending == true)
                        {
                            e.Cancel = true;
                            backgroundWorker1.ReportProgress(0);
                            return;
                        }
                    }
                    while (c1 != 0)   //giải thích tương tự với vòng while(b1!=0)
                    {
                        double.TryParse(txt_Y_Position.Text, out c1);

                        //Kiểm tra xem trong quá trình chạy người dùng có nhấn Cancel để hủy quá trình chạy hay không
                        if (backgroundWorker1.CancellationPending == true)
                        {
                            e.Cancel = true;
                            backgroundWorker1.ReportProgress(0);
                            return;
                        }
                    }
                    while (d1 != 0)  //giải thích tương tự với vòng while(b1!=0)
                    {
                        double.TryParse(txt_Z_Position.Text, out d1);

                        //Kiểm tra xem trong quá trình chạy người dùng có nhấn Cancel để hủy quá trình chạy hay không
                        if (backgroundWorker1.CancellationPending == true)
                        {
                            e.Cancel = true;
                            backgroundWorker1.ReportProgress(0);
                            return;
                        }
                    }
                }
                //Nếu dòng line không phải END và HOME, cũng không phải dòng RỖNG
                if (line != "END" && line != "HOME" && line != "") 
                {
                    //Tách các phần tử trong 1 dòng theo dấu cách, lưu vào str1
                    //Trong code có dấu '; ' thì chỉ cần tách theo dấu cách thôi, dấu chấm phẩy kệ nó, không cần xử lí
                    string[] str1 = line.Split(' ');
                    ////Duyệt từng chuỗi i trong str1
                    foreach (string l in str1)
                    {    
                        foreach (char c in l)
                        {
                            if (char.IsDigit(c))
                            {
                                str0 = str0 + c;  //Nếu thỏa mãn kí tự c có các phần tử đều là số thì thêm phần tử c trong mảng lst vào mảng str0 rỗng được khởi tạo  
                            }
                        }
                        str0 = str0 + " ";   //Thêm dấu cách để các số tìm được cách nhau ra
                    }
                    str0 = str0.Trim(); //Loại bỏ toàn bộ dấu cách ở đầu và cuối chuỗi str0.
                                        // Vì để ý dòng lệnh trong điều kiện if khi kết thúc vòng lặp foreach thì sẽ có dấu cách ở cuối chuỗi str0

                    //Bây giờ cần tách từng phần tử số này ra theo dấu cách
                    string[] lst2 = str0.Split(' ');  //tách từng phần tử str0 theo dấu cách và lưu vào mảng lst2
                                                     


                    //GHI TỌA ĐỘ CÁC ĐIỂM P1 VÀ P2 VÀO PLC
                    int P1X, P1Y, P2X, P2Y;
                    int.TryParse(lst2[0], out P1X);  //Tọa độ P1X là phần tử đều tiên
                    int.TryParse(lst2[1], out P1Y);  //Tọa độ P1Y là phần tử thứ 2
                    int.TryParse(lst2[2], out P2X);   // Tọa độ P2X là phần tử thứ 3
                    int.TryParse(lst2[3], out P2Y);   // Tọa độ P2Y là phần tử thứ 4

                    //Ghi tọa độ P1X vào PLC
                    int u = 10 * 1000 * P1X;
                    int d106, d107;
                    d107 = u / 65536;
                    d106 = u % 65536;
                    plc.SetDevice("D106", d106);
                    plc.SetDevice("D107", d107);

                    //Ghi tọa độ P1Y vào PLC
                    int v = 10 * 1000 * P1Y;
                    int d206, d207;
                    d207 = v / 65536;
                    d206 = v % 65536;
                    plc.SetDevice("D206", d206);
                    plc.SetDevice("D207", d207);

                    //Ghi tọa độ P2X vào PLC  
                    int b = 10 * 1000 * P2X;
                    int d108, d109;
                    d109 = b / 65536;
                    d108 = b % 65536;
                    plc.SetDevice("D108", d108);
                    plc.SetDevice("D109", d109);

                    //Ghi tọa độ P2Y vào PLC
                    int y = 10 * 1000 * P2Y;
                    int d208, d209;
                    d209 = y / 65536;
                    d208 = y % 65536;
                    plc.SetDevice("D208", d208);
                    plc.SetDevice("D209", d209);

                    if (lst2.Length < 5)
                    {
                        //Chọn chế độ nội suy đường thẳng
                        plc.SetDevice("M40", 0);
                    }    
                        // Nếu độ dài chuỗi lớn hơn hoặc bằng 5 (chính là các tọa độ để nội suy đường tròn ấy)
                        if (lst2.Length >= 5)
                    {
                        //Chọn chế độ nội suy đường tròn
                        plc.SetDevice("M40", 1);
                        int AX, AY;
                        int.TryParse(lst2[4], out AX);   //Tọa độ Arc Adress X là phần tử thứ 5
                        int.TryParse(lst2[5], out AY);   //Tọa độ Arc Adress Y là phần tử thứ 6

                        //Ghi AX vào PLC
                        int z = 10 * 1000 * AX;
                        int d110, d111;
                        d111 = z / 65536;
                        d110 = z % 65536;
                        plc.SetDevice("D110", d110);
                        plc.SetDevice("D111", d111);

                        //Ghi AY vào PLC
                        int p = 10 * 1000 * AY;
                        int d210, d211;
                        d211 = p / 65536;
                        d210 = p % 65536;
                        plc.SetDevice("D210", d210);
                        plc.SetDevice("D211", d211);
                    }

                    //Sau khi đã thiết lập chạy nội suy đường thẳng hoặc cung tròn thì kích RUN lên để chạy
                    //M30 sau khi lên 1 thì cần về 0 ngay thì trục mới chạy (do đó mới dùng Mouse_Up và Mouse_Down)
                    plc.SetDevice("M30", 1);
                    Thread.Sleep(300);  //Delay 0,3s
                    plc.SetDevice("M30", 0);  //On M30 trong 0,2s rồi OFF nó về 0. Delay ngắn quá thì không kịp tạo xung trong PLC để kích chạy

                    double m1 = 0;
                    double m2 = 0;

                   //Cần so sánh cả tọa độ X và Y của điểm cần tới
                    while (m1 != P2X || m2 != P2Y)   //Nếu vị trí hiện tại khác vị trí cần đến (robot chưa tới vị trí cần tới)
                    {
                        double.TryParse(txt_X_Position.Text, out m1);
                        double.TryParse(txt_Y_Position.Text, out m2);

                        //Kiểm tra xem trong quá trình chạy người dùng có nhấn Cancel để hủy quá trình chạy hay không
                        if (backgroundWorker1.CancellationPending == true)
                        {
                            e.Cancel = true;
                            backgroundWorker1.ReportProgress(0);
                            return;
                        }
                    }

                    if (backgroundWorker1.CancellationPending == true)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                    str0 = "";
                }

                //Kiểm tra xem trong quá trình chạy người dùng có nhấn Cancel để hủy quá trình chạy hay không
                //CancellationPending: trả về true nếu yêu cầu hủy chạy nền, mặc định ban đầu là false
                if (backgroundWorker1.CancellationPending == true)
                {
                    //DoWorkEventArgs e: Dùng để truy cập vào những thuộc tính của BackGroundWorker
                    //Cancel = true nếu sự kiện bị hủy và gọi đến hàm RunWorkerCompleted luôn, kết thúc chạy nền
                    //Nếu Cancel thì cần đưa ReportProgress về 0% 
                    // Chẳng hạn như đang chạy dở 50% mà hủy quá trình chạy thì đưa quá trình chạy trở về lại 0%
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }

                //lấy số dòng chạy được (i) chia tổng số dòng ra lượng công việc hoàn thành được
                double s = (double)n / (rtb_Lines.Length);

                double t = Math.Round(s, 2) * 100;
                int pt = Convert.ToInt32(t);    //Convert phần trăm từ Double sang int vì ReportProgress chỉ nhận tham số truyền vào là kiểu int

                backgroundWorker1.ReportProgress(pt);

                //Để tránh bị lỗi tọa độ trong quá trình nội suy thì khi kết thúc 1 đoạn nội suy thì cần đưa các tọa độ P1 và P2 về 0
                //Ở đây chỉ đưa P1X và P1Y về 0 là được vì nếu đưa cả P2X và P2Y về 0 thì robot về 0 luôn dù vẫn đang nội suy

                //Đưa P1X về 0
                plc.SetDevice("D106", 0);
                plc.SetDevice("D107", 0);

                //Đưa 0 vào P1Y
                plc.SetDevice("D206", 0);
                plc.SetDevice("D207", 0);
  
             }
        }

        //Hàm viết Code cập nhật tiến trình xử lí được bao nhiêu phần trăm vào progressBar
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            //Hiển thị cụ thể số phần trăm chạy được lên label để biết rõ hơn
            lbl_Phần_trăm.Text = e.ProgressPercentage.ToString() + "%";
        }

        // Hàm này sẽ được tự động gọi khi xảy ra 1 trong 3 trường hợp sau:
        //Trường hợp 1: Người dùng bấm Cancel (Hủy) tiến trình
        //Trường hợp 2: Qúa trình chạy bị lỗi
        //Trường hợp 3: Qúa trình thực sự hoàn thành
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Kiểm tra nếu người dùng bấm Cancel mà chương trình chưa hoàn thành
            if (e.Cancelled == true)
            {
                MessageBox.Show("Chương trình đã bị hủy theo yêu cầu", //Thông báo muốn hiển thị 
                             "THÔNG BÁO",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                //backgroundWorker1.ReportProgress(0);  //Đưa phần trăm về 0
                //lbl_Phần_trăm.Text = 0.ToString();   //Đưa thanh progessbar về 0
            }
            else if(e.Error != null)  // Trường hợp nếu có lỗi xảy ra
            {
                //nếu có lỗi thì đẩy lỗi ra màn hình qua e.Error.Message
                MessageBox.Show(e.Error.Message, //Thông báo muốn hiển thị 
                             "THÔNG BÁO",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
            else   //Trường hợp chương trình được chạy hoàn thành không lỗi mà người dùng cũng không Cancel
            {
                MessageBox.Show("Hoàn thành chạy chương trình", //Thông báo muốn hiển thị 
                                 "THÔNG BÁO",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                // Đặt tiến độ của progressbar và label hiển thị phần trăm về 0 khi hoàn thành công việc
                progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value = 0));
                lbl_Phần_trăm.Invoke((MethodInvoker)(() => lbl_Phần_trăm.Text = 0.ToString() + "%")); //Đưa về label_Phần_trăm về 0%
            }
        }

        //Dùng để hủy chương trình đang chạy - Ở đây là chương trình trong RichTextBox
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy == true)  //Nếu chương trình đang chạy thì hủy bỏ chương trình này
            {
                //Yêu cầu hủy bỏ công việc đang thực thi trong backgroundWorker.
                backgroundWorker1.CancelAsync();
            }
            else   //Nếu chương trình chưa được chạy thì thông báo ra màn hình
                MessageBox.Show("Chương trình chưa được chạy. Không cần Cancel", //Thông báo muốn hiển thị 
                                 "THÔNG BÁO",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }


        //Tọa độ đi xuống theo trục Z
        private void txt_Toa_độ_Z_nội_suy_TextChanged(object sender, EventArgs e)
        {
            if (txt_Toa_độ_Z_nội_suy.Text == "")  //Chuỗi rỗng thì không làm gì cả
            {
            }
            string str0 = "";
            foreach (char c in txt_Toa_độ_Z_nội_suy.Text)
            {
                if (char.IsDigit(c) == false && c != '.')  //Nếu kí tự c không phải số và không phải dấu '.'
                {
                    MessageBox.Show("Kí tự vừa nhập không phải một số. Vui lòng nhập lại", //Thông báo muốn hiển thị 
                                "CẢNH BÁO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
                if (char.IsDigit(c) || c == '.')
                {
                    str0 = str0 + c;  //Lưu số được nhập vào textbox vào chuỗi str0
                }
            }
            if (str0 != "")  //Nếu chuỗi str0 khác rỗng - tức có số nhập vào
            {
                double u = Convert.ToDouble(str0);  
                double u1 = Math.Round(u, 4);
                u1 = u1 * 10 * 1000;
                int u2 = Convert.ToInt32(u1);  //Convert sang số nguyên
                int d212, d213;
                d213 = u2 / 65536;
                d212 = u2 % 65536;
                plc.SetDevice("D212", d212);
                plc.SetDevice("D213", d213);
 
                // Nếu tọa độ nhập lớn hơn 90 (giới hạn hành trình trục Z)
                if (txt_Toa_độ_Z_nội_suy.Text != "" && Convert.ToDouble(str0) > 90)
                {
                    MessageBox.Show("Nhập quá giới hạn hành trình trục Y. Vui lòng nhập lại nhỏ hơn 280",
                                    "CẢNH BÁO",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }
    }
}

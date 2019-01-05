using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace DemoCalc
{
    public partial class Form1 : Form
    {
        //Khai báo biến
        #region Variables
        //Tài khoản
        private Account[] Arr_Acc = new Account[1];
        private bool isLogined = false;
        //Lưu trữ
        private float fMemory = 0;
        private string str_LastValue = "";
        private string str_Type = "";
        //Các biến bool để gắn cờ
        private bool isDot = false;
        private bool isCalc = false;
        private bool isMemory = false;
        private bool isPercent = false;
        private bool isInverse = false;
        private bool isSqrt = false;
        private bool isSquared = false;
        private bool isCubed = false;
        #endregion Variables
        public List<string> Infos { get; set; }
        public bool Existed { get; set; }

        public Form1()
        {
            InitializeComponent();
            Infos = new List<string>();
            Existed = false;
        }


        //Xử lý phần đăng nhập và đăng ký
        #region Login
        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (txtBox_Username.Text == "" || txtBox_Pass.Text == "")
            {
                MessageBox.Show(" Tài khoản và Mật khẩu trống.");
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader("user.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Infos.Add(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(ex.Message);
                }

                foreach (var info in Infos)
                {
                    string email = info.Substring(0, info.IndexOf("|"));
                    string password = info.Substring(info.IndexOf("|") + 1, info.Length - info.IndexOf("|") - 1);

                    string passwordHash;
                    using (MD5 md5 = MD5.Create())
                    {
                        byte[] inputBytes = Encoding.ASCII.GetBytes(txtBox_Pass.Text);
                        byte[] hashBytes = md5.ComputeHash(inputBytes);

                        // Convert the byte array to hexadecimal string
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < hashBytes.Length; i++)
                        {
                            sb.Append(hashBytes[i].ToString("X2"));
                        }
                        passwordHash = sb.ToString();
                    }

                    if (email == txtBox_Username.Text && password == passwordHash)
                    {
                        
                        Existed = true;
                    }
                }

                if (Existed)
                {
                    MessageBox.Show("Đăng Nhập thành công.");
                    this.DialogResult = DialogResult.OK;
                    isLogined = true;
                    txtBox_Username.Enabled = false;
                    txtBox_Pass.Enabled = false;
                    bt_Calc.Enabled = true;
                    bt_SolEqua.Enabled = true;
                    bt_Add.Enabled = true;
                    bt_Sub.Enabled = true;
                    bt_Multi.Enabled = true;
                    bt_Division.Enabled = true;
                }
                else
                {
                    MessageBox.Show(" Mật khẩu không đúng.");
                }
               
            }
        }

        private void txtBox_Username_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBox_Username.Text == "Tài khoản...") txtBox_Username.Text = "";
        }

        private void txtBox_Pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBox_Pass.Text == "Mật khẩu...") txtBox_Pass.Text = "";
        }

        private void bt_Reg_Click(object sender, EventArgs e)
        {
            //Hiển thị Textbox để nhập thông tin đăng ký
            if ((txtBox_RegUsername.Text == "") && (txtBox_RegPass.Text == "") && (txtBox_RegRePass.Text == ""))
            {
                txtBox_RegUsername.Enabled = true;
                txtBox_RegPass.Enabled = true;
                txtBox_RegRePass.Enabled = true;
            }
            
            else if (txtBox_RegPass.Text != txtBox_RegRePass.Text)
            {
                MessageBox.Show("Mật khẩu và Nhập Lại Mật khẩu không giống nhau.");
            }
            else
            {
                string username = txtBox_RegUsername.Text;
                string password = txtBox_RegPass.Text;

                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.ASCII.GetBytes(password);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    // Convert the byte array to hexadecimal string
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                    password = sb.ToString();
                }



                //Thêm tài khoản mới vào user.txt
                try
                {
                    using (StreamWriter sw = new StreamWriter("user.txt", true))
                    {
                        sw.WriteLine(username + "|" + password);
                        MessageBox.Show("Đăng Ký thành công.");
                        txtBox_RegUsername.Enabled = false;
                        txtBox_RegPass.Enabled = false;
                        txtBox_RegRePass.Enabled = false;
                        txtBox_RegUsername.Text = "";
                        txtBox_RegPass.Text = "";
                        txtBox_RegRePass.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The file could not be write:");
                    Console.WriteLine(ex.Message);
                }


                this.DialogResult = DialogResult.OK;
                
            }
        }

        


        //Xử lý nhập số từ các nút 0 -> 9 và nút "."
        #region DigitButtons
        //Xem cmt ở bt_0 và tương tự cho các bt còn lại
        private void bt_0_Click(object sender, EventArgs e)
        {
            //Nếu vừa thực hiện 1 trong các hành động như bấm 1 phép tính, Gọi M, ngịch đảo 1/x, lấy căn bậc 2, mũ 2, mũ 3
            //Thì nếu ta bấm phím số nó sẽ xóa đi các số trên khung kết quả để nhập số mới
            if (canPrintNewNumb())
            {
                //Vì ta chỉ xử lý lần lượt từng phép tính theo mẫu (a phép tính b)
                //Nên ta lưu giá trị trước của phép tính (a) rồi mới reset khung nhập để nhâp tiếp giá trị (b)
                str_LastValue = txtBox_Result.Text;
                txtBox_Result.Text = "0";

                //Sau khi nhập xong thì reset status của các biến bool về "false" (bấm 1 phép tính, Gọi M, ngịch đảo 1/x, lấy căn bậc 2, mũ 2, mũ 3)
                //Để người dùng có thể nhập tiếp số >9 mà ko bị reset nhập lại
                resetStatus();
            }
            else if(txtBox_Result.Text != "0")
            {
                //Đây là lúc ta có thể nhập tiếp số >9 mà ko bị reset, nên sẽ dùng toán tủ '+=' thay cho gán '='
                txtBox_Result.Text += "0";
            }
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            if (canPrintNewNumb())
            {
                str_LastValue = txtBox_Result.Text;
                txtBox_Result.Text = "1";
                resetStatus();
            }
            else if (txtBox_Result.Text == "0")
            {
                txtBox_Result.Text = "1";
            }
            else
                txtBox_Result.Text += "1";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            if (canPrintNewNumb())
            {
                str_LastValue = txtBox_Result.Text;
                txtBox_Result.Text = "2";
                resetStatus();
            }
            else if (txtBox_Result.Text == "0")
            {
                txtBox_Result.Text = "2";
            }
            else
                txtBox_Result.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            if (canPrintNewNumb())
            {
                str_LastValue = txtBox_Result.Text;
                txtBox_Result.Text = "3";
                resetStatus();
            }
            else if (txtBox_Result.Text == "0")
            {
                txtBox_Result.Text = "3";
            }
            else
                txtBox_Result.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            if (canPrintNewNumb())
            {
                str_LastValue = txtBox_Result.Text;
                txtBox_Result.Text = "4";
                resetStatus();
            }
            else if (txtBox_Result.Text == "0")
            {
                txtBox_Result.Text = "4";
            }
            else
                txtBox_Result.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            if (canPrintNewNumb())
            {
                str_LastValue = txtBox_Result.Text;
                txtBox_Result.Text = "5";
                resetStatus();
            }
            else if (txtBox_Result.Text == "0")
            {
                txtBox_Result.Text = "5";
            }
            else
                txtBox_Result.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            if (canPrintNewNumb())
            {
                str_LastValue = txtBox_Result.Text;
                txtBox_Result.Text = "6";
                resetStatus();
            }
            else if (txtBox_Result.Text == "0")
            {
                txtBox_Result.Text = "6";
            }
            else
                txtBox_Result.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            if (canPrintNewNumb())
            {
                str_LastValue = txtBox_Result.Text;
                txtBox_Result.Text = "7";
                resetStatus();
            }
            else if (txtBox_Result.Text == "0")
            {
                txtBox_Result.Text = "7";
            }
            else
                txtBox_Result.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            if (canPrintNewNumb())
            {
                str_LastValue = txtBox_Result.Text;
                txtBox_Result.Text = "8";
                resetStatus();
            }
            else if (txtBox_Result.Text == "0")
            {
                txtBox_Result.Text = "8";
            }
            else
                txtBox_Result.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            if (canPrintNewNumb())
            {
                str_LastValue = txtBox_Result.Text;
                txtBox_Result.Text = "9";
                resetStatus();
            }
            else if (txtBox_Result.Text == "0")
            {
                txtBox_Result.Text = "9";
            }
            else
                txtBox_Result.Text += "9";
        }

        private void bt_Dot_Click(object sender, EventArgs e)
        {
            //Nếu đã có dấu chấm rồi thì không đc thêm nữa
            if (!isDot)
            {
                if ((txtBox_Result.Text == "0") || canPrintNewNumb())
                {
                    txtBox_Result.Text = "0.";
                    resetStatus();
                }
                else
                    txtBox_Result.Text += ".";

                //Bật biến isDot, biến này sẽ tắt sau khi có phép tính mới
                isDot = true;
            }
        }
        #endregion DigitButtons


        //Xử lý các phép tính
        #region TypeOfCalc
        //Xem cmt của phép cộng và tương tự cho các phép tính còn lại
        private void bt_Add_Click(object sender, EventArgs e)
        {
            
                //Chép số vào Ô Input trước khi lấy giá trị của khung kết quả đi tính toán
                txtBox_InputStr.Text += txtBox_Result.Text;

                //Xét nếu tìm thấy dấu phép tính trước đó, có nghĩa là lần bấm phép tính này ta phải tính toán ra KQ luôn
                if (isContainCalcType())
                {
                    //Tính toán và gán kết quả cho biến 'LastValue' sau đó show KQ ra màn hình
                    str_LastValue = Calc(str_LastValue, txtBox_Result.Text, str_Type);
                    txtBox_Result.Text = str_LastValue;
                }

                //Thêm phép tính mới và chép vào ô Input
                str_Type = "+";
                txtBox_InputStr.Text += " + ";

                //Bật biến cờ đang tính, và tắt biến Dot để có thể nhập tiếp số thập phân
                isCalc = true;
                isDot = false;
            

            //Gán biến isPercent = true để có thể sử dụng chức năng isPercent (vì % chỉ lấy đc khi có 1 số và 1 phép tính)
            isPercent = true;
        }

        private void bt_Sub_Click(object sender, EventArgs e)
        {
            
                txtBox_InputStr.Text += txtBox_Result.Text;

                if (isContainCalcType())
                {
                    str_LastValue = Calc(str_LastValue, txtBox_Result.Text, str_Type);
                    txtBox_Result.Text = str_LastValue;
                }

                str_Type = "−";
                txtBox_InputStr.Text += " − ";
                isCalc = true;
                isDot = false;
            
            isPercent = true;
        }

        private void bt_Multi_Click(object sender, EventArgs e)
        {
            
            
                txtBox_InputStr.Text += txtBox_Result.Text;

                if (isContainCalcType())
                {
                    str_LastValue = Calc(str_LastValue, txtBox_Result.Text, str_Type);
                    txtBox_Result.Text = str_LastValue;
                }

                str_Type = "*";
                txtBox_InputStr.Text += " * ";
                isCalc = true;
                isDot = false;
           
            isPercent = true;
        }

        private void bt_Division_Click(object sender, EventArgs e)
        {
            
                txtBox_InputStr.Text += txtBox_Result.Text;

                if (isContainCalcType())
                {
                    str_LastValue = Calc(str_LastValue, txtBox_Result.Text, str_Type);
                    txtBox_Result.Text = str_LastValue;
                }

                str_Type = "/";
                txtBox_InputStr.Text += " / ";
                isCalc = true;
                isDot = false;
            
            isPercent = true;
        }

        //Xử lý nút = (tương tự như xử lý các phép tính)
        private void bt_Calc_Click(object sender, EventArgs e)
        {
            txtBox_InputStr.Text += txtBox_Result.Text;

            if (isContainCalcType())
            {
                str_LastValue = Calc(str_LastValue, txtBox_Result.Text, str_Type);
                txtBox_Result.Text = str_LastValue;
                txtBox_InputStr.Clear();
                isCalc = true;
                isDot = false;
            }
        }
        #endregion TypeOfCalc


        #region Functions
        //Xử lý nút Clear
        private void bt_Clear_Click(object sender, EventArgs e)
        {
            txtBox_Result.Text = "0";
            txtBox_InputStr.Clear();
            str_LastValue = "";
            str_Type = "";
            resetStatus();

        }

        //Xử lý chức năng %
        private void bt_Percent_Click(object sender, EventArgs e)
        {
            float _temp = float.Parse(txtBox_Result.Text);

            //Nếu đang có 1 số và 1 phép tính thì isPercent bật và ta có thể lấy % liên tục đên khi nhập số mới
            if (isPercent)
            {
                //KQ = số vừa nhập% * số ban đầu
                _temp = _temp / 100 * float.Parse(str_LastValue);
                txtBox_Result.Text = _temp.ToString();
                isCalc = false;
            }
            else
            {
                txtBox_Result.Text = "0";
            }
        }

        //Xử lý chức năng ngịch đảo
        private void bt_Inverse_Click(object sender, EventArgs e)
        {
            //Lấy giá trị từ khung KQ, nghịch đảo rồi gán lại cho khung KQ
            double _temp = double.Parse(txtBox_Result.Text);
            _temp = 1 / _temp;
            txtBox_Result.Text = _temp.ToString();
            //Xử lý biến cờ tương tự
            isInverse = true;
            isCalc = false;
        }

        //Xử lý nút xóa 
        private void bt_Delete_Click(object sender, EventArgs e)
        {
            isCalc = false;

            string _temp = txtBox_Result.Text;

            //Nếu xóa dấu '.' thì ta gán tắt isDot để có thể thêm lại lần nữa
            if (_temp[_temp.Length - 1] == '.')
            {
                isDot = false;
            }

            //Xóa phần tử cuối trong chuỗi
            _temp = _temp.Remove(_temp.Length - 1);

            //Gán lại cho khung KQ
            if (_temp == "")
            {
                txtBox_Result.Text = "0";
            }
            else
                txtBox_Result.Text = _temp;
        }

        //Xử lý chức năng căn bậc 2
        private void bt_Sqrt_Click(object sender, EventArgs e)
        {
            //Lấy giá trị từ khung Kq, rút căn và gán lại
            double _temp = double.Parse(txtBox_Result.Text);

            //Nếu căn bậc 2 số âm thì lỗi NaN
            _temp = Math.Sqrt(_temp);
            txtBox_Result.Text = _temp.ToString();
           

            //Xử lý cờ
            isSqrt = true;
            isCalc = false;
        }

        //Xử lý chức năng thêm dấu âm dương
        private void bt_Negative_Click(object sender, EventArgs e)
        {
            string _temp = txtBox_Result.Text;

            //Nếu đang là âm thì xóa
            if (_temp[0] == '-')
            {
                _temp = _temp.Remove(0, 1);
            }
            else //Đang ko có dấu thì thêm dấu âm
            {
                _temp = "-" + _temp;
            }

            txtBox_Result.Text = _temp;
        }

        //Xử lý chức năng mũ 2
        private void bt_Square_Click(object sender, EventArgs e)
        {
            float _temp = float.Parse(txtBox_Result.Text);
            _temp = _temp * _temp;
            txtBox_Result.Text = _temp.ToString();
            isSquared = true;
            isCalc = false;
        }

        //Xử lý chức năng mũ 3
        private void bt_Cube_Click(object sender, EventArgs e)
        {
            double _temp = double.Parse(txtBox_Result.Text);
            _temp = _temp * _temp * _temp;
            txtBox_Result.Text = _temp.ToString();
            isCubed = true;
            isCalc = false;
        }


        //Xử lý chức năng Memory
        #region MemoryFunction
        private void bt_MAdd_Click(object sender, EventArgs e)
        {
            //Nếu khung KQ chưa số khác 0 thì mới bật M+
            if (txtBox_Result.Text != "0")
            {
                //Lưu trữ
                fMemory += float.Parse(txtBox_Result.Text);
                //Bật M+
                lbl_Memory.Visible = true;
                isMemory = true;
            }
        }

        private void bt_MRecall_Click(object sender, EventArgs e)
        {
            if (txtBox_Result.Text != "0")
            {
                //Gọi lại M
                txtBox_Result.Text = fMemory.ToString();
                //Bật cờ isMemory để có thể nhập số khác vào khung KQ thay cho M vừa gọi
                isMemory = true;
                //Tắt cờ isCalc để có thể dùng giá trị của M để tính toán, vì nếu cờ bật thì k gọi phép tính tiếp theo đc
                isCalc = false;
            }
        }

        private void bt_MSub_Click(object sender, EventArgs e)
        {
            if (txtBox_Result.Text != "0")
            {
                fMemory -= float.Parse(txtBox_Result.Text);
                isMemory = true;

                //Nếu M bị trừ hết thì tắt biểu tượng M
                if (fMemory == 0)
                {
                    lbl_Memory.Visible = false;
                }
            }
        }

        private void bt_MClear_Click(object sender, EventArgs e)
        {
            fMemory = 0;
            lbl_Memory.Visible = false;
            isMemory = true;

        }
        #endregion MemoryFunction

        #endregion Functions


        //Hiện bảng giải phương trình
        private void bt_SolEqua_Click(object sender, EventArgs e)
        {
            EquaSol eqs = new EquaSol();
            eqs.Show();
        }

        //Hàm tính toán chung
        private string Calc(string a, string b, string _Type)
        {
            //Lấy hai giá trị trước sau và kiểu phép tính
            float fa = float.Parse(a);
            float fb = float.Parse(b);

            //Xét kiểu và tính toán, return kết quả
            if(_Type == "+")
            {
                return Convert.ToString(fa + fb);
            }
            else if (_Type == "−")
            {
                return Convert.ToString(fa - fb);
            }
            else if (_Type == "*")
            {
                return Convert.ToString(fa * fb);
            }
            else
            {
                return Convert.ToString(fa / fb);
            }
        }

        //Xét xem có thể in số mới ra màn hình (sau khi đã thực hiên 1 chức năng/phép tính gì đó)
        private bool canPrintNewNumb()
        {
            if ((isCalc) || (isMemory) || (isInverse) || (isSqrt) || (isSquared) || (isCubed))
            {
                return true;
            }
            else
                return false;
        }

        //Reset trạng thái cờ về false
        private void resetStatus()
        {
            isCalc = false;
            isMemory = false;
            isInverse = false;
            isSqrt = false;
            isSquared = false;
            isCubed = false;
        }

        //Xét xem có chứa phép tính chưa (vì nếu đã chứa phép tính thì phép tính tiếp theo ta phải tính kq của phép tính trc
        private bool isContainCalcType()
        {
            if ((txtBox_InputStr.Text.Contains("+")) || (txtBox_InputStr.Text.Contains("−")) || (txtBox_InputStr.Text.Contains("*")) || (txtBox_InputStr.Text.Contains("/")))
            {
                return true;
            }
            else
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void txtBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Memory_Click(object sender, EventArgs e)
        {

        }

        

      
        private void txtBox_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            txtBox_Username.Text = "";
            txtBox_Pass.Text = "";
            txtBox_Username.Enabled = true;
            txtBox_Pass.Enabled = true;
            bt_Calc.Enabled = false;
            bt_SolEqua.Enabled = false;
            bt_Add.Enabled = false;
            bt_Sub.Enabled = false;
            bt_Multi.Enabled = false;
            bt_Division.Enabled = false;
        }

        private void txtBox_RegUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtBox_RegPass_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtBox_RegRePass_TextChanged(object sender, EventArgs e)
        {

        }
    }



    public class Account
    {
        public Account(string Username, string Password)
        {
            this._Username = Username;
            this._Password = Password;
        }

        private string _Username;

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
    }
  #endregion
}

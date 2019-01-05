namespace DemoCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Result = new System.Windows.Forms.TextBox();
            this.bt_MAdd = new System.Windows.Forms.Button();
            this.bt_MSub = new System.Windows.Forms.Button();
            this.lbl_Memory = new System.Windows.Forms.Label();
            this.bt_MRecall = new System.Windows.Forms.Button();
            this.bt_MClear = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Negative = new System.Windows.Forms.Button();
            this.bt_Sqrt = new System.Windows.Forms.Button();
            this.bt_Square = new System.Windows.Forms.Button();
            this.bt_Cube = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_Division = new System.Windows.Forms.Button();
            this.bt_Percent = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_Dot = new System.Windows.Forms.Button();
            this.bt_Multi = new System.Windows.Forms.Button();
            this.bt_Sub = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Inverse = new System.Windows.Forms.Button();
            this.bt_Calc = new System.Windows.Forms.Button();
            this.bt_SolEqua = new System.Windows.Forms.Button();
            this.txtBox_InputStr = new System.Windows.Forms.TextBox();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Reg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_RegUsername = new System.Windows.Forms.TextBox();
            this.txtBox_RegPass = new System.Windows.Forms.TextBox();
            this.txtBox_RegRePass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(69, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "MÁY TÍNH";
            // 
            // txtBox_Result
            // 
            this.txtBox_Result.BackColor = System.Drawing.Color.Azure;
            this.txtBox_Result.Enabled = false;
            this.txtBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Result.Location = new System.Drawing.Point(255, 30);
            this.txtBox_Result.Multiline = true;
            this.txtBox_Result.Name = "txtBox_Result";
            this.txtBox_Result.Size = new System.Drawing.Size(296, 57);
            this.txtBox_Result.TabIndex = 7;
            this.txtBox_Result.Text = "0";
            this.txtBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBox_Result.TextChanged += new System.EventHandler(this.txtBox_Result_TextChanged);
            // 
            // bt_MAdd
            // 
            this.bt_MAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MAdd.Location = new System.Drawing.Point(255, 134);
            this.bt_MAdd.Name = "bt_MAdd";
            this.bt_MAdd.Size = new System.Drawing.Size(55, 23);
            this.bt_MAdd.TabIndex = 8;
            this.bt_MAdd.Text = "M+";
            this.bt_MAdd.UseVisualStyleBackColor = true;
            this.bt_MAdd.Click += new System.EventHandler(this.bt_MAdd_Click);
            // 
            // bt_MSub
            // 
            this.bt_MSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MSub.Location = new System.Drawing.Point(316, 134);
            this.bt_MSub.Name = "bt_MSub";
            this.bt_MSub.Size = new System.Drawing.Size(57, 23);
            this.bt_MSub.TabIndex = 9;
            this.bt_MSub.Text = "M-";
            this.bt_MSub.UseVisualStyleBackColor = true;
            this.bt_MSub.Click += new System.EventHandler(this.bt_MSub_Click);
            // 
            // lbl_Memory
            // 
            this.lbl_Memory.AutoSize = true;
            this.lbl_Memory.BackColor = System.Drawing.Color.Azure;
            this.lbl_Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Memory.ForeColor = System.Drawing.Color.Black;
            this.lbl_Memory.Location = new System.Drawing.Point(256, 72);
            this.lbl_Memory.Name = "lbl_Memory";
            this.lbl_Memory.Size = new System.Drawing.Size(17, 13);
            this.lbl_Memory.TabIndex = 10;
            this.lbl_Memory.Text = "M";
            this.lbl_Memory.Visible = false;
            this.lbl_Memory.Click += new System.EventHandler(this.lbl_Memory_Click);
            // 
            // bt_MRecall
            // 
            this.bt_MRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MRecall.Location = new System.Drawing.Point(379, 134);
            this.bt_MRecall.Name = "bt_MRecall";
            this.bt_MRecall.Size = new System.Drawing.Size(52, 23);
            this.bt_MRecall.TabIndex = 11;
            this.bt_MRecall.Text = "MR";
            this.bt_MRecall.UseVisualStyleBackColor = true;
            this.bt_MRecall.Click += new System.EventHandler(this.bt_MRecall_Click);
            // 
            // bt_MClear
            // 
            this.bt_MClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MClear.Location = new System.Drawing.Point(437, 134);
            this.bt_MClear.Name = "bt_MClear";
            this.bt_MClear.Size = new System.Drawing.Size(51, 23);
            this.bt_MClear.TabIndex = 12;
            this.bt_MClear.Text = "MC";
            this.bt_MClear.UseVisualStyleBackColor = true;
            this.bt_MClear.Click += new System.EventHandler(this.bt_MClear_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clear.Location = new System.Drawing.Point(494, 134);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(57, 23);
            this.bt_Clear.TabIndex = 13;
            this.bt_Clear.Text = "C";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Negative
            // 
            this.bt_Negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Negative.Location = new System.Drawing.Point(255, 163);
            this.bt_Negative.Name = "bt_Negative";
            this.bt_Negative.Size = new System.Drawing.Size(55, 23);
            this.bt_Negative.TabIndex = 14;
            this.bt_Negative.Text = "+-";
            this.bt_Negative.UseVisualStyleBackColor = true;
            this.bt_Negative.Click += new System.EventHandler(this.bt_Negative_Click);
            // 
            // bt_Sqrt
            // 
            this.bt_Sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sqrt.Location = new System.Drawing.Point(316, 163);
            this.bt_Sqrt.Name = "bt_Sqrt";
            this.bt_Sqrt.Size = new System.Drawing.Size(57, 23);
            this.bt_Sqrt.TabIndex = 15;
            this.bt_Sqrt.Text = "√";
            this.bt_Sqrt.UseVisualStyleBackColor = true;
            this.bt_Sqrt.Click += new System.EventHandler(this.bt_Sqrt_Click);
            // 
            // bt_Square
            // 
            this.bt_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Square.Location = new System.Drawing.Point(379, 163);
            this.bt_Square.Name = "bt_Square";
            this.bt_Square.Size = new System.Drawing.Size(52, 23);
            this.bt_Square.TabIndex = 16;
            this.bt_Square.Text = "^2";
            this.bt_Square.UseVisualStyleBackColor = true;
            this.bt_Square.Click += new System.EventHandler(this.bt_Square_Click);
            // 
            // bt_Cube
            // 
            this.bt_Cube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cube.Location = new System.Drawing.Point(437, 163);
            this.bt_Cube.Name = "bt_Cube";
            this.bt_Cube.Size = new System.Drawing.Size(51, 23);
            this.bt_Cube.TabIndex = 17;
            this.bt_Cube.Tag = "";
            this.bt_Cube.Text = "^3";
            this.bt_Cube.UseVisualStyleBackColor = true;
            this.bt_Cube.Click += new System.EventHandler(this.bt_Cube_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete.Location = new System.Drawing.Point(494, 163);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(57, 23);
            this.bt_Delete.TabIndex = 18;
            this.bt_Delete.Text = "<---";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_7
            // 
            this.bt_7.Location = new System.Drawing.Point(255, 192);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(55, 23);
            this.bt_7.TabIndex = 19;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_8
            // 
            this.bt_8.Location = new System.Drawing.Point(316, 192);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(57, 23);
            this.bt_8.TabIndex = 20;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = true;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_9
            // 
            this.bt_9.Location = new System.Drawing.Point(379, 192);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(52, 23);
            this.bt_9.TabIndex = 21;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = true;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_Division
            // 
            this.bt_Division.Enabled = false;
            this.bt_Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Division.Location = new System.Drawing.Point(437, 192);
            this.bt_Division.Name = "bt_Division";
            this.bt_Division.Size = new System.Drawing.Size(51, 23);
            this.bt_Division.TabIndex = 22;
            this.bt_Division.Tag = "";
            this.bt_Division.Text = "/";
            this.bt_Division.UseVisualStyleBackColor = true;
            this.bt_Division.Click += new System.EventHandler(this.bt_Division_Click);
            // 
            // bt_Percent
            // 
            this.bt_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Percent.Location = new System.Drawing.Point(494, 192);
            this.bt_Percent.Name = "bt_Percent";
            this.bt_Percent.Size = new System.Drawing.Size(57, 23);
            this.bt_Percent.TabIndex = 23;
            this.bt_Percent.Text = "%";
            this.bt_Percent.UseVisualStyleBackColor = true;
            this.bt_Percent.Click += new System.EventHandler(this.bt_Percent_Click);
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(255, 221);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(55, 23);
            this.bt_4.TabIndex = 19;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(255, 250);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(55, 23);
            this.bt_1.TabIndex = 19;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(316, 221);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(57, 23);
            this.bt_5.TabIndex = 20;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_0
            // 
            this.bt_0.Location = new System.Drawing.Point(255, 279);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(118, 23);
            this.bt_0.TabIndex = 19;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = true;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(316, 250);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(57, 23);
            this.bt_2.TabIndex = 20;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_6
            // 
            this.bt_6.Location = new System.Drawing.Point(379, 221);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(52, 23);
            this.bt_6.TabIndex = 21;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(379, 250);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(52, 23);
            this.bt_3.TabIndex = 21;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_Dot
            // 
            this.bt_Dot.Location = new System.Drawing.Point(379, 279);
            this.bt_Dot.Name = "bt_Dot";
            this.bt_Dot.Size = new System.Drawing.Size(52, 23);
            this.bt_Dot.TabIndex = 21;
            this.bt_Dot.Text = ".";
            this.bt_Dot.UseVisualStyleBackColor = true;
            this.bt_Dot.Click += new System.EventHandler(this.bt_Dot_Click);
            // 
            // bt_Multi
            // 
            this.bt_Multi.Enabled = false;
            this.bt_Multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Multi.Location = new System.Drawing.Point(437, 221);
            this.bt_Multi.Name = "bt_Multi";
            this.bt_Multi.Size = new System.Drawing.Size(51, 23);
            this.bt_Multi.TabIndex = 22;
            this.bt_Multi.Tag = "";
            this.bt_Multi.Text = "*";
            this.bt_Multi.UseVisualStyleBackColor = true;
            this.bt_Multi.Click += new System.EventHandler(this.bt_Multi_Click);
            // 
            // bt_Sub
            // 
            this.bt_Sub.Enabled = false;
            this.bt_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sub.Location = new System.Drawing.Point(437, 250);
            this.bt_Sub.Name = "bt_Sub";
            this.bt_Sub.Size = new System.Drawing.Size(51, 23);
            this.bt_Sub.TabIndex = 22;
            this.bt_Sub.Tag = "";
            this.bt_Sub.Text = "−";
            this.bt_Sub.UseVisualStyleBackColor = true;
            this.bt_Sub.Click += new System.EventHandler(this.bt_Sub_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Enabled = false;
            this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(437, 279);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(51, 23);
            this.bt_Add.TabIndex = 22;
            this.bt_Add.Tag = "";
            this.bt_Add.Text = "+";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Inverse
            // 
            this.bt_Inverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Inverse.Location = new System.Drawing.Point(494, 221);
            this.bt_Inverse.Name = "bt_Inverse";
            this.bt_Inverse.Size = new System.Drawing.Size(57, 23);
            this.bt_Inverse.TabIndex = 23;
            this.bt_Inverse.Text = "1/x";
            this.bt_Inverse.UseVisualStyleBackColor = true;
            this.bt_Inverse.Click += new System.EventHandler(this.bt_Inverse_Click);
            // 
            // bt_Calc
            // 
            this.bt_Calc.Enabled = false;
            this.bt_Calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Calc.Location = new System.Drawing.Point(494, 250);
            this.bt_Calc.Name = "bt_Calc";
            this.bt_Calc.Size = new System.Drawing.Size(57, 52);
            this.bt_Calc.TabIndex = 23;
            this.bt_Calc.Text = "=";
            this.bt_Calc.UseVisualStyleBackColor = true;
            this.bt_Calc.Click += new System.EventHandler(this.bt_Calc_Click);
            // 
            // bt_SolEqua
            // 
            this.bt_SolEqua.Enabled = false;
            this.bt_SolEqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SolEqua.Location = new System.Drawing.Point(255, 308);
            this.bt_SolEqua.Name = "bt_SolEqua";
            this.bt_SolEqua.Size = new System.Drawing.Size(296, 35);
            this.bt_SolEqua.TabIndex = 25;
            this.bt_SolEqua.Text = "Giải phương trình";
            this.bt_SolEqua.UseVisualStyleBackColor = true;
            this.bt_SolEqua.Click += new System.EventHandler(this.bt_SolEqua_Click);
            // 
            // txtBox_InputStr
            // 
            this.txtBox_InputStr.BackColor = System.Drawing.Color.Azure;
            this.txtBox_InputStr.Enabled = false;
            this.txtBox_InputStr.Location = new System.Drawing.Point(255, 89);
            this.txtBox_InputStr.Name = "txtBox_InputStr";
            this.txtBox_InputStr.Size = new System.Drawing.Size(296, 20);
            this.txtBox_InputStr.TabIndex = 28;
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Location = new System.Drawing.Point(105, 90);
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Username.TabIndex = 0;
            this.txtBox_Username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_Username_MouseClick);
            this.txtBox_Username.TextChanged += new System.EventHandler(this.txtBox_Username_TextChanged);
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.Location = new System.Drawing.Point(105, 116);
            this.txtBox_Pass.MinimumSize = new System.Drawing.Size(4, 500);
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.PasswordChar = '*';
            this.txtBox_Pass.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Pass.TabIndex = 1;
            this.txtBox_Pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_Pass_MouseClick);
            this.txtBox_Pass.TextChanged += new System.EventHandler(this.txtBox_Pass_TextChanged);
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(105, 142);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(100, 23);
            this.bt_Login.TabIndex = 2;
            this.bt_Login.Text = "Đăng Nhập";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đăng Nhập";
            // 
            // bt_Reg
            // 
            this.bt_Reg.Location = new System.Drawing.Point(105, 314);
            this.bt_Reg.Name = "bt_Reg";
            this.bt_Reg.Size = new System.Drawing.Size(100, 23);
            this.bt_Reg.TabIndex = 3;
            this.bt_Reg.Text = "Đăng Ký";
            this.bt_Reg.UseVisualStyleBackColor = true;
            this.bt_Reg.Click += new System.EventHandler(this.bt_Reg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tài Khoản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mật Khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tài Khoản:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Mật Khẩu:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Nhập Lại:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(105, 171);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(100, 23);
            this.bt_logout.TabIndex = 35;
            this.bt_logout.Text = "Đăng Xuất";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Đăng Ký";
            // 
            // txtBox_RegUsername
            // 
            this.txtBox_RegUsername.Enabled = false;
            this.txtBox_RegUsername.Location = new System.Drawing.Point(105, 231);
            this.txtBox_RegUsername.Name = "txtBox_RegUsername";
            this.txtBox_RegUsername.Size = new System.Drawing.Size(100, 20);
            this.txtBox_RegUsername.TabIndex = 37;
            this.txtBox_RegUsername.TextChanged += new System.EventHandler(this.txtBox_RegUsername_TextChanged_1);
            // 
            // txtBox_RegPass
            // 
            this.txtBox_RegPass.Enabled = false;
            this.txtBox_RegPass.Location = new System.Drawing.Point(105, 257);
            this.txtBox_RegPass.Name = "txtBox_RegPass";
            this.txtBox_RegPass.PasswordChar = '*';
            this.txtBox_RegPass.Size = new System.Drawing.Size(100, 20);
            this.txtBox_RegPass.TabIndex = 38;
            this.txtBox_RegPass.TextChanged += new System.EventHandler(this.txtBox_RegPass_TextChanged_1);
            // 
            // txtBox_RegRePass
            // 
            this.txtBox_RegRePass.Enabled = false;
            this.txtBox_RegRePass.Location = new System.Drawing.Point(105, 281);
            this.txtBox_RegRePass.Name = "txtBox_RegRePass";
            this.txtBox_RegRePass.PasswordChar = '*';
            this.txtBox_RegRePass.ShortcutsEnabled = false;
            this.txtBox_RegRePass.Size = new System.Drawing.Size(100, 20);
            this.txtBox_RegRePass.TabIndex = 39;
            this.txtBox_RegRePass.TextChanged += new System.EventHandler(this.txtBox_RegRePass_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 364);
            this.Controls.Add(this.txtBox_RegRePass);
            this.Controls.Add(this.txtBox_RegPass);
            this.Controls.Add(this.txtBox_RegUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_InputStr);
            this.Controls.Add(this.bt_SolEqua);
            this.Controls.Add(this.bt_Calc);
            this.Controls.Add(this.bt_Inverse);
            this.Controls.Add(this.bt_Percent);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_Sub);
            this.Controls.Add(this.bt_Multi);
            this.Controls.Add(this.bt_Division);
            this.Controls.Add(this.bt_Dot);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_0);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Cube);
            this.Controls.Add(this.bt_Square);
            this.Controls.Add(this.bt_Sqrt);
            this.Controls.Add(this.bt_Negative);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_MClear);
            this.Controls.Add(this.bt_MRecall);
            this.Controls.Add(this.lbl_Memory);
            this.Controls.Add(this.bt_MSub);
            this.Controls.Add(this.bt_MAdd);
            this.Controls.Add(this.txtBox_Result);
            this.Controls.Add(this.bt_Reg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.txtBox_Username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Result;
        private System.Windows.Forms.Button bt_MAdd;
        private System.Windows.Forms.Button bt_MSub;
        private System.Windows.Forms.Label lbl_Memory;
        private System.Windows.Forms.Button bt_MRecall;
        private System.Windows.Forms.Button bt_MClear;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Negative;
        private System.Windows.Forms.Button bt_Sqrt;
        private System.Windows.Forms.Button bt_Square;
        private System.Windows.Forms.Button bt_Cube;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_Division;
        private System.Windows.Forms.Button bt_Percent;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_Dot;
        private System.Windows.Forms.Button bt_Multi;
        private System.Windows.Forms.Button bt_Sub;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Inverse;
        private System.Windows.Forms.Button bt_Calc;
        private System.Windows.Forms.Button bt_SolEqua;
        private System.Windows.Forms.TextBox txtBox_InputStr;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Reg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_RegUsername;
        private System.Windows.Forms.TextBox txtBox_RegPass;
        private System.Windows.Forms.TextBox txtBox_RegRePass;
    }
}


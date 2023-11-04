
namespace vipigv2
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
            this.label2 = new System.Windows.Forms.Label();
            this.input_username_Vipig = new System.Windows.Forms.TextBox();
            this.input_password_Vipig = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input_password_ins = new System.Windows.Forms.TextBox();
            this.input_username_ins = new System.Windows.Forms.TextBox();
            this.btn_Star = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acc_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.my_user = new System.Windows.Forms.Label();
            this.my_xu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập Vipig";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu Vipig";
            // 
            // input_username_Vipig
            // 
            this.input_username_Vipig.Location = new System.Drawing.Point(139, 13);
            this.input_username_Vipig.Name = "input_username_Vipig";
            this.input_username_Vipig.Size = new System.Drawing.Size(110, 20);
            this.input_username_Vipig.TabIndex = 2;
            // 
            // input_password_Vipig
            // 
            this.input_password_Vipig.Location = new System.Drawing.Point(139, 40);
            this.input_password_Vipig.Name = "input_password_Vipig";
            this.input_password_Vipig.Size = new System.Drawing.Size(110, 20);
            this.input_password_Vipig.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên đăng nhập ins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu ins";
            // 
            // input_password_ins
            // 
            this.input_password_ins.Location = new System.Drawing.Point(408, 47);
            this.input_password_ins.Name = "input_password_ins";
            this.input_password_ins.Size = new System.Drawing.Size(110, 20);
            this.input_password_ins.TabIndex = 6;
            // 
            // input_username_ins
            // 
            this.input_username_ins.Location = new System.Drawing.Point(408, 10);
            this.input_username_ins.Name = "input_username_ins";
            this.input_username_ins.Size = new System.Drawing.Size(110, 20);
            this.input_username_ins.TabIndex = 7;
            // 
            // btn_Star
            // 
            this.btn_Star.BackColor = System.Drawing.Color.Lime;
            this.btn_Star.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Star.Location = new System.Drawing.Point(854, 10);
            this.btn_Star.Name = "btn_Star";
            this.btn_Star.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Star.Size = new System.Drawing.Size(75, 40);
            this.btn_Star.TabIndex = 8;
            this.btn_Star.Text = "Star";
            this.btn_Star.UseVisualStyleBackColor = false;
            this.btn_Star.Click += new System.EventHandler(this.btn_Star_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Red;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Location = new System.Drawing.Point(935, 12);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Stop.Size = new System.Drawing.Size(75, 40);
            this.btn_Stop.TabIndex = 9;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NV,
            this.acc_username,
            this.URL,
            this.messager});
            this.dataGridView1.Location = new System.Drawing.Point(16, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(994, 256);
            this.dataGridView1.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NV
            // 
            this.NV.HeaderText = "Loại nhiệm vụ";
            this.NV.Name = "NV";
            this.NV.ReadOnly = true;
            this.NV.Width = 150;
            // 
            // acc_username
            // 
            this.acc_username.HeaderText = "Tài khoản instagram";
            this.acc_username.Name = "acc_username";
            this.acc_username.ReadOnly = true;
            this.acc_username.Width = 200;
            // 
            // URL
            // 
            this.URL.HeaderText = "Link nhiệm vu";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Width = 250;
            // 
            // messager
            // 
            this.messager.HeaderText = "Trạng thái";
            this.messager.Name = "messager";
            this.messager.ReadOnly = true;
            this.messager.Width = 250;
            // 
            // my_user
            // 
            this.my_user.AutoSize = true;
            this.my_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_user.Location = new System.Drawing.Point(854, 69);
            this.my_user.Name = "my_user";
            this.my_user.Size = new System.Drawing.Size(91, 20);
            this.my_user.TabIndex = 11;
            this.my_user.Text = "Username";
            // 
            // my_xu
            // 
            this.my_xu.AutoSize = true;
            this.my_xu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_xu.Location = new System.Drawing.Point(855, 105);
            this.my_xu.Name = "my_xu";
            this.my_xu.Size = new System.Drawing.Size(31, 20);
            this.my_xu.TabIndex = 12;
            this.my_xu.Text = "Xu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.my_xu);
            this.Controls.Add(this.my_user);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Star);
            this.Controls.Add(this.input_username_ins);
            this.Controls.Add(this.input_password_ins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_password_Vipig);
            this.Controls.Add(this.input_username_Vipig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_username_Vipig;
        private System.Windows.Forms.TextBox input_password_Vipig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_password_ins;
        private System.Windows.Forms.TextBox input_username_ins;
        private System.Windows.Forms.Button btn_Star;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn acc_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn messager;
        private System.Windows.Forms.Label my_user;
        private System.Windows.Forms.Label my_xu;
    }
}


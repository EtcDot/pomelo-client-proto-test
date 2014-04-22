namespace Pomelo_NativeSocket {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_channel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_mid = new System.Windows.Forms.TextBox();
            this.tb_route = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(71, 235);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(140, 28);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(4, 122);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(245, 36);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tb_info
            // 
            this.tb_info.BackColor = System.Drawing.SystemColors.InfoText;
            this.tb_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_info.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_info.ForeColor = System.Drawing.Color.SpringGreen;
            this.tb_info.Location = new System.Drawing.Point(3, 3);
            this.tb_info.Multiline = true;
            this.tb_info.Name = "tb_info";
            this.tb_info.ReadOnly = true;
            this.tb_info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_info.Size = new System.Drawing.Size(476, 590);
            this.tb_info.TabIndex = 0;
            this.tb_info.TabStop = false;
            this.tb_info.WordWrap = false;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(71, 58);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(136, 21);
            this.tb_name.TabIndex = 1;
            this.tb_name.Text = "username";
            // 
            // tb_channel
            // 
            this.tb_channel.Location = new System.Drawing.Point(71, 95);
            this.tb_channel.Name = "tb_channel";
            this.tb_channel.Size = new System.Drawing.Size(136, 21);
            this.tb_channel.TabIndex = 2;
            this.tb_channel.Text = "password";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Controls.Add(this.tb_info, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 596);
            this.tableLayoutPanel1.TabIndex = 100001;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(485, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 590);
            this.panel1.TabIndex = 100001;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_data);
            this.groupBox2.Controls.Add(this.tb_mid);
            this.groupBox2.Controls.Add(this.tb_route);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_send);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 272);
            this.groupBox2.TabIndex = 100004;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "request";
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(47, 83);
            this.tb_data.Multiline = true;
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(204, 146);
            this.tb_data.TabIndex = 9;
            this.tb_data.Text = "{\"id\":1001}";
            // 
            // tb_mid
            // 
            this.tb_mid.Location = new System.Drawing.Point(47, 47);
            this.tb_mid.Name = "tb_mid";
            this.tb_mid.Size = new System.Drawing.Size(204, 21);
            this.tb_mid.TabIndex = 9;
            this.tb_mid.Text = "InstanceMessage";
            // 
            // tb_route
            // 
            this.tb_route.Location = new System.Drawing.Point(47, 20);
            this.tb_route.Name = "tb_route";
            this.tb_route.Size = new System.Drawing.Size(204, 21);
            this.tb_route.TabIndex = 9;
            this.tb_route.Text = "hall.hallHandler.reqInstance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "mid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "route";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_port);
            this.groupBox1.Controls.Add(this.tb_channel);
            this.groupBox1.Controls.Add(this.tb_ip);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GateServer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Channel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(38, 25);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(93, 21);
            this.tb_ip.TabIndex = 10;
            this.tb_ip.Text = "192.168.0.156";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "ip";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "port";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(190, 25);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(46, 21);
            this.tb_port.TabIndex = 10;
            this.tb_port.Text = "3014";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(254, 145);
            this.richTextBox1.TabIndex = 100005;
            this.richTextBox1.Text = "使用说明：\n1.点击connect连服务器(无需填用户名密码)\n2.填写相应request数据，发送请求。";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Text = "pomelo客户端协议测试工具";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox tb_info;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_channel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_mid;
        private System.Windows.Forms.TextBox tb_route;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


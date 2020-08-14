namespace MqttClient
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.box_server = new System.Windows.Forms.GroupBox();
            this.lab_connect = new System.Windows.Forms.Label();
            this.txt_clientid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label_ip = new System.Windows.Forms.Label();
            this.box_recive = new System.Windows.Forms.GroupBox();
            this.txt_subscribe = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_subscribe = new System.Windows.Forms.Button();
            this.box_level_subscribe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_subscribe_topic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_time = new System.Windows.Forms.Label();
            this.lab_send = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_time_sencond = new System.Windows.Forms.TextBox();
            this.checkBox_time = new System.Windows.Forms.CheckBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_publish = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.box_level_publish = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_publish_topic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.box_server.SuspendLayout();
            this.box_recive.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_server
            // 
            this.box_server.Controls.Add(this.lab_connect);
            this.box_server.Controls.Add(this.txt_clientid);
            this.box_server.Controls.Add(this.label1);
            this.box_server.Controls.Add(this.btn_close);
            this.box_server.Controls.Add(this.btn_connect);
            this.box_server.Controls.Add(this.txt_pwd);
            this.box_server.Controls.Add(this.label4);
            this.box_server.Controls.Add(this.txt_name);
            this.box_server.Controls.Add(this.label2);
            this.box_server.Controls.Add(this.txt_port);
            this.box_server.Controls.Add(this.label3);
            this.box_server.Controls.Add(this.txt_ip);
            this.box_server.Controls.Add(this.label_ip);
            this.box_server.Dock = System.Windows.Forms.DockStyle.Top;
            this.box_server.Location = new System.Drawing.Point(0, 0);
            this.box_server.Name = "box_server";
            this.box_server.Size = new System.Drawing.Size(893, 64);
            this.box_server.TabIndex = 0;
            this.box_server.TabStop = false;
            this.box_server.Text = "服务器设置";
            // 
            // lab_connect
            // 
            this.lab_connect.AutoSize = true;
            this.lab_connect.ForeColor = System.Drawing.Color.Red;
            this.lab_connect.Location = new System.Drawing.Point(821, 29);
            this.lab_connect.Name = "lab_connect";
            this.lab_connect.Size = new System.Drawing.Size(24, 17);
            this.lab_connect.TabIndex = 12;
            this.lab_connect.Text = "    ";
            // 
            // txt_clientid
            // 
            this.txt_clientid.Location = new System.Drawing.Point(601, 26);
            this.txt_clientid.Name = "txt_clientid";
            this.txt_clientid.Size = new System.Drawing.Size(100, 23);
            this.txt_clientid.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "客户端ID:";
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Location = new System.Drawing.Point(764, 24);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(51, 23);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "断开";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(707, 24);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(51, 23);
            this.btn_connect.TabIndex = 8;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(435, 26);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(100, 23);
            this.txt_pwd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "密码:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(295, 26);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 23);
            this.txt_name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "账号:";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(212, 26);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(42, 23);
            this.txt_port.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口:";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(45, 27);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(127, 23);
            this.txt_ip.TabIndex = 1;
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(9, 30);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(35, 17);
            this.label_ip.TabIndex = 0;
            this.label_ip.Text = "地址:";
            // 
            // box_recive
            // 
            this.box_recive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_recive.Controls.Add(this.txt_subscribe);
            this.box_recive.Controls.Add(this.btn_subscribe);
            this.box_recive.Controls.Add(this.box_level_subscribe);
            this.box_recive.Controls.Add(this.label6);
            this.box_recive.Controls.Add(this.txt_subscribe_topic);
            this.box_recive.Controls.Add(this.label5);
            this.box_recive.Location = new System.Drawing.Point(4, 72);
            this.box_recive.Name = "box_recive";
            this.box_recive.Size = new System.Drawing.Size(881, 284);
            this.box_recive.TabIndex = 1;
            this.box_recive.TabStop = false;
            this.box_recive.Text = "消息订阅";
            // 
            // txt_subscribe
            // 
            this.txt_subscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_subscribe.BackColor = System.Drawing.SystemColors.ControlText;
            this.txt_subscribe.ContextMenuStrip = this.contextMenuStrip1;
            this.txt_subscribe.ForeColor = System.Drawing.Color.Lime;
            this.txt_subscribe.Location = new System.Drawing.Point(9, 49);
            this.txt_subscribe.Name = "txt_subscribe";
            this.txt_subscribe.Size = new System.Drawing.Size(866, 229);
            this.txt_subscribe.TabIndex = 5;
            this.txt_subscribe.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "清除数据";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem2.Text = "保存到文件";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_subscribe
            // 
            this.btn_subscribe.Enabled = false;
            this.btn_subscribe.Location = new System.Drawing.Point(800, 18);
            this.btn_subscribe.Name = "btn_subscribe";
            this.btn_subscribe.Size = new System.Drawing.Size(75, 23);
            this.btn_subscribe.TabIndex = 4;
            this.btn_subscribe.Text = "订阅";
            this.btn_subscribe.UseVisualStyleBackColor = true;
            this.btn_subscribe.Click += new System.EventHandler(this.btn_subscribe_Click);
            // 
            // box_level_subscribe
            // 
            this.box_level_subscribe.FormattingEnabled = true;
            this.box_level_subscribe.Items.AddRange(new object[] {
            "AtMostOnce(最多一次)",
            "AtLeastOnce(最少一次) ",
            "ExactlyOnce(只有一次)"});
            this.box_level_subscribe.Location = new System.Drawing.Point(581, 18);
            this.box_level_subscribe.Name = "box_level_subscribe";
            this.box_level_subscribe.Size = new System.Drawing.Size(209, 25);
            this.box_level_subscribe.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "消息质量:";
            // 
            // txt_subscribe_topic
            // 
            this.txt_subscribe_topic.Location = new System.Drawing.Point(67, 20);
            this.txt_subscribe_topic.Name = "txt_subscribe_topic";
            this.txt_subscribe_topic.Size = new System.Drawing.Size(443, 23);
            this.txt_subscribe_topic.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "订阅主题:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_time);
            this.groupBox1.Controls.Add(this.lab_send);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_time_sencond);
            this.groupBox1.Controls.Add(this.checkBox_time);
            this.groupBox1.Controls.Add(this.btn_send);
            this.groupBox1.Controls.Add(this.txt_publish);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.box_level_publish);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_publish_topic);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "消息发布";
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.ForeColor = System.Drawing.Color.Red;
            this.lab_time.Location = new System.Drawing.Point(795, 63);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(16, 17);
            this.lab_time.TabIndex = 12;
            this.lab_time.Text = "  ";
            // 
            // lab_send
            // 
            this.lab_send.AutoSize = true;
            this.lab_send.ForeColor = System.Drawing.Color.Red;
            this.lab_send.Location = new System.Drawing.Point(799, 69);
            this.lab_send.Name = "lab_send";
            this.lab_send.Size = new System.Drawing.Size(16, 17);
            this.lab_send.TabIndex = 11;
            this.lab_send.Text = "  ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(834, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "(秒)";
            // 
            // txt_time_sencond
            // 
            this.txt_time_sencond.Location = new System.Drawing.Point(797, 87);
            this.txt_time_sencond.Name = "txt_time_sencond";
            this.txt_time_sencond.Size = new System.Drawing.Size(37, 23);
            this.txt_time_sencond.TabIndex = 9;
            // 
            // checkBox_time
            // 
            this.checkBox_time.AutoSize = true;
            this.checkBox_time.Enabled = false;
            this.checkBox_time.Location = new System.Drawing.Point(720, 89);
            this.checkBox_time.Name = "checkBox_time";
            this.checkBox_time.Size = new System.Drawing.Size(75, 21);
            this.checkBox_time.TabIndex = 8;
            this.checkBox_time.Text = "定时发送";
            this.checkBox_time.UseVisualStyleBackColor = true;
            this.checkBox_time.CheckedChanged += new System.EventHandler(this.checkBox_time_CheckedChanged);
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(720, 60);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(70, 23);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "发布";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_publish
            // 
            this.txt_publish.Location = new System.Drawing.Point(67, 60);
            this.txt_publish.Multiline = true;
            this.txt_publish.Name = "txt_publish";
            this.txt_publish.Size = new System.Drawing.Size(635, 46);
            this.txt_publish.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "发布内容:";
            // 
            // box_level_publish
            // 
            this.box_level_publish.FormattingEnabled = true;
            this.box_level_publish.Items.AddRange(new object[] {
            "AtMostOnce(最多一次)",
            "AtLeastOnce(最少一次) ",
            "ExactlyOnce(只有一次)"});
            this.box_level_publish.Location = new System.Drawing.Point(581, 20);
            this.box_level_publish.Name = "box_level_publish";
            this.box_level_publish.Size = new System.Drawing.Size(209, 25);
            this.box_level_publish.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "消息质量:";
            // 
            // txt_publish_topic
            // 
            this.txt_publish_topic.Location = new System.Drawing.Point(67, 22);
            this.txt_publish_topic.Name = "txt_publish_topic";
            this.txt_publish_topic.Size = new System.Drawing.Size(443, 23);
            this.txt_publish_topic.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "发布主题:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.box_recive);
            this.Controls.Add(this.box_server);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MQTT测试助手";
            this.box_server.ResumeLayout(false);
            this.box_server.PerformLayout();
            this.box_recive.ResumeLayout(false);
            this.box_recive.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_close;
        //private System.Windows.Forms.GroupBox groupbox_server;
        private System.Windows.Forms.GroupBox box_server;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.GroupBox box_recive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.TextBox txt_subscribe_top;
        //private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.TextBox txt_subscribe_topic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox box_level_subscribe;
        private System.Windows.Forms.Button btn_subscribe;
        private System.Windows.Forms.RichTextBox txt_subscribe;
        private System.Windows.Forms.ComboBox box_level_publish;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.ComboBox box_level_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_publish_topic;
        private System.Windows.Forms.TextBox txt_publish;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.CheckBox checkBox_time;
        private System.Windows.Forms.TextBox txt_time_sencond;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label lab_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_clientid;
        private System.Windows.Forms.Label lab_connect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}


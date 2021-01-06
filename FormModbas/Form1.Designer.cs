
namespace FormModbas
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
            this.components = new System.ComponentModel.Container();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ip_modbus = new System.Windows.Forms.TextBox();
            this.lbl_connected = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_connect_status = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.tmr_modbus = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cb_col_1 = new System.Windows.Forms.CheckBox();
            this.cb_col_2 = new System.Windows.Forms.CheckBox();
            this.cb_col_3 = new System.Windows.Forms.CheckBox();
            this.cb_col_4 = new System.Windows.Forms.CheckBox();
            this.cb_col_5 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(448, 96);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(158, 29);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "&Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Modbus Ip Adress:";
            // 
            // txt_ip_modbus
            // 
            this.txt_ip_modbus.Location = new System.Drawing.Point(448, 68);
            this.txt_ip_modbus.Name = "txt_ip_modbus";
            this.txt_ip_modbus.Size = new System.Drawing.Size(158, 22);
            this.txt_ip_modbus.TabIndex = 3;
            // 
            // lbl_connected
            // 
            this.lbl_connected.AutoSize = true;
            this.lbl_connected.Location = new System.Drawing.Point(626, 68);
            this.lbl_connected.Name = "lbl_connected";
            this.lbl_connected.Size = new System.Drawing.Size(86, 17);
            this.lbl_connected.TabIndex = 4;
            this.lbl_connected.Text = "Disconected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Progress Bar (Read Holding)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(299, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // lbl_connect_status
            // 
            this.lbl_connect_status.AutoSize = true;
            this.lbl_connect_status.Location = new System.Drawing.Point(448, 365);
            this.lbl_connect_status.Name = "lbl_connect_status";
            this.lbl_connect_status.Size = new System.Drawing.Size(16, 17);
            this.lbl_connect_status.TabIndex = 7;
            this.lbl_connect_status.Text = "0";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(448, 145);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(158, 33);
            this.btn_disconnect.TabIndex = 8;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // tmr_modbus
            // 
            this.tmr_modbus.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(34, 341);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(299, 56);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cb_col_1
            // 
            this.cb_col_1.AutoSize = true;
            this.cb_col_1.Location = new System.Drawing.Point(448, 184);
            this.cb_col_1.Name = "cb_col_1";
            this.cb_col_1.Size = new System.Drawing.Size(144, 21);
            this.cb_col_1.TabIndex = 10;
            this.cb_col_1.Text = "Col 1 (Read Coils)";
            this.cb_col_1.UseVisualStyleBackColor = true;
            // 
            // cb_col_2
            // 
            this.cb_col_2.AutoSize = true;
            this.cb_col_2.Location = new System.Drawing.Point(448, 211);
            this.cb_col_2.Name = "cb_col_2";
            this.cb_col_2.Size = new System.Drawing.Size(137, 21);
            this.cb_col_2.TabIndex = 11;
            this.cb_col_2.Text = "Col 2 (Read Coil)";
            this.cb_col_2.UseVisualStyleBackColor = true;
            // 
            // cb_col_3
            // 
            this.cb_col_3.AutoSize = true;
            this.cb_col_3.Location = new System.Drawing.Point(448, 239);
            this.cb_col_3.Name = "cb_col_3";
            this.cb_col_3.Size = new System.Drawing.Size(188, 21);
            this.cb_col_3.TabIndex = 12;
            this.cb_col_3.Text = "Col 3 (Read Digital Input)";
            this.cb_col_3.UseVisualStyleBackColor = true;
            // 
            // cb_col_4
            // 
            this.cb_col_4.AutoSize = true;
            this.cb_col_4.Location = new System.Drawing.Point(448, 267);
            this.cb_col_4.Name = "cb_col_4";
            this.cb_col_4.Size = new System.Drawing.Size(136, 21);
            this.cb_col_4.TabIndex = 13;
            this.cb_col_4.Text = "Col 4 (Write Coil)";
            this.cb_col_4.UseVisualStyleBackColor = true;
            this.cb_col_4.CheckedChanged += new System.EventHandler(this.cb_col_4_CheckedChanged);
            // 
            // cb_col_5
            // 
            this.cb_col_5.AutoSize = true;
            this.cb_col_5.Location = new System.Drawing.Point(448, 295);
            this.cb_col_5.Name = "cb_col_5";
            this.cb_col_5.Size = new System.Drawing.Size(136, 21);
            this.cb_col_5.TabIndex = 14;
            this.cb_col_5.Text = "Col 5 (Write Coil)";
            this.cb_col_5.UseVisualStyleBackColor = true;
            this.cb_col_5.CheckedChanged += new System.EventHandler(this.cb_col_5_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Write Holding Register:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Read Analogue Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_col_5);
            this.Controls.Add(this.cb_col_4);
            this.Controls.Add(this.cb_col_3);
            this.Controls.Add(this.cb_col_2);
            this.Controls.Add(this.cb_col_1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.lbl_connect_status);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_connected);
            this.Controls.Add(this.txt_ip_modbus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ip_modbus;
        private System.Windows.Forms.Label lbl_connected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_connect_status;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Timer tmr_modbus;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox cb_col_1;
        private System.Windows.Forms.CheckBox cb_col_2;
        private System.Windows.Forms.CheckBox cb_col_3;
        private System.Windows.Forms.CheckBox cb_col_4;
        private System.Windows.Forms.CheckBox cb_col_5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


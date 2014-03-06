namespace WindTouch
{
    partial class SerialSetting
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
            this.combo_name = new System.Windows.Forms.ComboBox();
            this.combo_data = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_parity = new System.Windows.Forms.ComboBox();
            this.combo_stop = new System.Windows.Forms.ComboBox();
            this.combo_baudrate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Go = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号";
            // 
            // combo_name
            // 
            this.combo_name.FormattingEnabled = true;
            this.combo_name.Location = new System.Drawing.Point(151, 12);
            this.combo_name.Name = "combo_name";
            this.combo_name.Size = new System.Drawing.Size(121, 20);
            this.combo_name.TabIndex = 1;
            // 
            // combo_data
            // 
            this.combo_data.FormattingEnabled = true;
            this.combo_data.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.combo_data.Location = new System.Drawing.Point(151, 42);
            this.combo_data.Name = "combo_data";
            this.combo_data.Size = new System.Drawing.Size(121, 20);
            this.combo_data.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "校验位";
            // 
            // combo_parity
            // 
            this.combo_parity.FormattingEnabled = true;
            this.combo_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.combo_parity.Location = new System.Drawing.Point(151, 72);
            this.combo_parity.Name = "combo_parity";
            this.combo_parity.Size = new System.Drawing.Size(121, 20);
            this.combo_parity.TabIndex = 3;
            // 
            // combo_stop
            // 
            this.combo_stop.FormattingEnabled = true;
            this.combo_stop.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.combo_stop.Location = new System.Drawing.Point(151, 102);
            this.combo_stop.Name = "combo_stop";
            this.combo_stop.Size = new System.Drawing.Size(121, 20);
            this.combo_stop.TabIndex = 3;
            // 
            // combo_baudrate
            // 
            this.combo_baudrate.FormattingEnabled = true;
            this.combo_baudrate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.combo_baudrate.Location = new System.Drawing.Point(151, 132);
            this.combo_baudrate.Name = "combo_baudrate";
            this.combo_baudrate.Size = new System.Drawing.Size(121, 20);
            this.combo_baudrate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "停止位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "波特率";
            // 
            // Button_Go
            // 
            this.Button_Go.Location = new System.Drawing.Point(49, 167);
            this.Button_Go.Name = "Button_Go";
            this.Button_Go.Size = new System.Drawing.Size(75, 23);
            this.Button_Go.TabIndex = 4;
            this.Button_Go.Text = "打开";
            this.Button_Go.UseVisualStyleBackColor = true;
            this.Button_Go.Click += new System.EventHandler(this.Button_Go_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(165, 167);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 4;
            this.Button_Cancel.Text = "取消";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // SerialSetting
            // 
            this.AcceptButton = this.Button_Go;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Go);
            this.Controls.Add(this.combo_baudrate);
            this.Controls.Add(this.combo_stop);
            this.Controls.Add(this.combo_parity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialSetting";
            this.Text = "SerialSetting";
            this.Load += new System.EventHandler(this.SerialSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_name;
        private System.Windows.Forms.ComboBox combo_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_parity;
        private System.Windows.Forms.ComboBox combo_stop;
        private System.Windows.Forms.ComboBox combo_baudrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_Go;
        private System.Windows.Forms.Button Button_Cancel;
    }
}
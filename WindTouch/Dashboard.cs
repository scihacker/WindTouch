using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindTouch
{
    public partial class Dashboard : Form
    {
        public Boolean recv = true;
        public WindTouch f;
        public Boolean EmergencyStop = true;
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(WindTouch f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void Track_Motor_Scroll2(object sender, EventArgs e)
        {
            Label_Motor_Speed2.Text = Track_Motor2.Value.ToString();
        }

        private void Track_Motor_Scroll3(object sender, EventArgs e)
        {
            Label_Motor_Speed3.Text = Track_Motor3.Value.ToString();
        }

        private void Track_Motor_Scroll4(object sender, EventArgs e)
        {
            Label_Motor_Speed4.Text = Track_Motor4.Value.ToString();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            f.DashBoardMenuItem.Checked = false;
            this.Hide();
        }

        private void Button_Hide_Click(object sender, EventArgs e)
        {
            f.DashBoardMenuItem.Checked = false;
            this.Hide();
        }

        private void Progress_Battery_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(Progress_Battery, Progress_Battery.Value.ToString() + "%");
        }

        private void Button_Pause_Click(object sender, EventArgs e)
        {
            if (recv) { recv = false; Button_Pause.Text = "开始刷新"; }
            else { recv = true; Button_Pause.Text = "停止刷新"; }
        }

        private void send_data()
        { 
            char[] b = new char[15];
            b[0] = (char)0xff;
            b[1] = (char)Num_Camera_P.Value;
            b[2] = (char)Num_Camera_D.Value;
            b[3] = (char)Num_EM_P.Value;
            b[4] = (char)Num_EM_D.Value;
            b[5] = (char)Num_Motor_P.Value;
            b[6] = (char)Num_Motor_I.Value;
            b[7] = (char)Num_Motor_D.Value;
            b[8] = (char)Num_Threshold.Value;
            b[9] = (char)Track_Motor1.Value;
            b[10] = (Check_Motor_PID.Checked) ? (char)1 : (char)0;
            b[11] = (EmergencyStop) ? (char)1 : (char)0;
            b[12] = (char)Track_Motor2.Value;
            b[13] = (char)Track_Motor3.Value;
            b[14] = (char)Track_Motor4.Value;
            f.sp.Write(b, 0, 15);    
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            EmergencyStop = false;
            send_data();
        }

        private void Button_Emergency_Click(object sender, EventArgs e)
        {
            EmergencyStop = true;
            send_data();
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            send_data();
        }

        private void Track_Motor_Scroll1(object sender, EventArgs e)
        {
            Label_Motor_Speed1.Text = Track_Motor1.Value.ToString();
        }
    }
}

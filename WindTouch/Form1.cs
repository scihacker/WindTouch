using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindTouch
{
    public partial class WindTouch : Form
    {
        private int input_speed, messure_speed, angle, midLine, battery, cond;
        private int[] graph; 
        private Dashboard db;

        private static int w = 480;
        private static int h = 250;
        public WindTouch()
        {
            db = new Dashboard(this);
            graph = new int[128];
            InitializeComponent();
        }

        private void About_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void SerialSettingMenuItem_Click(object sender, EventArgs e)
        {
            /*
            if (sp.IsOpen) { sp.Close(); ToolStrip_Cond.Text = "串口已关闭"; SerialSettingMenuItem.Text = "串口设置"; return; }
            sp.Open();
            SerialSettingMenuItem.Text = "关闭串口";
            ToolStrip_Cond.Text = "串口已打开";
            */
            
            if (sp.IsOpen) { sp.Close(); ToolStrip_Cond.Text = "串口已关闭"; SerialSettingMenuItem.Text = "串口设置"; return; }
            SerialSetting ss = new SerialSetting(sp);
            ss.ShowDialog();
            SerialSettingMenuItem.Text = "关闭串口";
            ToolStrip_Cond.Text = "串口已打开";
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DashBoardMenuItem_Click(object sender, EventArgs e)
        {
            if (DashBoardMenuItem.Checked) db.Show();
            else db.Hide();
        }

        private void sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                if (!db.recv) return;
                if (sp.ReadByte() != 255) return;
                input_speed = sp.ReadByte();
                messure_speed = sp.ReadByte();
                angle = sp.ReadByte();
                if (angle >= 128) angle = angle - 256;
                midLine = sp.ReadByte();
                battery = sp.ReadByte();
                cond = sp.ReadByte();
                for (int i = 0; i < 128; i++)
                    graph[i] = sp.ReadByte();
                db.Progress_Input_Speed.Invoke(new MethodInvoker(

                        delegate
                        {
                            db.Progress_Input_Speed.Value = input_speed;
                        }

                    ));
                db.Label_Input_Speed.Invoke(new MethodInvoker(

                        delegate
                        {
                            db.Label_Input_Speed.Text = input_speed.ToString();
                        }

                    ));
                db.Label_Messure_Speed.Invoke(new MethodInvoker(

                        delegate
                        {
                            db.Label_Messure_Speed.Text = messure_speed.ToString();
                        }

                    ));
                db.Progress_Messure_Speed.Invoke(new MethodInvoker(

                        delegate
                        {
                            db.Progress_Messure_Speed.Value = messure_speed;
                        }

                    ));
                db.Progress_Angle.Invoke(new MethodInvoker(

                        delegate
                        {
                            db.Progress_Angle.Value = angle + 128;
                        }

                    ));
                db.Label_Angle.Invoke(new MethodInvoker(

                        delegate
                        {
                            db.Label_Angle.Text = angle.ToString();
                        }

                    ));
                db.Progress_Battery.Invoke(new MethodInvoker(

                        delegate
                        {
                            db.Progress_Battery.Value = battery;
                        }

                    ));
                db.Progress_Battery.Invoke(new MethodInvoker(

                        delegate
                        {
                            db.Progress_Battery.Value = battery;
                        }

                    ));
            }
            catch (InvalidOperationException)
            {
                return;
            }
            catch (Exception)
            {
                // MessageBox.Show("Some Unknown Error");
                return;
            }

        }

        private void WindTouch_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("The Program will be closed.");
            sp.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void WindTouch_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 2);
            for (int i = 0;i < 127;i++)
            {
                graphics.DrawLine(blackPen, w * i / 128, h - graph[i] * h / 255, w * (i + 1) / 128, h - graph[i + 1] * h / 255);
            }
            graphics.DrawLine(blackPen, w * midLine / 128, 0, w * midLine / 128, h);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStrip_Value.Text = (e.X * 128 / w).ToString() + ", " + ((h - e.Y) * 255 / h).ToString();
        }
    }
}

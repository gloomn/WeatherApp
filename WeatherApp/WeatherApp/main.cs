/*
 * Copyright (c) 2021 gloomn
 *
 *  Licensed under the General Public License, Version 3.0 (the "License");
 *  you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * https://opensource.org/licenses/gpl-3.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class main : Form
    {
        int mov;
        int movX;
        int movY;
        private const int cGrip = 16;
        private const int cCaption = 32;
        int menu_width;
        bool hided;

        public main()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.MinimumSize = new Size(800, 450);
            menu_width = sidePanel.Width;
            hided = true;
        }

        public void navBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        public void navBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        public void navBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        protected override void WndProc(ref Message m)
        {
            if(m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if(pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if(pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            smallerButton.BringToFront();
        }

        private void smallerButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            maximizeButton.BringToFront();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void menuBar_Click(object sender, EventArgs e)
        {
            slidePanelTimer.Start();
            menuBar.Hide();
            closeMenu.Show();
        }

        private void slidePanelTimer_Tick(object sender, EventArgs e)
        {
            if(hided)
            {
                sidePanel.Width = sidePanel.Width + 145;
                if(sidePanel.Width >= menu_width)
                {
                    slidePanelTimer.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                sidePanel.Width = sidePanel.Width - 145;
                if(sidePanel.Width >= 0)
                {
                    slidePanelTimer.Stop();
                    hided = true;
                    this.Refresh();
                }
            }
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            slidePanelTimer.Start();
            closeMenu.Hide();
            menuBar.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            hanriverTemp1.BringToFront();
        }
    }
}

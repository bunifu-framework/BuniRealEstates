using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuniRealEstates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuDropdown1.SelectedIndex = 0;
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizePictureBox_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
           
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool isFormMinimized = false;
        private void minimizePictureBox7_Click(object sender, EventArgs e)
        {
            isFormMinimized = true;
            bunifuPanel1.Visible = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal){
                bunifuPanel1.Visible = true;
            }
        }

        private void maximizePictureBox8_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inBunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            List<Color> bunifuColors = new List<Color>();
            if (e.Checked == true)
            {
                if (bunifuColors.Count > 0)
                {
                    bunifuColors.Clear();
                    bunifuColors.Add(Color.FromArgb(210, 72, 169, 248));
                }
                else
                {
                    bunifuColors.Add(Color.FromArgb(210, 72, 169, 248));
                }
                bunifuBarChart1.BackgroundColor = bunifuColors;
            }
            else
            {
                if (bunifuColors.Count > 0)
                {
                    bunifuColors.Clear();
                    bunifuColors.Add(Color.FromArgb(100,170, 170, 170));
                }
                else
                {
                    bunifuColors.Add(Color.FromArgb(100, 170, 170, 170));
                }
                bunifuBarChart1.BackgroundColor = bunifuColors;
            }
        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void crBunifuToggleSwitch2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                crBunifuLineChart2.BorderColor = Color.FromArgb(27, 208, 132);
                crBunifuLineChart2.BackgroundColor = Color.FromArgb(27, 208, 132);
                crBunifuLineChart2.Order = -2;
            }
            else
            {
                crBunifuLineChart2.BorderColor = Color.LightGray;
                crBunifuLineChart2.BackgroundColor = Color.LightGray;
                crBunifuLineChart2.Order = 2;
            }
        }

        private void rcBunifuToggleSwitch3_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (e.Checked == true)
            {
                rcBunifuLineChart1.BackgroundColor = Color.CornflowerBlue;
                rcBunifuLineChart1.BorderColor = Color.CornflowerBlue;
                rcBunifuLineChart1.Order = -1;
            }
            else
            {
                rcBunifuLineChart1.BackgroundColor = Color.LightGray;
                rcBunifuLineChart1.BorderColor = Color.LightGray;
                rcBunifuLineChart1.Order = 1;
            }
        }
        Random randomData = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Double> polarDataList = new List<double>()
            {
                randomData.Next(20,90),
                randomData.Next(20,90),
                randomData.Next(20,90)
            };
            bunifuPolarAreaChart1.Data = polarDataList;
            bunifuChartCanvas1.Update();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (cbShowDate.Checked)
                labelTime.Text += $"\n{DateTime.Now.ToString("yyyy:MM:dd")}";
            if (cbShowDate.Checked)
                labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
        
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            cbShowDate.Visible = false;
            cbShowWeekday.Visible = false;
            btnHideControls.Visible = false;
            ShowInTaskbar = false;
        }
    }
}

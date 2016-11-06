using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetTime
{
    public partial class Form1 : Form
    {
        double beats;
        public Form1()
        {
            InitializeComponent();
            UpdateTime.Start();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            beats = DateTime.Now.ToUniversalTime().AddHours(1).TimeOfDay.TotalMilliseconds / 86400d;
            InternetTimeTextBox.Text = beats.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RealTimeUpdatingCheckBox.Checked == true)
            {
                beats = DateTime.Now.ToUniversalTime().AddHours(1).TimeOfDay.TotalMilliseconds / 86400d;
                InternetTimeTextBox.Text = beats.ToString();
            }
            NormalTimeTextBox.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var TestTimer = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 1000; i++)
            {
                beats = DateTime.Now.ToUniversalTime().AddHours(1).TimeOfDay.TotalMilliseconds / 86400d;
                InternetTimeTextBox.Text = beats.ToString();
            }
            TestTimer.Stop();
            TestEndedTextBox.Text = (TestTimer.ElapsedMilliseconds).ToString() + " ms";
        }
    }
}

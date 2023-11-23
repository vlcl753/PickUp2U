using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressSettingForm
{
    public partial class Form1 : Form
    {
        public string ExpectedTime { get; private set; }
        public string Status { get; private set; }
        public DateTime ProductInProgressTime { get; private set; }
        public DateTime PickupWaitingTime { get; private set; }
        public DateTime PickupCompleteTime { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void radProductInProgress_CheckedChanged(object sender, EventArgs e)
        {
            if (radProductInProgress.Checked)
            {
                ProductInProgressTime = DateTime.Now;
                txtInProgressTime.Text = ProductInProgressTime.ToString();
            }
        }

        private void radPickupWaiting_CheckedChanged(object sender, EventArgs e)
        {
            if (radPickupWaiting.Checked)
            {
                PickupWaitingTime = DateTime.Now;
                txtWaitingTime.Text = PickupWaitingTime.ToString();
            }
        }

        private void radPickupComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (radPickupComplete.Checked)
            {
                PickupCompleteTime = DateTime.Now;
                txtCompleteTime.Text = PickupCompleteTime.ToString();
            }
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            ExpectedTime = txtExpectedTime.Text;
          

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string GetSelectedStatus()
        {
            if (radProductInProgress.Checked)
            {
                return "상품 준비중";
            }
            else if (radPickupWaiting.Checked)
            {
                return "픽업 대기중";
            }
            else if (radPickupComplete.Checked)
            {
                return "픽업 완료";
            }
            else
            {
                return string.Empty;
            }
        }
       
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanCalculator
{
    public partial class RomanCalculator : Form
    {
        public RomanCalculator()
        {
            InitializeComponent();
            romanRadioBtn.Checked = true;
        }

        private void normalRadioBtn_OnClick(object sender, EventArgs e)
        {
            if (romanRadioBtn.Checked == true)
            {
                normalRadioBtn.Checked = true;
                romanRadioBtn.Checked = false;
            }
        }

        private void romanRadioBtn_OnClick(object sender, EventArgs e)
        {
            if (normalRadioBtn.Checked == true)
            {
                romanRadioBtn.Checked = true;
                normalRadioBtn.Checked = false;
            }
        }
        private void normalRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btnClear.Text = "C";
        }
        

        private void romanRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            btn1.Text = "I";
            btn2.Text = "II";
            btn3.Text = "III";
            btn4.Text = "IV";
            btn5.Text = "V";
            btn6.Text = "VI";
            btn7.Text = "VII";
            btn8.Text = "VIII";
            btn9.Text = "IX";
            btnClear.Text = "Diluo";
        }
    }
}

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
        int firstEntered; //remembers the first entry.
        int secondEntered; // remembers the second entry.
        string c; // represents the operand to be executed.
        int result; 
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
            label1.Text = "Calculator";
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
            label1.Text = "Computatrum";
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

        private void btn1_Click(object sender, EventArgs e)
        {
            if (display.Text == null)
            {
                int firstEntered = 1;
            }
            else
            {
                secondEntered = 1;
            }

            if(romanRadioBtn.Checked == true)
            {
                display.Text = "I";
            }
            else
            {
                display.Text = "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (display.Text == null)
            {
                int firstEntered = 2;
            }
            else
            {
                int secondEntered = 2;
            }
            if (romanRadioBtn.Checked == true)
            {
                display.Text = "II";
            }
            else
            {
                display.Text = "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (display.Text == null)
            {
                int firstEntered = 3;
            }
            else
            {
                int secondEntered = 3;
            }
            if (romanRadioBtn.Checked == true)
            {
                display.Text = "III";
            }
            else
            {
                display.Text = "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (display.Text == null)
            {
                int firstEntered = 4;
            }
            else
            {
                int secondEntered = 4;
            }
            if (romanRadioBtn.Checked == true)
            {
                display.Text = "IV";
            }
            else
            {
                display.Text = "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (display.Text == null)
            {
                int firstEntered = 5;
            }
            else
            {
                int secondEntered = 5;
            }

            if (romanRadioBtn.Checked == true)
            {
                display.Text = "V";
            }
            else
            {
                display.Text = "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (display.Text == null)
            {
                int firstEntered = 6;
            }
            else
            {
                int secondEntered = 6;
            }
            if (romanRadioBtn.Checked == true)
            {
                display.Text = "VI";
            }
            else
            {
                display.Text = "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (display.Text == null)
            {
                int firstEntered = 7;
            }
            else
            {
                int secondEntered = 7;
            }
            if (romanRadioBtn.Checked == true)
            {
                display.Text = "VII";
            }
            else
            {
                display.Text = "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (display.Text == null)
            {
                int firstEntered = 8;
            }
            else
            {
                int secondEntered = 8;
            }
            if (romanRadioBtn.Checked == true)
            {
                display.Text = "VIII";
            }
            else
            {
                display.Text = "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (display.Text == null)
            {
                int firstEntered = 9;
            }
            else
            {
                int secondEntered = 9;
            }
            if (romanRadioBtn.Checked == true)
            {
                display.Text = "IX";
            }
            else
            {
                display.Text = "9";
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case "+":
                    result = firstEntered + secondEntered;
                    break;
                case "-":
                    result = firstEntered - secondEntered;
                    break;
                case "/":
                    result = firstEntered / secondEntered;
                    break;
            }
            display.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int firstEntered = 0;
            int secondEntered = 0;
            display.Text = null;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            display.Text = "/";
            c = "/";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            display.Text = "-";
            c = "-";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            display.Text = "+";
            c = "+";
        }
    }
}

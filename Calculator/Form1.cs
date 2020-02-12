using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text != "0")
            {
                boxDisplay.Text += "0";
                updateResult();
            }  
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            boxDisplay.Text += ".";

            updateResult();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text == "0")
                boxDisplay.Text = "1";
            else
                boxDisplay.Text += "1";

            updateResult();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text == "0")
                boxDisplay.Text = "2";
            else
                boxDisplay.Text += "2";

            updateResult();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text == "0")
                boxDisplay.Text = "3";
            else
                boxDisplay.Text += "3";

            updateResult();
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text == "0")
                boxDisplay.Text = "4";
            else
                boxDisplay.Text += "4";

            updateResult();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text == "0")
                boxDisplay.Text = "5";
            else
                boxDisplay.Text += "5";

            updateResult();
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text == "0")
                boxDisplay.Text = "6";
            else
                boxDisplay.Text += "6";

            updateResult();
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text == "0")
                boxDisplay.Text = "7";
            else
                boxDisplay.Text += "7";

            updateResult();
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text == "0")
                boxDisplay.Text = "8";
            else
                boxDisplay.Text += "8";

            updateResult();
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text == "0")
                boxDisplay.Text = "9";
            else
                boxDisplay.Text += "9";

            updateResult();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            boxDisplay.Text = "0";

            boxResult.Text = "0";
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text != "0")
                boxDisplay.Text += "%";

            updateResult();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text != "0")
                boxDisplay.Text += "÷";

            updateResult();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text != "0")
                boxDisplay.Text += "×";

            updateResult();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text != "0")
                boxDisplay.Text += "−";
            else
                boxDisplay.Text = "−";

            updateResult();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 24)
                return;

            if (boxDisplay.Text.Length > 13)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (boxDisplay.Text != "0")
                boxDisplay.Text += "+";

            updateResult();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (boxDisplay.Text.Length > 0)
                boxDisplay.Text = boxDisplay.Text.Remove(boxDisplay.Text.Length - 1);

            if (boxDisplay.Text.Length == 0)
                boxDisplay.Text = "0";

            if (boxDisplay.Text.Length < 15)
                boxDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            updateResult();
        }

        private void buttonEquation_Click(object sender, EventArgs e)
        {
            if (boxResult.Text == "error")
                return;

            boxDisplay.Text = boxResult.Text;
        }

        private void boxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        void updateResult()
        {
            boxResult.Text = getResult();
        }

        string getResult()
        {
            string s = boxDisplay.Text;

            int num_Oper = 0;
            int type_Oper = 0;
            int pos_Oper = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '+')
                {
                    num_Oper++;
                    type_Oper = 0;
                    pos_Oper = i;
                }
                else if (s[i] == '−')
                {
                    num_Oper++;
                    type_Oper = 1;
                    pos_Oper = i;
                }
                else if (s[i] == '×')
                {
                    num_Oper++;
                    type_Oper = 2;
                    pos_Oper = i;
                }
                else if (s[i] == '÷')
                {
                    num_Oper++;
                    type_Oper = 3;
                    pos_Oper = i;
                }
            }

            if (num_Oper > 1)
                return "error";
            else if (num_Oper == 0)
            {
                //get number of percentage sign
                int numPercent = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '%')
                        numPercent++;
                }

                if (numPercent == 0)
                {
                    try
                    {
                        string sub = s;
                        if (sub[0] == '−')
                            sub = "-" + sub.Substring(1);
                        float number = float.Parse(sub);

                        if (number >= 0)
                            return number.ToString();
                        else
                            return '−' + number.ToString().Substring(1);
                    }
                    catch
                    {
                        return "error";
                    }
                }
                else if (numPercent == 1)
                {
                    if (s[s.Length - 1] != '%')
                        return "error";
                    else
                    {
                        bool isNega = (s[0] == '−');
                        string sNum;

                        if (isNega)
                            sNum = s.Substring(1, s.Length - 2);
                        else
                            sNum = s.Remove(s.Length - 1);


                        float number;

                        try
                        {
                            number = float.Parse(sNum) / 100;
                        }
                        catch
                        {
                            return "error";
                        }

                        if (isNega)
                            number = -number;

                        string res = number.ToString();

                        if (isNega)
                            res = "−" + res.Substring(1);

                        return res;
                    }
                }
                else
                    return "error";
            }
            else //num_Order == 1
            {
                string sNum1 = null;
                string sNum2 = null;

                try
                {
                    sNum1 = s.Substring(0, pos_Oper);
                    sNum2 = s.Substring(pos_Oper + 1, s.Length - pos_Oper - 1);

                    bool isPercentNum1 = (sNum1[sNum1.Length - 1] == '%');
                    bool isPercentNum2 = (sNum2[sNum2.Length - 1] == '%');

                    if (isPercentNum1)
                        sNum1 = sNum1.Remove(sNum1.Length - 1);

                    if (isPercentNum2)
                        sNum2 = sNum2.Remove(sNum2.Length - 1);
                    if (sNum1[0] == '−')
                        sNum1 = "-" + sNum1.Substring(1);

                    float num1 = float.Parse(sNum1);
                    float num2 = float.Parse(sNum2);

                    if (isPercentNum1)
                        num1 /= 100;
                    if (isPercentNum2)
                        num2 /= 100;

                    float res;

                    if (type_Oper == 0)
                        res = num1 + num2;
                    else if (type_Oper == 1)
                        res = num1 - num2;
                    else if (type_Oper == 2)
                        res = num1 * num2;
                    else
                        res = num1 / num2;

                    string resString = res.ToString();

                    if (resString[0] == '-')
                        resString = "−" + resString.Substring(1);

                    return resString;
                }
                catch
                {
                    return "error";
                }
            }
        }

        private void boxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

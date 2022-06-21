using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppsssssssssssssss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ffdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            public static void Deconv(double[] dividend, double[] divisor, out double[] quotient, out double[] remainder)
            {
                System.Drawing.Font iFont = new System.Drawing.Font("Tahoma", 11, FontStyle.Italic);
                if (dividend.Last() == 0)
                {
                    throw new ArithmeticException("Старший член многочлена делимого не может быть 0");
                }
                if (divisor.Last() == 0)
                {
                    throw new ArithmeticException("Старший член многочлена делителя не может быть 0");
                }
                remainder = (double[])dividend.Clone();
                quotient = new double[remainder.Length - divisor.Length + 1];
                for (int i = 0; i < quotient.Length; i++)
                {
                    double coeff = remainder[remainder.Length - i - 1] / divisor.Last();
                    quotient[quotient.Length - i - 1] = coeff;
                    for (int j = 0; j < divisor.Length; j++)
                    {
                        remainder[remainder.Length - i - j - 1] -= coeff * divisor[divisor.Length - j - 1];
                    }
                    string str5 = "";
                    if (remainder.Length == 2)
                    {
                        str5 = $"{remainder[1]}x + {remainder[0]}";
                    }
                    if (remainder.Length == 3)
                    {
                        str5 = $"{remainder[2]}x² + {remainder[1]}x + {remainder[0]}";
                    }
                    if (remainder.Length == 4)
                    {
                        str5 = $"{remainder[3]}x³+{remainder[2]}x² + {remainder[1]}x + {remainder[0]}";
                    }
                    if (remainder.Length == 5)
                    {
                        str5 = $"{remainder[4]}x⁴+{remainder[3]}x³+{remainder[2]}x² + {remainder[1]}x + {remainder[0]}";
                    }
                    if (remainder.Length == 6)
                    {
                        str5 = $"{remainder[5]}x⁵+{remainder[4]}x⁴+{remainder[3]}x³+{remainder[2]}x² + {remainder[1]}x + {remainder[0]}";
                    }
                }
            }
       
        }

        public static void unite(string[] quotient, out string top)
        {
            top = "";
            if (quotient == null)
            {
                top = "не делится!";
            }
            else
            {
                for (int i = 0; i < quotient.Length; i++)
                {
                    top += quotient[i] + " ";
                }
            }

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            double x1 = 10;
            double y1 = 25;
            double x2;

            string str = " ";
            string st = " ";
            if (quotient.Length == 2)
            {

                str = $"{quotient[1]} x + {quotient[0]}";
                strr1 = str.Split(' ');
                for (int i = 1; i < quotient.Length; i++)
                {
                    if (quotient[i] == 1)
                    {
                        for (int j = 0; j < strr1.Length - 1; j++)
                        {
                            if (strr1[j].Contains($"{quotient[i]}") == true)
                            {
                                strr1[j] = "";
                            }
                        }
                    }
                }
            }
            if (quotient.Length == 3)
            {
                str = $"{quotient[2]} x² + {quotient[1]} x + {quotient[0]}";
                strr1 = str.Split(' ');
                for (int i = 1; i < quotient.Length; i++)
                {
                    if (quotient[i] == 1)
                    {
                        for (int j = 0; j < strr1.Length - 1; j++)
                        {
                            if (strr1[j].Contains($"{quotient[i]}") == true)
                            {
                                strr1[j] = "";
                            }
                        }
                    }
                }
            }
            if (quotient.Length == 4)
            {
                str = $"{quotient[3]} x³+ {quotient[2]} x² + {quotient[1]} x + {quotient[0]}";
                strr1 = str.Split(' ');
                for (int i = 1; i < quotient.Length; i++)
                {
                    if (quotient[i] == 1)
                    {
                        for (int j = 0; j < strr1.Length - 1; j++)
                        {
                            if (strr1[j].Contains($"{quotient[i]}") == true)
                            {
                                strr1[j] = "";
                            }
                        }
                    }
                }
            }
            if (quotient.Length == 5)
            {
                str = $"{quotient[4]} x⁴+ {quotient[3]} x³+ {quotient[2]} x² + {quotient[1]} x + {quotient[0]}";
                strr1 = str.Split(' ');
                for (int i = 1; i < quotient.Length; i++)
                {
                    if (quotient[i] == 1)
                    {
                        for (int j = 0; j < strr1.Length - 1; j++)
                        {
                            if (strr1[j].Contains($"{quotient[i]}") == true)
                            {
                                strr1[j] = "";
                            }
                        }
                    }
                }
            }
            if (quotient.Length == 6)
            {
                str = $"{quotient[5]} x⁵+ {quotient[4]} x⁴+ {quotient[3]} x³+ {quotient[2]} x² + {quotient[1]} x + {quotient[0]}";
                strr1 = str.Split(' ');
                for (int i = 1; i < quotient.Length; i++)
                {
                    if (quotient[i] == 1)
                    {
                        for (int j = 0; j < strr1.Length - 1; j++)
                        {
                            if (strr1[j].Contains($"{quotient[i]}") == true)
                            {
                                strr1[j] = "";
                            }
                        }
                    }
                }
            }
            unite(strr1, out str);
            System.Drawing.Font iFont = new System.Drawing.Font("Tahoma", 11, FontStyle.Italic);
            string str1 = " ";
            if (reminder.Length == 2)
            {
                str1 = $"{reminder[1]}x + {reminder[0]}";
            }
            if (reminder.Length == 3)
            {
                str1 = $"{reminder[2]}x² + {reminder[1]}x + {reminder[0]}";
            }
            if (reminder.Length == 4)
            {
                str1 = $"{reminder[3]}x³+{reminder[2]}x² + {reminder[1]}x + {reminder[0]}";
            }
            if (reminder.Length == 5)
            {
                str1 = $"{reminder[4]}x⁴+{reminder[3]}x³+{reminder[2]}x² + {reminder[1]}x + {reminder[0]}";
            }
            if (reminder.Length == 6)
            {
                str1 = $"{reminder[5]}x⁵+{reminder[4]}x⁴+{reminder[3]}x³+{reminder[2]}x² + {reminder[1]}x + {reminder[0]}";
            }
            string str2 = " ";
            if (dividend.Length == 2)
            {
                str2 = $"{dividend[1]} x + {dividend[0]}";
                strr2 = str2.Split(' ');
                for (int i = 1; i < dividend.Length; i++)
                {
                    if (dividend[i] == 1)
                    {
                        for (int j = 0; j < strr2.Length - 1; j++)
                        {
                            if (strr2[j].Contains($"{dividend[i]}") == true)
                            {
                                strr2[j] = "";
                            }
                        }
                    }
                }
            }
            if (dividend.Length == 3)
            {
                str2 = $"{dividend[2]} x² + {dividend[1]} x + {dividend[0]}";
                strr2 = str2.Split(' ');
                for (int i = 1; i < dividend.Length; i++)
                {
                    if (dividend[i] == 1)
                    {
                        for (int j = 0; j < strr2.Length - 1; j++)
                        {
                            if (strr2[j].Contains($"{dividend[i]}") == true)
                            {
                                strr2[j] = "";
                            }
                        }
                    }
                }
            }
            if (dividend.Length == 4)
            {
                str2 = $"{dividend[3]} x³+ {dividend[2]} x² + {dividend[1]} x + {dividend[0]}";
                strr2 = str2.Split(' ');
                for (int i = 1; i < dividend.Length; i++)
                {
                    if (dividend[i] == 1)
                    {
                        for (int j = 0; j < strr2.Length - 1; j++)
                        {
                            if (strr2[j].Contains($"{dividend[i]}") == true)
                            {
                                strr2[j] = "";
                            }
                        }
                    }
                }
            }
            if (dividend.Length == 5)
            {
                str2 = $"{dividend[4]} x⁴+ {dividend[3]} x³+ {dividend[2]} x² + {dividend[1]} x + {dividend[0]}";
                strr2 = str2.Split(' ');
                for (int i = 1; i < dividend.Length; i++)
                {
                    if (dividend[i] == 1)
                    {
                        for (int j = 0; j < strr2.Length - 1; j++)
                        {
                            if (strr2[j].Contains($"{dividend[i]}") == true)
                            {
                                strr2[j] = "";
                            }
                        }
                    }
                }
            }
            if (dividend.Length == 6)
            {
                str2 = $"{dividend[5]} x⁵+ {dividend[4]} x⁴+ {dividend[3]} x³+ {dividend[2]} x² + {dividend[1]} x + {dividend[0]}";
                strr2 = str2.Split(' ');
                for (int i = 1; i < dividend.Length; i++)
                {
                    if (dividend[i] == 1)
                    {
                        for (int j = 0; j < strr2.Length - 1; j++)
                        {
                            if (strr2[j].Contains($"{dividend[i]}") == true)
                            {
                                strr2[j] = "";
                            }
                        }
                    }
                }
            }
            unite(strr2, out str2);
            string str3 = " ";
            if (divisor.Length == 2)
            {
                str3 = $"{divisor[1]} x + {divisor[0]}";
                strr3 = str3.Split(' ');
                for (int i = 1; i < divisor.Length; i++)
                {
                    if (divisor[i] == 1)
                    {
                        for (int j = 0; j < strr3.Length - 1; j++)
                        {
                            if (strr3[j].Contains($"{divisor[i]}") == true)
                            {
                                strr3[j] = "";
                            }
                        }
                    }
                }
            }
            if (divisor.Length == 3)
            {
                str3 = $"{divisor[2]} x² + {divisor[1]} x + {divisor[0]}";
                strr3 = str3.Split(' ');
                for (int i = 1; i < divisor.Length; i++)
                {
                    if (divisor[i] == 1)
                    {
                        for (int j = 0; j < strr3.Length - 1; j++)
                        {
                            if (strr3[j].Contains($"{divisor[i]}") == true)
                            {
                                strr3[j] = "";
                            }
                        }
                    }
                }
            }
            if (divisor.Length == 4)
            {
                str3 = $"{divisor[3]} x³ + {divisor[2]} x² + {divisor[1]} x + {divisor[0]}";
                strr3 = str3.Split(' ');
                for (int i = 1; i < divisor.Length; i++)
                {
                    if (divisor[i] == 1)
                    {
                        for (int j = 0; j < strr3.Length - 1; j++)
                        {
                            if (strr3[j].Contains($"{divisor[i]}") == true)
                            {
                                strr3[j] = "";
                            }
                        }
                    }
                }
            }
            if (divisor.Length == 5)
            {
                str3 = $"{divisor[4]} x⁴+ {divisor[3]} x³+ {divisor[2]} x² + {divisor[1]} x + {divisor[0]}";
                strr3 = str3.Split(' ');
                for (int i = 1; i < divisor.Length; i++)
                {
                    if (divisor[i] == 1)
                    {
                        for (int j = 0; j < strr3.Length - 1; j++)
                        {
                            if (strr3[j].Contains($"{divisor[i]}") == true)
                            {
                                strr3[j] = "";
                            }
                        }
                    }
                }
            }
            if (divisor.Length == 6)
            {
                str3 = $"{divisor[5]} x⁵ + {divisor[4]} x⁴ + {divisor[3]} x³+ {divisor[2]} x² + {divisor[1]} x + {divisor[0]}";
                strr3 = str3.Split(' ');
                for (int i = 1; i < divisor.Length; i++)
                {
                    if (divisor[i] == 1)
                    {
                        for (int j = 0; j < strr3.Length - 1; j++)
                        {
                            if (strr3[j].Contains($"{divisor[i]}") == true)
                            {
                                strr3[j] = "";
                            }
                        }
                    }
                }
            }
        }

}

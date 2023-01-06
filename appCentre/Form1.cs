using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCentre
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //binary to IP
        {
            string[] IPnumbers = new string[4];

            string input = BinaryTextBox.Text;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 8 == 0)
                    sb.Append(' ');
                sb.Append(input[i]);
            }
            string formatted = sb.ToString();
            string[] binaryNumbers = /*allBinaryNumbers*/formatted.Split(' ');

            // translate
            for(int m = 1; m < 5; m++)
            {
                int index = 0;
                string number = binaryNumbers[m].ToString();
                for (int o = 7; o >= 0; o--)
                {
                    if (number[o] == '1')
                    {
                        switch(o)
                        {
                            case 7:
                                index += 1;
                                break;
                            case 6:
                                index += 2;
                                break;
                            case 5:
                                index += 4;
                                break;
                            case 4:
                                index += 8;
                                break;
                            case 3:
                                index += 16;
                                break;
                            case 2:
                                index += 32;
                                break;
                            case 1:
                                index += 64;
                                break;
                            case 0:
                                index += 128;
                                break;
                        }
                    }
                }

                IPnumbers[m-1] = index.ToString();
            }
            IPTextBox.Text = IPnumbers[0] + "." + IPnumbers[1] + "." + IPnumbers[2] + "." + IPnumbers[3];
        }

        private void ToBinaryButton_Click(object sender, EventArgs e) // IP to binary
        {
            string[] IP = IPTextBox.Text.Split('.');
            string[] binary = new string[4];
            List<int> numberlist = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                int number = Convert.ToInt32(IP[i]);
                if (number - 128 >= 0)
                {
                    number -= 128;
                    numberlist.Add(1);
                }
                else if (number - 128 < 0)
                {
                    numberlist.Add(0);
                }

                if (number - 64 >= 0)
                {
                    number -= 64;
                    numberlist.Add(1);
                }
                else if (number - 64 < 0)
                {
                    numberlist.Add(0);
                }

                if (number - 32 >= 0)
                {
                    number -= 32;
                    numberlist.Add(1);
                }
                else if (number - 32 < 0)
                {
                    numberlist.Add(0);
                }

                if (number - 16 >= 0)
                {
                    number -= 16;
                    numberlist.Add(1);
                }
                else if (number - 16 < 0)
                {
                    numberlist.Add(0);
                }

                if (number - 8 >= 0)
                {
                    number -= 8;
                    numberlist.Add(1);
                }
                else if (number - 8 < 0)
                {
                    numberlist.Add(0);
                }

                if (number - 4 >= 0)
                {
                    number -= 4;
                    numberlist.Add(1);
                }
                else if (number - 4 < 0)
                {
                    numberlist.Add(0);
                }

                if (number - 2 >= 0)
                {
                    number -= 2;
                    numberlist.Add(1);
                }
                else if (number - 2 < 0)
                {
                    numberlist.Add(0);
                }

                if (number - 1 >= 0)
                {
                    number -= 1;
                    numberlist.Add(1);
                }
                else if (number - 1 < 0)
                {
                    numberlist.Add(0);
                }

                binary[i] = string.Join(null, numberlist);
                numberlist.Clear();
            }

            BinaryTextBox.Text = binary[0] + binary[1] + binary[2] + binary[3];
        }

        private void binaryToIPReturnButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Enabled = false;
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel2.Enabled = true;
            tableLayoutPanel2.Visible = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toBinaryIPconvert_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel2.Enabled = false;
            tableLayoutPanel1.Enabled = true;
            tableLayoutPanel1.Visible = true;
        }
    }
}

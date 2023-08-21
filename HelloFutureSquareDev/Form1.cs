using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HelloFutureSquareDev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dp_DOB.Value = DateTime.Today;
            dp_DOB.MaxDate = DateTime.Today;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        
        private void cb_male_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_male.Checked)
            {
                cb_female.Checked = false;
            }
        }

        private void cb_female_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_female.Checked)
            {
                cb_male.Checked = false;
            }
        }

        private void tb_phone_MouseClick(object sender, MouseEventArgs e)
        {
            if(tb_fullName.Text == "0123456789")
            {
                tb_fullName.Text = "";
            } 
        }

        private void button1_Click(object sender, EventArgs e) {
            if (cb_female.Checked || cb_male.Checked && cb_membership.Text != "<SELECT MEMBERSHIP>")
            {

                try
                {
                    // ------------------------view name on secound panel --------------------
                    string inputName = tb_fullName.Text;

                    string[] words = inputName.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                    List<string> wordList = new List<string>(words);
                    string f_name;
                    string _f_name = "";
                    string __f_name = "";

                    for (int i = 0; i < wordList.Count - 1; i++)
                    {
                        f_name = wordList[i].Substring(0, 1).ToUpper() + ". ";
                        _f_name = _f_name + f_name;
                    }

                    for (int i = 0; i < wordList.Count; i++)
                    {
                        __f_name = wordList[i];
                    }

                    tb_p2_fullname.Text = _f_name + __f_name;
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "name Convert Error");
                }



                try
                {
                    // ------------------------view address on secound panel --------------------
                    string inputAddress = tb_address.Text;

                    string[] address = inputAddress.Split(',', (char)StringSplitOptions.RemoveEmptyEntries);
                    List<string> addressList = new List<string>(address);
                    string f_address = "";
                    string _f_address = "";

                    for (int i = addressList.Count - 1; i >= 0; i--)
                    {
                        f_address = addressList[i] + ", ";

                        while (f_address.Contains("  "))
                        {
                            f_address = f_address.Replace("  ", " ");
                        }
                        while (f_address.Contains(" , "))
                        {
                            f_address = f_address.Replace(" , ", ", ");
                        }

                        _f_address = _f_address + f_address;
                    }

                    tb_p2_address.Text = _f_address;
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Address Convert Error");
                }

                try
                {
                    // ------------------------view phone on secound panel --------------------
                    string phone_number = "+94" + tb_phone.Text.Substring(1);
                    tb_p2_phone.Text = phone_number;

                    // ------------------------view gender on secound panel --------------------
                    if (cb_female.Checked)
                    {
                        tb_p2_gender.Text = "FEMALE";
                    }
                    else if (cb_male.Checked)
                    {
                        tb_p2_gender.Text = "MALE";
                    }

                    // ------------------------view age on secound panel --------------------

                    int age = DateTime.Today.Year - dp_DOB.Value.Year;

                    tb_p2_age.Text = age.ToString() + "Years";


                    // ------------------------view membership on secound panel --------------------
                    if (cb_membership.Text != "<SELECT MEMBERSHIP>")
                    {
                        tb_p2_membership.Text = cb_membership.Text;
                    }
                    else
                    {
                        MessageBox.Show("Select Your Membership");
                    }

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }


                panel2.Visible = true;
                panel1.Visible = false;
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cb_confirm.Checked)
            {
                panel2.Visible = false;
                panel3.Visible = true;

                try
                {

                    string contactNumberType = "";
                    if (tb_p2_phone.Text.StartsWith("+947"))
                    {
                        contactNumberType = "Mobile Number";
                    }
                    else if (tb_p2_phone.Text.StartsWith("+9411"))
                    {
                        contactNumberType = "Landline";
                    }

                    int taxValue = 0;
                    int taxAmount = 0;
                    string content = $"Full Name\t\t\t: {tb_p2_fullname.Text} \nName with Initials\t\t: {tb_fullName.Text} \nAddress\t\t\t: {tb_address.Text}\nReversed Address\t\t: {tb_p2_address.Text}\nLocal Contact Number\t: {tb_phone.Text}\nInternatioanl number\t\t: {tb_p2_phone.Text} \ncontact number type\t\t: {contactNumberType} \nGender\t\t\t\t: {tb_p2_gender.Text} \nMembership type\t\t: {tb_p2_membership.Text} \nTax Value\t\t: {taxValue} \nTax Amount\t\t: {taxAmount} \n";

                    try
                    {
                        File.WriteAllText(tb_fullName.Text + ".txt", content);


                    }catch(Exception E)
                    {
                        MessageBox.Show(E.Message, "SAVING PROBLEM");
                    }


                    richTextBox1.Text = content;
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb_address.Text = "";
            tb_fullName.Text = "";
            tb_phone.Text = "";
            cb_female.Checked = false;
            cb_male.Checked = false;
            dp_DOB.Value = DateTime.Today;
            cb_membership.Text = "<SELECT MEMBERSHIP>";
            cb_confirm.Checked = false;

            panel3.Visible = false;
            panel1.Visible = true;

        }
    }
}

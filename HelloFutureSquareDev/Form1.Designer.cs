
namespace HelloFutureSquareDev
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_membership = new System.Windows.Forms.ComboBox();
            this.dp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cb_female = new System.Windows.Forms.CheckBox();
            this.cb_male = new System.Windows.Forms.CheckBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_fullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_confirm = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_p2_membership = new System.Windows.Forms.TextBox();
            this.tb_p2_age = new System.Windows.Forms.TextBox();
            this.tb_p2_gender = new System.Windows.Forms.TextBox();
            this.tb_p2_address = new System.Windows.Forms.TextBox();
            this.tb_p2_phone = new System.Windows.Forms.TextBox();
            this.tb_p2_fullname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cb_membership);
            this.panel1.Controls.Add(this.dp_DOB);
            this.panel1.Controls.Add(this.cb_female);
            this.panel1.Controls.Add(this.cb_male);
            this.panel1.Controls.Add(this.tb_address);
            this.panel1.Controls.Add(this.tb_phone);
            this.panel1.Controls.Add(this.tb_fullName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(69, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 346);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "NEXT >";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_membership
            // 
            this.cb_membership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_membership.FormattingEnabled = true;
            this.cb_membership.Items.AddRange(new object[] {
            "VIP",
            "Gold",
            "Genarel"});
            this.cb_membership.Location = new System.Drawing.Point(200, 255);
            this.cb_membership.Name = "cb_membership";
            this.cb_membership.Size = new System.Drawing.Size(192, 24);
            this.cb_membership.TabIndex = 1;
            this.cb_membership.Text = "<SELECT MEMBERSHIP>";
            // 
            // dp_DOB
            // 
            this.dp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_DOB.Location = new System.Drawing.Point(200, 211);
            this.dp_DOB.Name = "dp_DOB";
            this.dp_DOB.Size = new System.Drawing.Size(303, 26);
            this.dp_DOB.TabIndex = 9;
            // 
            // cb_female
            // 
            this.cb_female.AutoSize = true;
            this.cb_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_female.Location = new System.Drawing.Point(200, 172);
            this.cb_female.Name = "cb_female";
            this.cb_female.Size = new System.Drawing.Size(76, 24);
            this.cb_female.TabIndex = 8;
            this.cb_female.Text = "female";
            this.cb_female.UseVisualStyleBackColor = true;
            this.cb_female.CheckedChanged += new System.EventHandler(this.cb_female_CheckedChanged);
            // 
            // cb_male
            // 
            this.cb_male.AutoSize = true;
            this.cb_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_male.Location = new System.Drawing.Point(200, 147);
            this.cb_male.Name = "cb_male";
            this.cb_male.Size = new System.Drawing.Size(62, 24);
            this.cb_male.TabIndex = 7;
            this.cb_male.Text = "male";
            this.cb_male.UseVisualStyleBackColor = true;
            this.cb_male.CheckedChanged += new System.EventHandler(this.cb_male_CheckedChanged);
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(201, 73);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(302, 26);
            this.tb_address.TabIndex = 6;
            this.tb_address.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_phone_MouseClick);
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(201, 109);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(302, 26);
            this.tb_phone.TabIndex = 6;
            this.tb_phone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_phone_MouseClick);
            // 
            // tb_fullName
            // 
            this.tb_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fullName.Location = new System.Drawing.Point(201, 34);
            this.tb_fullName.Name = "tb_fullName";
            this.tb_fullName.Size = new System.Drawing.Size(302, 26);
            this.tb_fullName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "MEMBERSHIP :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "BIRTH DAY :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "ADDRESS : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "GENDER :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "PHONE NUMBER :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "FULL NAME :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cb_confirm);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tb_p2_membership);
            this.panel2.Controls.Add(this.tb_p2_age);
            this.panel2.Controls.Add(this.tb_p2_gender);
            this.panel2.Controls.Add(this.tb_p2_address);
            this.panel2.Controls.Add(this.tb_p2_phone);
            this.panel2.Controls.Add(this.tb_p2_fullname);
            this.panel2.Location = new System.Drawing.Point(61, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 346);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(72, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 345);
            this.panel3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "< BACK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Silver;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(22, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(452, 231);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "< BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "NEXT >";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_confirm
            // 
            this.cb_confirm.AutoSize = true;
            this.cb_confirm.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_confirm.Location = new System.Drawing.Point(299, 307);
            this.cb_confirm.Name = "cb_confirm";
            this.cb_confirm.Size = new System.Drawing.Size(75, 17);
            this.cb_confirm.TabIndex = 10;
            this.cb_confirm.Text = "CONFIRM";
            this.cb_confirm.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "MEMBERSHIP :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "AGE :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "GENDER :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(81, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "ADDRESS :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "PHONE :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "NAME :";
            // 
            // tb_p2_membership
            // 
            this.tb_p2_membership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_p2_membership.Location = new System.Drawing.Point(186, 207);
            this.tb_p2_membership.Name = "tb_p2_membership";
            this.tb_p2_membership.ReadOnly = true;
            this.tb_p2_membership.Size = new System.Drawing.Size(269, 23);
            this.tb_p2_membership.TabIndex = 4;
            // 
            // tb_p2_age
            // 
            this.tb_p2_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_p2_age.Location = new System.Drawing.Point(186, 172);
            this.tb_p2_age.Name = "tb_p2_age";
            this.tb_p2_age.ReadOnly = true;
            this.tb_p2_age.Size = new System.Drawing.Size(269, 23);
            this.tb_p2_age.TabIndex = 3;
            // 
            // tb_p2_gender
            // 
            this.tb_p2_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_p2_gender.Location = new System.Drawing.Point(186, 137);
            this.tb_p2_gender.Name = "tb_p2_gender";
            this.tb_p2_gender.ReadOnly = true;
            this.tb_p2_gender.Size = new System.Drawing.Size(269, 23);
            this.tb_p2_gender.TabIndex = 2;
            // 
            // tb_p2_address
            // 
            this.tb_p2_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_p2_address.Location = new System.Drawing.Point(186, 73);
            this.tb_p2_address.Name = "tb_p2_address";
            this.tb_p2_address.ReadOnly = true;
            this.tb_p2_address.Size = new System.Drawing.Size(269, 23);
            this.tb_p2_address.TabIndex = 1;
            // 
            // tb_p2_phone
            // 
            this.tb_p2_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_p2_phone.Location = new System.Drawing.Point(186, 102);
            this.tb_p2_phone.Name = "tb_p2_phone";
            this.tb_p2_phone.ReadOnly = true;
            this.tb_p2_phone.Size = new System.Drawing.Size(269, 23);
            this.tb_p2_phone.TabIndex = 1;
            // 
            // tb_p2_fullname
            // 
            this.tb_p2_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_p2_fullname.Location = new System.Drawing.Point(186, 41);
            this.tb_p2_fullname.Name = "tb_p2_fullname";
            this.tb_p2_fullname.ReadOnly = true;
            this.tb_p2_fullname.Size = new System.Drawing.Size(269, 23);
            this.tb_p2_fullname.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(135, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(364, 29);
            this.label13.TabIndex = 3;
            this.label13.Text = "Carrom Users Information Server";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(337, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 28);
            this.button5.TabIndex = 2;
            this.button5.Text = "finish / reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 429);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Left-handed carrom association for Application | Shehan Rajapaksha | Assignment |" +
    " +94774690541";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dp_DOB;
        private System.Windows.Forms.CheckBox cb_female;
        private System.Windows.Forms.CheckBox cb_male;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_fullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_membership;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cb_confirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_p2_membership;
        private System.Windows.Forms.TextBox tb_p2_age;
        private System.Windows.Forms.TextBox tb_p2_gender;
        private System.Windows.Forms.TextBox tb_p2_phone;
        private System.Windows.Forms.TextBox tb_p2_fullname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_p2_address;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
    }
}


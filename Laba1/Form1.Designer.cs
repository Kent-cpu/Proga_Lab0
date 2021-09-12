
namespace Laba1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aField = new System.Windows.Forms.TextBox();
            this.bField = new System.Windows.Forms.TextBox();
            this.hField = new System.Windows.Forms.TextBox();
            this.mField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputAnswer = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errorField = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.findInfromation = new System.Windows.Forms.Button();
            this.generationDataBtn = new System.Windows.Forms.Button();
            this.informationUsers = new System.Windows.Forms.RichTextBox();
            this.errorTask2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // aField
            // 
            this.aField.Location = new System.Drawing.Point(20, 57);
            this.aField.Name = "aField";
            this.aField.Size = new System.Drawing.Size(167, 27);
            this.aField.TabIndex = 0;
            this.aField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bField
            // 
            this.bField.Location = new System.Drawing.Point(207, 57);
            this.bField.Name = "bField";
            this.bField.Size = new System.Drawing.Size(167, 27);
            this.bField.TabIndex = 1;
            this.bField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // hField
            // 
            this.hField.Location = new System.Drawing.Point(395, 54);
            this.hField.Name = "hField";
            this.hField.Size = new System.Drawing.Size(167, 27);
            this.hField.TabIndex = 2;
            // 
            // mField
            // 
            this.mField.Location = new System.Drawing.Point(585, 54);
            this.mField.Name = "mField";
            this.mField.Size = new System.Drawing.Size(167, 27);
            this.mField.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "m";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputAnswer
            // 
            this.outputAnswer.AutoSize = true;
            this.outputAnswer.Location = new System.Drawing.Point(356, 262);
            this.outputAnswer.Name = "outputAnswer";
            this.outputAnswer.Size = new System.Drawing.Size(18, 20);
            this.outputAnswer.TabIndex = 9;
            this.outputAnswer.Text = "g";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 450);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorField);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.outputAnswer);
            this.tabPage1.Controls.Add(this.aField);
            this.tabPage1.Controls.Add(this.bField);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.hField);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.mField);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errorField
            // 
            this.errorField.AutoSize = true;
            this.errorField.ForeColor = System.Drawing.Color.Red;
            this.errorField.Location = new System.Drawing.Point(356, 183);
            this.errorField.Name = "errorField";
            this.errorField.Size = new System.Drawing.Size(41, 20);
            this.errorField.TabIndex = 10;
            this.errorField.Text = "error";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.errorTask2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.findInfromation);
            this.tabPage2.Controls.Add(this.generationDataBtn);
            this.tabPage2.Controls.Add(this.informationUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Узнать информацию об абонентах";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Данные абонентов";
            // 
            // findInfromation
            // 
            this.findInfromation.Location = new System.Drawing.Point(310, 22);
            this.findInfromation.Name = "findInfromation";
            this.findInfromation.Size = new System.Drawing.Size(277, 47);
            this.findInfromation.TabIndex = 11;
            this.findInfromation.Text = "Узнать информацию об абонентах";
            this.findInfromation.UseVisualStyleBackColor = true;
            this.findInfromation.Click += new System.EventHandler(this.findInfromation_Click);
            // 
            // generationDataBtn
            // 
            this.generationDataBtn.Location = new System.Drawing.Point(27, 22);
            this.generationDataBtn.Name = "generationDataBtn";
            this.generationDataBtn.Size = new System.Drawing.Size(277, 47);
            this.generationDataBtn.TabIndex = 1;
            this.generationDataBtn.Text = "Генерировать";
            this.generationDataBtn.UseVisualStyleBackColor = true;
            this.generationDataBtn.Click += new System.EventHandler(this.generationDataBtn_Click);
            // 
            // informationUsers
            // 
            this.informationUsers.Location = new System.Drawing.Point(27, 141);
            this.informationUsers.Name = "informationUsers";
            this.informationUsers.Size = new System.Drawing.Size(740, 247);
            this.informationUsers.TabIndex = 0;
            this.informationUsers.Text = "";
            // 
            // errorTask2
            // 
            this.errorTask2.AutoSize = true;
            this.errorTask2.Location = new System.Drawing.Point(293, 89);
            this.errorTask2.Name = "errorTask2";
            this.errorTask2.Size = new System.Drawing.Size(16, 20);
            this.errorTask2.TabIndex = 13;
            this.errorTask2.Text = "с";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "h";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox aField;
        private System.Windows.Forms.TextBox bField;
        private System.Windows.Forms.TextBox hField;
        private System.Windows.Forms.TextBox mField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outputAnswer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label errorField;
        private System.Windows.Forms.Button generationDataBtn;
        private System.Windows.Forms.RichTextBox informationUsers;
        private System.Windows.Forms.Button findInfromation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorTask2;
    }
}


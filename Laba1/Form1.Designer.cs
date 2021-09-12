
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
            this.Task1 = new System.Windows.Forms.TabPage();
            this.errorField = new System.Windows.Forms.Label();
            this.Task2 = new System.Windows.Forms.TabPage();
            this.errorTask2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.findInfromation = new System.Windows.Forms.Button();
            this.generationDataBtn = new System.Windows.Forms.Button();
            this.informationUsers = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.Task1.SuspendLayout();
            this.Task2.SuspendLayout();
            this.SuspendLayout();
            // 
            // aField
            // 
            this.aField.Location = new System.Drawing.Point(20, 57);
            this.aField.Name = "aField";
            this.aField.Size = new System.Drawing.Size(167, 27);
            this.aField.TabIndex = 0;
            // 
            // bField
            // 
            this.bField.Location = new System.Drawing.Point(207, 57);
            this.bField.Name = "bField";
            this.bField.Size = new System.Drawing.Size(167, 27);
            this.bField.TabIndex = 1;
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
            this.outputAnswer.Size = new System.Drawing.Size(0, 20);
            this.outputAnswer.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Task1);
            this.tabControl1.Controls.Add(this.Task2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 450);
            this.tabControl1.TabIndex = 10;
            // 
            // Task1
            // 
            this.Task1.Controls.Add(this.errorField);
            this.Task1.Controls.Add(this.button1);
            this.Task1.Controls.Add(this.outputAnswer);
            this.Task1.Controls.Add(this.aField);
            this.Task1.Controls.Add(this.bField);
            this.Task1.Controls.Add(this.label4);
            this.Task1.Controls.Add(this.hField);
            this.Task1.Controls.Add(this.label3);
            this.Task1.Controls.Add(this.mField);
            this.Task1.Controls.Add(this.label2);
            this.Task1.Controls.Add(this.label1);
            this.Task1.Location = new System.Drawing.Point(4, 29);
            this.Task1.Name = "Task1";
            this.Task1.Padding = new System.Windows.Forms.Padding(3);
            this.Task1.Size = new System.Drawing.Size(790, 417);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Task1";
            this.Task1.UseVisualStyleBackColor = true;
            // 
            // errorField
            // 
            this.errorField.AutoSize = true;
            this.errorField.ForeColor = System.Drawing.Color.Red;
            this.errorField.Location = new System.Drawing.Point(356, 183);
            this.errorField.Name = "errorField";
            this.errorField.Size = new System.Drawing.Size(0, 20);
            this.errorField.TabIndex = 10;
            // 
            // Task2
            // 
            this.Task2.Controls.Add(this.errorTask2);
            this.Task2.Controls.Add(this.label5);
            this.Task2.Controls.Add(this.findInfromation);
            this.Task2.Controls.Add(this.generationDataBtn);
            this.Task2.Controls.Add(this.informationUsers);
            this.Task2.Location = new System.Drawing.Point(4, 29);
            this.Task2.Name = "Task2";
            this.Task2.Padding = new System.Windows.Forms.Padding(3);
            this.Task2.Size = new System.Drawing.Size(790, 417);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Task2";
            this.Task2.UseVisualStyleBackColor = true;
            // 
            // errorTask2
            // 
            this.errorTask2.AutoSize = true;
            this.errorTask2.ForeColor = System.Drawing.Color.Red;
            this.errorTask2.Location = new System.Drawing.Point(353, 85);
            this.errorTask2.Name = "errorTask2";
            this.errorTask2.Size = new System.Drawing.Size(0, 20);
            this.errorTask2.TabIndex = 13;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "h";
            this.tabControl1.ResumeLayout(false);
            this.Task1.ResumeLayout(false);
            this.Task1.PerformLayout();
            this.Task2.ResumeLayout(false);
            this.Task2.PerformLayout();
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
        private System.Windows.Forms.TabPage Task1;
        private System.Windows.Forms.TabPage Task2;
        private System.Windows.Forms.Label errorField;
        private System.Windows.Forms.Button generationDataBtn;
        private System.Windows.Forms.RichTextBox informationUsers;
        private System.Windows.Forms.Button findInfromation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorTask2;
    }
}


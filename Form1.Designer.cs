
namespace NewVaccination
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
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.comboBoxProvince = new System.Windows.Forms.ComboBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labProv = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labFName = new System.Windows.Forms.Label();
            this.labSurname = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(327, 356);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(253, 24);
            this.cbGender.TabIndex = 25;
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(379, 495);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(132, 29);
            this.buttonReg.TabIndex = 24;
            this.buttonReg.Text = "Register";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Items.AddRange(new object[] {
            "Gauteng"});
            this.comboBoxProvince.Location = new System.Drawing.Point(325, 427);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(255, 28);
            this.comboBoxProvince.TabIndex = 23;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(325, 279);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(255, 26);
            this.textBoxFirstName.TabIndex = 22;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(325, 208);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(255, 26);
            this.textBoxSurname.TabIndex = 21;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(325, 135);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(255, 26);
            this.textBoxID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Vaccination Form";
            // 
            // labProv
            // 
            this.labProv.AutoSize = true;
            this.labProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProv.Location = new System.Drawing.Point(69, 430);
            this.labProv.Name = "labProv";
            this.labProv.Size = new System.Drawing.Size(74, 20);
            this.labProv.TabIndex = 18;
            this.labProv.Text = "Province";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGender.Location = new System.Drawing.Point(69, 356);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(69, 20);
            this.labGender.TabIndex = 17;
            this.labGender.Text = "Gender:";
            // 
            // labFName
            // 
            this.labFName.AutoSize = true;
            this.labFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFName.Location = new System.Drawing.Point(69, 282);
            this.labFName.Name = "labFName";
            this.labFName.Size = new System.Drawing.Size(97, 20);
            this.labFName.TabIndex = 16;
            this.labFName.Text = "First Name:";
            // 
            // labSurname
            // 
            this.labSurname.AutoSize = true;
            this.labSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSurname.Location = new System.Drawing.Point(69, 211);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(81, 20);
            this.labSurname.TabIndex = 15;
            this.labSurname.Text = "Surname:";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(69, 138);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(31, 20);
            this.labID.TabIndex = 14;
            this.labID.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.comboBoxProvince);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labProv);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labFName);
            this.Controls.Add(this.labSurname);
            this.Controls.Add(this.labID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.ComboBox comboBoxProvince;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labProv;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labFName;
        private System.Windows.Forms.Label labSurname;
        private System.Windows.Forms.Label labID;
    }
}


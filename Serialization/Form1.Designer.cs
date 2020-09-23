namespace Serialization
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btSerialize = new System.Windows.Forms.Button();
            this.btDeserialize = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnJDeserialize = new System.Windows.Forms.Button();
            this.btnJSerialize = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.XmlDeserialize = new System.Windows.Forms.Button();
            this.XmlSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salary";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(152, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.Location = new System.Drawing.Point(152, 98);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(202, 26);
            this.txtPhoneNo.TabIndex = 6;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(152, 203);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(202, 26);
            this.txtDepartment.TabIndex = 8;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(152, 259);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(202, 26);
            this.txtSalary.TabIndex = 9;
            // 
            // btSerialize
            // 
            this.btSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSerialize.Location = new System.Drawing.Point(81, 301);
            this.btSerialize.Name = "btSerialize";
            this.btSerialize.Size = new System.Drawing.Size(128, 29);
            this.btSerialize.TabIndex = 10;
            this.btSerialize.Text = "Serialize";
            this.btSerialize.UseVisualStyleBackColor = true;
            this.btSerialize.Click += new System.EventHandler(this.btSerialize_Click);
            // 
            // btDeserialize
            // 
            this.btDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeserialize.Location = new System.Drawing.Point(226, 301);
            this.btDeserialize.Name = "btDeserialize";
            this.btDeserialize.Size = new System.Drawing.Size(128, 29);
            this.btDeserialize.TabIndex = 11;
            this.btDeserialize.Text = "Deserialize";
            this.btDeserialize.UseVisualStyleBackColor = true;
            this.btDeserialize.Click += new System.EventHandler(this.btDeserialize_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(37, 417);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Location = new System.Drawing.Point(154, 152);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(200, 20);
            this.dtpDoB.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Binary:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "JSON:";
            // 
            // btnJDeserialize
            // 
            this.btnJDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJDeserialize.Location = new System.Drawing.Point(226, 371);
            this.btnJDeserialize.Name = "btnJDeserialize";
            this.btnJDeserialize.Size = new System.Drawing.Size(128, 29);
            this.btnJDeserialize.TabIndex = 17;
            this.btnJDeserialize.Text = "Deserialize";
            this.btnJDeserialize.UseVisualStyleBackColor = true;
            this.btnJDeserialize.Click += new System.EventHandler(this.btnJDeserialize_Click);
            // 
            // btnJSerialize
            // 
            this.btnJSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSerialize.Location = new System.Drawing.Point(81, 371);
            this.btnJSerialize.Name = "btnJSerialize";
            this.btnJSerialize.Size = new System.Drawing.Size(128, 29);
            this.btnJSerialize.TabIndex = 16;
            this.btnJSerialize.Text = "Serialize";
            this.btnJSerialize.UseVisualStyleBackColor = true;
            this.btnJSerialize.Click += new System.EventHandler(this.btnJSerialize_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "XML:";
            // 
            // XmlDeserialize
            // 
            this.XmlDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XmlDeserialize.Location = new System.Drawing.Point(226, 336);
            this.XmlDeserialize.Name = "XmlDeserialize";
            this.XmlDeserialize.Size = new System.Drawing.Size(128, 29);
            this.XmlDeserialize.TabIndex = 19;
            this.XmlDeserialize.Text = "Deserialize";
            this.XmlDeserialize.UseVisualStyleBackColor = true;
            this.XmlDeserialize.Click += new System.EventHandler(this.XmlDeserialize_Click);
            // 
            // XmlSerialize
            // 
            this.XmlSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XmlSerialize.Location = new System.Drawing.Point(81, 336);
            this.XmlSerialize.Name = "XmlSerialize";
            this.XmlSerialize.Size = new System.Drawing.Size(128, 29);
            this.XmlSerialize.TabIndex = 18;
            this.XmlSerialize.Text = "Serialize";
            this.XmlSerialize.UseVisualStyleBackColor = true;
            this.XmlSerialize.Click += new System.EventHandler(this.XmlSerialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 453);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.XmlDeserialize);
            this.Controls.Add(this.XmlSerialize);
            this.Controls.Add(this.btnJDeserialize);
            this.Controls.Add(this.btnJSerialize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDoB);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btDeserialize);
            this.Controls.Add(this.btSerialize);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btSerialize;
        private System.Windows.Forms.Button btDeserialize;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnJDeserialize;
        private System.Windows.Forms.Button btnJSerialize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button XmlDeserialize;
        private System.Windows.Forms.Button XmlSerialize;
    }
}


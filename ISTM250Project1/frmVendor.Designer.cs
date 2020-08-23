namespace ISTM250Project1
{
    partial class frmVendor
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVName = new System.Windows.Forms.TextBox();
            this.txtVAddress = new System.Windows.Forms.TextBox();
            this.txtVCity = new System.Windows.Forms.TextBox();
            this.txtVZip = new System.Windows.Forms.TextBox();
            this.txtVComments = new System.Windows.Forms.TextBox();
            this.txtVRep = new System.Windows.Forms.TextBox();
            this.txtVSales = new System.Windows.Forms.TextBox();
            this.txtVPhone = new System.Windows.Forms.TextBox();
            this.cboDiscount = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(300, 486);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = " Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(133, 486);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(113, 23);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(133, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Current Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(300, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Default Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vendor Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Street Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zip Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sales Year to Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sales Rep Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Comments:";
            // 
            // txtVName
            // 
            this.txtVName.Location = new System.Drawing.Point(263, 35);
            this.txtVName.Name = "txtVName";
            this.txtVName.Size = new System.Drawing.Size(196, 20);
            this.txtVName.TabIndex = 0;
            this.txtVName.TextChanged += new System.EventHandler(this.TxtVState_TextChanged);
            // 
            // txtVAddress
            // 
            this.txtVAddress.Location = new System.Drawing.Point(263, 81);
            this.txtVAddress.Name = "txtVAddress";
            this.txtVAddress.Size = new System.Drawing.Size(196, 20);
            this.txtVAddress.TabIndex = 1;
            this.txtVAddress.TextChanged += new System.EventHandler(this.TxtVState_TextChanged);
            // 
            // txtVCity
            // 
            this.txtVCity.Location = new System.Drawing.Point(263, 124);
            this.txtVCity.Name = "txtVCity";
            this.txtVCity.Size = new System.Drawing.Size(196, 20);
            this.txtVCity.TabIndex = 2;
            this.txtVCity.TextChanged += new System.EventHandler(this.TxtVState_TextChanged);
            // 
            // txtVZip
            // 
            this.txtVZip.Location = new System.Drawing.Point(263, 210);
            this.txtVZip.Name = "txtVZip";
            this.txtVZip.Size = new System.Drawing.Size(196, 20);
            this.txtVZip.TabIndex = 4;
            this.txtVZip.TextChanged += new System.EventHandler(this.TxtVState_TextChanged);
            // 
            // txtVComments
            // 
            this.txtVComments.Location = new System.Drawing.Point(263, 377);
            this.txtVComments.Name = "txtVComments";
            this.txtVComments.Size = new System.Drawing.Size(196, 20);
            this.txtVComments.TabIndex = 8;
            this.txtVComments.TextChanged += new System.EventHandler(this.TxtVState_TextChanged);
            // 
            // txtVRep
            // 
            this.txtVRep.Location = new System.Drawing.Point(263, 332);
            this.txtVRep.Name = "txtVRep";
            this.txtVRep.Size = new System.Drawing.Size(196, 20);
            this.txtVRep.TabIndex = 7;
            this.txtVRep.TextChanged += new System.EventHandler(this.TxtVState_TextChanged);
            // 
            // txtVSales
            // 
            this.txtVSales.Location = new System.Drawing.Point(263, 291);
            this.txtVSales.Name = "txtVSales";
            this.txtVSales.Size = new System.Drawing.Size(196, 20);
            this.txtVSales.TabIndex = 6;
            this.txtVSales.TextChanged += new System.EventHandler(this.TxtVState_TextChanged);
            // 
            // txtVPhone
            // 
            this.txtVPhone.Location = new System.Drawing.Point(263, 251);
            this.txtVPhone.Name = "txtVPhone";
            this.txtVPhone.Size = new System.Drawing.Size(196, 20);
            this.txtVPhone.TabIndex = 5;
            this.txtVPhone.TextChanged += new System.EventHandler(this.TxtVState_TextChanged);
            // 
            // cboDiscount
            // 
            this.cboDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiscount.FormattingEnabled = true;
            this.cboDiscount.Location = new System.Drawing.Point(263, 420);
            this.cboDiscount.Name = "cboDiscount";
            this.cboDiscount.Size = new System.Drawing.Size(196, 21);
            this.cboDiscount.TabIndex = 9;
            this.cboDiscount.SelectedIndexChanged += new System.EventHandler(this.CboDiscount_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "State:";
            // 
            // txtVState
            // 
            this.txtVState.Location = new System.Drawing.Point(263, 169);
            this.txtVState.Name = "txtVState";
            this.txtVState.Size = new System.Drawing.Size(196, 20);
            this.txtVState.TabIndex = 3;
            this.txtVState.TextChanged += new System.EventHandler(this.TxtVState_TextChanged);
            // 
            // frmVendor
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(538, 586);
            this.Controls.Add(this.txtVState);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboDiscount);
            this.Controls.Add(this.txtVPhone);
            this.Controls.Add(this.txtVSales);
            this.Controls.Add(this.txtVRep);
            this.Controls.Add(this.txtVComments);
            this.Controls.Add(this.txtVZip);
            this.Controls.Add(this.txtVCity);
            this.Controls.Add(this.txtVAddress);
            this.Controls.Add(this.txtVName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Name = "frmVendor";
            this.Text = "Vendor";
            this.Load += new System.EventHandler(this.FrmVendor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVName;
        private System.Windows.Forms.TextBox txtVAddress;
        private System.Windows.Forms.TextBox txtVCity;
        private System.Windows.Forms.TextBox txtVZip;
        private System.Windows.Forms.TextBox txtVComments;
        private System.Windows.Forms.TextBox txtVRep;
        private System.Windows.Forms.TextBox txtVSales;
        private System.Windows.Forms.TextBox txtVPhone;
        private System.Windows.Forms.ComboBox cboDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVState;
    }
}
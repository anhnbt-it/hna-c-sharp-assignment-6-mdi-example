
namespace WindowsFormsMDIExample
{
    partial class FrmNewAuthor
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
            this.lblAuthorId = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.cboCities = new System.Windows.Forms.ComboBox();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.chkContract = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAuthorId
            // 
            this.lblAuthorId.AutoSize = true;
            this.lblAuthorId.Location = new System.Drawing.Point(12, 28);
            this.lblAuthorId.Name = "lblAuthorId";
            this.lblAuthorId.Size = new System.Drawing.Size(58, 15);
            this.lblAuthorId.TabIndex = 0;
            this.lblAuthorId.Text = "Author ID";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(216, 25);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 15);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(216, 60);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(33, 15);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 98);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 15);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone No.";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(216, 95);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(24, 15);
            this.lblZip.TabIndex = 5;
            this.lblZip.Text = "Zip";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(13, 145);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(216, 126);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(53, 15);
            this.lblContract.TabIndex = 7;
            this.lblContract.Text = "Contract";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(249, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(330, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(80, 25);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(130, 23);
            this.txtAuthorId.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(80, 60);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(62, 23);
            this.txtFirstName.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(148, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(62, 23);
            this.txtLastName.TabIndex = 12;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(80, 95);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(130, 23);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(80, 130);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(130, 67);
            this.rtbAddress.TabIndex = 14;
            this.rtbAddress.Text = "";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(275, 92);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(130, 23);
            this.txtZip.TabIndex = 15;
            // 
            // cboCities
            // 
            this.cboCities.FormattingEnabled = true;
            this.cboCities.Location = new System.Drawing.Point(275, 22);
            this.cboCities.Name = "cboCities";
            this.cboCities.Size = new System.Drawing.Size(130, 23);
            this.cboCities.TabIndex = 16;
            // 
            // cboStates
            // 
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(275, 57);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(130, 23);
            this.cboStates.TabIndex = 17;
            // 
            // chkContract
            // 
            this.chkContract.AutoSize = true;
            this.chkContract.Location = new System.Drawing.Point(275, 126);
            this.chkContract.Name = "chkContract";
            this.chkContract.Size = new System.Drawing.Size(15, 14);
            this.chkContract.TabIndex = 18;
            this.chkContract.UseVisualStyleBackColor = true;
            // 
            // FrmNewAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 238);
            this.Controls.Add(this.chkContract);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(this.cboCities);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtAuthorId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAuthorId);
            this.Name = "FrmNewAuthor";
            this.Text = "Add New Author";
            this.Load += new System.EventHandler(this.FrmNewAuthor_Load);
            this.Shown += new System.EventHandler(this.FrmNewAuthor_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthorId;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.ComboBox cboCities;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.CheckBox chkContract;
    }
}
namespace House_selling_desktop_application
{
    partial class HouseUpdateForm
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
            this.backB = new System.Windows.Forms.Button();
            this.statusRequiredL = new System.Windows.Forms.Label();
            this.nameRequiredL = new System.Windows.Forms.Label();
            this.buildingEndDateL = new System.Windows.Forms.Label();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.buildingEndDateDP = new System.Windows.Forms.DateTimePicker();
            this.statusL = new System.Windows.Forms.Label();
            this.priceNB = new System.Windows.Forms.NumericUpDown();
            this.priceL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameL = new System.Windows.Forms.Label();
            this.updateHouseB = new System.Windows.Forms.Button();
            this.IdL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceNB)).BeginInit();
            this.SuspendLayout();
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(208, 191);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 23;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // statusRequiredL
            // 
            this.statusRequiredL.AutoSize = true;
            this.statusRequiredL.ForeColor = System.Drawing.Color.DarkRed;
            this.statusRequiredL.Location = new System.Drawing.Point(70, 119);
            this.statusRequiredL.Name = "statusRequiredL";
            this.statusRequiredL.Size = new System.Drawing.Size(95, 13);
            this.statusRequiredL.TabIndex = 22;
            this.statusRequiredL.Text = "* Status is required";
            this.statusRequiredL.Visible = false;
            // 
            // nameRequiredL
            // 
            this.nameRequiredL.AutoSize = true;
            this.nameRequiredL.ForeColor = System.Drawing.Color.DarkRed;
            this.nameRequiredL.Location = new System.Drawing.Point(70, 53);
            this.nameRequiredL.Name = "nameRequiredL";
            this.nameRequiredL.Size = new System.Drawing.Size(93, 13);
            this.nameRequiredL.TabIndex = 21;
            this.nameRequiredL.Text = "* Name is required";
            this.nameRequiredL.Visible = false;
            // 
            // buildingEndDateL
            // 
            this.buildingEndDateL.AutoSize = true;
            this.buildingEndDateL.Location = new System.Drawing.Point(65, 144);
            this.buildingEndDateL.Name = "buildingEndDateL";
            this.buildingEndDateL.Size = new System.Drawing.Size(98, 13);
            this.buildingEndDateL.TabIndex = 20;
            this.buildingEndDateL.Text = "Building End Date :";
            // 
            // statusCB
            // 
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Location = new System.Drawing.Point(153, 95);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(121, 21);
            this.statusCB.TabIndex = 19;
            this.statusCB.Validating += new System.ComponentModel.CancelEventHandler(this.statusCB_Validating);
            // 
            // buildingEndDateDP
            // 
            this.buildingEndDateDP.Location = new System.Drawing.Point(169, 138);
            this.buildingEndDateDP.Name = "buildingEndDateDP";
            this.buildingEndDateDP.Size = new System.Drawing.Size(200, 20);
            this.buildingEndDateDP.TabIndex = 18;
            // 
            // statusL
            // 
            this.statusL.AutoSize = true;
            this.statusL.Location = new System.Drawing.Point(67, 98);
            this.statusL.Name = "statusL";
            this.statusL.Size = new System.Drawing.Size(80, 13);
            this.statusL.TabIndex = 17;
            this.statusL.Text = "House Status : ";
            // 
            // priceNB
            // 
            this.priceNB.Location = new System.Drawing.Point(112, 69);
            this.priceNB.Name = "priceNB";
            this.priceNB.Size = new System.Drawing.Size(120, 20);
            this.priceNB.TabIndex = 16;
            // 
            // priceL
            // 
            this.priceL.AutoSize = true;
            this.priceL.Location = new System.Drawing.Point(65, 71);
            this.priceL.Name = "priceL";
            this.priceL.Size = new System.Drawing.Size(37, 13);
            this.priceL.TabIndex = 15;
            this.priceL.Text = "Price :";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(112, 30);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 14;
            this.nameTB.Validating += new System.ComponentModel.CancelEventHandler(this.nameTB_Validating);
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(65, 33);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(41, 13);
            this.nameL.TabIndex = 13;
            this.nameL.Text = "Name :";
            // 
            // updateHouseB
            // 
            this.updateHouseB.Location = new System.Drawing.Point(112, 191);
            this.updateHouseB.Name = "updateHouseB";
            this.updateHouseB.Size = new System.Drawing.Size(75, 23);
            this.updateHouseB.TabIndex = 12;
            this.updateHouseB.Text = "Update House";
            this.updateHouseB.UseVisualStyleBackColor = true;
            this.updateHouseB.Click += new System.EventHandler(this.updateHouseB_Click);
            // 
            // IdL
            // 
            this.IdL.AutoSize = true;
            this.IdL.Location = new System.Drawing.Point(263, 33);
            this.IdL.Name = "IdL";
            this.IdL.Size = new System.Drawing.Size(16, 13);
            this.IdL.TabIndex = 24;
            this.IdL.Text = "Id";
            this.IdL.Visible = false;
            // 
            // HouseUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.IdL);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.statusRequiredL);
            this.Controls.Add(this.nameRequiredL);
            this.Controls.Add(this.buildingEndDateL);
            this.Controls.Add(this.statusCB);
            this.Controls.Add(this.buildingEndDateDP);
            this.Controls.Add(this.statusL);
            this.Controls.Add(this.priceNB);
            this.Controls.Add(this.priceL);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.updateHouseB);
            this.Name = "HouseUpdateForm";
            this.Text = "HouseUpdateForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HouseUpdateForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HouseUpdateForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.priceNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Label statusRequiredL;
        private System.Windows.Forms.Label nameRequiredL;
        private System.Windows.Forms.Label buildingEndDateL;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.DateTimePicker buildingEndDateDP;
        private System.Windows.Forms.Label statusL;
        private System.Windows.Forms.NumericUpDown priceNB;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Button updateHouseB;
        private System.Windows.Forms.Label IdL;
    }
}
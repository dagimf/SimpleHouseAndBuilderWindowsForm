namespace House_selling_desktop_application
{
    partial class AddHouseForm
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
            this.saveHouseB = new System.Windows.Forms.Button();
            this.nameL = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.priceL = new System.Windows.Forms.Label();
            this.priceNB = new System.Windows.Forms.NumericUpDown();
            this.statusL = new System.Windows.Forms.Label();
            this.buildingEndDateDP = new System.Windows.Forms.DateTimePicker();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.buildingEndDateL = new System.Windows.Forms.Label();
            this.nameRequiredL = new System.Windows.Forms.Label();
            this.statusRequiredL = new System.Windows.Forms.Label();
            this.backB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceNB)).BeginInit();
            this.SuspendLayout();
            // 
            // saveHouseB
            // 
            this.saveHouseB.Enabled = false;
            this.saveHouseB.Location = new System.Drawing.Point(84, 195);
            this.saveHouseB.Name = "saveHouseB";
            this.saveHouseB.Size = new System.Drawing.Size(75, 23);
            this.saveHouseB.TabIndex = 0;
            this.saveHouseB.Text = "Save House";
            this.saveHouseB.UseVisualStyleBackColor = true;
            this.saveHouseB.Click += new System.EventHandler(this.saveHouseB_Click);
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(37, 37);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(41, 13);
            this.nameL.TabIndex = 1;
            this.nameL.Text = "Name :";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(84, 34);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 2;
            this.nameTB.Validating += new System.ComponentModel.CancelEventHandler(this.nameTB_Validating);
            // 
            // priceL
            // 
            this.priceL.AutoSize = true;
            this.priceL.Location = new System.Drawing.Point(37, 75);
            this.priceL.Name = "priceL";
            this.priceL.Size = new System.Drawing.Size(37, 13);
            this.priceL.TabIndex = 3;
            this.priceL.Text = "Price :";
            // 
            // priceNB
            // 
            this.priceNB.Location = new System.Drawing.Point(84, 73);
            this.priceNB.Name = "priceNB";
            this.priceNB.Size = new System.Drawing.Size(120, 20);
            this.priceNB.TabIndex = 4;
            // 
            // statusL
            // 
            this.statusL.AutoSize = true;
            this.statusL.Location = new System.Drawing.Point(39, 102);
            this.statusL.Name = "statusL";
            this.statusL.Size = new System.Drawing.Size(80, 13);
            this.statusL.TabIndex = 5;
            this.statusL.Text = "House Status : ";
            // 
            // buildingEndDateDP
            // 
            this.buildingEndDateDP.Location = new System.Drawing.Point(141, 142);
            this.buildingEndDateDP.Name = "buildingEndDateDP";
            this.buildingEndDateDP.Size = new System.Drawing.Size(200, 20);
            this.buildingEndDateDP.TabIndex = 6;
            // 
            // statusCB
            // 
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Location = new System.Drawing.Point(125, 99);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(121, 21);
            this.statusCB.TabIndex = 7;
            this.statusCB.DropDown += new System.EventHandler(this.statusCB_DropDown);
            this.statusCB.Validating += new System.ComponentModel.CancelEventHandler(this.statusCB_Validating);
            // 
            // buildingEndDateL
            // 
            this.buildingEndDateL.AutoSize = true;
            this.buildingEndDateL.Location = new System.Drawing.Point(37, 148);
            this.buildingEndDateL.Name = "buildingEndDateL";
            this.buildingEndDateL.Size = new System.Drawing.Size(98, 13);
            this.buildingEndDateL.TabIndex = 8;
            this.buildingEndDateL.Text = "Building End Date :";
            // 
            // nameRequiredL
            // 
            this.nameRequiredL.AutoSize = true;
            this.nameRequiredL.ForeColor = System.Drawing.Color.DarkRed;
            this.nameRequiredL.Location = new System.Drawing.Point(42, 57);
            this.nameRequiredL.Name = "nameRequiredL";
            this.nameRequiredL.Size = new System.Drawing.Size(93, 13);
            this.nameRequiredL.TabIndex = 9;
            this.nameRequiredL.Text = "* Name is required";
            this.nameRequiredL.Visible = false;
            // 
            // statusRequiredL
            // 
            this.statusRequiredL.AutoSize = true;
            this.statusRequiredL.ForeColor = System.Drawing.Color.DarkRed;
            this.statusRequiredL.Location = new System.Drawing.Point(42, 123);
            this.statusRequiredL.Name = "statusRequiredL";
            this.statusRequiredL.Size = new System.Drawing.Size(95, 13);
            this.statusRequiredL.TabIndex = 10;
            this.statusRequiredL.Text = "* Status is required";
            this.statusRequiredL.Visible = false;
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(180, 195);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 11;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // AddHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
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
            this.Controls.Add(this.saveHouseB);
            this.Name = "AddHouseForm";
            this.Text = "AddHouseForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddHouseForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.priceNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveHouseB;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.NumericUpDown priceNB;
        private System.Windows.Forms.Label statusL;
        private System.Windows.Forms.DateTimePicker buildingEndDateDP;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.Label buildingEndDateL;
        private System.Windows.Forms.Label nameRequiredL;
        private System.Windows.Forms.Label statusRequiredL;
        private System.Windows.Forms.Button backB;
    }
}
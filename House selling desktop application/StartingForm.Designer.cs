namespace House_selling_desktop_application
{
    partial class StartingForm
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
            this.addHouseB = new System.Windows.Forms.Button();
            this.getHousesB = new System.Windows.Forms.Button();
            this.getWorkersB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addHouseB
            // 
            this.addHouseB.Location = new System.Drawing.Point(90, 33);
            this.addHouseB.Name = "addHouseB";
            this.addHouseB.Size = new System.Drawing.Size(99, 23);
            this.addHouseB.TabIndex = 0;
            this.addHouseB.Text = "Add House";
            this.addHouseB.UseVisualStyleBackColor = true;
            this.addHouseB.Click += new System.EventHandler(this.addHouseB_Click);
            // 
            // getHousesB
            // 
            this.getHousesB.Location = new System.Drawing.Point(90, 89);
            this.getHousesB.Name = "getHousesB";
            this.getHousesB.Size = new System.Drawing.Size(99, 23);
            this.getHousesB.TabIndex = 1;
            this.getHousesB.Text = "Get All Houses";
            this.getHousesB.UseVisualStyleBackColor = true;
            this.getHousesB.Click += new System.EventHandler(this.getHousesB_Click);
            // 
            // getWorkersB
            // 
            this.getWorkersB.Location = new System.Drawing.Point(90, 153);
            this.getWorkersB.Name = "getWorkersB";
            this.getWorkersB.Size = new System.Drawing.Size(99, 23);
            this.getWorkersB.TabIndex = 2;
            this.getWorkersB.Text = "Get All Workers";
            this.getWorkersB.UseVisualStyleBackColor = true;
            this.getWorkersB.Click += new System.EventHandler(this.getWorkersB_Click);
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.getWorkersB);
            this.Controls.Add(this.getHousesB);
            this.Controls.Add(this.addHouseB);
            this.Name = "StartingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addHouseB;
        private System.Windows.Forms.Button getHousesB;
        private System.Windows.Forms.Button getWorkersB;
    }
}


namespace House_selling_desktop_application
{
    partial class GetAllHouseForm
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
            this.houseLV = new System.Windows.Forms.ListView();
            this.backB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            this.assigneWorkerB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // houseLV
            // 
            this.houseLV.FullRowSelect = true;
            this.houseLV.GridLines = true;
            this.houseLV.Location = new System.Drawing.Point(12, 12);
            this.houseLV.MultiSelect = false;
            this.houseLV.Name = "houseLV";
            this.houseLV.Size = new System.Drawing.Size(573, 222);
            this.houseLV.TabIndex = 0;
            this.houseLV.UseCompatibleStateImageBehavior = false;
            this.houseLV.SelectedIndexChanged += new System.EventHandler(this.houseLV_SelectedIndexChanged);
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(389, 261);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 1;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // updateB
            // 
            this.updateB.Location = new System.Drawing.Point(262, 261);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(75, 23);
            this.updateB.TabIndex = 2;
            this.updateB.Text = "Update";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // assigneWorkerB
            // 
            this.assigneWorkerB.Enabled = false;
            this.assigneWorkerB.Location = new System.Drawing.Point(109, 261);
            this.assigneWorkerB.Name = "assigneWorkerB";
            this.assigneWorkerB.Size = new System.Drawing.Size(97, 23);
            this.assigneWorkerB.TabIndex = 3;
            this.assigneWorkerB.Text = "Assign worker";
            this.assigneWorkerB.UseVisualStyleBackColor = true;
            this.assigneWorkerB.Click += new System.EventHandler(this.assigneWorkerB_Click);
            // 
            // GetAllHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 309);
            this.Controls.Add(this.assigneWorkerB);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.houseLV);
            this.Name = "GetAllHouseForm";
            this.Text = "All House";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetAllHouseForm_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.GetAllHouseForm_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView houseLV;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Button assigneWorkerB;

    }
}
namespace House_selling_desktop_application
{
    partial class GetAllWorkersForm
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
            this.workerLV = new System.Windows.Forms.ListView();
            this.backB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workerLV
            // 
            this.workerLV.Location = new System.Drawing.Point(12, 21);
            this.workerLV.Name = "workerLV";
            this.workerLV.Size = new System.Drawing.Size(260, 199);
            this.workerLV.TabIndex = 0;
            this.workerLV.UseCompatibleStateImageBehavior = false;
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(92, 226);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 1;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // GetAllWorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.workerLV);
            this.Name = "GetAllWorkersForm";
            this.Text = "GetAllWorkersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetAllWorkersForm_FormClosed);
            this.Load += new System.EventHandler(this.GetAllWorkersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView workerLV;
        private System.Windows.Forms.Button backB;
    }
}
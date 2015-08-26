namespace House_selling_desktop_application
{
    partial class AssignWorkerForm
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
            this.nameL = new System.Windows.Forms.Label();
            this.assignedWorkersL = new System.Windows.Forms.Label();
            this.allWorkerL = new System.Windows.Forms.Label();
            this.assignedWorkerLB = new System.Windows.Forms.ListView();
            this.allWorkerLB = new System.Windows.Forms.ListView();
            this.houseIdL = new System.Windows.Forms.Label();
            this.removeB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.backB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(27, 117);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(41, 13);
            this.nameL.TabIndex = 0;
            this.nameL.Text = "Name :";
            // 
            // assignedWorkersL
            // 
            this.assignedWorkersL.AutoSize = true;
            this.assignedWorkersL.Location = new System.Drawing.Point(168, 28);
            this.assignedWorkersL.Name = "assignedWorkersL";
            this.assignedWorkersL.Size = new System.Drawing.Size(130, 13);
            this.assignedWorkersL.TabIndex = 1;
            this.assignedWorkersL.Text = "Current Assigned Workers";
            // 
            // allWorkerL
            // 
            this.allWorkerL.AutoSize = true;
            this.allWorkerL.Location = new System.Drawing.Point(352, 28);
            this.allWorkerL.Name = "allWorkerL";
            this.allWorkerL.Size = new System.Drawing.Size(47, 13);
            this.allWorkerL.TabIndex = 3;
            this.allWorkerL.Text = "Workers";
            // 
            // assignedWorkerLB
            // 
            this.assignedWorkerLB.Location = new System.Drawing.Point(171, 65);
            this.assignedWorkerLB.Name = "assignedWorkerLB";
            this.assignedWorkerLB.Size = new System.Drawing.Size(121, 147);
            this.assignedWorkerLB.TabIndex = 5;
            this.assignedWorkerLB.UseCompatibleStateImageBehavior = false;
            // 
            // allWorkerLB
            // 
            this.allWorkerLB.Location = new System.Drawing.Point(355, 65);
            this.allWorkerLB.Name = "allWorkerLB";
            this.allWorkerLB.Size = new System.Drawing.Size(132, 147);
            this.allWorkerLB.TabIndex = 6;
            this.allWorkerLB.UseCompatibleStateImageBehavior = false;
            // 
            // houseIdL
            // 
            this.houseIdL.AutoSize = true;
            this.houseIdL.Location = new System.Drawing.Point(30, 156);
            this.houseIdL.Name = "houseIdL";
            this.houseIdL.Size = new System.Drawing.Size(16, 13);
            this.houseIdL.TabIndex = 7;
            this.houseIdL.Text = "Id";
            this.houseIdL.Visible = false;
            // 
            // removeB
            // 
            this.removeB.Location = new System.Drawing.Point(298, 107);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(51, 23);
            this.removeB.TabIndex = 8;
            this.removeB.Text = ">";
            this.removeB.UseVisualStyleBackColor = true;
            this.removeB.Click += new System.EventHandler(this.removeB_Click);
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(298, 146);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(51, 23);
            this.addB.TabIndex = 9;
            this.addB.Text = "<";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(260, 257);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 10;
            this.backB.Text = "back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // AssignWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 308);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.houseIdL);
            this.Controls.Add(this.allWorkerLB);
            this.Controls.Add(this.assignedWorkerLB);
            this.Controls.Add(this.allWorkerL);
            this.Controls.Add(this.assignedWorkersL);
            this.Controls.Add(this.nameL);
            this.Name = "AssignWorkerForm";
            this.Text = "AssignWorkerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AssignWorkerForm_FormClosed);
            this.Load += new System.EventHandler(this.AssignWorkerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label assignedWorkersL;
        private System.Windows.Forms.Label allWorkerL;
        private System.Windows.Forms.ListView assignedWorkerLB;
        private System.Windows.Forms.ListView allWorkerLB;
        private System.Windows.Forms.Label houseIdL;
        private System.Windows.Forms.Button removeB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button backB;
    }
}
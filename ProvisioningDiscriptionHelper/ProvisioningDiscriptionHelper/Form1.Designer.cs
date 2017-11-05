namespace ProvisioningDiscriptionHelper
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
            this.OpenProvisioningDescription = new System.Windows.Forms.Button();
            this.SaveProvisioningDescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenProvisioningDescription
            // 
            this.OpenProvisioningDescription.Location = new System.Drawing.Point(410, 13);
            this.OpenProvisioningDescription.Name = "OpenProvisioningDescription";
            this.OpenProvisioningDescription.Size = new System.Drawing.Size(75, 23);
            this.OpenProvisioningDescription.TabIndex = 0;
            this.OpenProvisioningDescription.Text = "Open XML";
            this.OpenProvisioningDescription.UseVisualStyleBackColor = true;
            this.OpenProvisioningDescription.Click += new System.EventHandler(this.OpenProvisioningDescription_Click);
            // 
            // SaveProvisioningDescription
            // 
            this.SaveProvisioningDescription.Location = new System.Drawing.Point(409, 43);
            this.SaveProvisioningDescription.Name = "SaveProvisioningDescription";
            this.SaveProvisioningDescription.Size = new System.Drawing.Size(75, 23);
            this.SaveProvisioningDescription.TabIndex = 1;
            this.SaveProvisioningDescription.Text = "Save XML";
            this.SaveProvisioningDescription.UseVisualStyleBackColor = true;
            this.SaveProvisioningDescription.Click += new System.EventHandler(this.SaveProvisioningDescription_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 408);
            this.Controls.Add(this.SaveProvisioningDescription);
            this.Controls.Add(this.OpenProvisioningDescription);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenProvisioningDescription;
        private System.Windows.Forms.Button SaveProvisioningDescription;
    }
}


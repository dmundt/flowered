﻿namespace Flowered.App.SimpleClient
{
    partial class FormSetAddress
    {
        #region Fields

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSet;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSetUrl;
        private System.Windows.Forms.TextBox tbUrl;

        #endregion Fields

        #region Methods

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSet = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lblSetUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // btnSet
            //
            this.btnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSet.Enabled = false;
            this.btnSet.Location = new System.Drawing.Point(116, 52);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "&Set";
            this.btnSet.UseVisualStyleBackColor = true;
            //
            // btnCancel
            //
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 52);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // tbUrl
            //
            this.tbUrl.Location = new System.Drawing.Point(50, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(222, 20);
            this.tbUrl.TabIndex = 2;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            //
            // lblSetUrl
            //
            this.lblSetUrl.AutoSize = true;
            this.lblSetUrl.Location = new System.Drawing.Point(12, 15);
            this.lblSetUrl.Name = "lblSetUrl";
            this.lblSetUrl.Size = new System.Drawing.Size(32, 13);
            this.lblSetUrl.TabIndex = 3;
            this.lblSetUrl.Text = "URL:";
            //
            // FormSetUrl
            //
            this.AcceptButton = this.btnSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(292, 87);
            this.Controls.Add(this.lblSetUrl);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetUrl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set URL";
            this.Load += new System.EventHandler(this.FormSetUrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion Methods
    }
}
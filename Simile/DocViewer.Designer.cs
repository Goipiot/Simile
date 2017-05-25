namespace Simile
{
    partial class DocViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocViewer));
            this.DocWindow = new AxAcroPDFLib.AxAcroPDF();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DocWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // DocWindow
            // 
            this.DocWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocWindow.Enabled = true;
            this.DocWindow.Location = new System.Drawing.Point(12, 105);
            this.DocWindow.Name = "DocWindow";
            this.DocWindow.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("DocWindow.OcxState")));
            this.DocWindow.Size = new System.Drawing.Size(376, 247);
            this.DocWindow.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(149, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(85, 29);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label1";
            // 
            // DocViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(400, 364);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.DocWindow);
            this.Name = "DocViewer";
            this.Text = "Просмотр";
            this.Load += new System.EventHandler(this.DocViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public AxAcroPDFLib.AxAcroPDF DocWindow;
        public System.Windows.Forms.Label nameLabel;
    }
}
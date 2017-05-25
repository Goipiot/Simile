namespace Simile
{
    partial class Создание
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
            this.filelabel = new System.Windows.Forms.Label();
            this.filebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.varBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filelabel
            // 
            this.filelabel.AutoSize = true;
            this.filelabel.Location = new System.Drawing.Point(169, 23);
            this.filelabel.Name = "filelabel";
            this.filelabel.Size = new System.Drawing.Size(0, 20);
            this.filelabel.TabIndex = 0;
            // 
            // filebutton
            // 
            this.filebutton.Location = new System.Drawing.Point(46, 15);
            this.filebutton.Name = "filebutton";
            this.filebutton.Size = new System.Drawing.Size(117, 36);
            this.filebutton.TabIndex = 1;
            this.filebutton.Text = "Choose file";
            this.filebutton.UseVisualStyleBackColor = true;
            this.filebutton.Click += new System.EventHandler(this.filebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(150, 203);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(173, 32);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "Add new topic";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Topic Name";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(150, 58);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(173, 26);
            this.namebox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(150, 90);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(173, 45);
            this.infoBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Your variant";
            // 
            // varBox
            // 
            this.varBox.Location = new System.Drawing.Point(150, 155);
            this.varBox.Name = "varBox";
            this.varBox.Size = new System.Drawing.Size(100, 26);
            this.varBox.TabIndex = 10;
            // 
            // Создание
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 247);
            this.Controls.Add(this.varBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.filebutton);
            this.Controls.Add(this.filelabel);
            this.Name = "Создание";
            this.Text = "Создание";
            this.Load += new System.EventHandler(this.NewTopic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filelabel;
        private System.Windows.Forms.Button filebutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox varBox;
    }
}
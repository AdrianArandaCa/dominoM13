namespace Projecte_Domino.Vista
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
            this.labelPrueba = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrueba
            // 
            this.labelPrueba.Location = new System.Drawing.Point(118, 59);
            this.labelPrueba.Name = "labelPrueba";
            this.labelPrueba.Size = new System.Drawing.Size(109, 60);
            this.labelPrueba.TabIndex = 0;
            this.labelPrueba.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(413, 91);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 50);
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.labelPrueba);
            this.Name = "Form1";
            this.Text = "Domino";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelPrueba;
        public System.Windows.Forms.PictureBox picture;
    }
}


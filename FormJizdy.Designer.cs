namespace Autoskola
{
    partial class FormJizdy
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbxSeznamJizd = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(31, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 114);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vytvořit jízdy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(31, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 114);
            this.button3.TabIndex = 3;
            this.button3.Text = "Odstranit jízdu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(31, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 114);
            this.button2.TabIndex = 2;
            this.button2.Text = "Upravit jízdu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbxSeznamJizd
            // 
            this.lbxSeznamJizd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbxSeznamJizd.FormattingEnabled = true;
            this.lbxSeznamJizd.ItemHeight = 20;
            this.lbxSeznamJizd.Location = new System.Drawing.Point(301, 37);
            this.lbxSeznamJizd.Name = "lbxSeznamJizd";
            this.lbxSeznamJizd.Size = new System.Drawing.Size(449, 384);
            this.lbxSeznamJizd.TabIndex = 4;
            // 
            // FormJizdy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 535);
            this.Controls.Add(this.lbxSeznamJizd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormJizdy";
            this.Text = "FormJizdy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbxSeznamJizd;
    }
}
namespace Autoskola
{
    partial class FormVytvoritJizdu
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnVytvoritJizdu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 58);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(302, 32);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // BtnVytvoritJizdu
            // 
            this.BtnVytvoritJizdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnVytvoritJizdu.Location = new System.Drawing.Point(22, 95);
            this.BtnVytvoritJizdu.Name = "BtnVytvoritJizdu";
            this.BtnVytvoritJizdu.Size = new System.Drawing.Size(302, 56);
            this.BtnVytvoritJizdu.TabIndex = 3;
            this.BtnVytvoritJizdu.Text = "Vytvořit jízdu";
            this.BtnVytvoritJizdu.UseVisualStyleBackColor = true;
            this.BtnVytvoritJizdu.Click += new System.EventHandler(this.BtnVytvoritJizdu_Click);
            // 
            // FormVytvoritJizdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 213);
            this.Controls.Add(this.BtnVytvoritJizdu);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVytvoritJizdu";
            this.Text = "FormVytvoritJizdu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnVytvoritJizdu;
    }
}
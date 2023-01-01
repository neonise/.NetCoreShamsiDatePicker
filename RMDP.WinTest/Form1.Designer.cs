namespace RMDP.WinTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.faDatePicker1 = new RMDP.Win.Controls.FADatePicker();
            this.SuspendLayout();
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(305, 99);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(135, 30);
            this.faDatePicker1.TabIndex = 0;
            this.faDatePicker1.Text = "[Empty Value]";
            this.faDatePicker1.Theme = RMDP.Win.Enums.ThemeTypes.WindowsXP;
            this.faDatePicker1.SelectedDateTimeChanged += new System.EventHandler(this.faDatePicker1_SelectedDateTimeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.faDatePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Win.Controls.FADatePicker faDatePicker1;
    }
}
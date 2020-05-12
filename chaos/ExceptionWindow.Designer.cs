namespace chaos
{
    partial class ExceptionWindow
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
            this.label_exception = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_exception
            // 
            this.label_exception.AutoSize = true;
            this.label_exception.Location = new System.Drawing.Point(24, 24);
            this.label_exception.Name = "label_exception";
            this.label_exception.Size = new System.Drawing.Size(46, 17);
            this.label_exception.TabIndex = 0;
            this.label_exception.Text = "label1";
            // 
            // ExceptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 267);
            this.Controls.Add(this.label_exception);
            this.Name = "ExceptionWindow";
            this.Text = "exceptionWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exception;
    }
}
namespace CatchButton
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
            btnCatch = new Button();
            SuspendLayout();
            // 
            // btnCatch
            // 
            btnCatch.Location = new Point(344, 232);
            btnCatch.Name = "btnCatch";
            btnCatch.Size = new Size(220, 94);
            btnCatch.TabIndex = 0;
            btnCatch.Text = "나를 잡아봐";
            btnCatch.UseVisualStyleBackColor = true;
            btnCatch.MouseEnter += btnCatch_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 735);
            Controls.Add(btnCatch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCatch;
    }
}

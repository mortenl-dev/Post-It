namespace WinFormsApp2
{
    partial class TextBoxUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usercontroltb = new TextBox();
            SuspendLayout();
            // 
            // usercontroltb
            // 
            usercontroltb.Location = new Point(3, 3);
            usercontroltb.Name = "usercontroltb";
            usercontroltb.Size = new Size(301, 27);
            usercontroltb.TabIndex = 0;
            // 
            // TextBoxUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(usercontroltb);
            Name = "TextBoxUC";
            Size = new Size(304, 35);
            Load += TextBoxUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usercontroltb;
    }
}

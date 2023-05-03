namespace Trello_local_sharp
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
            listBox_status_new = new ListBox();
            SuspendLayout();
            // 
            // listBox_status_new
            // 
            listBox_status_new.FormattingEnabled = true;
            listBox_status_new.Location = new Point(12, 61);
            listBox_status_new.Name = "listBox_status_new";
            listBox_status_new.Size = new Size(173, 94);
            listBox_status_new.TabIndex = 0;
            listBox_status_new.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1551, 450);
            Controls.Add(listBox_status_new);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_status_new;
    }
}
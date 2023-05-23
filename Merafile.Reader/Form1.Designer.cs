namespace Merafile.Reader
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            detailsRichTextBox = new RichTextBox();
            stopProcessButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 451);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(detailsRichTextBox);
            panel1.Controls.Add(stopProcessButton);
            panel1.Location = new Point(808, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 441);
            panel1.TabIndex = 1;
            // 
            // detailsRichTextBox
            // 
            detailsRichTextBox.Location = new Point(2, 29);
            detailsRichTextBox.Margin = new Padding(3, 2, 3, 2);
            detailsRichTextBox.Name = "detailsRichTextBox";
            detailsRichTextBox.Size = new Size(254, 403);
            detailsRichTextBox.TabIndex = 2;
            detailsRichTextBox.Text = "";
            // 
            // stopProcessButton
            // 
            stopProcessButton.Location = new Point(3, 2);
            stopProcessButton.Margin = new Padding(3, 2, 3, 2);
            stopProcessButton.Name = "stopProcessButton";
            stopProcessButton.Size = new Size(254, 23);
            stopProcessButton.TabIndex = 1;
            stopProcessButton.Text = "Stop process";
            stopProcessButton.UseVisualStyleBackColor = true;
            stopProcessButton.Click += stopProcessButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 456);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "MetafileReader";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button stopProcessButton;
        private RichTextBox detailsRichTextBox;
    }
}
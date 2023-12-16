namespace Paddle_WinForm
{
    partial class MainForm
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
            openButton = new Button();
            outputBox = new TextBox();
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.Font = new Font("Microsoft YaHei UI", 10.7142859F, FontStyle.Regular, GraphicsUnit.Point, 134);
            openButton.Location = new Point(320, 30);
            openButton.Name = "openButton";
            openButton.Size = new Size(131, 40);
            openButton.TabIndex = 0;
            openButton.Text = "open";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // outputBox
            // 
            outputBox.BackColor = SystemColors.ControlLightLight;
            outputBox.Font = new Font("Microsoft YaHei UI", 10.7142859F, FontStyle.Regular, GraphicsUnit.Point, 134);
            outputBox.Location = new Point(30, 85);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.ReadOnly = true;
            outputBox.ScrollBars = ScrollBars.Vertical;
            outputBox.Size = new Size(720, 640);
            outputBox.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 736);
            Controls.Add(outputBox);
            Controls.Add(openButton);
            Name = "MainForm";
            Text = "PaddleOCR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openButton;
        private TextBox outputBox;
    }
}

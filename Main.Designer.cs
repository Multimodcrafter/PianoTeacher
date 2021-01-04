namespace PianoTeacher
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChordLabel = new System.Windows.Forms.Label();
            this.ConfigureButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChordLabel
            // 
            this.ChordLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ChordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ChordLabel.Location = new System.Drawing.Point(12, 9);
            this.ChordLabel.Name = "ChordLabel";
            this.ChordLabel.Size = new System.Drawing.Size(754, 340);
            this.ChordLabel.TabIndex = 0;
            this.ChordLabel.Text = "Am7";
            this.ChordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfigureButton
            // 
            this.ConfigureButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConfigureButton.Location = new System.Drawing.Point(195, 382);
            this.ConfigureButton.Name = "ConfigureButton";
            this.ConfigureButton.Size = new System.Drawing.Size(200, 50);
            this.ConfigureButton.TabIndex = 1;
            this.ConfigureButton.Text = "Configure exercise";
            this.ConfigureButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartButton.Location = new System.Drawing.Point(405, 382);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 50);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start exercise";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ConfigureButton);
            this.Controls.Add(this.ChordLabel);
            this.Name = "Form1";
            this.Text = "PianoTeacher";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button ConfigureButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ChordLabel;

        #endregion
    }
}
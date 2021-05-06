
namespace GuessingGame
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.titleLabel.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(236, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(313, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Guessing Game";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.instructionsLabel.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.Color.White;
            this.instructionsLabel.Location = new System.Drawing.Point(166, 84);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(453, 38);
            this.instructionsLabel.TabIndex = 1;
            this.instructionsLabel.Text = "enter a number between 1 and 100";
            // 
            // numberInput
            // 
            this.numberInput.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.Location = new System.Drawing.Point(341, 171);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(100, 45);
            this.numberInput.TabIndex = 2;
            this.numberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.guessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.guessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.ForeColor = System.Drawing.Color.White;
            this.guessButton.Location = new System.Drawing.Point(317, 254);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(147, 58);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "guess";
            this.guessButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.outputLabel.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(166, 331);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(453, 79);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 440);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label outputLabel;
    }
}


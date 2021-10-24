
namespace Week_5_Activity_11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RollDiceButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.d1Display = new System.Windows.Forms.Label();
            this.d2Display = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sideSelection = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RollDiceButton
            // 
            this.RollDiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RollDiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollDiceButton.Location = new System.Drawing.Point(108, 168);
            this.RollDiceButton.Name = "RollDiceButton";
            this.RollDiceButton.Size = new System.Drawing.Size(139, 59);
            this.RollDiceButton.TabIndex = 0;
            this.RollDiceButton.Text = "Roll Dice";
            this.RollDiceButton.UseVisualStyleBackColor = false;
            this.RollDiceButton.Click += new System.EventHandler(this.RollDiceButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(77, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 72);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(207, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 72);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // d1Display
            // 
            this.d1Display.AutoSize = true;
            this.d1Display.BackColor = System.Drawing.Color.White;
            this.d1Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1Display.Location = new System.Drawing.Point(237, 103);
            this.d1Display.Name = "d1Display";
            this.d1Display.Size = new System.Drawing.Size(21, 24);
            this.d1Display.TabIndex = 3;
            this.d1Display.Text = "1";
            // 
            // d2Display
            // 
            this.d2Display.AutoSize = true;
            this.d2Display.BackColor = System.Drawing.Color.White;
            this.d2Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2Display.Location = new System.Drawing.Point(105, 103);
            this.d2Display.Name = "d2Display";
            this.d2Display.Size = new System.Drawing.Size(21, 24);
            this.d2Display.TabIndex = 4;
            this.d2Display.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select number of sides on the dice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "(Must be between 4 and 20)";
            // 
            // sideSelection
            // 
            this.sideSelection.Location = new System.Drawing.Point(268, 12);
            this.sideSelection.Name = "sideSelection";
            this.sideSelection.Size = new System.Drawing.Size(64, 20);
            this.sideSelection.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(355, 258);
            this.Controls.Add(this.sideSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.d2Display);
            this.Controls.Add(this.d1Display);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RollDiceButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Roll Dice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollDiceButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label d1Display;
        private System.Windows.Forms.Label d2Display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sideSelection;
    }
}


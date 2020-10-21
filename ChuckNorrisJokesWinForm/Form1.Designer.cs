namespace ChuckNorrisJokesWinForm
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
            this.getJokeBtn = new System.Windows.Forms.Button();
            this.categoriesDdl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // getJokeBtn
            // 
            this.getJokeBtn.Location = new System.Drawing.Point(63, 181);
            this.getJokeBtn.Name = "getJokeBtn";
            this.getJokeBtn.Size = new System.Drawing.Size(144, 88);
            this.getJokeBtn.TabIndex = 0;
            this.getJokeBtn.Text = "Get Joke";
            this.getJokeBtn.UseVisualStyleBackColor = true;
            this.getJokeBtn.Click += new System.EventHandler(this.getJokeBtn_Click);
            // 
            // categoriesDdl
            // 
            this.categoriesDdl.FormattingEnabled = true;
            this.categoriesDdl.Location = new System.Drawing.Point(256, 112);
            this.categoriesDdl.Name = "categoriesDdl";
            this.categoriesDdl.Size = new System.Drawing.Size(124, 24);
            this.categoriesDdl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 372);
            this.Controls.Add(this.categoriesDdl);
            this.Controls.Add(this.getJokeBtn);
            this.Name = "Form1";
            this.Text = "Chuck Norris Joke App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getJokeBtn;
        private System.Windows.Forms.ComboBox categoriesDdl;
    }
}


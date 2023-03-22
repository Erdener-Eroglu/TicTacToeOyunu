namespace TicTacToeOyunu.Forms
{
    partial class AnaMenuForm
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
            btnIkiKisilik = new Button();
            SuspendLayout();
            // 
            // btnIkiKisilik
            // 
            btnIkiKisilik.Location = new Point(153, 206);
            btnIkiKisilik.Name = "btnIkiKisilik";
            btnIkiKisilik.Size = new Size(231, 71);
            btnIkiKisilik.TabIndex = 0;
            btnIkiKisilik.Text = "İki Kişilik Oyna";
            btnIkiKisilik.UseVisualStyleBackColor = true;
            btnIkiKisilik.Click += btnIkiKisilik_Click;
            // 
            // AnaMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 447);
            Controls.Add(btnIkiKisilik);
            Name = "AnaMenuForm";
            Text = "AnaMenuForm";
            FormClosing += AnaMenuForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnIkiKisilik;
    }
}
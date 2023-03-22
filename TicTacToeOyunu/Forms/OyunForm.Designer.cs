namespace TicTacToeOyunu.Forms
{
    partial class OyunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBoxO = new PictureBox();
            pictureBoxX = new PictureBox();
            lblXScore = new Label();
            lblOScore = new Label();
            btnSıfırla = new Button();
            btnGeri = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxX).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(lblXScore, 0, 0);
            tableLayoutPanel1.Controls.Add(lblOScore, 2, 0);
            tableLayoutPanel1.Controls.Add(btnSıfırla, 1, 2);
            tableLayoutPanel1.Controls.Add(btnGeri, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0723324F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.6745033F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(579, 660);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox3, 2, 0);
            tableLayoutPanel2.Controls.Add(pictureBox4, 0, 1);
            tableLayoutPanel2.Controls.Add(pictureBox5, 1, 1);
            tableLayoutPanel2.Controls.Add(pictureBox6, 2, 1);
            tableLayoutPanel2.Controls.Add(pictureBox7, 0, 2);
            tableLayoutPanel2.Controls.Add(pictureBox8, 1, 2);
            tableLayoutPanel2.Controls.Add(pictureBox9, 2, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(118, 135);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(341, 388);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox_Clixk;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(118, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox_Clixk;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(230, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(105, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox_Clixk;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Location = new Point(6, 134);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(103, 119);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox_Clixk;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Location = new Point(118, 134);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(103, 119);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox_Clixk;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Location = new Point(230, 134);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(105, 119);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox_Clixk;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Dock = DockStyle.Fill;
            pictureBox7.Location = new Point(6, 262);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(103, 120);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox_Clixk;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.White;
            pictureBox8.Dock = DockStyle.Fill;
            pictureBox8.Location = new Point(118, 262);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(103, 120);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox_Clixk;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.White;
            pictureBox9.Dock = DockStyle.Fill;
            pictureBox9.Location = new Point(230, 262);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(105, 120);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox_Clixk;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pictureBoxO, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBoxX, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(118, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(341, 126);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // pictureBoxO
            // 
            pictureBoxO.Dock = DockStyle.Fill;
            pictureBoxO.Image = Properties.Resources.o;
            pictureBoxO.Location = new Point(173, 3);
            pictureBoxO.Name = "pictureBoxO";
            pictureBoxO.Size = new Size(165, 120);
            pictureBoxO.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxO.TabIndex = 0;
            pictureBoxO.TabStop = false;
            // 
            // pictureBoxX
            // 
            pictureBoxX.Dock = DockStyle.Fill;
            pictureBoxX.Image = Properties.Resources.x;
            pictureBoxX.Location = new Point(3, 3);
            pictureBoxX.Name = "pictureBoxX";
            pictureBoxX.Size = new Size(164, 120);
            pictureBoxX.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxX.TabIndex = 1;
            pictureBoxX.TabStop = false;
            // 
            // lblXScore
            // 
            lblXScore.AutoSize = true;
            lblXScore.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblXScore.Location = new Point(25, 18);
            lblXScore.Margin = new Padding(25, 18, 3, 0);
            lblXScore.Name = "lblXScore";
            lblXScore.Size = new Size(49, 54);
            lblXScore.TabIndex = 2;
            lblXScore.Text = "0";
            // 
            // lblOScore
            // 
            lblOScore.AutoSize = true;
            lblOScore.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblOScore.Location = new Point(487, 18);
            lblOScore.Margin = new Padding(25, 18, 3, 0);
            lblOScore.Name = "lblOScore";
            lblOScore.Size = new Size(49, 54);
            lblOScore.TabIndex = 2;
            lblOScore.Text = "0";
            // 
            // btnSıfırla
            // 
            btnSıfırla.Dock = DockStyle.Fill;
            btnSıfırla.Font = new Font("Sigmar One", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSıfırla.Location = new Point(118, 529);
            btnSıfırla.Name = "btnSıfırla";
            btnSıfırla.Size = new Size(341, 128);
            btnSıfırla.TabIndex = 3;
            btnSıfırla.Text = "Reset";
            btnSıfırla.UseVisualStyleBackColor = true;
            btnSıfırla.Click += btnSıfırla_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.DarkRed;
            btnGeri.BackgroundImage = (Image)resources.GetObject("btnGeri.BackgroundImage");
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.Dock = DockStyle.Fill;
            btnGeri.Location = new Point(3, 529);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(109, 128);
            btnGeri.TabIndex = 4;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // OyunForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 660);
            Controls.Add(tableLayoutPanel1);
            Name = "OyunForm";
            Text = "OyunForm";
            FormClosing += OyunForm_FormClosing;
            Load += OyunForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxX).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBoxO;
        private PictureBox pictureBoxX;
        private Label lblXScore;
        private Label lblOScore;
        private Button btnSıfırla;
        private Button btnGeri;
    }
}
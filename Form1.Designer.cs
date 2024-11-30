namespace Bt3
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
            txtHoLot = new TextBox();
            txtTen = new TextBox();
            btnHoLot = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            label1 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(218, 109);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(784, 31);
            txtHoLot.TabIndex = 0;
            txtHoLot.TextChanged += txtHo_TextChanged;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(255, 192, 255);
            txtTen.Location = new Point(218, 184);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(777, 31);
            txtTen.TabIndex = 1;
            // 
            // btnHoLot
            // 
            btnHoLot.BackColor = Color.Gainsboro;
            btnHoLot.ForeColor = Color.Black;
            btnHoLot.Location = new Point(257, 274);
            btnHoLot.Name = "btnHoLot";
            btnHoLot.Size = new Size(112, 34);
            btnHoLot.TabIndex = 2;
            btnHoLot.Text = "Họ Lót";
            btnHoLot.UseVisualStyleBackColor = false;
            btnHoLot.Click += btnHoLot_Click;
            // 
            // btnTen
            // 
            btnTen.BackColor = Color.Gainsboro;
            btnTen.ForeColor = Color.Black;
            btnTen.Location = new Point(551, 274);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(112, 34);
            btnTen.TabIndex = 3;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = false;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.BackColor = Color.Gainsboro;
            btnHoTen.ForeColor = Color.Black;
            btnHoTen.Location = new Point(854, 274);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(112, 34);
            btnHoTen.TabIndex = 4;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = false;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(115, 117);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 5;
            label1.Text = "Họ lót:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(115, 184);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 6;
            label2.Text = "Tên:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(476, 399);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(215, 49);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm chương trình";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 83);
            panel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1131, 548);
            Controls.Add(panel1);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHoLot);
            Controls.Add(txtTen);
            Controls.Add(txtHoLot);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaption;
            Name = "Form1";
            Text = "Bài Tập Họ Tên";
            TransparencyKey = Color.Gray;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHo;
        private TextBox txtTen;
        private Button button1;
        private Button btnTen;
        private Button btnHoTen;
        private Label label1;
        private Label label2;
        private Button btnAdd;
        private Panel panel1;
        private TextBox txtHoLot;
        private Button btnHoLot;
    }
}

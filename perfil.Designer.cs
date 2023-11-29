namespace MARATONES_PROGRAMACION
{
    partial class perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perfil));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(313, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 218);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 1;
            label1.Text = "NOMBRES";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 412);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "-----";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(148, 293);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 3;
            label3.Text = "APELLIDOS";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 261);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "----------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 341);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 5;
            label5.Text = "---------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(148, 369);
            label6.Name = "label6";
            label6.Size = new Size(262, 32);
            label6.TabIndex = 6;
            label6.Text = "CORREO ELECTRONICO";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(470, 218);
            label7.Name = "label7";
            label7.Size = new Size(125, 32);
            label7.TabIndex = 7;
            label7.Text = "TELEFONO";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(470, 261);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 8;
            label8.Text = "----------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(470, 293);
            label9.Name = "label9";
            label9.Size = new Size(161, 32);
            label9.TabIndex = 9;
            label9.Text = "UNIVERSIDAD";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(470, 341);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 10;
            label10.Text = "----------";
            // 
            // button1
            // 
            button1.Location = new Point(713, 412);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "MENU";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "perfil";
            Text = "perfil";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
    }
}
namespace proyecto_ventas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(37, 38, 58);
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 211);
            label1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(37, 38, 58);
            iconPictureBox1.BackgroundImage = (Image)resources.GetObject("iconPictureBox1.BackgroundImage");
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 128;
            iconPictureBox1.Location = new Point(12, 33);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(129, 128);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 33);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 5;
            label3.Text = "Nro Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 84);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 21;
            iconButton1.Location = new Point(191, 155);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(89, 35);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Ingresar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 21;
            iconButton2.Location = new Point(301, 155);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(89, 35);
            iconButton2.TabIndex = 8;
            iconButton2.Text = "Cancelar";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 211);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
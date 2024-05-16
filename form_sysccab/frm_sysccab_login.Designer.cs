namespace form_sysccab_menu
{
    partial class frm_sysccab_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sysccab_login));
            btnIngresar = new Button();
            label1 = new Label();
            txtUsuario = new TextBox();
            btnsalir = new Button();
            txtContrasena = new TextBox();
            label2 = new Label();
            frm_titulo_login = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.FromArgb(0, 0, 192);
            btnIngresar.Location = new Point(54, 302);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(108, 33);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btn_login;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 150);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(107, 168);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(178, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.ForeColor = Color.Navy;
            btnsalir.Location = new Point(193, 302);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(101, 33);
            btnsalir.TabIndex = 3;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btn_salir;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(107, 230);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(178, 23);
            txtContrasena.TabIndex = 4;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 212);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 5;
            label2.Text = "Contrasena";
            // 
            // frm_titulo_login
            // 
            frm_titulo_login.AutoSize = true;
            frm_titulo_login.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            frm_titulo_login.Location = new Point(139, 76);
            frm_titulo_login.Name = "frm_titulo_login";
            frm_titulo_login.Size = new Size(90, 25);
            frm_titulo_login.TabIndex = 6;
            frm_titulo_login.Text = "SYSCCAB";
            frm_titulo_login.Click += frm_titulo_login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 3, 17);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(frm_titulo_login);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(btnsalir);
            panel1.ForeColor = Color.Snow;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 449);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(69, 226);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(410, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(392, 449);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // frm_sysccab_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Name = "frm_sysccab_login";
            Text = "frm_sysccab_login";
            Load += frm_sysccab_login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresar;
        private Label label1;
        private TextBox txtUsuario;
        private Button btnsalir;
        private TextBox txtContrasena;
        private Label label2;
        private Label frm_titulo_login;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}
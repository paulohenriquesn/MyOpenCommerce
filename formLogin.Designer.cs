namespace MyOpenCommerce
{
    partial class formLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.pictureBox_Pass = new System.Windows.Forms.PictureBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pass)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Arial", 10.25F);
            this.label_Username.Location = new System.Drawing.Point(113, 171);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(72, 16);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(116, 190);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(153, 20);
            this.textBox_Username.TabIndex = 1;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(116, 282);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(153, 20);
            this.textBox_Password.TabIndex = 3;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Arial", 10.25F);
            this.label_Password.Location = new System.Drawing.Point(116, 263);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(69, 16);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.Image = global::MyOpenCommerce.Properties.Resources.user;
            this.pictureBox_User.Location = new System.Drawing.Point(30, 155);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_User.TabIndex = 4;
            this.pictureBox_User.TabStop = false;
            // 
            // pictureBox_Pass
            // 
            this.pictureBox_Pass.Image = global::MyOpenCommerce.Properties.Resources.pass;
            this.pictureBox_Pass.Location = new System.Drawing.Point(30, 238);
            this.pictureBox_Pass.Name = "pictureBox_Pass";
            this.pictureBox_Pass.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Pass.TabIndex = 5;
            this.pictureBox_Pass.TabStop = false;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(30, 351);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(86, 34);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(183, 351);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(86, 34);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F);
            this.labelTitle.Location = new System.Drawing.Point(24, 49);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(259, 32);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "MyOpenCommerce";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 411);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.pictureBox_Pass);
            this.Controls.Add(this.pictureBox_User);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "formLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.PictureBox pictureBox_Pass;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label labelTitle;
    }
}


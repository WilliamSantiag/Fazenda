namespace Fazenda
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ntcadastroLinkLabel = new System.Windows.Forms.LinkLabel();
            this.entrarButton = new System.Windows.Forms.Button();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.LOGIN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ntcadastroLinkLabel);
            this.panel2.Controls.Add(this.entrarButton);
            this.panel2.Controls.Add(this.senhaTextBox);
            this.panel2.Controls.Add(this.usuarioTextBox);
            this.panel2.Controls.Add(this.LOGIN);
            this.panel2.Location = new System.Drawing.Point(279, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 332);
            this.panel2.TabIndex = 0;
            // 
            // ntcadastroLinkLabel
            // 
            this.ntcadastroLinkLabel.AutoSize = true;
            this.ntcadastroLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ntcadastroLinkLabel.LinkColor = System.Drawing.Color.Maroon;
            this.ntcadastroLinkLabel.Location = new System.Drawing.Point(87, 289);
            this.ntcadastroLinkLabel.Name = "ntcadastroLinkLabel";
            this.ntcadastroLinkLabel.Size = new System.Drawing.Size(101, 13);
            this.ntcadastroLinkLabel.TabIndex = 4;
            this.ntcadastroLinkLabel.TabStop = true;
            this.ntcadastroLinkLabel.Text = "Não tenho cadastro";
            this.ntcadastroLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ntcadastroLinkLabel_LinkClicked);
            // 
            // entrarButton
            // 
            this.entrarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.entrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarButton.ForeColor = System.Drawing.Color.White;
            this.entrarButton.Location = new System.Drawing.Point(92, 231);
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(96, 33);
            this.entrarButton.TabIndex = 3;
            this.entrarButton.Text = "Entrar";
            this.entrarButton.UseVisualStyleBackColor = false;
            this.entrarButton.Click += new System.EventHandler(this.entrarButton_Click);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.Location = new System.Drawing.Point(78, 179);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(118, 21);
            this.senhaTextBox.TabIndex = 2;
            this.senhaTextBox.Text = "Senha";
            this.senhaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(78, 117);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(118, 21);
            this.usuarioTextBox.TabIndex = 1;
            this.usuarioTextBox.Text = "Usuário";
            this.usuarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(87, 39);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(92, 29);
            this.LOGIN.TabIndex = 0;
            this.LOGIN.Text = "LOGIN";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel ntcadastroLinkLabel;
        private System.Windows.Forms.Button entrarButton;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label LOGIN;
    }
}


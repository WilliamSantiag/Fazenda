namespace Fazenda
{
    partial class Cadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cadastrarfunButton = new System.Windows.Forms.Button();
            this.senhacaTextBox = new System.Windows.Forms.TextBox();
            this.usuariocaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.cadastrarfunButton);
            this.panel2.Controls.Add(this.senhacaTextBox);
            this.panel2.Controls.Add(this.usuariocaTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(272, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 325);
            this.panel2.TabIndex = 0;
            // 
            // cadastrarfunButton
            // 
            this.cadastrarfunButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cadastrarfunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarfunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarfunButton.ForeColor = System.Drawing.Color.White;
            this.cadastrarfunButton.Location = new System.Drawing.Point(99, 253);
            this.cadastrarfunButton.Name = "cadastrarfunButton";
            this.cadastrarfunButton.Size = new System.Drawing.Size(84, 41);
            this.cadastrarfunButton.TabIndex = 3;
            this.cadastrarfunButton.Text = "Cadastrar";
            this.cadastrarfunButton.UseVisualStyleBackColor = false;
            this.cadastrarfunButton.Click += new System.EventHandler(this.cadastrarfunButton_Click);
            // 
            // senhacaTextBox
            // 
            this.senhacaTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.senhacaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhacaTextBox.Location = new System.Drawing.Point(84, 191);
            this.senhacaTextBox.Name = "senhacaTextBox";
            this.senhacaTextBox.Size = new System.Drawing.Size(113, 21);
            this.senhacaTextBox.TabIndex = 2;
            this.senhacaTextBox.Text = "Senha";
            this.senhacaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.senhacaTextBox.UseSystemPasswordChar = true;
            // 
            // usuariocaTextBox
            // 
            this.usuariocaTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.usuariocaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariocaTextBox.Location = new System.Drawing.Point(84, 121);
            this.usuariocaTextBox.Name = "usuariocaTextBox";
            this.usuariocaTextBox.Size = new System.Drawing.Size(113, 21);
            this.usuariocaTextBox.TabIndex = 1;
            this.usuariocaTextBox.Text = "Usuário";
            this.usuariocaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Cadastro";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cadastrarfunButton;
        private System.Windows.Forms.TextBox senhacaTextBox;
        private System.Windows.Forms.TextBox usuariocaTextBox;
        private System.Windows.Forms.Label label1;
    }
}
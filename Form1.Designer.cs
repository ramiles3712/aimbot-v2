namespace testepctraba
{
    partial class Form1
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
            btnHs = new Button();
            SuspendLayout();
            // 
            // btnHs
            // 
            btnHs.Location = new Point(52, 93);
            btnHs.Name = "btnHs";
            btnHs.Size = new Size(131, 38);
            btnHs.TabIndex = 0;
            btnHs.Text = "Ativar Aimbot";
            btnHs.UseVisualStyleBackColor = true;
            btnHs.Click += btnHs_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 143);
            Controls.Add(btnHs);
            Name = "Form1";
            Text = "Aimbot Teste";
            Load += Form1_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHs;
    }
}

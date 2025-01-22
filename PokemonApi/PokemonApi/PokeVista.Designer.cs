namespace PokemonApi
{
    partial class PokeVista
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Imagem = new System.Windows.Forms.PictureBox();
            this.Nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagem
            // 
            this.Imagem.Location = new System.Drawing.Point(41, 50);
            this.Imagem.Name = "Imagem";
            this.Imagem.Size = new System.Drawing.Size(151, 121);
            this.Imagem.TabIndex = 0;
            this.Imagem.TabStop = false;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(103, 203);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "label1";
            // 
            // PokeVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Imagem);
            this.Name = "PokeVista";
            this.Size = new System.Drawing.Size(232, 263);
            this.Load += new System.EventHandler(this.PokeVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagem;
        private System.Windows.Forms.Label Nome;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonApi
{
    public partial class PokeVista : UserControl
    {
        public PokeVista(string nome, Image imagem)
        {
            InitializeComponent();
            this.Nome.Text = nome;
            this.Imagem.Image = imagem; 
        }

        private void PokeVista_Load(object sender, EventArgs e)
        {

        }
    }
}

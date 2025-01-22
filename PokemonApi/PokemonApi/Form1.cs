using PokemonApi.Models;
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
    public partial class Form1 : Form
    {
        ApiRequest api = new ApiRequest();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void carregarDados()
        {
            flowLayoutPanel1.Controls.Clear();
            
            PokeLista pokemon = new PokeLista();

            pokemon = api.ObterLista();

            foreach (var item in pokemon.ListaPokemons)
            {
                flowLayoutPanel1.Controls.Add(new PokeVista(item.nomePokemon, item.GetImagem()));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregarDados();
        }
    }
}

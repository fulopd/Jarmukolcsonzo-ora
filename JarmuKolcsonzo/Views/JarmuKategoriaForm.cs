using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.Presenters;
using JarmuKolcsonzo.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarmuKolcsonzo.Views
{
    public partial class JarmuKategoriaForm : Form, IJarmuKategoriaView
    {
        private int Id;
        private JarmuKategoriaPresenter presenter;

        public JarmuKategoriaForm()
        {
            InitializeComponent();
            presenter = new JarmuKategoriaPresenter(this);
        }

        public string errorMessage { 
            get => errorProvider1.GetError(textBoxKategoriaNevText); //OK gomb műveletéhez kell majd valamiért...
            set => errorProvider1.SetError(textBoxKategoriaNevText, value);
        }

        public jarmukategoria jarmukategoria {

            get 
            {
                var jk = new jarmukategoria(textBoxKategoriaNevText.Text);
                if (Id>0)
                {
                    jk.Id = Id;
                }
                return jk;
            }
            set 
            {
                Id = value.Id;
                textBoxKategoriaNevText.Text = value.kategoriaNev;
            }
        }

        private void buttonHozzadas_Click(object sender, EventArgs e)
        {
            presenter.Save(this.jarmukategoria);
            if (string.IsNullOrEmpty(errorMessage))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

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
    public partial class JarmuKategoria : Form, IDataGridList<jarmukategoria>
    {
        private JarmuKategoriaPresenter presenter;
        public JarmuKategoria()
        {
            InitializeComponent();
            presenter = new JarmuKategoriaPresenter(this);
        }

        public BindingList<jarmukategoria> bindingList 
        {
            get => (BindingList<jarmukategoria>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value; 
        }
        private void JarmuKategoria_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void mentestoolStripButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            var index = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[index - 1].Cells[0].Value = index;
        }
    }
}

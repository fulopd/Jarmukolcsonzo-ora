using JarmuKolcsonzo.Models;
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
    public partial class JarmuLista : Form
    {
        public JarmuLista()
        {
            InitializeComponent();

            var colbox = new DataGridViewComboBoxColumn();

            using (var db = new JKContext())
            {
                colbox.HeaderText = "Kategória";
                colbox.DataSource = db.jarmukategoria.ToList();
                colbox.ValueMember = "Id";
                colbox.DisplayMember = "kategoriaNev";
            }

            dataGridView1.Columns.RemoveAt(1);
            dataGridView1.Columns.Insert(1, colbox);
        }
    }
}

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
    public partial class JarmuKategoriaListaForm : Form, IDataGridList<jarmukategoria>
    {
        JarmuKategoriaListaPresenter presenter;
        // Oldal per / elem értéke
        private int pageCount;
        private int colIndex;

        public JarmuKategoriaListaForm()
        {
            InitializeComponent();
            presenter = new JarmuKategoriaListaPresenter(this);
            Init();
        }

        private void Init()
        {
            pageNumber = 1;
            itemsPerPage = 25;
            sortBy = "Id";
            ascending = true;
            colIndex = 0;
        }

        public BindingList<jarmukategoria> bindingList {
            // Kasztolni kell, mert alapesetben OBJECT elemet tartalmaz
            get => (BindingList<jarmukategoria>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }

        public int pageNumber { get; set; }
        public int itemsPerPage { get; set; }
        public string search => KeresestoolStripTextBox.Text;
        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalItems
        {
            set
            {
                // Összes oldal száma
                pageCount = (value - 1) / itemsPerPage + 1;
                // Jelenlegi oldal / Összes oldal szám
                PageLabel.Text = pageNumber.ToString() + "/" + pageCount.ToString();
            }
        }

        private void JarmuKategoriaForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void mentestoolStripButton1_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            presenter.LoadData();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            //page = page - 1;
            if (pageNumber >= 2) // page != 1
            {
                pageNumber--;
                presenter.LoadData();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (pageNumber < pageCount)
            {
                pageNumber++;
                presenter.LoadData();
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            pageNumber = pageCount;
            presenter.LoadData();
        }

        private void KeresestoolStripButton_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (colIndex == e.ColumnIndex)
            {
                // Ellentétre vált az értéke
                ascending = !ascending;
            }

            // Oszlop száma szerint módosítja a sortBy értékét
            switch (e.ColumnIndex)
            {
                case 0:
                    sortBy = "Id";
                    break;
                case 1:
                    sortBy = "kategoriaNev";
                    break;
                default:
                    break;
            }

            // 0-tól számozza az oszlopokat
            colIndex = e.ColumnIndex;

            presenter.LoadData();
        }

        private void toolStripButtonUj_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonTorles_Click(object sender, EventArgs e)
        {

        }

        private void szerkesztesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void torlesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

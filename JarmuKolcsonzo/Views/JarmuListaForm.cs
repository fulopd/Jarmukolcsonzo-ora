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
    public partial class JarmuListaForm : Form, IJarmuListaView
    {
        private int pageCount;
        private int colIndex;
        private JarmuListaPresenter presenter;
        // Combobox oszlop a járműkategóriának
        private DataGridViewComboBoxColumn jkCol;

        public JarmuListaForm()
        {
            InitializeComponent();
            presenter = new JarmuListaPresenter(this);
            jkCol = new DataGridViewComboBoxColumn();
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

        public BindingList<jarmu> bindingList {
            get => (BindingList<jarmu>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }
        public List<jarmukategoria> jarmukategoriaList {
            get => (List<jarmukategoria>)jkCol.DataSource;
            set
            {
                value.Insert(0, new jarmukategoria() { Id = 0 });
                jkCol.DataSource = value;
            }
        }

        private void JarmuListaForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();

            // ComboBox Oszlop hozzáadása
            // 0-tól számozza az oszlopok indexét
            dataGridView1.Columns.RemoveAt(2);

            jkCol.DataPropertyName = "kategoriaId";
            // Megjelenítendő adat
            jkCol.DisplayMember = "kategoriaNev";
            //dataGridView1.Columns["Oszlopneve"]
            jkCol.Name = "kategoriaId";
            jkCol.HeaderText = "Kategória";
            // Cella értéke
            jkCol.ValueMember = "Id";

            // Hozzáadás a táblázathoz (index, oszlop neve)
            dataGridView1.Columns.Insert(2, jkCol);
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
                    sortBy = "rendszam";
                    break;
                case 3:
                    sortBy = "tipus";
                    break;
                case 4:
                    sortBy = "modell";
                    break;
                case 5:
                    sortBy = "fogyasztas";
                    break;
                default:
                    break;
            }

            // 0-tól számozza az oszlopokat
            colIndex = e.ColumnIndex;

            presenter.LoadData();
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // e.Row.Cells["kategoriaId"].Value = 0;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                switch (e.ColumnIndex)
                {
                    // fogyasztás
                    case 6:
                        MessageBox.Show("Kérem az tizedesjegyet vesszővel válassza el!",
                            "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show(e.Exception.Message);
                        break;
                }
            }
        }
    }
}

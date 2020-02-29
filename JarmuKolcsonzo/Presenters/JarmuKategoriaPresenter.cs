using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.Repositories;
using JarmuKolcsonzo.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Presenters
{
    public class JarmuKategoriaPresenter
    {
        IDataGridList<jarmukategoria> view;
        JarmuKategoriaRepository repo = new JarmuKategoriaRepository();

        public JarmuKategoriaPresenter(IDataGridList<jarmukategoria> param)
        {
            view = param;
        }

        /// <summary>
        /// Adatok betöltése, az interfész Lista értékadása.
        /// </summary>
        public void LoadData()
        {
            view.bindingList = repo.GetAllKategoria(
                view.pageNumber,
                view.itemsPerPage,
                view.search,
                view.sortBy,
                view.ascending);

            view.totalItems = repo.Count();
        }

        public void Save()
        {
            repo.Save();
        }
    }
}

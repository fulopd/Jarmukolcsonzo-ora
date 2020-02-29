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
    public class JarmuListaPresenter
    {
        IJarmuListaView view;
        JarmuListaRepository repo = new JarmuListaRepository();
        JarmuKategoriaRepository jkRepo = new JarmuKategoriaRepository();

        public JarmuListaPresenter(IJarmuListaView param)
        {
            view = param;
        }

        /// <summary>
        /// Adatok betöltése, az interfész Lista értékadása.
        /// </summary>
        public void LoadData()
        {
            view.bindingList = repo.GetAllJarmu(
                view.pageNumber,
                view.itemsPerPage,
                view.search,
                view.sortBy,
                view.ascending);
            view.jarmukategoriaList = jkRepo.GetAllKategoria().ToList();
            view.totalItems = repo.Count();
        }

        public void Save()
        {
            repo.Save();
        }
    }
}

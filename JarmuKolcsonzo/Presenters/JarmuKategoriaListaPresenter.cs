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
    public class JarmuKategoriaListaPresenter
    {
        IDataGridList<jarmukategoria> view;
        JarmuKategoriaRepository repo = new JarmuKategoriaRepository();

        public JarmuKategoriaListaPresenter(IDataGridList<jarmukategoria> param)
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

        public void Add(jarmukategoria jk)
        {
            //Adatbázishoz hozzá fűzi
            repo.Insert(jk);
            //Hozzá fűzi a bindingListhez
            view.bindingList.Add(jk);            
        }

        public void Remove(int index)
        {
            var jk = view.bindingList.ElementAt(index);
            if (jk != null)
            {
                //Listán töröl
                view.bindingList.RemoveAt(index);
                //adatbázisból töröl
                if (jk.Id > 0)
                {
                    repo.Delete(jk.Id);
                }
                
            }
        }

        public void Modify(jarmukategoria jk) 
        {
            repo.Update(jk);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}

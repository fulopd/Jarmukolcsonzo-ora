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
        //Csak ellenőrzésre használjuk a repot.
        JarmuKategoriaRepository repo = new JarmuKategoriaRepository();
        IJarmuKategoriaView view;

        public JarmuKategoriaPresenter(IJarmuKategoriaView param)
        {
            view = param;
        }

        public void Save(jarmukategoria jk) 
        {
            view.errorMessage = null;
            if (repo.Exist(jk))
            {
                try
                {
                    //frrissítés  (adatbázis mentés még nem történik)
                    repo.Update(jk);
                }
                catch (Exception ex)
                {
                    view.errorMessage = ex.Message;
                }
            }
            else
            {
                try
                {
                    //új elemhozzáadása (adatbázis mentés még nem történik)
                    repo.Insert(jk);
                }
                catch (Exception ex)
                {
                    view.errorMessage = ex.Message;
                }
            }
        }
    }
}

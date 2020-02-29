using JarmuKolcsonzo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Repositories
{
    public class JarmuKategoriaRepository
    {
        private JKContext db = new JKContext();
        private int _totalItems;

        public BindingList<jarmukategoria> GetAllKategoria(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            // AsQueryable == Még nem fogja lefuttatni a C#, csak ToList esetén
            IQueryable<jarmukategoria> query = db.jarmukategoria.OrderBy(x => x.Id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                // KISCICA == kiscica
                search = search.ToLower();

                query = query.Where(x => 
                    x.kategoriaNev.ToLower().Contains(search)
                    );
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "Id":
                        query = ascending ?
                            query.OrderBy(x => x.Id) :
                            query.OrderByDescending(x => x.Id);
                        break;
                    case "kategoriaNev":
                        query = ascending ? 
                            query.OrderBy(x => x.kategoriaNev) :
                            query.OrderByDescending(x => x.kategoriaNev);
                        break;
                    default:
                        break;
                }
            }

            // Összes találat kiszámítása
            _totalItems = query.Count();

            // Oldaltördelés
            if (page + itemsPerPage > 0)
            {
                // Skip = ugrás
                // Take = Hátralévő elemek megjelenítése
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
            }

            return new BindingList<jarmukategoria>(query.ToList());

            /*
            // A memóriában eltárolja a táblát
            db.jarmukategoria.Load();
            // A helyi memóriában lévő adatokat átalakítja
            return db.jarmukategoria.Local.ToBindingList();
            */
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}

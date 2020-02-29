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
    public class JarmuKategoriaRepository : IDisposable //destruktort hoz létre
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

        public void Insert(jarmukategoria jk) 
        {
            //Ellenőrzi, hogy létezik e már az adott elem
            if (db.jarmukategoria.Any(x => x.kategoriaNev == jk.kategoriaNev))
            {
                //az egész metódust így belerakhatjuk egy try-chatch-be (presenterbe)
                throw new Exception("Már létezik ilyen jármű kategória");
            }
            else
            {
                db.jarmukategoria.Add(jk);
            }            
        }

        public void Delete(int id) 
        {
            var jk = db.jarmukategoria.Find(id);

            if (jk != null)
            {
                db.jarmukategoria.Remove(jk);
            }
        }

        public void Update(jarmukategoria param) 
        {
            var db_jk = db.jarmukategoria.Find(param.Id);
            if (db_jk != null)
            {
                //Az összes értéket frissiti a paraméter értékeivel
                db.Entry(db_jk).CurrentValues.SetValues(param);

                //Ha csak egy mezőt akarunk frissiteni
                //db_jk.kategoriaNev = param.kategoriaNev;
                //db.SaveChanges();
            }
        }
        
        public void Save()
        {
            db.SaveChanges();
        }

        public bool Exist(jarmukategoria jk) 
        {
            return db.jarmukategoria.Any(x => x.Id == jk.Id);
        }

        public void Dispose()
        {
            //Destruktor előtti műveletek (hogy usingal is tudjuk használni)
            Dispose(true);
            //Memória felszabadítása
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) 
        {
            if (disposing)
            {
                //Adatbáziskapcsolatot is zárja le
                db.Dispose();
            }
        }
    }
}

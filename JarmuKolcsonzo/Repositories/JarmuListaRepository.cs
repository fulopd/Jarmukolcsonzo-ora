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
    public class JarmuListaRepository
    {
        private JKContext db = new JKContext();
        private int _totalItems;

        public BindingList<jarmu> GetAllJarmu(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            // AsQueryable == Még nem fogja lefuttatni a C#, csak ToList esetén
            var query = db.jarmu.OrderBy(x => x.Id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                // KISCICA == kiscica
                search = search.ToLower();
                double fogyasztas;
                // Ha nem sikerül akkor a fogyasztas éréke 0
                double.TryParse(search, out fogyasztas);

                // ToString(), Convert és társai nem fognak működni 
                // mert SQL lekérdezés lesz belőle
                query = query.Where(x =>
                    x.rendszam.ToLower().Contains(search) ||
                    x.tipus.ToLower().Contains(search) ||
                    x.modell.ToLower().Contains(search)
                    //x.fogyasztas.Value.Equals(fogyasztas)
                    );

                // TODO: érték keresés
                if (fogyasztas > 0)
                {
                    query = query.Where(x => x.fogyasztas.Value.Equals(fogyasztas));
                }
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                // Több oszlop esetén feltételekkel kell megvizsálni a sortBy értékét
                switch (sortBy)
                {
                    case "rendszam":
                        query = ascending ? query.OrderBy(x => x.rendszam) : query.OrderByDescending(x => x.rendszam); 
                        break;
                    case "tipus":
                        query = ascending ? query.OrderBy(x => x.tipus) : query.OrderByDescending(x => x.tipus);
                        break;
                    case "modell":
                        query = ascending ? query.OrderBy(x => x.modell) : query.OrderByDescending(x => x.modell);
                        break;
                    case "fogyasztas":
                        query = ascending ? query.OrderBy(x => x.fogyasztas) : query.OrderByDescending(x => x.fogyasztas);
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

            return new BindingList<jarmu>(query.ToList());
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

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

        public BindingList<jarmukategoria> GetJarmuKategoriaList()
        {
            db.jarmukategoria.Load();
            return db.jarmukategoria.Local.ToBindingList();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}

﻿using JarmuKolcsonzo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.ViewInterfaces
{
    public interface IJarmuListaView : IDataGridList<jarmu>
    {
        List<jarmukategoria> jarmukategoriaList { get; set; }
    }
}

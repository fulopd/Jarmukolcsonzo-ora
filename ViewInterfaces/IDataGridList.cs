using JarmuKolcsonzo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.ViewInterfaces
{
    interface IDataGridList<T>
    {
        BindingList<T> bindingList { get; set; }
    }
}

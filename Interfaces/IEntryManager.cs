using SingleResponsibility.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Interfaces
{
    public interface IEntryManager<T>
    {
        void AddEntry(T entry);
        void RemoveEntry(int index);

    }
}

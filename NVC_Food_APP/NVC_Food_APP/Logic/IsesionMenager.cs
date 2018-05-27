using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVC_Food_APP.Logic
{
    public interface IsesionMenager
    {
        T Get<T>(string key);
        void Set<T>(string name, T value);
        void Abadon();
        void TryGet(string key);


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2TpParcialLabo
{
    public interface ISerializador<T> where T : class , new()
    {
        public bool Serializar(T obj);
        public T Deserializar();

    }
}

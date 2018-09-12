using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlingLuxury.CRUD
{
    public interface CRUD<T>
    {
        //Interfaces de tipo CRUD que nos permite crear,consultar,actualizar y eliminar elementos de una clase
        List<T> Listar(string query);
        void Insertar(T t);
        T Buscar(string query);
        void Actualizar(int id, T t);
        void CambiarEstado(int id, T t);
    }
}

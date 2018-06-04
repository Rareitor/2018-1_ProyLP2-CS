using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ManualBL
    {
        ManualDA accesoManual= new ManualDA();
        public void SubirArchivo(byte[] archivo)
        {
            accesoManual.cargarArchivo(archivo);
        }
        //public byte[] bajarArchivo()
        //{
        //    return accesoManual.bajarArchivo();
        //}
    }
}

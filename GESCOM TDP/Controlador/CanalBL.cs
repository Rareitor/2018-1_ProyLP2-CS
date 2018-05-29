using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CanalBL
    {
        CanalDA accesoCanal = new CanalDA();

        public BindingList<Canal> listarCanal()
        {
           return accesoCanal.ListarCanales();
        }
    }
}

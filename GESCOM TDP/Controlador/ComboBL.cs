using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ComboBL
    {
        private ComboDA accesoCombo = new ComboDA();

        public BindingList<Combo> listarCombos()
        {
            return accesoCombo.ListarCombos();
        }

    }
}

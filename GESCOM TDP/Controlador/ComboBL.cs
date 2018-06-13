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

        public BindingList<Combo> listarCombos(ref BindingList<String> listaComision, ref BindingList<String> listaBono, ref BindingList<String> listaPenalidad)
        {
            return accesoCombo.ListarCombos(ref listaComision, ref  listaBono, ref  listaPenalidad);
        }

        public string agregarComboProducto(ComboProducto cp)
        {
            return accesoCombo.agregarComboProducto(cp);

        }

        public List<ComboProducto> listarComboProductos(string fePeriodo)
        {
            return accesoCombo.listarComboProductos(fePeriodo);
        }

        public void cargarCombo(Combo c)
        {
            accesoCombo.cargarCombo(c);
        }

      
    }
}

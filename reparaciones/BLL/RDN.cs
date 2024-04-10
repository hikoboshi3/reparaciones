using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Modelos.Entidades;

namespace BLL
{
    public class RDN
    {
        ApiCaller api = new ApiCaller();
        public long CrearPresupuesto(Presupuesto _presupuesto)
        {
            long _IdPresupuesto = 0;
            decimal _totalRepuestos = 0;
            decimal _totalManoDeObra = 0;
            int _tiempo = 0;

            if (_presupuesto != null)
            {
                //Primero Guardamos el presupuesto, y obtenemos el Id
                _IdPresupuesto = api.IngresarPresupuesto(_presupuesto);
                _presupuesto.Id = _IdPresupuesto;

                // Cargamos los desperfectos...
                List<Desperfecto> desperfectos = _presupuesto.Fallas;

                foreach(Desperfecto _desperfecto in desperfectos)
                {
                    _totalManoDeObra = _totalManoDeObra + _desperfecto.ManoDeObra;
                    _tiempo = _tiempo + _desperfecto.Tiempo;

                    _desperfecto.idPresupuesto = _IdPresupuesto;
                    //cargamos el desperfecto
                    long _IdDesperfecto = api.IngresarDesperfecto(_desperfecto);

                    //Cargamos los repuestos...O sea, Insertamos en la tabla DesperfectosRepuestos
                    List<Repuesto> repuestos = _desperfecto.Repuestos;
                    foreach(Repuesto _repuesto in repuestos)
                    {
                        _totalRepuestos = _totalRepuestos + _repuesto.Precio;

                         DesperfectoRepuesto _desRep = new DesperfectoRepuesto();
                        _desRep.IdDesperfecto = _IdDesperfecto;
                        _desRep.IdRepuesto = _repuesto.IdRepuesto;
                        api.DesperfectoRepuesto(_desRep);
                    }
                }
            }

            if (_IdPresupuesto > 0)
            {
                _presupuesto.TotalManoDeObra = _totalManoDeObra;
                _presupuesto.TotalRepuestos = _totalRepuestos;

                // Para calcular el total, se computan:
                // 130 por cada día
                _presupuesto.TotalTiempo = _tiempo * 130;

                //Se le agrega un 10% de ganancia...
                _presupuesto.Total =
                    (_presupuesto.TotalManoDeObra +
                    _presupuesto.TotalRepuestos +
                    (Convert.ToDecimal(_presupuesto.TotalTiempo) * Convert.ToDecimal(1.1)));

                //Ahora que sabemos los costos, actualizamos los valores del presupuesto
                api.ActualizarPresupuesto(_presupuesto);
            }
            return _IdPresupuesto;
         }
    }

}
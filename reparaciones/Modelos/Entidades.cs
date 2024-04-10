using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Entidades
    {
        public partial class Vehiculo
        {
            public string marca { get; set; }
            public string modelo { get; set; }
            public string patente { get; set; }
        }

        public class Automovil : Vehiculo
        {
            public int tipo { get; set; }
            public int cantidad_puertas { get; set; }
        }

        public class Moto : Vehiculo
        {
            public string cilindrada { get; set; }
        }

        public class Presupuesto
        {
            public Int64 Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Email { get; set; }
            public long IdVehiculo { get; set; }
            public DateTime FechaIngreso { get; set; }
            public decimal TotalRepuestos { get; set; }
            public decimal TotalManoDeObra { get; set; }
            public decimal TotalTiempo { get; set; }
            public decimal Total { get; set; }
            public string Estado { get; set; }
            public List<Desperfecto> Fallas { get; set; }
        }

        public class Desperfecto
        {
            public long idPresupuesto { get; set; }
            public string Descripcion { get; set; }
            public decimal ManoDeObra { get; set; }
            public int Tiempo { get; set; }
            public List<Repuesto> Repuestos { get; set; }
        }

        public class Repuesto
        {
            public int IdRepuesto { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
        }

        public class DesperfectoRepuesto
        {
            public long IdDesperfecto { get; set; }
            public long IdRepuesto { get; set; }
        }

        public class Registros
        {
            public List<Dictionary<string, object>> Records { get; set; }
        }
   
        public enum TipoAutomovil
        {
            compacto = 1,
            sedan = 2,
            monovolumen = 3,
            utilitario = 4,
            lujo = 5
        }

    }
}

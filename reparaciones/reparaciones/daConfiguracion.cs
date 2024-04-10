
using Newtonsoft.Json;
using System.Reflection;

namespace reparaciones
{

    public class daConfiguracion
    {
        public Dictionary<string, tConfigDatabase> Databases { get; set; }
        public List<string> DatabasesProperties { get; set; }

        public enum typeConfig
        {
            All = 0,
            Databases = 1,
            Veraz = 2
        }

        public daConfiguracion(typeConfig _typeconfig)
        {
            try
            {
                switch (_typeconfig)
                {
                    case typeConfig.All:
                        LoadAll();
                        break;

                    case typeConfig.Databases:
                        LoadDatabases();
                        break;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private List<string> ReflexProperties(object _obj)
        {
            List<string> ret = new List<string>();
            foreach (PropertyInfo p in _obj.GetType().GetProperties()) { ret.Add(p.Name); }
            return ret;
        }
        private void LoadAll()
        {
            try
            {
                LoadDatabases();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void LoadDatabases()
        {
            DatabasesProperties = ReflexProperties(new tConfigDatabase());
            tConfigDatabase[]? tDatabase;
            string path = "./configDatabases.json";
            if (!File.Exists(path)) { throw new Exception("¡No se encontró " + path + "!"); }
            var json = File.ReadAllText(path);
            tDatabase = JsonConvert.DeserializeObject<tConfigDatabase[]>(json);
            Databases = new Dictionary<string, tConfigDatabase>();
            foreach (tConfigDatabase obj in tDatabase) { Databases.Add(obj.key, obj); }
        }

        /*Define all config files structures*/
        /*must be modified or extended with each implementation*/

        public class tConfigDatabase
        {
            public string? key { get; set; }
            public string? server { get; set; }
            public string? username { get; set; }
            public string? password { get; set; }
            public string? database { get; set; }
        }
    }
}

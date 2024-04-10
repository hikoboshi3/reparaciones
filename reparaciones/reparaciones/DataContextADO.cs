namespace reparaciones
{
    public class DataContextADO
    {
        public Dictionary<string, string> connString = new Dictionary<string, string>();

        public DataContextADO()
        {
            daConfiguracion _config = new daConfiguracion(daConfiguracion.typeConfig.All);
            connString.Clear();
            foreach (KeyValuePair<string, daConfiguracion.tConfigDatabase> _d in _config.Databases)
            {
                connString.Add(_d.Value.key, "database=" + _d.Value.database + ";encrypt=false;server=" + _d.Value.server + ";user=" + _d.Value.username + ";password=" + _d.Value.password + ";MultipleActiveResultSets=True");
                //  connString.Add(_d.Value.key, "database="gateway_debitos";encrypt=false;server="172.16.100.100";user="sldisql";password="Q665U74HtG4IEB97Sck6IEt_Frd2";MultipleActiveResultSets=True");
            }
        }
    }
}

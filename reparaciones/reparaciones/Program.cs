using reparaciones.DAL;
using static Modelos.Entidades;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

string result;

app.MapPost("/IngresarAutomovil", (Modelos.Entidades.Automovil auto) =>
{
    DAL dal = new DAL();
    
    result = dal.AltaAutomovil(auto).ToString();
    return result;
});

app.MapPost("/IngresarMoto", (Modelos.Entidades.Moto moto) =>
{
    DAL dal = new DAL();

    result = dal.AltaMoto(moto).ToString();
    return result;
});

app.MapPost("/GetRepuestos", () =>
{
    DAL dal = new DAL();

    return dal.GetRepuestos();
});

app.MapPost("/IngresarPresupuesto", (Presupuesto _presupuesto) =>
{
    DAL dal = new DAL();

    return dal.IngresarPresupuesto(_presupuesto);
});

app.MapPost("/IngresarDesperfecto", (Desperfecto _desperfecto) =>
{
    DAL dal = new DAL();

    return dal.IngresarDesperfecto(_desperfecto);
});

app.MapPost("/DesperfectoRepuesto", (DesperfectoRepuesto _desrep) =>
{
    DAL dal = new DAL();

    dal.DesperfectoRepuesto(_desrep.IdDesperfecto, _desrep.IdRepuesto);
    //return result;
    // MIRU luego le mandamos bool 
});

app.MapPost("/ActualizarPresupuesto", (Presupuesto _presupuesto) =>
{
    DAL dal = new DAL();
    dal.ActualizarPresupuesto(_presupuesto);
});


app.Run(null);


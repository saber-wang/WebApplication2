using Asp.Versioning;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddExceptionHandler(options => options.ExceptionHandler= async(http)=> {
    http.Response.StatusCode = 200;
    await http.Response.WriteAsync("111"); });
builder.Services.AddApiVersioning(option =>
{
    option.ReportApiVersions = true;
    option.AssumeDefaultVersionWhenUnspecified = true;
    option.DefaultApiVersion = new ApiVersion(1, 0);
}).AddMvc().AddApiExplorer(o =>
{
    o.GroupNameFormat = "'v'VVV";
    o.SubstituteApiVersionInUrl = true;
    o.DefaultApiVersion = new ApiVersion(1, 0);
});

var app = builder.Build();


app.UseExceptionHandler();

app.MapControllers();
app.Run();

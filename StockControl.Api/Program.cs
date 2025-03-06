
using Microsoft.EntityFrameworkCore;
using StockControl.Api.Data;

var builder = WebApplication.CreateBuilder(args);

var cnn = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.CustomSchemaIds(n => n.FullName);
});
builder.Services.AddTransient<Handler>();
builder.Services.AddDbContext<AppDBContext>( x =>
{
    x.UseSqlServer(cnn);
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/v1/category", (Request request, Handler handle) => handle.Handle(request)).Produces<Response>();

app.Run();


public class Response
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
}

public class Request
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
}
    public class Handler
    {
        public Response Handle(Request request)
        {
            var response = new Response
            {
                Id = request.Id,
                Title = request.Title,
            };

            return response;
        }
    }

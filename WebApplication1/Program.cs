using WebApplication1;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>();
builder.Services.AddGraphQLServer().AddQueryType<Query>();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapGraphQL();
//app.UseRouting();
//app.UseEndpoints(endpoints => endpoints.MapGraphQL());

app.Run();

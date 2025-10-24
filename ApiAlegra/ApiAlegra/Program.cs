using ApiAlegra.Service;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();


builder.Services.AddHttpClient<CustomFieldService>();
builder.Services.AddHttpClient<PersonaService>();
builder.Services.AddHttpClient<FacturaService>();
builder.Services.AddHttpClient<ItemsService>();




// Add Swagger/OpenAPI services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

/**
 * Vamos agregar estas instrucciones para que no me de problema
 * el proyecto al consumir los endpoint desde la aplicación Blazor.
 * Con esto, nos habilita las peticiones. Si yo quiero colocarle
 * más seguridad al sistema u otro tipo de seguridad... aquí podría
 * empezar a bloquear las IPs que me recibe, etc.
 */

app.UseCors(policyName => policyName
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(isOriginAllowed => true)
    .AllowCredentials());

app.Run();

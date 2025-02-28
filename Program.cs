using BatresA.C_2AllForOne.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<SayHelloServices>();
builder.Services.AddScoped<AskingQuestionsServices>();
builder.Services.AddScoped<Add2NumsServices>();
builder.Services.AddScoped<MadLibServices>();
builder.Services.AddScoped<OddOrEvenServices>();
builder.Services.AddScoped<ReverseItAlphanumericServices>();
builder.Services.AddScoped<ReverseItNumbersServices>();
builder.Services.AddScoped<Magic8BallServices>();
builder.Services.AddScoped<GuessItServices>();
builder.Services.AddScoped<RestaurantPickerServices>();
builder.Services.AddScoped<GreaterOrLessServices>();

builder.Services.AddCors(options =>{
    options.AddPolicy("AllowAll", 
    policy=> {
        policy.AllowAnyOrigin() //Allows any request from any origin 
              .AllowAnyMethod() //Allows any Http Request (GET, POST, PUT ETC...)
              .AllowAnyHeader();//Allows any headers
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowAll");

app.MapControllers();

app.Run();

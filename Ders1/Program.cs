var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddRazorPages();

var app = builder.Build();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");


//app.MapGet("/", () => {

//    var A = 10;
//    var B = 20;
//    var SUM =A+ B;
//    return "Toplam:" + SUM.ToString();

//});
app.UseStaticFiles();
app.Run();

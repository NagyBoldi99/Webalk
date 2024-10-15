using System.IO;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services:AddCors(options = {
    options.AddPolicy(nameof: MyAllowSpecificOrigins,policy => {policy.WithOrigins("*")});
});
var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);

app.MapGet("/log", (int rowsNum) => {
    return rowsNum
});

String line;
try
{
    StreamReader sr = new StreamReader("D:\programozás\github\Webalk\SimpleLogViewer\logviewer\nohup.out");
    line = sr.ReadLine();
    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    sr.Close();
    Console.ReadLine();
}
app.Run();

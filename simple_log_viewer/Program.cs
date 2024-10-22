var builder = WebApplication.CreateBuilder(args);

var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  => {
                          policy.WithOrigins("*");
                      });
});

var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);

// Test: http://localhost:5197/log?rows=10
app.MapGet("/log", (int rows) => {

       Console.WriteLine("Got log view request...");
       var textArray = new List<string>();
       try
        {
            string text = File.ReadAllText("nohup.out");
            string[] lines = text.Split("\n");
    
            foreach (string line in lines) {
                textArray.Add(line);
            }

            for (int i = 0, j = textArray.Count - 1; i < j; i++)
            {
                string temp = textArray[j];
                textArray.RemoveAt(j);
                textArray.Insert(i, temp);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }

        if (rows < textArray.Count) {
            textArray.RemoveRange(rows, (textArray.Count-rows)-1);
        }
        string result = string.Join("<br>", textArray);
        return result;
});

app.MapGet("/", () => "Hello World!");

app.Run();

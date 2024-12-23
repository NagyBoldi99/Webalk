var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options => {
    options.SerializerOptions.WriteIndented = true;
    options.SerializerOptions.IncludeFields = true;
});

var app = builder.Build();

app.MapPost("/", (Todo todo) => {
    if (todo is not null) {
        todo.Name = "Luke " + todo.Name;
        todo.IsComplete = !todo.IsComplete;
    }
    return todo;
});

app.Run();

class Todo {
    public string? Name { get; set; }
    public string? NameField;
    public bool IsComplete { get; set; }
}

/**

Test: make POST reequest with this json:

{
"name": "Skywalker",
"namefield": "example",
"iscomplese": true
}

*/

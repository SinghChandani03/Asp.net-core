var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//Middleware
//app.use(async (context, next) => {
//    await context.response.writeasync("hello");
//    await next(context);
//    await context.response.writeasync("hello chandani");
//});

//middleware 2
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Hello again");
//    await next(context);
//});

//app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllers();


//app.UseRouting();

//creating endpoints

//app.UseEndpoints(endpoints =>
//{
//    //add your endpoints here
//    endpoints.MapGet("map1", async (context) => {
//        await context.Response.WriteAsync("In Map 1");
//    });

//    endpoints.MapPost("map2", async (context) => {
//        await context.Response.WriteAsync("In Map 2");
//    });

//    endpoints.MapPut("map3", async (context) => {
//        await context.Response.WriteAsync("In Map 2");
//    });

//    endpoints.MapDelete("map4", async (context) => {
//        await context.Response.WriteAsync("In Map 2");
//    });
//});

app.Run();


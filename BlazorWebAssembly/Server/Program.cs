using Data;
using Data.Models.Interfaces;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

builder.Services.AddOptions<BlogApiJsonDirectAccessSetting>()
 .Configure(options =>
 {
     options.DataPath = @"..\..\..\Data\";
     options.BlogPostsFolder = "Blogposts";
     options.TagsFolder = "Tags";
     options.CategoriesFolder = "Categories";
 });
builder.Services.AddScoped<IBlogApi, BlogApiJsonDirectAccess>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

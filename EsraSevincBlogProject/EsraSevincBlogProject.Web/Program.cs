using EsraSevincBlogProject.Business.Abstract;
using EsraSevincBlogProject.Business.Concrete;
using EsraSevincBlogProject.Business.ValidationRules;
using EsraSevincBlogProject.DataAccess.Abstract;
using EsraSevincBlogProject.DataAccess.Concrete;
using EsraSevincBlogProject.Entities.Entities;
using FluentValidation;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IBlogService, BlogManager>();
builder.Services.AddSingleton<IBlogDal, BlogDal>();

builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<ICategoryDal, CategoryDal>();

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddScoped<IValidator<Category>, CategoryValidation>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
});
	

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

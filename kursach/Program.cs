using Blazored.LocalStorage;
using kursach;
using kursach.DBManager;
using kursach.DBManager.Models.ItemsModels;
using kursach.DBManager.Models.SellsModels;
using kursach.DBManager.Models.SubsidiaryModels;
using kursach.DBManager.Models.SupplyModels;
using kursach.DBManager.Models.UserModels;
using kursach.utils;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Tewr.Blazor.FileReader;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddTransient<UserController>();
        builder.Services.AddTransient<SupplyController>();
        builder.Services.AddTransient<ItemsController>();
        builder.Services.AddTransient<SellsController>();
        builder.Services.AddTransient<SubsidiaryController>();

        builder.Services.AddSingleton<ItemsInCartController>();

        builder.Services.AddBlazoredLocalStorage();
        // auth conn
        builder.Services.AddOptions();
        builder.Services.AddAuthenticationCore();
        builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

        //database
        builder.Services.AddDbContext<DBManager>(options =>
          options.UseMySql(builder.Configuration["ConnectionStrings:DefaultConnection"], new MySqlServerVersion(new Version(8, 0, 25))));

        //filereader
        builder.Services.AddFileReaderService();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        else
        {
            app.UseDeveloperExceptionPage();
        }

        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;

            var context = services.GetRequiredService<DBManager>();
            context.Database.EnsureCreated();
            // DbInitializer.Initialize(context);
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();
        app.MapBlazorHub();
        app.MapFallbackToPage("/_host");

        app.Run();
    }
}
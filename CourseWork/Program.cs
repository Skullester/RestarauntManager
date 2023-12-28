using System.Runtime.InteropServices.Marshalling;
using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;
namespace CourseWork;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new ManagerForm());
        //  CreateStorage();
    }

    private static void CreateStorage()
    {
        ApplicationContext app = new();
        app.Products.Add(new Sushi("Лосось", 50));
        app.Products.Add(new Sushi("Тунец", 60));
        app.Products.Add(new Sushi("Угорь", 80));
        app.Products.Add(new Sushi("Креветки", 30));
        app.Products.Add(new Sushi("Сливочный сыр", 20));
        app.SaveChanges();
    }
}
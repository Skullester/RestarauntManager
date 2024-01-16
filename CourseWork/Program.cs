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
    }
}
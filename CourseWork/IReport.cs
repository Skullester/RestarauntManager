using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseWork;

interface IReport
{
    List<Product> Report();
}
class ProfitReport : IReport
{
    private ApplicationContext context;
    public ProfitReport(ApplicationContext context)
    {
        this.context = context;
    }

    public List<Product> Report()
    {
        return null;
    }

    public override string ToString()
    {
        return "Прибыль";
    }
}
class BestProductReport : IReport
{
    private ApplicationContext context;
    public BestProductReport(ApplicationContext context)
    {
        this.context = context;
    }

    public List<Product> Report()
    {
        return context.Menu.Include(x => x.Category).OrderByDescending(x => x.OrderCount).Take(5).ToList();
    }

    public override string ToString()
    {
        return "Лучший товар";
    }
}

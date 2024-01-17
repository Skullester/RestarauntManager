using ManagerApp;
using Microsoft.EntityFrameworkCore;

namespace CourseWork;

interface IReport
{
    void Report(ReportForm reportForm);
}
class ProfitReport : IReport
{
    private ApplicationContext context;
    public ProfitReport(ApplicationContext context)
    {
        this.context = context;
    }

    public void Report(ReportForm reportForm)
    {
        reportForm.label1.Text = "Отчет за 30 дней";
        var query = from rest in context.Restarauntss
                    join mp2 in context.Restarauntss on rest.Id equals mp2.Id
                    select new
                    {
                        Ресторан = rest.Name,
                        Прибыль = rest.Profit,
                        Количество_заказов = rest.OrderCount
                    };
        var result = query.ToList();
        reportForm.dataGridView1.DataSource = result;
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
    public void Report(ReportForm reportForm)
    {
        var list = context.Menu
                          .Include(x => x.Category)
                          .OrderByDescending(x => x.OrderCount)
                          .Take(8)
                          .ToList();
        var query = from product in list
                    join category in context.Categories on product.CategoryId equals category.Id
                    select new
                    {
                        Название = product.Name,
                        Цена = product.Cost + "₽",
                        Категория = category.Name,
                        Количество_Покупок = product.OrderCount
                    };
        reportForm.dataGridView1.DataSource = query.ToList();
    }

    public override string ToString()
    {
        return "Лучшие товары";
    }
}
class ClientReport : IReport
{
    private ApplicationContext context;
    public ClientReport(ApplicationContext context)
    {
        this.context = context;
    }
    public void Report(ReportForm rf)
    {
        rf.label1.Text = "Отчет по клиентам";
        var query = from rest in context.Restarauntss
                    join mp2 in context.Restarauntss on rest.Id equals mp2.Id
                    select new
                    {
                        Ресторан = rest.Name,
                        Количество_Клиентов = rest.ClientCount,
                    };
        var result = query.ToList();
        rf.dataGridView1.DataSource = result;
    }
    public override string ToString()
    {
        return "Клиенты";
    }
}
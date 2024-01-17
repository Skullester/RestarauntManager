using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ManagerApp;

namespace CourseWork;
public partial class ManagerForm : Form
{
    private ApplicationContext context = new();
    private List<Order> orderList = null!;
    private List<Ingredient> sushiList = null!;
    private List<User> consumerList = null!;
    private IReport report = null!;
    private bool isSorted;
    List<Order> ordered;
    List<Ingredient> ingrediented;
    public ManagerForm()
    {
        InitializeComponent();
        Initialize();
        InitializeDate();
        InitializeEntities();
    }
    private void Initialize()
    {

        comboBoxReport.Items.AddRange([new ProfitReport(context), new BestProductReport(context), new ClientReport(context)]);
        comboBoxReport.SelectedValueChanged += OnReportChanged;
        foreach (var item in Controls)
            if (item is ComboBox cb) cb.SelectedIndex = 0;
    }
    private void OnReportChanged(object? obj, EventArgs e)
    {
        report = (comboBoxReport.SelectedItem as IReport)!;
    }
    protected override void OnFormClosing(FormClosingEventArgs eventArgs)
    {
        var result = MessageBox.Show("Действительно закрыть?", "Close?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result != DialogResult.Yes)
            eventArgs.Cancel = true;
    }
    private void InitializeDate()
    {
        dateLabel.Text = DateTime.Now.ToShortDateString();
    }
    private void InitializeEntities()
    {
        orderList = context.Orders
            .ToList();
        sushiList = context.Ingredients.ToList();
        consumerList = context.Users.ToList();
        foreach (var item in Controls)
        {
            if (item is DataGridView dbv)
                dbv.ReadOnly = true;
        }
        ordered = orderList;
        ingrediented = sushiList;

    }
    private void InitializeTable()
    {
        var query = from order in context.Orders
                    join user in context.Users on order.UserId equals user.Id
                    select new
                    {
                        Дата = order.Date,
                        Клиент = user.Name,
                        Товар = order.ProductName,
                        Цена = order.Cost + "₽",
                        Ресторан = order.Restaraunt,
                        Телефон = "+" + user.Number
                    };
        var result = query.ToList();
        orderTable.DataSource = result;
        var query2 = from ingrdient in context.Ingredients
                     join ingrdeient in context.Ingredients on ingrdient.Id equals ingrdeient.Id
                     select new
                     {
                         Ингредиент = ingrdeient.Name,
                         Количество = ingrdeient.Count
                     };
        var result2 = query2.ToList();
        storageTable.DataSource = result2;
        var query3 = from user in context.Users
                     join user2 in context.Users on user.Id equals user2.Id
                     select new
                     {
                         Клиент = user.Name,
                         Количество_Заказов = user2.CountOrders,
                         Телефон = "+" + user.Number
                     };
        var result3 = query3.ToList();
        consumersTable.DataSource = result3;
    }
    private void OpenTable(object sender, EventArgs e)
    {
        InitializeTable();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        timeLabel.Text = DateTime.Now.ToLongTimeString();
    }

    private void Restart(object sender, EventArgs e)
    {
        context = new();
        InitializeEntities();
        InitializeTable();

    }

    private void Find(object sender, EventArgs e)
    {
        var selector = (sender as TextBox)!.Text;
        if (selector == string.Empty)
        {
            var query3 = from ingrdient in ingrediented
                         join ingrdeient in context.Ingredients on ingrdient.Id equals ingrdeient.Id
                         select new
                         {
                             Ингредиент = ingrdeient.Name,
                             Количество = ingrdeient.Count
                         };
            storageTable.DataSource = query3.ToList();
            return;
        }
        StringBuilder sb = new();
        for (int i = 0; i < selector.Length; i++)
        {
            var sym = selector[i];
            if (i > 0)
                sb.Append(char.ToLower(sym));
            else sb.Append(char.ToUpper(sym));
        }
        selector = sb.ToString();
        var selectedList = context.Ingredients
            .Where(x => x.Name
                .StartsWith(selector))
            .ToList();
        var query2 = from ingrdient in selectedList
                     join ingrdeient in context.Ingredients on ingrdient.Id equals ingrdeient.Id
                     select new
                     {
                         Ингредиент = ingrdeient.Name,
                         Количество = ingrdeient.Count
                     };
        var result2 = query2.ToList();
        storageTable.DataSource = result2;
    }

    private void Process(object sender, EventArgs e)
    {
        if (context.Orders.Local.Count == 0)
        {
            MessageBox.Show("Все заказы уже обработаны");
            return;
        }
        context.Orders.Remove(ordered[0]);
        ordered.Remove(ordered[0]);
        context.SaveChanges();
        var query = from order in ordered
                    join user in context.Users on order.UserId equals user.Id
                    select new
                    {
                        Дата = order.Date,
                        Клиент = user.Name,
                        Товар = order.ProductName,
                        Цена = order.Cost + "P",
                        Ресторан = order.Restaraunt,
                        Телефон = "+" + user.Number
                    };
        var result = query.ToList();
        orderTable.DataSource = result;
    }

    private void Sort(object sender, EventArgs e)
    {
        isSorted = !isSorted;
        if (isSorted)
            ordered = context.Orders.OrderBy(x => x.Cost).ToList();
        else
            ordered = context.Orders.OrderByDescending(x => x.Cost).ToList();
        SendQuery(ordered);
    }
    private void SendQuery(List<Order> orders)
    {
        var query = from order in orders
                    join user in context.Users on order.UserId equals user.Id
                    select new
                    {
                        Дата = order.Date,
                        Клиент = user.Name,
                        Товар = order.ProductName,
                        Цена = order.Cost + "₽",
                        Ресторан = order.Restaraunt,
                        Телефон = "+" + user.Number
                    };
        orderTable.DataSource = query.ToList();
    }

    private void MakeReport(object sender, EventArgs e)
    {
        var reportForm = new ReportForm();

        report.Report(reportForm);
        reportForm.ShowDialog();
    }
}

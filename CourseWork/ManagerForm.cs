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
    public ManagerForm()
    {
        InitializeComponent();
        Initialize();
        InitializeDate();
        InitializeEntities();
    }
    private void Initialize()
    {
        comboBoxReport.Items.AddRange([new ProfitReport(), new ProfitReport()]);
        comboBoxReport.SelectedValueChanged += OnReportChanged;
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
            .Include(x => x.User)
            .ToList();
        sushiList = context.Products.ToList();
        consumerList = context.Users.ToList();
        foreach (var item in Controls)
        {
            if (item is DataGridView dbv)
                dbv.ReadOnly = true;
        }
    }
    private void InitializeTable()
    {
        orderTable.DataSource = orderList;
        storageTable.DataSource = sushiList;
        consumersTable.DataSource = consumerList;
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
            storageTable.DataSource = sushiList;
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
        var selectedList = context.Products
            .Where(x => x.Name
                .StartsWith(selector))
            .ToList();
        storageTable.DataSource = selectedList;
    }

    private void Process(object sender, EventArgs e)
    {
        if (context.Orders.Local.Count == 0)
        {
            MessageBox.Show("Все заказы уже обработаны");
            return;
        }
        context.Orders.Remove(orderList[0]);
        context.SaveChanges();
        orderList = context.Orders.ToList();
        orderTable.DataSource = orderList;
    }

    private void Sort(object sender, EventArgs e)
    {
        isSorted = !isSorted;
        if (isSorted)
            orderTable.DataSource = context.Orders.OrderBy(x => x.Cost).ToList();
        else orderTable.DataSource = context.Orders.OrderByDescending(x => x.Cost).ToList();
    }

    private void MakeReport(object sender, EventArgs e)
    {
        report.Report();
        new ReportForm().ShowDialog();
    }
}

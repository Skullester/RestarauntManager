using CourseWork.Entities;
using ApplicationContext = CourseWork.ApplicationContext;

namespace UserApp;

public partial class OrderForm : Form
{
    private static readonly ApplicationContext context = new();
    private readonly string sushiName;
    private readonly PictureBox pictureBox;
    private readonly string productName;
    private readonly int cost;
    private Restaraunt restaraunt;
    public OrderForm(string name, PictureBox picture, string productName, int cost)
    {
        this.cost = cost;
        this.productName = productName;
        MaximizeBox = false;
        this.pictureBox = picture;
        this.sushiName = name;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        InitializeComponent();
        Initialize();
    }
    private void Initialize()
    {

        pictureBox1.Image = pictureBox.Image;
        sushiLabel.Text = sushiName;
        labelCost.Text = "Цена: " + cost.ToString() + "₽";
        comboBox1.Items.AddRange([ApplicationContext.Restaraunts[0], ApplicationContext.Restaraunts[1]]);
        comboBox1.SelectedValueChanged += OnReportChanged;
        foreach (var item in Controls)
            if (item is ComboBox cb) cb.SelectedIndex = 0;
    }
    private void OnReportChanged(object? obj, EventArgs e)
    {
        restaraunt = (comboBox1.SelectedItem as Restaraunt)!;
    }
    private void BuyProduct(object sender, EventArgs e)
    {
        var name = nameTextBox.Text.Trim();
        var number = numberTextBox.Text.Trim();
        if (number.Length == 0)
        {
            MessageBox.Show("Введите номер телефона, чтобы продолжить", "Ошибка");
            return;
        }
        var selectedConsumer = context.Users.Where(x => x.Number == number).FirstOrDefault();
        bool isNull = selectedConsumer == null;
        if (isNull && name.Length == 0)
        {
            MessageBox.Show("Ваш телефон не найден, пожалуйста, введите имя, чтобы продолжить", "Ошибка");
            return;
        }
        if (isNull)
        {
            selectedConsumer = new User(number, name);
            restaraunt.ClientCount++;
        }
        selectedConsumer!.CountOrders++;
        Order order = new(restaraunt.Id, selectedConsumer.Id, productName, cost) { User = selectedConsumer };
        MessageBox.Show("Спасибо за заказ! Ожидайте звонка!");
        Product product = null!;
        foreach (var item in ApplicationContext.Products)
            if (item.Name == productName)
            {
                product = item;
                item.OrderCount++;
            }
        context.Orders.Add(order);
        restaraunt.Profit += cost;
        restaraunt.OrderCount++;
        context.Menu.Update(product);
        context.Restarauntss.Update(restaraunt);
        context.SaveChanges();
        this.Hide();
    }
}

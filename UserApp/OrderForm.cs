﻿using CourseWork.Entities;
using ApplicationContext = CourseWork.ApplicationContext;

namespace UserApp;

public partial class OrderForm : Form
{
    private static readonly ApplicationContext context = new();
    private readonly string sushiName;
    private readonly PictureBox pictureBox;
    private readonly string productName;
    private readonly decimal cost;
    public OrderForm(string name, PictureBox picture, string productName, decimal cost)
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
        var selectorConsumer = context.Users.Where(x => x.Number == number).FirstOrDefault();
        bool isNull = selectorConsumer == null;
        if (isNull && name.Length == 0)
        {
            MessageBox.Show("Ваш телефон не найден, пожалуйста, введите имя, чтобы продолжить", "Ошибка");
            return;
        }
        Order order;
        if (!isNull)
        {
            selectorConsumer!.CountOrders++;
            order = new Order(selectorConsumer, productName, cost);
        }
        else order = new Order(new Consumer(number, name), productName, cost);
        context.Orders.Add(order);
        context.SaveChanges();
        MessageBox.Show("Спасибо за заказ! Ожидайте звонка!");
        this.Hide();
    }
}

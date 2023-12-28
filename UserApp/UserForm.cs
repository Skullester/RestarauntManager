namespace UserApp;

public partial class UserForm : Form
{
    private List<Category> categories = new();
    public UserForm()
    {
        InitializeComponent();
        InitializeDate();
        InitializeCategories();
    }

    protected override void OnFormClosing(FormClosingEventArgs eventArgs)
    {
        var result = MessageBox.Show("������������� �������?", "Close?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result != DialogResult.Yes)
            eventArgs.Cancel = true;
    }
    private void InitializeCategories()
    {
        categories.Add(new Category([@"..\Images\hot1.png", @"..\Images\hot2.png", @"..\Images\hot3.png", @"..\Images\hot4.png"], ["���������� ����������", "���������� �����", "����� ��� ���", "�������"], 300));
        categories.Add(new Category([@"..\Images\class1.png", @"..\Images\class2.png", @"..\Images\class3.png", @"..\Images\class4.png"], ["���� � ������� ������", "���� � ��������� ������", "���� � ������� � ������� ", "���� � �������"], 200));
        categories.Add(new Category([@"..\Images\Lux1.png", @"..\Images\Lux2.png", @"..\Images\Lux3.png", @"..\Images\Lux4.png"], ["����� ����", "����� ����", "��������� ����", "���������� ����"], 400));
        categories.Add(new Category([@"..\Images\Gunkan.png", @"..\Images\Gunkan2.png", @"..\Images\Gunkan3.png", @"..\Images\Sushi.png"], ["������ � ������ � ������������", "������ � ������ ������", "������ � ������� ������ � ������������", "���� � �������"], 500));
    }
    private void InitializeDate()
    {
        dateLabel.Text = DateTime.Now.ToShortDateString();
    }
    private void timer1_Tick(object sender, EventArgs e)
    {
        timeLabel.Text = DateTime.Now.ToLongTimeString();
    }
    private void ShowHot(object sender, EventArgs e)
    {
        categories[0].Show();
    }
    private void ShowClassic(object sender, EventArgs e)
    {
        categories[1].Show();
    }
    private void ShowLux(object sender, EventArgs e)
    {
        categories[2].Show();
    }
    private void ShowSushi(object sender, EventArgs e)
    {
        categories[3].Show();
    }
}

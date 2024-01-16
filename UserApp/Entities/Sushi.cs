namespace UserApp;

public class Sushi
{
    private readonly PictureBox pictureBox;
    private readonly string imageUrl;
    private readonly string name;
    private readonly int cost;
    public Sushi(PictureBox picture, string pictureURL, string name, int cost)
    {
        this.name = name;
        pictureBox = picture;
        imageUrl = pictureURL;
        pictureBox.Click += MakeOrder;
        this.cost = cost;
    }
    public void SetImage()
    {
        pictureBox.Size = new Size(1500, 800);
        pictureBox.Cursor = Cursors.Hand;
        pictureBox.Image = Image.FromFile(imageUrl);
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    public void MakeOrder(object? sender, EventArgs e)
    {
        var newForm = new OrderForm(name, pictureBox, this.name, cost);
        newForm.ShowDialog();
    }
}

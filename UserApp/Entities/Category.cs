using System.Windows.Forms;

namespace UserApp;
class Category
{
    private List<Sushi> sushis;
    private const int COUNT_OF_PRODUCTS = 4;
    private readonly List<PictureBox> pictureBoxes = new();
    public Category(string[] urls, string[] names, int cost)
    {
        sushis = new List<Sushi>();
        for (int i = 0; i < COUNT_OF_PRODUCTS; i++)
        {
            var picture = new PictureBox();
            pictureBoxes.Add(picture);
            sushis.Add(new Sushi(picture, urls[i], names[i], cost));
        }
    }
    private void AddControls()
    {
        UserForm.TableLayoutPanel1.Controls.Clear();
        foreach (var item in pictureBoxes)
        {
            UserForm.TableLayoutPanel1.Controls.Add(item);
        }
    }
    public void Show()
    {
        AddControls();
        foreach (var s in sushis)
            s.SetImage();

    }
}
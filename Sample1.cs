

using System.Drawing;
using System.Windows.Forms;

class Sample1 
{
    public static void Main() { 
        Form fm = new Form();
        fm.Text = "Hello";
        fm.Width = 100; fm.Height = 800;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("C:\\DevOnNCD\\csharp\\Sample1\\Sample1\\lion.jpeg");
        pb.Left = 0;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Width = 170;
        lb.Text = "사자입니다.";

        if (pb.Left >= 150)
        {
            lb.Text = "사자는 동쪽에 있습니다.";
        }

        pb.Parent = fm;
        lb.Parent = fm;

        Application.Run(fm);
    }
}
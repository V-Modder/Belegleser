using ControlManager;
using System;
using System.Drawing;
using System.Windows.Forms;

class SizeablePictureBox : PictureBox
{
    private int borderSize = 3;
    private Color borderColor;
    private string name;

    public SizeablePictureBox(Color color)
    {
        this.borderColor = color;
        this.SizeChanged += SizeablePictureBox_SizeChanged;
        this.DrawBorder();
        ControlMoverOrResizer.Init(this);
    }

    private void SizeablePictureBox_SizeChanged(object sender, EventArgs e)
    {
        this.DrawBorder();
    }

    public void DrawBorder()
    {
        Bitmap map = new Bitmap(this.Width, this.Height);
        Graphics g = Graphics.FromImage(map);
        g.FillRectangle(Brushes.Transparent, 0, 0, this.Width, this.Height);
        Pen pen = new Pen(this.borderColor, this.borderSize);
        g.DrawRectangle(pen, this.borderSize, this.borderSize, this.Width - (this.borderSize * 2), this.Height - (this.borderSize * 2));
        g.Dispose();
        this.BackgroundImage = map;
    }

    public override string ToString()
    {
        return this.name;
    }

    public new string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Color BorderColor
    {
        get { return this.borderColor; }
        set { this.borderColor = value; }
    }
}
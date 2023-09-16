using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundButton : Button
{
    public RoundButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.Size = new Size(100, 100);
        this.BackColor = Color.White;
        this.ForeColor = Color.Black;
        this.Text = "Round Button";
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        GraphicsPath path = new GraphicsPath();
        path.AddEllipse(0, 0, this.Width, this.Height);

        this.Region = new Region(path);
    }
}

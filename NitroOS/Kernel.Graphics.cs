using Cosmos.System.Graphics;
using System.Drawing;

namespace NitroOS
{
    public partial class Kernel
    {
        Canvas canvas;

        void InicialitzarGrafics()
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(640, 480, ColorDepth.ColorDepth32));
            canvas.Clear(Color.FromArgb(13, 27, 42));
            canvas.Display();
        }

        void MostrarBenvingudaGrafica()
        {
            canvas.Clear(Color.FromArgb(13, 27, 42));

            // Marc superior
            canvas.DrawRectangle(Color.FromArgb(26, 115, 232), 40, 40, 560, 380);
            canvas.DrawRectangle(Color.FromArgb(0, 196, 204), 50, 50, 540, 360);

            // Logo simple amb formes
            canvas.DrawRectangle(Color.FromArgb(26, 115, 232), 260, 90, 120, 80);
            canvas.DrawLine(Color.White, 280, 150, 320, 110);
            canvas.DrawLine(Color.White, 320, 110, 360, 150);
            canvas.DrawLine(Color.FromArgb(0, 196, 204), 280, 150, 360, 150);

            // Text
            canvas.DrawString("NitroOS", PCScreenFont.Default, new SolidBrush(Color.White), 270, 200);
            canvas.DrawString("cosmoOS v1.6 - Graphic Mode", PCScreenFont.Default, new SolidBrush(Color.FromArgb(0, 196, 204)), 215, 230);
            canvas.DrawString("Desenvolupament per Eduardo, Noha i Marc", PCScreenFont.Default, new SolidBrush(Color.LightGray), 170, 260);
            canvas.DrawString("Prem Enter per entrar a la shell", PCScreenFont.Default, new SolidBrush(Color.FromArgb(20, 212, 107)), 190, 330);

            canvas.Display();
        }
    }
}
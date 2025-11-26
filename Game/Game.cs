using Excubo.Blazor.Canvas;
using Excubo.Blazor.Canvas.Contexts;
using Microsoft.JSInterop;
using GeograficWars.Game;
using System.Drawing;

namespace GeograficWars.Game
{
    public class Game
    {
        private readonly IJSRuntime _js;
        public double Width { get; private set; }
        public double Height { get; private set; }

        private Context2D? ctx;
        private Canvas? canvasRef;

        public Game(IJSRuntime js)
        {
            _js = js;
        }

        public async Task InitializeAsync(Canvas canvas, WindowSize size)
        {
            canvasRef = canvas;

            Width = size.Width;
            Height = size.Height;

            ctx = await canvasRef.GetContext2DAsync();
        }

        public async Task DrawAsync()
        {
            if (ctx == null)
            {
                return;
            }

            await using var batch = ctx.CreateBatch();

            await batch.FillStyleAsync("lightblue");
            await batch.FillRectAsync(0, 0, Width, Height);
        }
    }
}

using Excubo.Blazor.Canvas.Contexts;
using Excubo.Blazor.Canvas;
using GeograficWars.Game;
using System.Drawing;

namespace GeograficWars.Rendering
{
    public class GameRenderer
    {

        private Context2D? _ctx;
        private Canvas? _canvasRef;

        private CountryManager _countryManager;

        public double Width { get; private set; }
        public double Height { get; private set; }

        public async Task InitializeAsync(Canvas canvas, WindowSize size, CountryManager countryManager)
        {
            _countryManager = countryManager;

            _canvasRef = canvas;

            Width = size.Width;
            Height = size.Height;

            _ctx = await _canvasRef.GetContext2DAsync();
        }

        public async Task Render()
        {

            if (_ctx == null)
            {
                return;
            }

            await using Batch2D batch = _ctx.CreateBatch();

            await RenderBackground(batch);
            await RenderCountries(batch);
        }

        private async Task RenderBackground(Batch2D batch)
        {
            await batch.FillStyleAsync("dodgerblue");
            await batch.FillRectAsync(0, 0, Width, Height);
        }

        private async Task RenderCountries(Batch2D batch)
        {

            await batch.SaveAsync();
            await batch.ScaleAsync(0.25, 0.25);

            await batch.DrawImageAsync("brazil", 0, 0);
            await batch.RestoreAsync();
        }

    }
}
using Excubo.Blazor.Canvas.Contexts;
using Excubo.Blazor.Canvas;
using GeograficWars.Game;
using System.Drawing;
using Microsoft.AspNetCore.Components.Web;

namespace GeograficWars.Rendering
{
    public class GameRenderer
    {

        private Context2D? _ctx;
        private Canvas? _canvasRef;

        private CountriesManager _countryManager;

        public double Width { get; private set; }
        public double Height { get; private set; }

        public async Task InitializeAsync(Canvas canvas, WindowSize size, CountriesManager countryManager)
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

            foreach (var country in _countryManager.GetCountries())
            {
                await DrawCountry(batch, country.GetCountryData());
            }
        }

        private async Task DrawCountry(Batch2D batch, CountryData country)
        {
            await batch.SaveAsync();
            await batch.ScaleAsync(country.Scale, country.Scale);

            await batch.DrawImageAsync(country.CountryId, Width * country.X, Height * country.Y);
            await batch.RestoreAsync();
        }
    }
}
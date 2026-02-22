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

        public double Width { get; private set; }
        public double Height { get; private set; }

        public async Task InitializeAsync(Canvas canvas, WindowSize size)
        {
            _canvasRef = canvas;

            Width = size.Width;
            Height = size.Height;

            _ctx = await _canvasRef.GetContext2DAsync();
        }

        public void UpdateCanvasSize(WindowSize size)
        {
            Width = size.Width;
            Height = size.Height;
        }

        public async Task Render(Room room)
        {

            if (_ctx == null)
            {
                return;
            }

            await using Batch2D batch = _ctx.CreateBatch();

            await RenderBackground(batch);
            await RenderCountries(batch, room.GetCountriesManager().GetCountries(), 1);

        }

        private async Task RenderBackground(Batch2D batch)
        {
            await batch.FillStyleAsync("dodgerblue");
            await batch.FillRectAsync(0, 0, Width, Height);
        }

        private async Task RenderCountries(Batch2D batch, List<Country> countries, double scale)
        {

            foreach (var country in countries)
            {
                await DrawCountry(batch, country.GetCountryData(), scale);
            }
        }

        private async Task DrawCountry(Batch2D batch, CountryData countryData, double scale)
        {
            await batch.FillStyleAsync("green");

            foreach (var countryChunk in countryData.ChunksData)
            { 
                await batch.FillRectAsync(
                    (Width * (countryData.X + countryChunk.X)) * scale, 
                    (Height * (countryData.Y + countryChunk.Y)) * scale, 
                    (Width * countryChunk.W) * scale, 
                    (Height * countryChunk.H) * scale
                );
            }
        }
    }
}
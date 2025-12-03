using Excubo.Blazor.Canvas;
using Excubo.Blazor.Canvas.Contexts;
using Microsoft.JSInterop;
using GeograficWars.Game;
using GeograficWars.Rendering;
using System.Drawing;
using System.Text.Json;

namespace GeograficWars.Game
{
    public class Game
    {

        private CountryManager countryManager;
        private GameRenderer renderer;

        public Game()
        {
            countryManager = new CountryManager();
            renderer = new GameRenderer();
        }

        public async Task InitializeAsync(Canvas canvas, WindowSize size)
        {
            countryManager.LoadCountries();

            await renderer.InitializeAsync(canvas, size, countryManager);
        }

        public async Task Render()
        {
            await renderer.Render();
        }
    }
}

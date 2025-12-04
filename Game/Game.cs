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

        private CountryManager _countryManager;
        private GameRenderer _renderer;

        public Game(CountryManager countryManager)
        {
            _countryManager = countryManager;
            _renderer = new GameRenderer();
        }

        public async Task InitializeAsync(Canvas canvas, WindowSize size)
        {
            await _renderer.InitializeAsync(canvas, size, _countryManager);
        }

        public async Task Render()
        {
            await _renderer.Render();
        }
    }
}

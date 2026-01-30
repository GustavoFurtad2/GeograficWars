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

        private GameRenderer _renderer;

        public Game()
        {
            _renderer = new GameRenderer();
        }

        public async Task InitializeAsync(Canvas canvas, WindowSize size)
        {
            await _renderer.InitializeAsync(canvas, size);
        }

        public async Task Render(List<Country> countries)
        {
            await _renderer.Render(countries);
        }
    }
}

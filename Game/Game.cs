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

        private GameState _gameState;
        private GameRenderer _renderer;
        private CountriesManager _countriesManager;

        public Game()
        {
            _gameState = new GameState();
            _renderer = new GameRenderer();
            _countriesManager = new CountriesManager(_gameState);

            _countriesManager.LoadCountries();
        }

        public async Task InitializeAsync(Canvas canvas, WindowSize size)
        {
            await _renderer.InitializeAsync(canvas, size, _countriesManager);
        }

        public CountriesManager GetCountriesManager()
        {
            return _countriesManager;
        }

        public async Task Render()
        {
            await _renderer.Render();
        }
    }
}

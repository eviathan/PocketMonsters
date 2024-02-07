using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PocketMonsters.Engine;

public class PocketMonstersGame : Game
{
    private readonly GameManager _gameManager;
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public PocketMonstersGame()
    {
        _gameManager = new GameManager();
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        _gameManager.HandleInitialisation();
        base.Initialize();
    }

    protected override void LoadContent()
    {
        // TODO: Deal with sprite batching for multiple sprite batchers
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        _gameManager.HandleLoading(_spriteBatch);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        _gameManager.HandleUpdate(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _gameManager.HandleDrawing(Content, gameTime);

        base.Draw(gameTime);
    }
}

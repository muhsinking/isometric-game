using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace MonoGameTest1
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
		IsometricMap map;
		SpriteClass turtle;
		int windowWidth = 1400;
		int windowHeight = 800;

		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			graphics.PreferredBackBufferWidth = windowWidth;  // set this value to the desired width of your window
			graphics.PreferredBackBufferHeight = windowHeight;   // set this value to the desired height of your window
			graphics.ApplyChanges();
		}

		protected override void Initialize()
		{
			base.Initialize();
		}

		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch(GraphicsDevice);
			map = new IsometricMap(this.Content, GraphicsDevice, new Vector2(windowWidth,windowHeight), 8, 8, 1, 3f);
			turtle = new SpriteClass(this.Content, "halberd-badger-nobg", 0, 0, 3f);
		}

		protected override void Update(GameTime gameTime)
		{
			MouseState mouse = Mouse.GetState();

			turtle.X = mouse.X;
			turtle.Y = mouse.Y;

			map.Update(gameTime);

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear(Color.DarkSlateGray);

			spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, null, null, null, null);

			map.Draw(spriteBatch);

			//turtle.Draw(spriteBatch);

			spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}

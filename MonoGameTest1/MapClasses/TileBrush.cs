using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameTest1
{
	public class TileBrush
	{
		const int EMPTY = 0;
		const int GRASS = 1;
		const int DIRT = 2;

		SpriteClass grass;
		ContentManager content;

		public TileBrush(ContentManager content)
		{
			grass = new SpriteClass(content, "pixel-tile-deep");
		}

		public void Draw(SpriteBatch spriteBatch, IsometricTile tile)
		{
			if (tile.TextureID == GRASS)
			{
				grass.Draw(spriteBatch);
			}
		}
	}
}

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameTest1
{
	public class ActorBrush
	{
		const int TURTLE = 1;
		const int TURTLEGANG = 2;
		const int BADGER = 3;

		Texture2D turtle;
		Texture2D turtleGang;
		Texture2D badger;

		ContentManager content;

		float scale;

		public ActorBrush(ContentManager content, float scale)
		{
			this.scale = scale;
			this.content = content;
			turtle = content.Load<Texture2D>("crossbow-turtle-large");
			turtleGang = content.Load<Texture2D>("crossbow-turtle-gang");
			badger = content.Load<Texture2D>("halberd-badger-nobg");

		}

		public void Draw(SpriteBatch spriteBatch, IsometricTile tile)
		{
			int yOff = 32; // how much to displace actor up from tile (may not want this to be uniform...

			foreach (int ID in tile.ActorList)
			{
				SpriteClass actor = new SpriteClass(tile.X, tile.Y-(yOff*scale), scale);

				if (ID == TURTLE) actor.texture = turtle;

				if (ID == TURTLEGANG) actor.texture = turtleGang;

				if (ID == BADGER) actor.texture = badger;

				// TODO try/catch for null texture, cause that can totally happen if ID is invalid
				actor.Draw(spriteBatch);
			}
		}
	}
}

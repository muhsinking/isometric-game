using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameTest1
{
	public class MapObject : SpriteClass
	{
		public int TileX { get; set; }
		public int TileY { get; set; }
		public int TileZ { get; set; }

		public MapObject(ContentManager content, string textureName, int tileX, int tileY, int tileZ, float scale) : base(content, textureName, scale)
		{
			TileX = tileX;
			TileY = tileY;
			TileZ = tileZ;
		}
	}
}

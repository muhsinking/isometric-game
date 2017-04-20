using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameTest1
{
	
	public class IsometricTile
	{
		const int EMPTY = 0;
		const int GRASS = 1;
		const int DIRT = 2;

		const int CROSSBOWTURTLE = 1;

		public float X { get; set; }
		public float Y { get; set; }
		public int TextureID { get; set; }
		public List<int> ActorList { get; set; }
		public Boolean highlighted { get; set; }


		public IsometricTile(int TextureID, float X, float Y)
		{
			this.TextureID = TextureID;
			this.X = X;
			this.Y = Y;
			highlighted = false;

			ActorList = new List<int>();
		}


	}
}
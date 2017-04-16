using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameTest1
{
	public class Snake : Character
	{
		const string TEXTURENAME = "bow-snake-nobg";
		const int STARTHEALTH = 12;
		const int STARTARMOR = 13;
		const int STARTATTACK = 10;
		const int STARTDAMAGE = 10;

		public Snake(ContentManager content, int x, int y, int z, float scale) : base(content, TEXTURENAME, STARTHEALTH, STARTARMOR, STARTATTACK, STARTDAMAGE, x, y, z, scale)
		{

		}
	}
}

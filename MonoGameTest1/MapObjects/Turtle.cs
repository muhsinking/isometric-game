using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameTest1
{
	public class Turtle : Character
	{
		const string TEXTURENAME = "crossbow-turtle-large";
		const int STARTHEALTH = 20;
		const int STARTARMOR = 16;
		const int STARTATTACK = 5;
		const int STARTDAMAGE = 5;

		public Turtle(ContentManager content, int x, int y, int z, float scale) : base(content, TEXTURENAME, STARTHEALTH, STARTARMOR, STARTATTACK, STARTDAMAGE, x, y, z, scale)
		{

		}
	}
}

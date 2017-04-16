using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameTest1
{
	public class Badger : Character
	{
		const string TEXTURENAME = "halberd-badger-nobg";
		const int STARTHEALTH = 15;
		const int STARTARMOR = 15;
		const int STARTATTACK = 7;
		const int STARTDAMAGE = 10;

		public Badger(ContentManager content, int tileX, int tileY, int tileZ, float scale) : base(content, TEXTURENAME, STARTHEALTH, STARTARMOR, STARTATTACK, STARTDAMAGE, tileX, tileY, tileZ, scale)
		{

		}
	}
}

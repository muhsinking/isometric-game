using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameTest1
{
	public class Weasel : Character
	{
		// only attack is special attack that stops enemy movement and deals damage if they walk over target tile
		const string TEXTURENAME = "caltrop-weasel-nobg";
		const int STARTHEALTH = 15;
		const int STARTARMOR = 15;
		const int STARTATTACK = 7;
		const int STARTDAMAGE = 10;

		public Weasel(ContentManager content, int tileX, int tileY, int tileZ, float scale) : base(content, TEXTURENAME, STARTHEALTH, STARTARMOR, STARTATTACK, STARTDAMAGE, tileX, tileY, tileZ, scale)
		{

		}
	}
}

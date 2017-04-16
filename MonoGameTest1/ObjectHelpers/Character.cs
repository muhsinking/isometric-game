using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameTest1
{
	public class Character : MapObject
	{
		const int LEFT = 0;
		const int UP = 1;
		const int RIGHT = 2;
		const int DOWN = 3;
		
		public int health;
		public int armor;
		public int attackBonus;
		public int damage;

		public Random roll;

		public Character(ContentManager content, string textureName, int health, int armor, int attackBonus, int damage, int x, int y, int z, float scale)  : base(content, textureName, x, y, z, scale)
		{
			this.health = health;
			this.armor = armor;
			this.attackBonus = attackBonus;
			this.damage = damage;
		}

		public void move(int direction)
		{
			if (direction == LEFT)
			{
				this.TileX--;
			}
			else if (direction == UP)
			{
				this.TileY--;
			}
			else if (direction == RIGHT)
			{
				this.TileX++;
			}
			else if (direction == DOWN)
			{
				this.TileY++;
			}
		}

		public void attack(Character target)
		{
			int r = roll.Next(1, 20);
			if (r + this.attackBonus >= target.armor)
			{
				target.health -= this.damage;
			}
		}
	}
}

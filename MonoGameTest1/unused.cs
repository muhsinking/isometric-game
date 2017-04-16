using System;
namespace MonoGameTest1
{
	public class unused
	{
		public unused()
		{
			// tile engine prototype
			/*int scale = 2;
			int tileWidth = tile.Width * scale;
			int tileHeight = tile.Height * scale;
			int boardWidth = 12;
			int boardHeight = 24;
			int x = tileWidth/2;
			int y = tileWidth/2;

			for (int i = 0; i < boardHeight; i++)
			{
				for (int j = 0; j < boardWidth; j++)
				{
					spriteBatch.Draw(tile, new Vector2(x,y), null, Color.DarkGray, 0f, new Vector2(0, 0), new Vector2(scale, scale), SpriteEffects.None, 0f);
					x += tileWidth;
				}

				x -= tileWidth * boardWidth;

				if (x == tileWidth/2)
				{
					x += tileWidth / 2;
				}

				else 
				{
					x = tileWidth/2;
				}

				y += tileHeight / 3;

			}

			x = tileWidth / 2;
			y = tileWidth / 2;
			int zOffset = tileHeight / 3 - scale;

			for (int i = 0; i < boardHeight; i++)
			{

				for (int j = 0; j < boardWidth; j++)
				{
					if (i == j || i == j - 1)
					{
						spriteBatch.Draw(tile, new Vector2(x, y - zOffset), null, Color.LightGray, 0f, new Vector2(0, 0), new Vector2(scale, scale), SpriteEffects.None, 0f);
					}
					x += tileWidth;
				}

				x -= tileWidth * boardWidth;

				if (x == tileWidth / 2)
				{
					x += tileWidth / 2;
				}

				else
				{
					x = tileWidth / 2;
				}

				y += tileHeight / 3;

			}

			x = tileWidth / 2;
			y = tileWidth / 2;
			zOffset *= 2;

			for (int i = 0; i < boardHeight; i++)
			{
				for (int j = 0; j < boardWidth; j++)
				{
					if (i == j || i == j-1)
					{
						spriteBatch.Draw(tile, new Vector2(x, y - zOffset), null, Color.White, 0f, new Vector2(0, 0), new Vector2(scale, scale), SpriteEffects.None, 0f);
					}
					x += tileWidth;
				}

				x -= tileWidth * boardWidth;

				if (x == tileWidth / 2)
				{
					x += tileWidth / 2;
				}

				else
				{
					x = tileWidth / 2;
				}

				y += tileHeight / 3;

			}*/

			//int tileWidth = grass.texture.Width * (int)grass.scale;
			//int tileHeight = grass.texture.Height * (int)grass.scale;
			//int zOffset = tileHeight / 3;

			//// starting point of first tile
			//int cX = 400;
			//int cY = 50;
			//int numInRow = 1;

			//for (int i = 0; i < xLength; i++)
			//{
			//	for (int j = 0; j < numInRow; j++)
			//	{
			//		for (int k = 0; k < zLength; k++)
			//		{
			//			if (map[i, j, k] == 1)
			//			{
			//				grass.X = cX;
			//				grass.Y = cY;
			//				grass.Draw(spriteBatch);
			//			}
			//		}

			//		cX += tileWidth - (int)scale;
			//	}
			//	// ugly hack plz fix
			//	cX -= (tileWidth - (int)scale) * numInRow + (tileWidth / 2 - (int)scale / 2);
			//	cY += tileHeight / 3;
			//	numInRow++;
			//}

			//numInRow -= 2;
			//cX += tileWidth;


			//for (int i = 0; i < xLength - 1; i++)
			//{
			//	for (int j = 0; j < numInRow; j++)
			//	{
			//		for (int k = 0; k < zLength; k++)
			//		{
			//			if (map[i, j, k] == 1)
			//			{
			//				grass.X = cX;
			//				grass.Y = cY;
			//				grass.Draw(spriteBatch);
			//			}
			//			cY -= zOffset;
			//		}
			//		cY += zOffset * zLength;
			//		cX += tileWidth - (int)scale;
			//	}
			//	// ugly hack plz fix
			//	cX -= (tileWidth - (int)scale) * numInRow - (tileWidth / 2 - (int)scale / 2);
			//	cY += tileHeight / 3;
			//	numInRow--;
			//}

			//int tileWidth = grass.texture.Width * (int)grass.scale;
			//int tileHeight = grass.texture.Height * (int)grass.scale;
			//int zOffset = tileHeight / 5;

			//// starting point of first tile
			//int cX = 700;
			//int cY = 50;
			//int numInRow = 1;

			//for (int i = 0; i < xLength; i++)
			//{
			//	for (int j = 0; j < numInRow; j++)
			//	{
			//		for (int k = 0; k < zLength; k++)
			//		{
			//			if (tileMap[i, j, k].TextureID == 1)
			//			{
			//				grass.X = cX;
			//				grass.Y = cY;
			//				grass.Draw(spriteBatch);
			//			}
			//		}

			//		cX += tileWidth - (int)scale;
			//	}
			//	// ugly hack plz fix
			//	cX -= (tileWidth - (int)scale) * numInRow + (tileWidth / 2 - (int)scale / 2);
			//	cY += tileHeight * 2 / 5 - (int)scale;
			//	numInRow++;
			//}

			//numInRow -= 2;
			//cX += tileWidth;


			//for (int i = 0; i < xLength - 1; i++)
			//{
			//	for (int j = 0; j < numInRow; j++)
			//	{
			//		for (int k = 0; k < zLength; k++)
			//		{
			//			if (tileMap[i, j, k].TextureID == 1)
			//			{
			//				grass.X = cX;
			//				grass.Y = cY;
			//				grass.Draw(spriteBatch);
			//			}
			//			//if (spriteMap[i, j, k] == 1)
			//			//{
			//			//	turtleGang.X = cX;
			//			//	turtleGang.Y = cY - zOffset;
			//			//	turtleGang.Draw(spriteBatch);
			//			//}

			//			cY -= zOffset;
			//		}
			//		cY += zOffset * zLength;
			//		cX += tileWidth - (int) scale;
			//	}
			//	// ugly hack plz fix
			//	cX -= (tileWidth - (int) scale) * numInRow - (tileWidth / 2 - (int)scale / 2);
			//	cY += tileHeight * 2 / 5 - (int)scale;
			//	numInRow--;
			//}

		}
	}
}

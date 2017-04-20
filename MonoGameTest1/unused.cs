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


			//for (int y = 0; y < tileMapIso.GetLength(1); y++)
			//{
			//	for (int x = 0; x < tileMapIso.GetLength(0); x++)
			//	{
			//		for (int z = 0; z < tileMapIso.GetLength(2); z++)
			//		{
			//			if (tileMapIso[x, y, z] != null)
			//			{
			//				if (tileMapIso[x, y, z].TextureID == 1)
			//				{
			//					// tile brush and actor brush
			//					// each takes tile/actor IDs, then draws the appropriate thingy in the given space
			//					// add an list of actors to each tile
			//					// actor brush takes that list, places them on the tile one after another, using the x,y,z of the tile
			//					grass.X = tileMapIso[x, y, z].X;
			//					grass.Y = tileMapIso[x, y, z].Y;

			//					if (tileMapIso[x, y, z].highlighted)
			//					{
			//						grass.DrawHighlighted(spriteBatch);
			//					}

			//					else
			//					{
			//						grass.Draw(spriteBatch);
			//					}
			//					//actorBrush.Draw(spriteBatch, tileMapIso[x, y, z]);
			//				}
			//			}
			//		}
			//			//}

//Vector2 iso = CartToIso(new Vector2(x, y));


////newTile.X = windowDimensions.X/2 + tileWidth * iso.X / 2;

////TODO fix texture to get rid of 2*scale
////newTile.Y = 50 + (tileHeight * 4 / 5 - (4*scale)) * iso.Y - (z*tileHeight*1/5);
////newTile.Y = 50 + (tileHeight * 2 / 3 - (2 * scale)) * iso.Y - (z * tileHeight * 1 / 3);


////newTile.Y = 80 + (tileHeight * 3 / 4 - (2 * this.scale)) * iso.Y - (z * tileHeight * 1 / 4 + (2 * this.scale));
//iso.X += tileMapIso.GetLength(0)/2;
//						iso.Y *= 2;

		}
	}
}

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace MonoGameTest1
{
	public class IsometricMap
	{
		const int EMPTY = 0;
		const int GRASS = 1;
		const int DIRT = 2;

		int xLength;
		int yLength;
		int zLength;
		float scale;
		IsometricTile[,,] tileMap; // 3d array, 0 is ground level
		IsometricTile[,,] tileMapIso;
		float yCharacterOffset; //HACK

		MouseHandler mouseHandler;

		char lastKey;

		Badger badger;

		List<MapObject> mapObjectList;

		SpriteClass grass;

		public IsometricMap(ContentManager content, GraphicsDevice graphicsDevice, Vector2 windowDimensions, int xLength, int yLength, int zLength, float scale)
		{
			this.xLength = xLength;
			this.yLength = yLength;
			this.zLength = zLength;
			this.scale = scale;

			mouseHandler = new MouseHandler();

			lastKey = '_';

			tileMap = new IsometricTile[xLength, yLength, zLength];
			tileMapIso = new IsometricTile[xLength*2-1,yLength*2-1, zLength];
			mapObjectList = new List<MapObject>();

			yCharacterOffset = 32 * scale;

			// load grass texture
			//grass = new SpriteClass(content, "tile-grass-no-detail", 0, 0, this.scale);
			//grass = new SpriteClass(content, "pixel-tile-deep", 0, 0, this.scale);
			grass = new SpriteClass(content, "pixel-tile-square", 0, 0, this.scale * .9f);

			int tileWidth = (int)(grass.texture.Width * this.scale);
			int tileHeight = (int)(grass.texture.Height * this.scale);

			Vector2 boardDimensions = new Vector2(xLength*tileWidth, yLength*tileHeight);
			Vector2 startingPoint = new Vector2(windowDimensions.X/2 - boardDimensions.X/2 - tileWidth/2, windowDimensions.Y/2 - boardDimensions.Y/2 - tileHeight/2);


			badger = new Badger(content, 3, 3, 0, scale);
			mapObjectList.Add(badger);

			for (int x = 0; x < xLength; x++)
			{
				for (int y = 0; y < yLength; y++)
				{
					for (int z = 0; z < zLength; z++)
					{
						IsometricTile newTile;
						if (z == 0 || x == 3 || y == 3)
						{
							newTile = new IsometricTile(1,0,0);
						}

						else 
						{
							newTile = new IsometricTile(0,0,0);
						}


						newTile.X = startingPoint.X + x * tileWidth;
						newTile.Y = startingPoint.Y + y * tileHeight;

						Vector2 iso = CartToIso(new Vector2(x, y));


						//newTile.X = windowDimensions.X/2 + tileWidth * iso.X / 2;

						//TODO fix texture to get rid of 2*scale
						//newTile.Y = 50 + (tileHeight * 4 / 5 - (4*scale)) * iso.Y - (z*tileHeight*1/5);
						//newTile.Y = 50 + (tileHeight * 2 / 3 - (2 * scale)) * iso.Y - (z * tileHeight * 1 / 3);


						//newTile.Y = 80 + (tileHeight * 3 / 4 - (2 * this.scale)) * iso.Y - (z * tileHeight * 1 / 4 + (2 * this.scale));
						iso.X += tileMapIso.GetLength(0)/2;
						iso.Y *= 2;

						tileMap[x, y, z] = newTile;
						tileMapIso[(int)iso.X, (int)iso.Y, z] = newTile;
					}
				}

			}

		}

		
		//public int[] getTileHitbox(IsometricTile tile)
		//{
			
		//}

		// convert cartesian coordinates to isometric coordinates
		public Vector2 CartToIso(Vector2 cart)
		{
			Vector2 iso = new Vector2();
			iso.X = cart.X - cart.Y;
			iso.Y = (cart.X + cart.Y)/2;
			return iso;
		}

		// convert isometric coordinates to cartesian coordinates
		public Vector2 IsoToCart(Vector2 iso)
		{
			Vector2 cart = new Vector2();
			cart.X = (2 * iso.Y + iso.X) / 2;
			cart.Y = (2 * iso.Y - iso.X) / 2;
			return cart;
		}

		public void DrawTiles(SpriteBatch spriteBatch)
		{
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
			//	}
			//}

			for (int y = 0; y < yLength; y++)
			{
				for (int x = 0; x < xLength; x++)
				{
					IsometricTile curr = tileMap[x, y, 0];
					if(curr.TextureID == 1)
					{
						grass.X = curr.X;
						grass.Y = curr.Y;
						grass.Draw(spriteBatch);
					}

				}	
			}
		}

		public void Update(float elapsedTime)
		{
			KeyBoardHandler();
			mouseHandler.Update();
			UpdateTiles();
		}

		public void UpdateTiles()
		{
			IsometricTile curr;
			// update tiles in cartesian order
			for (int x = 0; x < xLength; x++)
			{
				for (int y = 0; y < yLength; y++)
				{
					for (int z = 0; z < zLength; z++)
					{
						curr = tileMap[x, y, z];
						if (getTilePointCollision(curr, new Vector2(mouseHandler.mouse.X, mouseHandler.mouse.Y)))
						{
							curr.highlighted = true;
						}
						else curr.highlighted = false;
					}
				}
			}
		}

		public Boolean getTilePointCollision(IsometricTile tile, Vector2 point)
		{
			float halfTextureWidth = grass.texture.Width/2;
			float halfTextureHeight = grass.texture.Height / 2;
			if (point.X <= tile.X + halfTextureWidth && point.X >= tile.X - halfTextureWidth
			    && point.Y <= tile.Y + halfTextureHeight && point.Y >= tile.Y - halfTextureHeight)
			{
				return true;
			}
			return false;
		}

		public void DrawObjects(SpriteBatch spriteBatch)
		{
			foreach(MapObject o in mapObjectList){
				o.X = tileMap[o.TileX, o.TileY, o.TileZ].X;
				o.Y = tileMap[o.TileX, o.TileY, o.TileZ].Y - yCharacterOffset;
				o.Draw(spriteBatch);
			}
		}

		public void Draw(SpriteBatch spriteBatch)		
		{
			DrawTiles(spriteBatch);
			DrawObjects(spriteBatch);
		}

		public Boolean Validtile(int X, int Y, int Z)
		{
			if (X < 0 || Y < 0 || X >= xLength || Y >= yLength) return false;
			if (tileMap[X,Y,Z] == null) return false;
			if (tileMap[X, Y, Z].TextureID == 0) return false;
			return true;
		}

		public void KeyBoardHandler()
		{
			KeyboardState state = Keyboard.GetState();

			if (state.IsKeyDown(Keys.W))
			{
				if (lastKey != 'w')
				{
					lastKey = 'w';
					if(Validtile(badger.TileX,badger.TileY-1,badger.TileZ))
						badger.move(1);
				}
			}
			else if (state.IsKeyDown(Keys.A))
			{
				if (lastKey != 'a')
				{
					
					lastKey = 'a';
					if (Validtile(badger.TileX - 1, badger.TileY, badger.TileZ))
						badger.move(0);
				}
			}
			else if (state.IsKeyDown(Keys.S))
			{
				if (lastKey != 's')
				{
					
					lastKey = 's';
					if (Validtile(badger.TileX, badger.TileY + 1, badger.TileZ))
						badger.move(3);
				}
			}
			else if (state.IsKeyDown(Keys.D))
			{
				if (lastKey != 'd')
				{
					lastKey = 'd';
					if (Validtile(badger.TileX + 1, badger.TileY, badger.TileZ))
						badger.move(2);
				}
			}
			else {
				lastKey = '_';
			}
		}
	}
}

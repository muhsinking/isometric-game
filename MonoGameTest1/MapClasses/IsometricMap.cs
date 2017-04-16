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

		char lastKey;

		Badger badger;

		TileBrush tileBrush;
		ActorBrush actorBrush;

		List<MapObject> mapObjectList;

		SpriteClass grass;
		SpriteClass turtleGang;
		Vector2 windowDimensions;

		public IsometricMap(ContentManager content, GraphicsDevice graphicsDevice, Vector2 windowDimensions, int xLength, int yLength, int zLength, float scale)
		{
			this.xLength = xLength;
			this.yLength = yLength;
			this.zLength = zLength;
			this.scale = scale;
			this.windowDimensions = windowDimensions;

			lastKey = '_';

			tileBrush = new TileBrush(content);
			actorBrush = new ActorBrush(content, scale);

			tileMap = new IsometricTile[xLength, yLength, zLength];
			tileMapIso = new IsometricTile[xLength*2-1,yLength*2-1, zLength];
			mapObjectList = new List<MapObject>();

			yCharacterOffset = 32 * scale;

			// load grass texture
			grass = new SpriteClass(content, "tile-grass-no-detail", 0, 0, this.scale);
			//grass = new SpriteClass(content, "pixel-tile-deep", 0, 0, this.scale);

			// load turtle gang texture
			// turtleGang = new Character(content, "crossbow-turtle", 0, 0, this.scale);

			int tileWidth = (int) (grass.texture.Width * this.scale);
			int tileHeight = (int) (grass.texture.Height * this.scale);
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
							if (x == 3 && y == 3)
							{
								newTile.ActorList.Add(3);
							}
						}
						else 
						{
							newTile = new IsometricTile(0,0,0);
						}


						Vector2 iso = CartToIso(new Vector2(x, y));

						newTile.X = windowDimensions.X/2 + tileWidth * iso.X / 2;

						//TODO fix texture to get rid of 2*scale
						newTile.Y = 50 + (tileHeight * 4 / 5 - (4*scale)) * iso.Y - (z*tileHeight*1/5);
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

		public void Update(float elapsedTime)
		{
			for (int i = 0; i < xLength; i++)
			{
				for (int j = 0; j < yLength; j++)
				{
					for (int k = 0; k < zLength; k++)
					{
						
					}
				}
			}
		}

		public void DrawTiles(SpriteBatch spriteBatch)
		{
			for (int y = 0; y < tileMapIso.GetLength(1); y++)
			{
				for (int x = 0; x < tileMapIso.GetLength(0); x++)
				{
					for (int z = 0; z < tileMapIso.GetLength(2); z++)
					{
						if (tileMapIso[x, y, z] != null)
						{
							if (tileMapIso[x, y, z].TextureID == 1)
							{
								// tile brush and actor brush
								// each takes tile/actor IDs, then draws the appropriate thingy in the given space
								// add an list of actors to each tile
								// actor brush takes that list, places them on the tile one after another, using the x,y,z of the tile
								grass.X = tileMapIso[x, y, z].X;
								grass.Y = tileMapIso[x, y, z].Y;
								grass.Draw(spriteBatch);
								//actorBrush.Draw(spriteBatch, tileMapIso[x, y, z]);
							}
						}
					}
				}
			}
		}

		public void Update(GameTime gameTime)
		{
			KeyBoardHandler();
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

		public void KeyBoardHandler()
		{
			KeyboardState state = Keyboard.GetState();

			if (state.IsKeyDown(Keys.W))
			{
				if (lastKey != 'w')
				{
					lastKey = 'w';
					badger.move(1);
				}
			}
			else if (state.IsKeyDown(Keys.A))
			{
				if (lastKey != 'a')
				{
					lastKey = 'a';
					badger.move(0);
				}
			}
			else if (state.IsKeyDown(Keys.S))
			{
				if (lastKey != 's')
				{
					lastKey = 's';
					badger.move(3);
				}
			}
			else if (state.IsKeyDown(Keys.D))
			{
				if (lastKey != 'd')
				{
					lastKey = 'd';
					badger.move(2);
				}
			}
			else {
				lastKey = '_';
			}
		}
	}
}

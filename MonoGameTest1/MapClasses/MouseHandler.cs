using System;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace MonoGameTest1
{
	public class MouseHandler
	{
		public MouseState mouse { get; set; }

		public Vector3 highlighted { get; set; }

		public MouseHandler()
		{
			mouse = Mouse.GetState();
			highlighted = new Vector3(-1, -1, -1);
		}

		public void Update()
		{
			mouse = Mouse.GetState();
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Cat_Planet_2
{
	class Wall
	{
		public Rectangle hitBox;
		public bool hitable;
		
		public Wall(Rectangle hitBox)
		{
			this.hitBox = hitBox;
			this.hitable = true;
		}

		public void Draw(Texture2D texture, SpriteBatch sb)
		{
			sb.Draw(texture, hitBox, Color.Black);
		}
	}
}

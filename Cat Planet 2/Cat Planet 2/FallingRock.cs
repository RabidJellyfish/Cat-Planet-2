﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Cat_Planet_2
{
	class FallingRock : Obstacle
	{
		Texture2D texture;
		Vector2 motion;
		Vector2 initialPosition;
		Vector2 initialSpeed;
		float angle;

		public FallingRock(Texture2D texture, Vector2 initialPosition, Vector2 initialSpeed, Rectangle hitbox)
			: base(hitbox)
		{
			this.texture = texture;
			this.initialPosition = initialPosition;
			this.initialSpeed = initialSpeed;
			this.motion = initialSpeed;
			angle = 0;
		}

		public override void Update()
		{
			motion.Y += 0.3f;
			angle += MathHelper.TwoPi / 360;

			hitBox.X += (int)Math.Round(motion.X);
			hitBox.Y += (int)Math.Round(motion.Y);

			if (hitBox.Y > 900)
			{
				hitBox.X = (int)initialPosition.X;
				hitBox.Y = (int)initialPosition.Y;
				motion = initialSpeed;
			}
		}

		public override void Draw(SpriteBatch sb)
		{
			sb.Draw(texture, new Rectangle(hitBox.X + 32, hitBox.Y + 16, 64, 64), null, Color.White, angle, new Vector2(texture.Width / 2, texture.Height / 2), SpriteEffects.None, 1);
		}
	}
}

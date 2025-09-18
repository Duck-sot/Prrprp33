using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Prrprp33
{
    public class Russel : Merc
    {
        public Russel(Texture2D texture, Vector2 position, Rectangle hitbox, Point size, Color color) : base(texture, position, hitbox, size, color)
        {
            this.texture = texture;
            this.position = position;
            this.color = color;
            hitbox = new Rectangle((int)position.X, (int)position.Y, size.X, size.Y);
        }
        public override void Update()
        {
            Random rand = new Random();
            Vector2 dir = new((float)-rand.NextDouble(),(float)rand.NextDouble() );
            dir.Normalize();
        }
        public override void Draw()
        {
            base.Draw();
            SpriteBatch.Draw(texture, hitbox, Color.White);
        }
    }
}
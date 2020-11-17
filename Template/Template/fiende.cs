using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Template
{
    class fiende : Bas
    {
        public fiende(Texture2D skin, Vector2 coords)
        {
            pixel = skin;
            pos = coords;
        }

        public void Draw(SpriteBatch spritebatch)
        {
            pos.Y = 200;
            pos.X = 20;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(50,50)), Color.Pink);
            
        }
    }
}

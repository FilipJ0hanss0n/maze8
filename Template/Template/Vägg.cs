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
    class Vägg:Bas
    {
        public Vägg(Texture2D skin, Vector2 coords)
        {
            pixel = skin;
            pos = coords;
        }
        public void Draw(SpriteBatch spritebatch)
        {
            pos.Y = 20;
            pos.X = 5;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(10, 300)), Color.Black);
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(300, 10)), Color.Black);
            pos.Y = 60;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(100, 10)), Color.Black);
            pos.Y = 90;
            pos.X = 30;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(300, 10)), Color.Black);
            pos.Y = 120;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(10, 200)), Color.Black);
            pos.X = 60;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(10, 100)), Color.Black);
            pos.Y = 135;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(200, 10)), Color.Black);
            pos.Y = 165;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(10, 300)), Color.Black);
            pos.X = 90;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(400, 10)), Color.Black);
            pos.X = 110;
            pos.Y = 190;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(650, 10)), Color.Black);
            pos.X = 300;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(300, 10)), Color.Black);
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(10, 200)), Color.Black);
            pos.X = 400;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(10, 200)), Color.Black);
            pos.Y = 300;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(100, 10)), Color.Black);
            pos.Y = 10;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(10, 100)), Color.Black);
            pos.Y = 20;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(100, 10)), Color.Black);
            pos.X = 600;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(10, 150)), Color.Black);
            pos.Y = 280;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(100, 10)), Color.Black);
            pos.Y = 220;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(10, 200)), Color.Black);
            pos.Y = 300;
            pos.X = 500;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(50, 10)), Color.Black);
            pos.Y = 450;
            pos.X = 100;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(1000, 10)), Color.Black);
            pos.Y = 300;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(500, 10)), Color.Black);
            pos.X = 700;
            pos.Y = 20;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(10, 250)), Color.Black);
            pos.X = 90;
            pos.Y = 300;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(200, 10)), Color.Black);
            pos.X = 780;
            pos.Y = 460;
            spritebatch.Draw(pixel, new Rectangle(pos.ToPoint(), new Point(20, 20)), Color.Red);

        }
    }
}

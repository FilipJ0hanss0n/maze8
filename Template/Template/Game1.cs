﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Template
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player player;
        Vägg vägg;
        fiende Fiende;
        //KOmentar
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

            int myNum = (int)Månad.November;
            Console.WriteLine(myNum);
         

        }
        enum Månad
        {
            Januari,    // 0
            Februari,   // 1
            March,      // 2
            April,      // 3
            Maj,        // 4
            Juni,       // 5
            July,       // 6
            Augusti,     // 7
            September,   // 8
            Oktober,     // 9
            November,    // 10
            December,    // 11
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player = new Player(Content.Load<Texture2D>("pixel"), new Vector2(1, 1));
            vägg = new Vägg(Content.Load<Texture2D>("pixel"), new Vector2(5, 20));
            Fiende = new fiende(Content.Load<Texture2D>("pixel"), new Vector2(50, 30));
            // TODO: use this.Content to load your game content here 
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            player.Update();

            for (int i = -3; i < 21; i++)
            {
                for (int o = -3; o < 21; o++)
                {
                    if (player.Pos == new Vector2(i + 780, o + 460))
                    {
                        this.Exit();
                    }
                }
            }

            for (int i = -3; i < 52; i++)
            {
                for (int o = -3; o < 52; o++)
                {
                    if (player.Pos == new Vector2(i + 20, o + 200))
                    {
                        this.Exit();
                    }
                }
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            player.Draw(spriteBatch);
            vägg.Draw(spriteBatch);
            Fiende.Draw(spriteBatch);
            spriteBatch.End();

            // TODO: Add your drawing code here.

            base.Draw(gameTime);
        }
    }
}

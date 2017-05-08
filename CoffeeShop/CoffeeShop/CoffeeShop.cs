using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace CoffeeShop
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class CoffeeShop : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Background
        Texture2D BackgroundTexture;

        //Screen Parameters
        int screenwidth;
        int screenheight;

        //Lists holding Information about cashiers and customers
        List<int> CustomerList = new List<int>();
        int[] Cashiers = new int[4];

        //Sprites
        Texture2D FoodTexture;
        Texture2D CoffeeTexture;
        Texture2D BothTexture;

        //Sprites with set positions
        Texture2D CashierTexture;
        Vector2[] CashierPosition = new Vector2[4];

        //Text Fonts
        SpriteFont StatsFont;
        Vector2 FontPos;

        public CoffeeShop()
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
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Checks the screen Height and Width of the screen
            screenwidth = GraphicsDevice.Viewport.Width;
            screenheight = GraphicsDevice.Viewport.Height;

            //Loads PointFont
            StatsFont = Content.Load<SpriteFont>(@"Statsfont");
            //Postion of stats goes here

            //Loads Sprites
            LoadResources();
        }

        private void LoadResources()
        {
            string image = "Resources\\Coffee Sprite";
            CoffeeTexture = Content.Load<Texture2D>(image);

            string image2 = "Resources\\Food Sprite";
            FoodTexture = Content.Load<Texture2D>(image2);

            string image3 = "Resources\\Both Sprite";
            BothTexture = Content.Load<Texture2D>(image3);

            string image4 = "Resources\\Cashier Sprite";
            CashierTexture = Content.Load<Texture2D>(image4);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

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

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

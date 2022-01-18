using System;
using Raylib_cs;


namespace bilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starta grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            //ladda in bilden
            Texture2D dog = Raylib.LoadTexture(@"./resurser/dog.png");
            Texture2D flower = Raylib.LoadTexture(@"./resurser/flowe.png");


            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita ut bilder
                Raylib.DrawTexture(dog, 100, 100, Color.WHITE);
                Raylib.DrawTexture(flower, 300, 100, Color.WHITE);


                // Ritat ut på fönstret
                Raylib.EndDrawing();
            }


        }
    }
}

using System;
using ra
namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
             // Starta grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

          

            //skapa en spelare av en rektangel
            Rectangle spelare = new Rectangle(100,100,50,50);
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
}}

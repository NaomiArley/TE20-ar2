using System;
using Raylib_cs;

namespace INNPUT
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
            Rectangle spelare2 = new Rectangle(200,200,50,50);
            //ladda bild för spelaren
            Texture2D star = Raylib.LoadTexture(@"./resurser/star.png");
            Texture2D star2 = Raylib.LoadTexture(@"./resurser/star(1).png");
            
            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita ut spelare
               Raylib.DrawTexture(star,(int)spelare.x, (int)spelare.y , Color.WHITE);
               Raylib.DrawTexture(star2,(int)spelare2.x, (int)spelare2.y , Color.WHITE);
               


                // Ritat ut på fönstret
                Raylib.EndDrawing();
                //lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y += 5;
                }
                //SPELARE2
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    spelare2.x += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    spelare2.x -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    spelare2.y -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    spelare2.y += 5;
                }

                
    }}}
}

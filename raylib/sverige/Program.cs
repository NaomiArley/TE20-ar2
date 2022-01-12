using System;
using Raylib_cs;

namespace sverige
{
    class Program
    {
        static void Main(string[] args)
        {
             //starta ett fönster
            Raylib.InitWindow(800,600,"Ett fönster");

            //ställ in fps
            Raylib.SetTargetFPS(60);

            //animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                 //börja rita
                 Raylib.BeginDrawing();
                 
                 //tömma ritytan
                 Raylib.ClearBackground(Color.WHITE);

                 //rita fyrkant
                 Raylib.DrawRectangle(100,100,510,310, Color.BLUE);
                 Raylib.DrawRectangle(100,100,500,300, Color.SKYBLUE);
                 Raylib.DrawRectangle(100,250,500,50, Color.YELLOW);
                 Raylib.DrawRectangle(240,100,50,300, Color.YELLOW);
                 

                 //sluta rita
                 Raylib.EndDrawing();
            }
        }
    }
}

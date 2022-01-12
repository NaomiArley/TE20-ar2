using System;
using Raylib_cs;

namespace grunder
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
                 Raylib.ClearBackground(Color.LIME);

                 //rita fyrkant
                 Raylib.DrawRectangle(100,100,200,100, Color.DARKBROWN);

                Raylib.DrawText("hejhejhej", 100,500,50, Color.BLACK);
                 //sluta rita
                 Raylib.EndDrawing();

            }
        }
    }
}

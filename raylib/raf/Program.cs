using System;
using Raylib_cs;

namespace raf
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
                 Raylib.ClearBackground(Color.BEIGE);

                 //rita fyrkant
                 Raylib.DrawRectangle(0,0,300,600, Color.DARKBROWN);
                 Raylib.DrawText("royal air force",50,50,50, Color.BLACK);

                 //rita crkel
                 Raylib.DrawCircle(500,200,100, Color.DARKBLUE);
                 Raylib.DrawCircle(500,200,70, Color.WHITE);
                 Raylib.DrawCircle(500,200,30, Color.RED);


                 //sluta rita
                 Raylib.EndDrawing();

            }
        }
    }
}

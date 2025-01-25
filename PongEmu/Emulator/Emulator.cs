using System;
using Raylib_cs;


class Emulator {
    public static int ScreenResize = 10;

    public void Run(string FilePath, string FileName) {
        Raylib.SetTargetFPS(60);
        Raylib.InitWindow(
            64 * ScreenResize,
            32 * ScreenResize,
            $"PongEmu - {FileName} ({Raylib.GetFPS()})"
        );

        while (!Raylib.WindowShouldClose()) {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}

﻿namespace TheSlum
{
    using GameEngine;

    public static class Program
    {
        public static void Main()
        {
            Engine engine = new MyEngine();
            engine.Run();
        }
    }
}
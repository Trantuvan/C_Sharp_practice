﻿using System;

namespace MulitipleInheritance
{
    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {
        }

        public void Focus()
        {
            Console.WriteLine("Receied focus.");
        }
    }
}

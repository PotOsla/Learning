﻿using System.Text;
{
    var commands = new string[] { "push Привет! Это снова я! Пока!",
                "pop 5",
                "push Как твои успехи? Плохо?",
                "push qwertyuiop",
                "push 1234567890",
                "pop 26" };

    PushPop.ApplyCommands(commands);
}
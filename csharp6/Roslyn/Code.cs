﻿public class Greeter
{
    public void SayHello()
    {
        var message = "Hello, World!";
        PrintMessage(message);
    }

    void PrintMessage(string message)
    {
        var length = message.Length;
        System.Console.WriteLine("{1} {0}", message, length);
    }
}
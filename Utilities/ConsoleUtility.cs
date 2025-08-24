/*
* console utility class
*/
using System;

namespace AquariumApp;

public static class ConsoleUtility
{
    private const int DEFAULT_LINE_BREAKS = 2;

    private static void VisualGap(int lineBreaks = DEFAULT_LINE_BREAKS)
    {
        // guard against crash
        // no point in calling a method that won't end up doing anything
        if (lineBreaks <= 0)
            lineBreaks = DEFAULT_LINE_BREAKS;

        for (var i = 0; i < lineBreaks; i++)
        {
            Console.WriteLine();
        }
    }

    public static void Header(string phrase)
    {
        Console.Clear();
        Console.Title = phrase;
        Console.WriteLine(phrase);
        for (var i = 0; i < phrase.Length; i++)
        {
            Console.Write("-");
        }

        VisualGap(6);
    }

    public static void Footer()
    {
        Console.Write("Program written by unix0x01");
        //VisualGap(6);
        VisualGap();
    }
}
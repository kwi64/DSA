using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

static class Utils
{
    [ModuleInitializer]
    public static void PrintInfo()
    {
        var entry = Assembly.GetEntryAssembly()?.EntryPoint;
        var startup = entry?.DeclaringType?.FullName;

        Console.WriteLine("Running: {0}\n", startup);
    }
    
    extension<T>(Stack<T> enumerable)
    {
        public string Printout => $"[{enumerable.GetType().Name}] => [ {string.Join(", ", enumerable)} ]\n";
    }  
}

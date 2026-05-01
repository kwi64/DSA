using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    extension<T>(IEnumerable<T> source)
    {
        public string PrintOut() => $"[{string.Join(", ", source)}]\n";
    }
}
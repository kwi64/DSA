using System;
using System.Reflection;
using System.Runtime.CompilerServices;

static class RunInfo
{
    [ModuleInitializer]
    public static void PrintInfo()
    {
        var entry = Assembly.GetEntryAssembly()?.EntryPoint;
        var startup = entry?.DeclaringType?.FullName;

        Console.WriteLine("Running: {0}\n", startup);
    }
}
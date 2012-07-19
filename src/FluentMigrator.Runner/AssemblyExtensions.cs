using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FluentMigrator.Runner
{
    public static class AssemblyExtensions
    {
        public static Type[] GetExportedTypes(this Assembly assembly)
        {
            return assembly.GetTypes().Where(type => type.IsPublic).ToArray();
        }

        public static string GetLocation(this Assembly assembly)
        {
            return Path.GetDirectoryName(assembly.GetName().CodeBase);
        }
    }
}
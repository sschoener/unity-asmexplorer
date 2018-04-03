using System;
using System.Collections.Generic;
using System.Text;

namespace AsmExplorer {
    public static class TypeExt {
        private static Dictionary<Type, string> _specialNames = new Dictionary<Type, string>() {
          {typeof(long), "long"},
          {typeof(int), "int"},
          {typeof(short), "short"},
          {typeof(sbyte), "sbyte"},
          {typeof(ulong), "ulong"},
          {typeof(uint), "uint"},
          {typeof(ushort), "ushort"},
          {typeof(byte), "byte"},
          {typeof(void), "void"},
          {typeof(string), "string"},
          {typeof(bool), "bool"},
          {typeof(object), "object"}
        };

        public static string PrettyName(this Type type, bool full=false) {
            string name;
            if (_specialNames.TryGetValue(type, out name))
                return name;
            if (full)
                return type.FullName;
            return type.Name;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
static public class ImportantWords
{
    static public readonly string[] Keywords = new string[]{
        "abstract", "add*", "alias*", "as",
"ascending*",
      "async*", "await*", "base","bool",
"break",
      "by*", "byte", "case", "catch", "char",
"checked",
      "class", "const", "continue", "decimal",
"default",
      "delegate", "descending*", "do",
"double",
      "dynamic*", "else", "enum", "event",
"equals*",
      "explicit", "extern", "false",
"finally", "fixed",
      "from*", "float", "for", "foreach",
"get*", "global*",
      "group*", "goto", "if", "implicit",
"in", "int",
      "into*", "interface", "internal", "is",
"lock", "long",
      "join*", "let*", "nameof*", "namespace",
"new", "nonnull*",
      "null", "object", "on*", "operator",
"orderby*", "out",
      "override", "params", "partial*",
"private", "protected",
      "public", "readonly", "ref", "remove*",
"return", "sbyte",
      "sealed", "select*", "set*", "short",
"sizeof",
      "stackalloc", "static", "string",
"struct", "switch",
      "this", "throw", "true", "try",
"typeof", "uint", "ulong",
      "unsafe", "ushort", "using", "value*",
"var*", "virtual",
      "unchecked", "void", "volatile",
"where*", "while", "yield*"
    };
}
class Program
{
    private static void ShowContextualKeywords1()
    {
        IEnumerable<string> selection = from word in ImportantWords.Keywords
                                        where !word.Contains('*')
                                        select word;

        foreach (string keyword in selection)
        {
            Console.Write(keyword + " ");
        }
        Console.WriteLine();
        IEnumerable<string> selection1 = from word in ImportantWords.Keywords
                                         where word.Contains('*')
                                         select word;

        foreach (string keyword in selection1)
        {
            Console.Write(keyword + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        ShowContextualKeywords1();
    }
}

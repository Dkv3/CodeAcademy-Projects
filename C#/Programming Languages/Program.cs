using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();
        
      var alphabetically = languages.OrderBy(l => l.Name);
      // PrettyPrintAll(alphabetically);

      var oldest = languages.Min(l => l.Year);
      // Console.WriteLine(oldest);


      foreach (var x in languages)
      {
        // Console.WriteLine(x.Prettify());
      }
      
      var languageInfo = from l in languages
      select $"{l.Year}, {l.Name}, {l.ChiefDeveloper}";

      foreach (var x in languageInfo)
      {
        // Console.WriteLine(x);
      }

      var cSharpLanguages = languages
      .Where(l => l.Name == "C#");

      foreach (var x in cSharpLanguages)
      {
        // Console.WriteLine(x.Prettify());
      }

      var microsoftLanguages = languages
      .Where(l => l.ChiefDeveloper == "Microsoft");

      foreach (var x in microsoftLanguages)
      {
        // Console.WriteLine(x.Prettify());
      }

      var lispLanguages = languages
      .Where(l => l.Predecessors.Contains("Lisp"));

      foreach (var x in lispLanguages)
      {
        // Console.WriteLine(x.Prettify());
      }

      var scriptLanguages = languages
      .Where(l => l.Name.Contains("Script"));

      foreach (var x in scriptLanguages)
      {
        // Console.WriteLine(x.Prettify());
      }

      var totalLanguages = languages.Count();
      // Console.WriteLine(totalLanguages);

      var decadeLanguages = languages
      .Where(l => l.Year >= 1995 && l.Year <= 2005)
      .Select(l => $"{l.Name} was invented in {l.Year}.");

      foreach (var x in decadeLanguages)
      {
        // Console.WriteLine(x);
      }

    }

    public static void PrettyPrintAll(IEnumerable<Language> langs)
    {
      foreach (Language l in langs)
      Console.WriteLine(l.Prettify());
    }

    public static void PrintAll(IEnumerable<Object> langs)
    {
      foreach (Language l in langs)
      Console.WriteLine(l);
    }
  }
}

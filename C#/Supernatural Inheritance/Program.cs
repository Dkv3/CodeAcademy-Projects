using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm s = new Storm("wind", false, "Zul'rajas");
      Console.WriteLine(s.Announce());

      Pupil p = new Pupil("Mezil-kree");
      Storm pupilStorm = p.CastWindStorm();
      Console.WriteLine(pupilStorm.Announce());

      Mage m = new Mage("Gul'dan");
      Storm mageStorm = m.CastRainStorm();
      Console.WriteLine(mageStorm.Announce());

      Archmage a = new Archmage("Aran");
      Storm archStormRain = a.CastRainStorm();
      Storm archStormLight = a.CastLightningStorm();
      Console.WriteLine(archStormRain.Announce());
      Console.WriteLine(archStormLight.Announce());
    }
  }
}
using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Party");
      tdl.Display();

      PasswordManager pm = new PasswordManager("iluvpie", true);
      pm.Display();

      tdl.Reset();
      pm.Reset();
      tdl.Display();
      pm.Display();
    }
  }
}

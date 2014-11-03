using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace app
{
  class Program
  {
    [STAThread()]
    static void Main(string[] args)
    {
      Application app = new Application();
      Window win = new Window();
      win.Title = "aloha wpf";
      app.Run(win);
    }
  }
}

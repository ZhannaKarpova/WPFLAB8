using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFLAB8
{
    class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctri+T"));
            Exit = new RoutedCommand("Exit", typeof(MyCommands), inputs);
        }
    }
}

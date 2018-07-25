using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Demo
{
    public partial class MyType
    {
        public static string PlatformProperty { get; set; } = "This is UWP text!";

        public static Button PlatformButton { get; set; } = null;
    }
}

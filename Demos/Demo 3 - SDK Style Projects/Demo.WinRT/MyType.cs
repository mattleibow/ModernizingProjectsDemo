using System;
using Windows.UI.Xaml.Controls;

namespace Demo
{
    public partial class MyType
    {
        public static string PlatformProperty { get; set; } = "This is Windows Runtime text!";

        public static Button PlatformButton { get; set; } = null;
    }
}

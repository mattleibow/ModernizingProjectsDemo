using System;
using Windows.UI.Xaml.Controls;

namespace Demo
{
    public partial class MyType
    {
        public static string PlatformProperty { get; set; } = "This is Windows Phone 8.1 text!";

        public static Button PlatformButton { get; set; } = null;
    }
}

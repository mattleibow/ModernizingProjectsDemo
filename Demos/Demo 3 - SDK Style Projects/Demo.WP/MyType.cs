using System;
using System.Windows.Controls;

namespace Demo
{
    public partial class MyType
    {
        public static string PlatformProperty { get; set; } = "This is Windows Phone 8 Silverlight text!";

        public static Button PlatformButton { get; set; } = null;
    }
}

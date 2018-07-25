using System;
using Android.Widget;

namespace Demo
{
    public partial class MyType
    {
        public static string PlatformProperty { get; set; } = "This is Android text!";

        public static Button PlatformButton { get; set; } = null;
    }
}

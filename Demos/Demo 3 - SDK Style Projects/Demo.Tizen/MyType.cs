using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElmSharp;

namespace Demo
{
    public partial class MyType
    {
        public static string PlatformProperty { get; set; } = "This is Tizen text!";

        public static Button PlatformButton { get; set; } = null;
    }
}

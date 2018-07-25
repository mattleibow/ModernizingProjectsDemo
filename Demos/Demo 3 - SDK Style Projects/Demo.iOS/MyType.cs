using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace ClassLibrary1
{
    public partial class MyType
    {
        public static string PlatformProperty { get; set; } = "This is iOS text!";

        public static UIButton PlatformButton { get; set; } = null;
    }
}

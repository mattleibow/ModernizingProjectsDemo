using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Demo
{
    public partial class MyType
    {
        public static string PlatformProperty { get; set; } = "This is Silverlight text!";

        public static Button PlatformButton { get; set; } = null;
    }
}

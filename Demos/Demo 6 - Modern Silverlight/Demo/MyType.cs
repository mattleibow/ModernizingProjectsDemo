using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Demo
{
    public class MyType
    {
        public MyType()
        {
            BinaryProperty = 0b_0101_0101;

            FunctionProperty = default;

            int count = 5;
            string label = "Colors used in the map";
            TupleProperty = (count: count, label: label);

            StringProperty = "Hello World!";
        }

        public string StringProperty { get; }

        public int BinaryProperty { get; }

        public (int count, string label) TupleProperty { get; }

        public Func<string, bool> FunctionProperty { get; }
    }
}

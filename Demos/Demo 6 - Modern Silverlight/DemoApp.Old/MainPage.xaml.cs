using Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace DemoApp.Old
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            var myType = new MyType();
            textBlock.Text = string.Format(
                "OLD\n(count: {0}, label: {1})",
                myType.TupleProperty.Item1,
                myType.TupleProperty.Item2);
        }
    }
}

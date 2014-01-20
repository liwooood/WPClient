using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Reactive;
using System.Diagnostics;

namespace WPClient
{
    public partial class ReactivePage : PhoneApplicationPage
    {
        public ReactivePage()
        {
            InitializeComponent();
        }

        private void btnReactive_Click(object sender, RoutedEventArgs e)
        {
            IObservable<Int32> input = Observable.Range(1, 15);
            
            input.Where(i => i % 2 == 0).Subscribe(x => Debug.WriteLine("{0} ", x));
        }

        private void btnLinq_Click(object sender, RoutedEventArgs e)
        {
            List<Int32> its = Enumerable.Range(1, 15).ToList();
            its.Where(i => i % 2 == 0).ToList().ForEach(i => Debug.WriteLine("{0} ", i));
        }
    }
}
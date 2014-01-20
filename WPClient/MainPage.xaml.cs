using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WPClient.Resources;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace WPClient
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 构造函数
        public MainPage()
        {
            InitializeComponent();

            // 用于本地化 ApplicationBar 的示例代码
            //BuildLocalizedApplicationBar();
        }

        private async void btnSync_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("test 1...");
            string result = "";
            result = await WaitAsynchronouslyAsync();

            //result = await WaitSynchronously();

            Debug.WriteLine("test 2...");
            Debug.WriteLine("result={0}", result);
        }

        public async Task<string> WaitAsynchronouslyAsync()
        {
            await Task.Delay(1000 * 5);
            return "WaitAsynchronouslyAsync finished";
        }

        public async Task<string> WaitSynchronously()
        {
            Thread.Sleep(1000 * 5);

            return "WaitSynchronously finished";
        }

        private void btnNetwork_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("socket");
        }

        private void btnReactive_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page/ReactivePage.xaml", UriKind.Relative));
        }

        // 用于生成本地化 ApplicationBar 的示例代码
        //private void BuildLocalizedApplicationBar()
        //{
        //    // 将页面的 ApplicationBar 设置为 ApplicationBar 的新实例。
        //    ApplicationBar = new ApplicationBar();

        //    // 创建新按钮并将文本值设置为 AppResources 中的本地化字符串。
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // 使用 AppResources 中的本地化字符串创建新菜单项。
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}
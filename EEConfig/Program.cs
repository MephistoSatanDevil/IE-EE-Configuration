// Program.cs
using EEConfig.UI; // 确保导入包含 ConfigWindow 的命名空间
using System;
using System.Globalization;

namespace EEConfig // 使用您的 EEConfig 项目的根命名空间
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 设置应用程序的视觉样式（可选，但推荐）
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); // 通常设为 false 以获得更一致的外观

            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CurrentUICulture;

            // 启动主窗口
            Application.Run(new ConfigWindow()); // 调用修改后的无参数构造函数
        }
    }
}
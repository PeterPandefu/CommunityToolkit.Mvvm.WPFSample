using CommunityToolkit.Mvvm.Sample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityToolkit.Mvvm.Sample.ViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            Tyeps = new List<TreeNode>()
            {
                new TreeNode("Attribute",new TreeNode[]
                {
                     new TreeNode("ObservableProperty attribute"),
                     new TreeNode("RelayCommand attribute"),
                     new TreeNode("INotifyPropertyChanged attributes"),

                }),

                new TreeNode("ObservableObject"),

                new TreeNode("ObservableValidator"),

                new TreeNode("Commands",new TreeNode[]
                {
                     new TreeNode("Relay Commands"),
                     new TreeNode("Async Commands"),
                }),

                new TreeNode("Messager",new TreeNode[]
                {
                     new TreeNode("Sending messages"),
                     new TreeNode("Request messages"),
                }),

                new TreeNode("Ioc (Inversion of control)"),

                new TreeNode("Collections"),
            };
        }
        /// <summary>
        /// CommunityToolkit.Mvvm 组件类型
        /// </summary>
        public List<TreeNode> Tyeps { get; set; }
    }
}

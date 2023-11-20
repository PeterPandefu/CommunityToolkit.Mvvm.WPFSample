using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityToolkit.Mvvm.Sample.Model
{
    public class TreeNode
    {
        public string Name { get; set; } = string.Empty;

        public List<TreeNode> Children { get; set; } = new List<TreeNode>();

        public TreeNode(string name)
        {
            Name = name;
        }

        public TreeNode(string name, IEnumerable<TreeNode> children)
        {
            Name = name;
            Children = new List<TreeNode>(children);
        }

    }
}

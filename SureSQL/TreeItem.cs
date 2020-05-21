using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureSQL
{
    public class TreeItem
    {
        public enum Type { TABLE, FUNCTION, PROCEDURE, VIEW }

        public string Name { get; set; }
        public List<TreeItem> Children{ get; set; }

        public int DataType { get; set; }

        public TreeItem(string name, Type type) {
            this.Name = name;
            this.DataType = (int)type;
        }

        public void AddChild(string name, Type type) {
            this.Children.Add(new TreeItem(name, type));
        }
        
    }
}

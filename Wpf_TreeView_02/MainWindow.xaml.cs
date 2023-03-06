using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_TreeView_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class TreeViewData
    {
        public static List<Node> DataList { get; set; } = GetDataList();
        public static List<Node> GetDataList()
        {
            List<Node> dataList = new List<Node>
            {
                new Node { 
                    Name = "Test 1", 
                    ChildNodes = new List<Node> {
                        new Node { Name = "Child1" }, 
                        new Node { Name = "Child2" }, 
                        new Node { Name = "Child3" } 
                    } 
                },
                new Node { Name = "Test 2"},
                new Node { Name = "Test 3"},
                new Node { 
                    Name = "Test 99", 
                    ChildNodes = new List<Node> {
                        new Node { Name = "Child1" }, 
                        new Node { Name = "Child2" }, 
                        new Node { 
                            Name = "Child3", 
                            ChildNodes = new List<Node> { 
                                new Node { Name = "Child1" }, 
                                new Node { Name = "Child2" }, 
                                new Node { Name = "Child3" } 
                            } 
                        } 
                    }  
                },
            };
            return dataList;
        }
    }

    public class Node
    {
        public string Name { get; set; } = string.Empty;
        public IList<Node>? ChildNodes { get; set; }
    }
}

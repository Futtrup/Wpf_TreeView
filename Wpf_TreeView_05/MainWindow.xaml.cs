using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf_TreeView_05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Node> Root { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            Root = new List<Node> { };

            Node rootElement = new Node { Header = "Root" };
            Root.Add(rootElement);

            Node child01 = new Node { Header = "Child 01" };
            Node child02 = new Node { Header = "Child 02" };
            rootElement.ChildNodes.Add(child01);
            rootElement.ChildNodes.Add(child02);

            Node grandChild01 = new Node { Header = "Grand child 01" };
            Node grandChild02 = new Node { Header = "Grand child 02" };
            child02.ChildNodes.Add(grandChild01);
            child02.ChildNodes.Add(grandChild02);

            //grandChild02.ChildNodes.Add(rootElement);
            //trv_BrowseNodes.ItemsSource = Root;
            DataContext = this;
            btn_Test.Click += On_Btn_Test_Click;
        }

        private void On_Btn_Test_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = trv_BrowseNodes.SelectedItem;
            if (selectedItem == null)
                return;

            if (!(selectedItem is Node))
                return;

            Node selectedNode = (Node)selectedItem;
            Node newChildNode = new Node { Header = "New child node from button click event" };
            selectedNode.ChildNodes.Add(newChildNode);
        }
    }

    public class Node
    {
        public string Header { get; set; } = string.Empty;
        public ObservableCollection<Node> ChildNodes { get; set; } = new ObservableCollection<Node>();
    }
}

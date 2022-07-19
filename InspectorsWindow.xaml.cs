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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CodeFirst;
using System.ComponentModel;


namespace Test
{
    /// <summary>
    /// Логика взаимодействия для InspectorsWindow.xaml
    /// </summary>
    public partial class InspectorsWindow : Window
    {
        public InspectorsWindow()
        {
            InitializeComponent();
            DataContext = new MyContext();
            Loaded += InspectorsWindow_Loaded;
            Closing += OnWindowClosing;
        }

        private void Button_AddInspector(object sender, RoutedEventArgs e)
        {
            AddInspectorForm addInspectorForm = new AddInspectorForm();
            
            addInspectorForm.ShowDialog();
            Servise servise = new Servise();

            inspectors.ItemsSource = servise.GetInspectors();

        }
        private void Button_DeleteInspector(object sender, RoutedEventArgs e)
        {
            DeleteInspectorForm deleteInspectorForm = new DeleteInspectorForm();

            deleteInspectorForm.ShowDialog();
            Servise servise = new Servise();

            inspectors.ItemsSource = servise.GetInspectors();
        }
        private void Button_EditInspector(object sender, RoutedEventArgs e)
        {
            
        }

        private void InspectorsWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //MyContext myContext = new MyContext();
            Servise servise = new Servise();

            inspectors.ItemsSource = servise.GetInspectors();
        }

        private void Button_BackToMainWindow(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            Hide();
        }

        public void OnWindowClosing(object sender, CancelEventArgs e)
        {
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            Owner.Show();

        }
    }
}

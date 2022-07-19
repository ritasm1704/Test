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
using CodeFirst;
using System.Data.SqlClient;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    

    public partial class MainWindow : Window
    {
        private Inspection selectedInspection = null;

        public MainWindow()
        {
            MyContext myContext = new MyContext();

            Servise servise = new Servise();

            Inspector inspector = new Inspector
            {
                InspectorName = "Михаил",
                InspectorNumber = "01234567"
            };
            Inspector inspector2 = new Inspector
            {
                InspectorName = "Александр",
                InspectorNumber = "15935722"
            };
            Inspector inspector3 = new Inspector
            {
                InspectorName = "Иван",
                InspectorNumber = "11222234"
            };
            servise.AddInspector(inspector);
            servise.AddInspector(inspector2);
            servise.AddInspector(inspector3);

            Inspection inspection = new Inspection
            {
                InspectionName = "Пожарная инсп",
                Date = new DateTime(2020, 12, 2),
                InspectorId = inspector.InspectorId,
                InspectorName = inspector.ToString()
            };

            Inspection inspection2 = new Inspection
            {
                InspectionName = "Основная инсп",
                Date = new DateTime(2020, 12, 2),
                InspectorId = inspector2.InspectorId,
                InspectorName = inspector2.ToString()
            };
            servise.AddInspection(inspection);
            servise.AddInspection(inspection2);

            Remark rem = new Remark
            {
                RemarkStr = "Замечание 1",
                Comment = "все плохо",
                InspectionId = inspection.InspectionId,
                DateOfFix = new DateTime(2020, 12, 3)
            };
            Remark rem2 = new Remark
            {
                RemarkStr = "Замечание 2",
                Comment = "все плохо",
                InspectionId = inspection.InspectionId,
                DateOfFix = new DateTime(2020, 12, 3)
            };

            servise.AddRemark(rem);
            servise.AddRemark(rem2);

            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //MyContext myContext = new MyContext();
            UpdataData();
            //this.OnActivated
            //throw new NotImplementedException();
        }

        protected override void OnActivated(EventArgs e)
        {
            UpdataData();
        }
        //protected override void OnContentRendered(EventArgs e)
        //{
        //    UpdataData();
        //}

        public void UpdataData()
        {
            Servise servise = new Servise();

            inspections.ItemsSource = servise.GetAllInspections();

            List<Inspector> insp = servise.GetInspectors();

            Inspector inspector = new Inspector
            {
                InspectorName = "Все",
                InspectorNumber = ""

            };
            insp.Insert(0, inspector);

            inspectors.ItemsSource = insp;
            inspectors.SelectedIndex = 0;
        }

        private void DataGrid_GotFocus(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource.GetType() == typeof(DataGridCell))
            {
                DataGrid grd = (DataGrid)sender;

                //MyContext myContext = new MyContext();
                Servise servise = new Servise();

                Inspection insp = grd.SelectedItem as Inspection;
                selectedInspection = insp;
                if (insp != null)
                {
                    List<Remark> rem = servise.GetRemarks(insp);

                    remarks.ItemsSource = rem;
                    
                } 
                else
                {
                    remarks.ItemsSource = null;
                }
                
                grd.BeginEdit(e);
            }
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            
            ComboBox comboBox = (ComboBox)sender;
            Inspector inspector = (Inspector)comboBox.SelectedItem;

            //MyContext myContext = new MyContext();
            Servise servise = new Servise();

            if (inspector != null)
            {
                if (inspector.ToString() == "Все")
                {
                    inspections.ItemsSource = servise.GetAllInspections();
                }
                else
                {
                    inspections.ItemsSource = servise.GetInspectionByInspector(inspector);
                }
            }
            else
            {
                inspections.ItemsSource = servise.GetAllInspections();
            }

            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            //MyContext myContext = new MyContext();
            Servise servise = new Servise();
            inspections.ItemsSource = servise.GetInspectionByInspectionName(textBox.Text);
        }

        private void Button_DirectoryInspectors(object sender, RoutedEventArgs e)
        {
            InspectorsWindow inspectorsWindow = new InspectorsWindow();
            inspectorsWindow.Owner = this;
            Hide();
            inspectorsWindow.Show();
        }

        private void Button_AddInspection(object sender, RoutedEventArgs e)
        {
            AddInspectionForm addInspection = new AddInspectionForm();
            addInspection.ShowDialog();
            
        }

        private void Button_DeleteInspection(object sender, RoutedEventArgs e)
        {
            DeleteInspectionForm deleteInspection = new DeleteInspectionForm(selectedInspection);
            deleteInspection.ShowDialog();
        }

        private void Button_EditInspection(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

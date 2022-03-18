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


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DocumentManager documentManager;
        public MainWindow()
        {
            InitializeComponent();
            documentManager = new DocumentManager(body);

        }





        private void NewDocument(object sender, ExecutedRoutedEventArgs e)
        {
            if (documentManager.BodyTextChanged)
            {
                documentManager.SaveDocument();
            }
            documentManager.NewDocument();
        }

        private void OpenDocument(object sender, ExecutedRoutedEventArgs e)
        {
            if (documentManager.BodyTextChanged)
            {
                documentManager.SaveDocument();
            }
            documentManager.OpenDocument();
        }

        private void SaveDocument(object sender, ExecutedRoutedEventArgs e)
        {
            documentManager.SaveDocument();
        }

        private void SaveDocumentAs(object sender, ExecutedRoutedEventArgs e)
        {
            documentManager.SaveDocumentAs();
        }

        private void bodyTextChanged(object sender, TextChangedEventArgs e)
        {
            documentManager.TextChanged();
        }

        private void commandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = documentManager.BodyTextChanged;
        }

    }
}

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

namespace Eye_save
{
    public partial class MainWindow : Window
    {

        private List<Agent> _Agents;

        public List<Agent> Agents

        {
            get
            {
                return _Agents;
            }
            set
            {
                _Agents = value;
            }
        }

        // Подключение к БД
        public MainWindow()            
        {
            InitializeComponent();         
            this.DataContext = this;       
            Agents = Core.DB.Agent.ToList();
        }

        // Реализация кнопки выхд
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        
        // Реалтзация кнопки Агенты
        private void Agent_Click (object sender, RoutedEventArgs e)
        {
            var d = new AgentsWindow();
            d.Show();
        }

    }
}

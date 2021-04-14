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
using System.Windows.Shapes;

namespace Eye_save
{
    /// <summary>
    /// Логика взаимодействия для AgentsWindow.xaml
    /// </summary>
    public partial class AgentsWindow : Window
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
        public AgentsWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Agents = Core.DB.Agent.ToList();
        }

        // Реализация перехода к окну "Добавить Агента"
        private void EditAgent(object sender, RoutedEventArgs e)
        {
            var a = new EditAgent();
            a.Show();
        }

        // Реализация перехода к окну "Редактировать Агента "
        private void ReEditAgent(object sender, RoutedEventArgs e)
        {
            var b = new ReEditAgent();
            b.Show();
        }

        // Реализация перехода к окну "Приоритет"
        private void Preoritet(object sender, RoutedEventArgs e)
        {
            var c = new Preoritet();
            c.Show();
        }
    }
}

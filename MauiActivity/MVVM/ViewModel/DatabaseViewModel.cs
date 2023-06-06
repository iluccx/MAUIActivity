using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiActivity.MVVM.ViewModel
{
    public class DatabaseViewModel
    {
        public DatabaseViewModel()
        {

        }

        public double Valor1 { get; set; }
        public double Valor2 { get; set; }

        public double Valor3 { get; set; }
        public double Valor4 { get; set; }

        public double Valor5 { get; set; }
        public double Valor6 { get; set; }

        public ICommand ClickSaveRecord => new Command(SaveRecord);

        private void SaveRecord()
        {
           

        }
    }
}

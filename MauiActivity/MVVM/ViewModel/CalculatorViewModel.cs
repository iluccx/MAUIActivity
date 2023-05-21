using PropertyChanged;
using System.Windows.Input;
using MauiActivity.MVVM.Models;

namespace MauiActivity.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CalculatorViewModel
    {
        public CalculatorViewModel()
        {
                
        }
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Oper { get; set; }
        public double Result { get; set; }
        public string History { get; set; } = string.Empty;

        public ICommand ClickAC => new Command(ACClean);
        public ICommand ClickAdd => new Command(AddNumber);
        public ICommand ClickSubtract => new Command(SubtractNumber);
        public ICommand ClickMultiply => new Command(MultiplyNumber);
        public ICommand ClickDiv=> new Command(DivNumber);
        public ICommand ClickPercentage => new Command(PercentageNumber);
        public ICommand ClickNumber => new Command(numberType);
        public ICommand ClickEqual => new Command(equalNumber);
        public ICommand ClickDelete => new Command(DeleteNumber);

        private void ACClean()
        {
            Num1 = 0;
            Num2 = 0;
            Result = 0;
            History = "";
            Oper = "";
        }

        private void AddNumber(object obj)
        {
            Num1 = Convert.ToDouble(History.ToString());
            History = History += "+";
            Oper = "+";
        }
        private void SubtractNumber(object obj)
        {
            Num1 = Convert.ToDouble(History.ToString());
            History = History += "-";
            Oper = "-";
        }
        private void MultiplyNumber(object obj)
        {
            Num1 = Convert.ToDouble(History.ToString());
            History = History += "*";
            Oper = "*";
        }
        private void DivNumber(object obj)
        {
            if (!(History[History.Length - 1]).Equals("/"))
            {
                Num1 = Convert.ToDouble(History.ToString());
                History = History += "/";
                Oper = "/";
            }
        }

        private void PercentageNumber(object obj)
        {
            try
            {
                string number = History;
                if (number != "0")
                {
                    decimal percentValue = Convert.ToDecimal(number);
                    string result = (percentValue / 100).ToString("0.##");
                    Result =  Double.Parse(result);
                }
            }
            catch (Exception ex)
            {
                History = "Error";
            }
        }

        private void numberType(object obj)
        {
            History = History += (string)obj;
        }

        private void equalNumber(object obj)
        {
            try
            {
                string[] secNum = History.Split(Oper);
                Num2 = Convert.ToDouble(secNum[1].ToString());

                switch (Oper)
                {
                    case "+":
                        Result = Num1 + Num2;
                        break;
                    case "-":
                        Result = Num1 - Num2;
                        break;
                    case "/":
                        if (Num2 == 0)
                        {
                            Result = 0;
                            History= "Error, Division por 0";
                        }
                        else
                        {
                            Result = Num1 / Num2;
                        }
                        break;
                    case "*":
                        Result = Num1 * Num2;
                        break;

                    default:
                        break;
                }
            }catch(Exception ex) { History = "Error"; }
        }
        private void DeleteNumber(object obj)
        {
            try
            { 
                if (History.Length==0)
                {
                    History = "";
                }
                else
                {
                    History = History.Remove(History.Length - 1);
                }
            }
            catch (Exception)
            {
                History = "Error";
            }
        }
    }
    

}

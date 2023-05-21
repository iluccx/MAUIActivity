using MauiActivity.MVVM.Models;

namespace MauiActivity.MVVM.ViewModel
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Person = new()
            {
                Name= "Jhon munoz",
                Age = 24
            };
        }
        public Person Person { get; set; }
    }
}

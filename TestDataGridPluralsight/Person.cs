using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDataGridPluralsight
{
    public class Person :ObservableObject
    {
        private string _name; public string Name { get => _name; set { Set(() => Name, ref _name, value); }}
        private string _sex; public string Sex { get => _sex; set { Set(() => Sex, ref _sex, value); }}

        public Person(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }
    }
}

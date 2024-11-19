using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    internal class Article
    {
        public Person Person { get; set; }
        public string Name { get; set; }
        public double Reiting { get; set; }
        public Article() { 
            Person = new Person();
            Name = "Неизвестно";
            Reiting = 5;
        }
        public Article(Person person, string name, double rank)
        {
            Person = person;
            Name = name;
            Reiting = rank;
        }
        public override string ToString() {
            return $"\tИнформация о статье\nАвтор: {Person};\nНазвание статьи: {Name};\nРейтинг статьи: {Reiting}.\n";
        }
    }
}

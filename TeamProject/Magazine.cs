using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

enum Frequancy{ Weekly, Monthly, Yearly}
namespace TeamProject
{
    internal class Magazine
    {
        private string nameOfMagazine;
        private Frequancy frequancy;
        private DateTime reliseDate;
        private int tirazh;
        private Article[] articles;
        public Magazine(string nameOfMagazine, Frequancy frequancy, DateTime reliseData, int tirazh, Article[] articles)
        {
            this.nameOfMagazine = nameOfMagazine;
            this.frequancy = frequancy;
            this.reliseDate = reliseData;
            this.tirazh = tirazh;
            this.articles = new Article[articles.Length];
            this.articles = articles;
        }
        public Magazine()
        {
            nameOfMagazine = "Неизвестно";
            frequancy = Frequancy.Weekly;
            reliseDate = DateTime.Now;
            tirazh = 1;
            articles = new Article[1];
        }
        public string NameOfMagazine
        {
            get
            {
                return nameOfMagazine;
            }
            set
            {
                nameOfMagazine = value;
            }
        }
        public Frequancy Frequancy
        {
            get
            {
                return frequancy;
            }
            set
            {
                frequancy = value;
            }
        }
        public DateTime ReliseData
        {
            get
            {
                return reliseDate;
            }
            set
            {
                reliseDate = value;
            }
        }
        public int Tirazh
        {
            get
            {
                return tirazh;
            }
            set
            {
                tirazh = value;
            }
        }
        public Article[] Articles
        {
            get
            {
                return articles;
            }
            set
            {
                articles = value;
            }
        }
        public double Avg
        {
            get
            {
                if (Articles == null || Articles.Length == 0)
                {
                    return 0;
                }
                double sum = 0;
                int count = 0;
                for (int i = 0; i < Articles.Length; i++)
                {
                    if (Articles[i] != null)
                    {
                        sum += Articles[i].Reiting;
                        count++;
                    }
                }
                return count > 0 ? sum / count : 0;
            }
        }
        public bool this[Frequancy frequancy]
        {
            get
            {
                return Frequancy == frequancy;             
            }
        }
        public void AddArticles(params Article[] articles1)
        {
            int razm = Articles.Length;
            Array.Resize(ref articles, Articles.Length + articles1.Length);
            for (int i = razm; i < Articles.Length - 1; i++)
            {
                Articles[i] = articles1[i];
            }
        }
        public override string ToString()
        {
            for (int i = 0; i < Articles.Length; i++)
            {
                Console.WriteLine($"\t\tСтатья {i+1}");
                Console.WriteLine(Articles[i]);
            }
            return $"Название журнала: {NameOfMagazine}, переодичность выхода журнала: {Frequancy}, дата выхода журнала - {ReliseData}, тираж журнала: {Tirazh}";
        }
        public virtual string ToShortString()
        {
            return $"Название журнала: {NameOfMagazine}, переодичность выхода журнала: {Frequancy}, дата выхода журнала - {ReliseData}, тираж журнала: {Tirazh}, средний рейтинг статей: {Math.Round(Avg, 2)}";
        }
    }
}

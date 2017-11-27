using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracktTask04
{
    public class Money
    {
        private int nominal;
        private int count;

        public int GetNominal()
        {
            return nominal;
        }

        public void SetNominal(int nominal)
        {
            Console.Write("Введите номинал купюры: ");
            string text = Console.ReadLine();

            bool isParsed = int.TryParse(text, out nominal);
            if(!isParsed)
            {
                Console.Write("Ошибка!");
                return;
            }
            this.nominal = nominal;
        }

        public int GetCount()
        {
            return count;
        }

        public void SetCount(int count)
        {
            Console.Write("Введите количество купюр: ");
            string text = Console.ReadLine();

            bool isParsed = int.TryParse(text, out count);
            if (!isParsed)
            {
                Console.Write("Ошибка!");
                return;
            }
            this.count = count;
        }

        public void ShowMoney()
        {
            Console.Write("Номинал купюры: " + nominal);

            Console.Write("Количество купюр: " + count);
        }

        public bool IsEnough(int valueOfStuff)
        {
            Console.Write("Введите сумму товара: ");
            string text = Console.ReadLine();

            bool isParsed = int.TryParse(text, out valueOfStuff);

            if(!isParsed)
            {
                Console.WriteLine("Ошибка!");
                return false;
            }

            if(count<valueOfStuff)
            {
                Console.Write("Извините, но у вас не хватает средств!");
            }
            else
            {
                Console.Write("Количесвто средств достаточна!");
            }
            return true;
           
        }

        public void HowManyStuff()
        {
            Console.Write("Введиет цену товара: ");
            string text = Console.ReadLine();

            int value;
            bool isParsed = int.TryParse(text, out value);

            if(!isParsed)
            {
                Console.WriteLine("Ошибка!");
                return;
            }


            if (value > count)
            {
                Console.WriteLine("У вас недостаточно стредств!");
            }
            else
            {
                int amount = count / value;
                Console.Write("Количесвто товара которые можете купить: "+amount);
            }
        }
    }
}

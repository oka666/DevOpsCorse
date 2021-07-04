using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class7
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item("test1");
            Item item2 = new Item("test2");
            Pudge pudge = new Pudge("test",12,new Item[] {item1,item2 });
            pudge.getInfo();

        }

    }

    class Pudge
        {
            public Pudge(string name,int level,Item[] items )
            {
                this.name = name;
                this.level = level;
                this.items = items;
            }

            public Pudge(string name, int level, Item items1, Item item2)
            {
                this.name = name;
                this.level = level;
                items[0] = items1;
                items[1] = item2;
            }

            private string name;
            int level;
            Item[] items = Item[2];

            public void getInfo()
            {
                Console.WriteLine(name,level,items[0].getName(), items[1].getName());
            }
        }
        class Item
        {

            string item1;
            string item2;
        public Item(string items1)
        {
            this.item1 = item1;
        }
    }
    }


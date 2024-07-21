using System;
namespace Structures
{
    struct StructureBasic
    {
        int i;
        //We can define only parameterised constructor as by default it is having Parameterless Constructor
        public StructureBasic(int i)
        {
            this.i = i;
        }
        public void Message()
        {
            Console.WriteLine("We are using Structure message in Message Method: "+ i);
        }

        static void Main(string[] args)
        {
            StructureBasic obj = new StructureBasic();
            //In structure it is not mandatory to use new keyword for instance creation
            StructureBasic obj1;
            obj1.i = 10;
            obj1.Message();
            obj.Message();

            StructureBasic obj2 = new StructureBasic();
            obj2.Message();

            StructureBasic obj3 = new StructureBasic(30);
            obj3.Message();

            Console.ReadLine();
        }

    }
}
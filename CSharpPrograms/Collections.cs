using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
  
    public class Collections
    {
       public static void Main()
        {
            /* ----------Non - Generic Collections ----------- */
            int[] arr= {1,2,3,4,5};
            int[] arr1 = new int[5];
            Array.Copy(arr,arr1 , arr.Length);
            //Console.WriteLine(arr1.Max()-1);
            Array.Resize(ref arr,15);


            ArrayList al=new ArrayList();
            
            al.Add(900);
            al.Add(100);
            al.Add(920);
            al.Add(90);
            al.Add(30);
           
            al.Insert(2, 850); // insert element in the middle of array
            al.Remove(90); // delete first occurence of ele 
            al.RemoveAt(2);
            foreach(var obj in al)
            {
                Console.Write(obj+" ");
            }
            Console.WriteLine(al.Capacity);

            Hashtable hashtable = new Hashtable();
            hashtable.Add("name", "swathi");
            hashtable.Add("age", 25);
            hashtable.Add("Location", "Hyderabad");
            hashtable.Add("Salary", 19000);

            Console.WriteLine(al[3]);  // need to remeber keys in Array List
            Console.WriteLine(hashtable["Location"]); // user defined key
            Console.WriteLine("Hash Code is:"+"swa".GetHashCode());
            foreach (var val in hashtable.Values /*Keys*/)
            {
                Console.WriteLine(val);
            }
     /* ---------- Generic Collections ----------- */
    
     List<Program> program = new List<Program>();
            foreach(var item in program)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class generics
    {
        public bool convert(object a, object b) {
            if (a.Equals(b))
           return true;
            return false;
        }
        public bool Compare<T>(T a, T b)  /* <T> (type) consider like a float automatically  */ 
        {
            if (a.Equals(b))
                return true;               // making generic methods
            return false;
        }
        static void Main()
        {
            generics gen=new generics();
         // bool res=  gen.convert(2, 2);
          bool res=  gen.convert(22.4f, 2.76);
          bool res1=  gen.Compare<float>(22.4f, 22.4f);
          bool res2=  gen.Compare<int>(22, 22);
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            // intension is to comapre two float values becouse of object it will campare and return result without error.
            //sending float value(value type ) and storing in object(reference type) performing boxing and unboxing internally. if we want to get correct result we need to perforn boxing again and again (kill performence).
            // to overcome we have generics 

            Console.ReadLine();

        }
    }

    public class Generics<T>   // making generic clases
    {
        public void Add(T a,T b)
        {
            dynamic d1 = a,d2=b; 
            Console.WriteLine(d1+d2);
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a, d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a, d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a, d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }

    
   public class ClassGen
    {
        static void Main()
        {
            Generics<int> gen=new Generics<int>();
            gen.Add(10,20);gen.Mul(10, 20);gen.Sub(10, 20);gen.Div(10, 20);
        } 
    }
    public class DictionaryCollection
    {
        public static void Main()
        {
            Dictionary<string,object> dic = new Dictionary<string,object>();
            dic.Add("a", 1);
            dic.Add("b", 2);
            dic.Add("c", 3);
            dic.Add("d", 4);
            dic.Add("e", 23.4);
            dic.Add("f", "swa");
            foreach(var item in dic)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }

    public class TestProducts
    {
        public static int CompareNames(Products s1, Products s2)
        {
           return s1.ProductName. CompareTo(s2.ProductName);  //sorting using delegate 
        }
        static void Main()
        {
           List<Products> products = new List<Products>();
            /* First Method */
            Products products1 = new Products { ProductID=101,ProductName="Refrigirator",ProductPrice=25000};
            Products products2 = new Products { ProductID=103,ProductName="Poojastore",ProductPrice=1500};
            Products products3 = new Products { ProductID=102,ProductName="TV",ProductPrice=75000};
            Products products4 = new Products { ProductID=104,ProductName="Mobile",ProductPrice=7000};
            products.AddRange(new[] { products1, products2, products3, products4 });
            foreach (Products item in products)
            {
                Console.WriteLine("Second Method:" + item.ProductPrice + " " + item.ProductName);
            }

            /* Second Method */

            products.Add(new Products { ProductID = 111, ProductName = "Lenovo", ProductPrice = 55000 });
            products.Add(new Products { ProductID = 222, ProductName = "HP", ProductPrice = 62000 });
            foreach(Products item in products)
            {
                Console.WriteLine(item.ProductID+" "+item.ProductName+" "+item.ProductPrice);  
            }
            /* Third Method */
            List<Products> products5 = new List<Products>() { products1,products2,products3,products4};
            ProductsCamare productsCamare=new ProductsCamare();
           
            products5.Sort();
            products5.Sort(productsCamare);
            Comparison<Products> obj = new Comparison<Products>(CompareNames); // sorting by name using delegate
            products5.Sort(obj);
            //products5.Sort(1, 3, productsCamare);we can sort by index position value.
            foreach (Products item in products5)
            {
                Console.WriteLine("Third method"+item.ProductID + " " + item.ProductName + " " + item.ProductPrice);

            }


        }
    }
}


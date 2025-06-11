public class Program
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public char SurName { get; set; }

   
}
public class Products : IComparable<Products>  // for sorting items based in product id
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public double ProductPrice { get; set; }
    public string Manufactureddate { get; set; }
    public int CompareTo(Products other)
    {
        if (this.ProductID > other.ProductID) return 1;
        else if (this.ProductID < other.ProductID) return -1;
        else return 0;

    }

}
public class ProductsCamare : IComparer<Products>
{
    public int Compare(Products x, Products y)
    {
        if (x.ProductPrice > y.ProductPrice) return 1;
        else if (x.ProductPrice < y.ProductPrice) return -1;
        else return 0;
    }
}

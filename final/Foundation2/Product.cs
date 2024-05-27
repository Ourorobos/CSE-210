using System;

public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _numOf;

    public Product(string name, int id, double price, int numberOfProduct)
    {
        _name = name;
        _id = id;
        _price = price;
        _numOf = numberOfProduct;
    }

    public double GetTotal()
    {
        return _price * _numOf;
    }
    public string GetPackingList()
    {
        return $"{_name}, {_id}: {_numOf}";
    }

}
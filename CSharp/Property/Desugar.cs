public decimal price {get; set;}

//Se transformarÃ¡ em:

private decimal price;
public decimal Price {
   get { return price; }
   set { price = value; }
}

//https://pt.stackoverflow.com/q/405783/101

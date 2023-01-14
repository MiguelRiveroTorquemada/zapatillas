namespace Classes;
 public class Zapatilla{
    public string name { get; }
    public string nameZapatilla { get; }
    public bool quedanZapatillas { get;set; }
    public DateTime  fechaAlta { get; }
    public decimal price { get; }
    public int stock { get; }
    

    public Zapatilla(string name,string nameZapatillas, bool quedanPlazas,DateTime fechaAlta, decimal price,int stock){
        this.name=name;
        this.nameZapatilla=nameZapatillas;
        this.quedanZapatillas=quedanPlazas;
        this.fechaAlta=fechaAlta;
        this.price=price;
        this.stock=stock;
    }
    public void ChangeGender(){
        quedanZapatillas=!quedanZapatillas;
    }

    public string Summary(){
        return name+" "+nameZapatilla+" "+quedanZapatillas.ToString()+" "+fechaAlta.ToString()+" "+price.ToString()+" "+ stock.ToString();
    }
 }


 
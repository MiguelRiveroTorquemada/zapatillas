namespace Classes;
 public class Marca{
    public string name { get; }
    public bool gender { get;set; }
    public DateTime  fechaAlta { get; }
    public decimal tallas { get; }
    public int tipos { get; }
    

    public Marca(string name, bool gender,DateTime fechaAlta, decimal tallas,int tipos){
        this.name=name;
        this.gender=gender;
        this.fechaAlta=fechaAlta;
        this.tallas=tallas;
        this.tipos=tipos;
    }
 

    public void ChangeGender(){
        gender=!gender;
    }

    public string Summary(){
        return name+" "+" "+gender.ToString()+" "+fechaAlta.ToString()+" "+tallas.ToString()+" "+ tipos.ToString();
    }
 }


 
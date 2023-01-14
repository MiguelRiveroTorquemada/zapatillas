namespace Classes;

class ZapatillaRepository{
    List<Zapatilla> data = new List<Zapatilla>();

    public void create(Zapatilla newZapatilla){
        data.Add(newZapatilla);
    }

    public List<Zapatilla> all(){
        return data;
    }

    public Zapatilla find(string name){
        return data.Find(item=> item.name== name);
    }

}

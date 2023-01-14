namespace Classes;
using System.Text;
using System.Text.Json;
class MarcaRepository{
    List<Marca> data = new List<Marca>();

    public void create(Marca newMarca){
        data.Add(newMarca);
        
    }

    public List<Marca> all(){
        return data;
    }

    public Marca find(string name){
        return data.Find(item=> item.name== name);
    }


}


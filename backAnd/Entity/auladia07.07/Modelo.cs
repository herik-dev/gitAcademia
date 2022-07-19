using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auladia07._07
{
    //para a classe Veiculo
    public void Salvar()
    {
        var db = new BaseContext();
        db.Veiculos.Add(this);
        db.SaveChanges();
    }

    public static List<Veiculo> Todos()
    {
        var db = new BaseContext();
        return db.Veiculos.ToList();
    }


    //para a classe Modelo
    public void Salvar()
    {
        var db = new BaseContext();
        db.Modelos.Add(this);
        db.SaveChanges();
    }

    public static List<Modelo> Todos()
    {
        var db = new BaseContext();
        return db.Modelos.ToList();
    }
}

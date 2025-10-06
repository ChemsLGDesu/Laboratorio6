using UnityEngine;

public class Saeed : EntityBase, IAtacable, IRecibirDa�o, IDropearItem
{
    public Saeed()
    {
        nameID = "Saeed";
        life = 200;
        atack = 30;
        defense = 10;
    }
    public override void Atacar()
    {
        Debug.Log($"{nameID} Dispara con su Ametralladora Ligera M249");
    }

    public override void RecibirDa�o(int cantidad)
    {
        life -= cantidad / 2; 
        Debug.Log($"{nameID} resiste el da�o. Vida restante: {life}");
    }

    public void DropearItem()
    {
        Debug.Log($"{nameID} dej� caer el Corazon de Africa (Diamante)!");
    }
}

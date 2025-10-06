using UnityEngine;

public class GuardTheAhsarah : EntityBase, IAtacable, IRecibirDa�o, IDropearItem
{
    public GuardTheAhsarah()
    {
        nameID = "Guardian de Ahsarah";
        life = 100;
        atack = 15;
        defense = 5;        
    }

    public override void Atacar()
    {
        Debug.Log($"{nameID} ataca con su cuchillo mariposa");
    }

    
    public override void RecibirDa�o(int cantidad)
    {
       life -= cantidad;
        Debug.Log($"{nameID} recibe {cantidad} de da�o. Vida restante: {life}");
    }

    public void DropearItem()
    {
        Debug.Log($"{nameID} dej� caer una Copa de vino especial de Ahsarah con un valor de 65.000 de tekin!"); 
    }
}

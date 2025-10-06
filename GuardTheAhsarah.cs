using UnityEngine;

public class GuardTheAhsarah : EntityBase, IAtacable, IRecibirDaño, IDropearItem
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

    
    public override void RecibirDaño(int cantidad)
    {
       life -= cantidad;
        Debug.Log($"{nameID} recibe {cantidad} de daño. Vida restante: {life}");
    }

    public void DropearItem()
    {
        Debug.Log($"{nameID} dejó caer una Copa de vino especial de Ahsarah con un valor de 65.000 de tekin!"); 
    }
}

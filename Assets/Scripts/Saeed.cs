using UnityEngine;
using UnityEngine.Video;

public class Saeed : EnemigoEntity, IAtacable, IRecibirDa�o
{
    public void Awake()
    {
        nameID = "Saeed";
        life = 200;
        atack = 30;
        defense = 10;
    }
    public override void Atacar(EntityBase objetivo)
    {
        Debug.Log($"{nameID} Dispara con su Ametralladora Ligera M249 {objetivo.NameID}");
        objetivo.RecibirDa�o(atack);
    }
    public override void RecibirDa�o(int cantidad)
    {
        int da�oFinal = Mathf.Max(0,(cantidad / 2) - defense);
        life -= da�oFinal;
        Debug.Log($"{nameID} resiste el ataque. Pierde {da�oFinal} de vida. Vida restante: {life}");

        if (life <= 0)
        {
            Death();
        }    
    }
    public override void DropearItem()
    {
        Debug.Log($"{nameID} dej� caer el Corazon de Africa (Diamante :D)");
    }
    public override void Death()
    {
        base.Death();
        DropearItem();
    }

}

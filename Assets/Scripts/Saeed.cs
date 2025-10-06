using UnityEngine;
using UnityEngine.Video;

public class Saeed : EnemigoEntity, IAtacable, IRecibirDaño
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
        objetivo.RecibirDaño(atack);
    }
    public override void RecibirDaño(int cantidad)
    {
        int dañoFinal = Mathf.Max(0,(cantidad / 2) - defense);
        life -= dañoFinal;
        Debug.Log($"{nameID} resiste el ataque. Pierde {dañoFinal} de vida. Vida restante: {life}");

        if (life <= 0)
        {
            Death();
        }    
    }
    public override void DropearItem()
    {
        Debug.Log($"{nameID} dejó caer el Corazon de Africa (Diamante :D)");
    }
    public override void Death()
    {
        base.Death();
        DropearItem();
    }

}

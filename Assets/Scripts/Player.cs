using UnityEngine;

public class Player : EntityBase, IAtacable, IRecibirDaño
{
    private void Awake()
    {
        nameID = "Stinger";
        life = 150;
        atack = 25;
        defense = 8;
    }
    public override void Atacar(EntityBase objetivo)
    {
        Debug.Log($"{nameID} le disparo con su pistola de colmena a {objetivo.NameID} con presicion!");
        objetivo.RecibirDaño(atack);
    }

    public override void RecibirDaño(int cantidad)
    {
        int dañoFinal = Mathf.Max(0, cantidad - defense);
        life -= dañoFinal;
        Debug.Log($"{nameID} recibe {dañoFinal} de daño. Vida restante: {life}");

        if ( life <= 0 )
        {
            Death();
        }
    }

    public override void Death()
    {
        base.Death();
        Debug.Log("Stinger ha sido derrotado. Exfiltracion Fallida.");
    }
}

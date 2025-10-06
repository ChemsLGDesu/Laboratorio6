using UnityEngine;

public class Player : EntityBase, IAtacable, IRecibirDa�o
{
    public float speed = 5f;
    public float attackRange = 2f;
    public LayerMask enemyLayer;

    private Rigidbody2D rb;
    private Vector2 movement;
    private void Awake()
    {
        nameID = "Stinger";
        life = 150;
        atack = 25;
        defense = 8;
    }
    public override void Atacar(EntityBase objetivo)
    {
        Debug.Log($"{nameID} dispara con su pistla de colmena a {objetivo.NameID} con presicion!");
        objetivo.RecibirDa�o(atack);
    }

    public override void RecibirDa�o(int cantidad)
    {
        int da�oFinal = Mathf.Max(0, cantidad - defense);
        life -= da�oFinal;
        Debug.Log($"{nameID} recibe {da�oFinal} de da�o. Vida restante: {life}");

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

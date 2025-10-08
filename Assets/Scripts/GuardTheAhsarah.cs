using UnityEngine;

public class GuardTheAhsarah : EnemigoEntity, IAtacable,IRecibirDaño
{
    private void Awake()
    {
        nameID = "Guardian de Ahsarah";
        life = 100;
        atack = 15;
        defense = 5;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player jugador = collision.gameObject.GetComponent<Player>();
        if (jugador != null)
        {
            Atacar(jugador);
            jugador.Atacar(this);
        }
    }
    public override void Atacar(EntityBase objetivo)
    {
        Debug.Log($"{nameID} ataca con su cuchillo mariposa");
        objetivo.RecibirDaño(atack);
    }

    public override void RecibirDaño(int cantidad)
    {
        int dañoFinal = Mathf.Max(0, cantidad - defense);
        life -= dañoFinal;
        Debug.Log($"{nameID} recibe {dañoFinal} de daño. Vida restante: {life}");

        if (life <= 0)
        {
            Death();
        }         
    }
    public override void DropearItem()
    {
        Debug.Log($"{nameID} dejo caer una Copa de vino especial de Ahsarah con un valor de 65.000 de tekin!");
    }
    public override void Death()
    {
        base.Death();
        DropearItem();
    }
}

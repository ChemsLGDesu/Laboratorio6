using UnityEngine;

public abstract class EnemigoEntity : EntityBase, IDropearItem
{
    public float velocidad = 2f;
    public float ataque = 10f;
    public float distanciaAtaque = 1.2f;
    public float attackCooldown = 2f;
    private float lastAttackTime = 0f;

    protected Transform objetivo;
    public abstract void DropearItem();
    protected virtual void Start()
    {
        objetivo = GameObject.FindWithTag("Player")?.transform;
    }
    protected virtual void Update()
    {
        if (objetivo == null) return;

        // seguir al jugador
        float distancia = Vector2.Distance(transform.position, objetivo.position);

        if (distancia > distanciaAtaque)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                objetivo.position,
                velocidad * Time.deltaTime
            );
        }
        else
        {
            AtacarJugador();
        }
    }

    protected virtual void AtacarJugador()
    {
        if (Time.time - lastAttackTime < attackCooldown)
            return;

        Player player = objetivo.GetComponent<Player>();
        if (player != null)
        {
            player.RecibirDaño(atack);
            RecibirDaño(player.Atack); // el jugador también lo golpea
            Debug.Log($"{name} y el Player se golpearon!");

            lastAttackTime = Time.time;
        }
    }

    public override void RecibirDaño(int cantidad)
    {
        life -= cantidad;
        if (life <= 0)
        {
            Debug.Log($"{name} fue derrotado");
            Destroy(gameObject);
        }
    }
}


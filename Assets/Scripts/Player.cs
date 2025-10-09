using UnityEngine;

public class Player : EntityBase, IAtacable, IRecibirDaño
{
    [SerializeField] private float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    private void Awake()
    {
        nameID = "Stinger";
        life = 150;
        atack = 25;
        defense = 8;
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemigoEntity enemigo = collision.gameObject.GetComponent<EnemigoEntity>();
        if (enemigo != null)
        {
            Atacar(enemigo);
            enemigo.Atacar(this);
        }
    }
    private void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }
    public override void Atacar(EntityBase objetivo)
    {
        Debug.Log($"{nameID} dispara con su pistla de colmena a {objetivo.NameID} con presicion!");
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

    


using UnityEngine;

public class kit : Item, IConsumible
{
    [SerializeField] private Player player;
    public int lifeRecovered = 50;

    private void Awake()
    {
        Name = "Botiquin de Campo";
        player = FindFirstObjectByType<Player>(); ; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Usar();
        }
    }

    public override void Usar()
    {
        Consumir();
    }

    public void Consumir()
    {
        if (player != null)
        {
            player.Vida += lifeRecovered;
            Debug.Log($"Usaste el {Name} y recuperaste {lifeRecovered} puntos de vida. Vida actual: {player.Vida}");
        }
        else
        {
            Debug.Log("No se encontró al jugador para curar.");
        }
    }
}
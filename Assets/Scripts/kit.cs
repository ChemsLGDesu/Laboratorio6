using UnityEngine;

public class kit : Item, IConsumible
{
    public int lifeRecovered = 50;
    private Player player; // referencia al jugador

    private void Awake()
    {
        Name = "Botiquin de Campo";
        player = FindObjectOfType<Player>(); // busca al Player en la escena
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
            player.Vida += lifeRecovered; // aumenta la vida
            Debug.Log($"Usaste el {Name} y recuperaste {lifeRecovered} puntos de vida. Vida actual: {player.Vida}");
        }
        else
        {
            Debug.LogWarning("No se encontró al jugador para curar.");
        }
    }
}
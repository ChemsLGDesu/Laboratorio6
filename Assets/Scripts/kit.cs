using UnityEngine;

public class kit : Item, IConsumible
{
    public int lifeRecovered = 50;
    private void Awake()
    {
        Name = "Botiquin de Campo";
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
        Debug.Log($"Usaste el {Name} y recuperaste {lifeRecovered} puntos de vida");
        lifeRecovered++;
    }
}

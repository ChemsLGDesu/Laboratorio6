using UnityEngine;

public class BuffItem : Item, IAplicarBuff
{
    public int increaseAttack = 10;
    private void Awake()
    {
        Name = "Buff Colmena";
    }

    public override void Usar()
    {
        Debug.Log($"{Name} aumento el daño de su Pistola de Colmena ");
    }

    public void AplicarBuff(EntityBase objetivo)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            objetivo.GetType().GetProperty("ataque")?.SetValue(objetivo, objetivo.Atack + increaseAttack);
            Debug.Log($"{objetivo.NameID} recibe un buff de +{increaseAttack} ataque!");
        }
    }
}

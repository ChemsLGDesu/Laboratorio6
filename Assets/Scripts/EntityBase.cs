using UnityEngine;

public abstract class EntityBase : MonoBehaviour
{
    [SerializeField] protected string nameID;
    [SerializeField] protected float life = 100f;
    [SerializeField] protected int atack;
    [SerializeField] protected int defense;
    [SerializeField] protected float vidaMaxima = 150f;

    public float Vida
    {
        get => life;
        set
        {
            life = Mathf.Clamp(value, 0, vidaMaxima);
            if (life == 0 && !estaMuerto)
            {
                Death();
            }
        }
    }
    protected bool estaMuerto = false;
    public string NameID => nameID;
    public float Life { get => life; protected set => life = value; }
    public int Atack => atack;
    public int Defense => defense;

    public abstract void Atacar(EntityBase objetivo);
    public abstract void RecibirDaño(int cantidad);

    public virtual void Death()
    {
        estaMuerto = true;
        Debug.Log($"{name} ha muerto.");
        Destroy(gameObject);
    }
    
    public virtual void MostrarInfo()
    {
        Debug.Log($"[{nameID}] Vida: {life}, Ataque: {atack}, Defensa: {defense}");
    }
}

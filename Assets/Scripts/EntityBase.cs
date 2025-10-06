using UnityEngine;

public abstract class EntityBase : MonoBehaviour
{
    [SerializeField] protected string nameID;
    [SerializeField] protected int life;
    [SerializeField] protected int atack;
    [SerializeField] protected int defense;

    public string NameID => nameID;
    public int Life { get => life; protected set => life = value; }
    public int Atack => atack;
    public int Defense => defense;

    public abstract void Atacar(EntityBase objetivo);
    public abstract void RecibirDaño(int cantidad);

    public virtual void Death()
    {
        Debug.Log($"{nameID} ha sido derrotado ");
    }
    public virtual void MostrarInfo()
    {
        Debug.Log($"[{nameID}] Vida: {life}, Ataque: {atack}, Defensa: {defense}");
    }
}

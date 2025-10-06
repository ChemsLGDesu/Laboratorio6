using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player stinger;
    public GuardTheAhsarah guardTheAhsarah;
    public Saeed saeed;
    public GameObject kitPrefab;
    void Start()
    {
        stinger = gameObject.AddComponent<Player>();
        guardTheAhsarah = gameObject.AddComponent<GuardTheAhsarah>();
        saeed = gameObject.AddComponent<Saeed>();
        kit kit = new kit();
        BuffItem buffColmena = new BuffItem();


        stinger.MostrarInfo();
        guardTheAhsarah.MostrarInfo();
        saeed.MostrarInfo();

        stinger.Atacar(guardTheAhsarah);
        guardTheAhsarah.Atacar(stinger);
        saeed.Atacar(stinger);

        kit.Usar();
        buffColmena.AplicarBuff(stinger);
    }
}

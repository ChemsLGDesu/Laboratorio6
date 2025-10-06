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

        Vector3 posicionSpawn = new Vector3(0, 1, 0);
        Instantiate(kitPrefab, posicionSpawn, Quaternion.identity);

        BuffItem buffItem= new BuffItem();

        stinger.MostrarInfo();
        guardTheAhsarah.MostrarInfo();
        saeed.MostrarInfo();

        stinger.Atacar(guardTheAhsarah);
        guardTheAhsarah.Atacar(stinger);
        saeed.Atacar(stinger);

        kit.Usar();
        buffItem.AplicarBuff(stinger);
    }
}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player stinger;
    public GuardTheAhsarah guardTheAhsarah;
    public Saeed saeed;
    public GameObject kitPrefab;

    void Start()
    {
        GameObject playerGO = new GameObject("Player");
        stinger = playerGO.AddComponent<Player>();

        GameObject guardGO = new GameObject("GuardTheAhsarah");
        guardTheAhsarah = guardGO.AddComponent<GuardTheAhsarah>();

        GameObject saeedGO = new GameObject("Saeed");
        saeed = saeedGO.AddComponent<Saeed>();

        Vector3 kitSpawn = new Vector3(0, 1, 0);
        GameObject go = Instantiate(kitPrefab, kitSpawn, Quaternion.identity);
        kit kitComp = go.GetComponent<kit>();
        kitComp.Usar(stinger);

        BuffItem buffColmena = new BuffItem();

        stinger.MostrarInfo();
        guardTheAhsarah.MostrarInfo();
        saeed.MostrarInfo();

        stinger.Atacar(guardTheAhsarah);
        guardTheAhsarah.Atacar(stinger);
        saeed.Atacar(stinger);

        buffColmena.AplicarBuff(stinger);
    }
}

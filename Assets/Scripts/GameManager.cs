using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject guardPrefab;
    public GameObject saeedPrefab;
    public GameObject kitPrefab;

    private Player stinger;
    private GuardTheAhsarah guardTheAhsarah;
    private Saeed saeed;

    void Start()
    {
        // Instanciamos los personajes visibles en escena
        GameObject playerGO = Instantiate(playerPrefab, new Vector3(-2, 0, 0), Quaternion.identity);
        stinger = playerGO.GetComponent<Player>();

        GameObject guardGO = Instantiate(guardPrefab, new Vector3(2, 0, 0), Quaternion.identity);
        guardTheAhsarah = guardGO.GetComponent<GuardTheAhsarah>();

        GameObject saeedGO = Instantiate(saeedPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        saeed = saeedGO.GetComponent<Saeed>();

        // Spawneamos el kit
        Vector3 kitSpawn = new Vector3(0, 1, 0);
        GameObject go = Instantiate(kitPrefab, kitSpawn, Quaternion.identity);

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
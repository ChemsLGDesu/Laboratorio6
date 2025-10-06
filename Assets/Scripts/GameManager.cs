using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject guardPrefab;
    public GameObject saeedPrefab;
   
    private Player stinger;
    private GuardTheAhsarah guardTheAhsarah;
    private Saeed saeed;
    private BuffItem buffColmena;
    void Start()
    {    
        stinger = GetComponent<Player>();     
        guardTheAhsarah =GetComponent<GuardTheAhsarah>();
        saeed = GetComponent<Saeed>();

        

        stinger.MostrarInfo();
        guardTheAhsarah.MostrarInfo();
        saeed.MostrarInfo();

        stinger.Atacar(guardTheAhsarah);
        guardTheAhsarah.Atacar(stinger);
        saeed.Atacar(stinger);

        buffColmena.AplicarBuff(stinger);
    }
}
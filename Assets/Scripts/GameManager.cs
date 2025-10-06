using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player jugadorManager;
    [SerializeField] private GuardTheAhsarah guardManager;
    [SerializeField] private Saeed saeedManager;

    void Start()
    {
        Player Stinger = new Player();
        GuardTheAhsarah guard = new GuardTheAhsarah();
        Saeed saeed = new Saeed();
        kit botiquin = new kit();
        BuffItem buffItem = new BuffItem();

        Stinger.MostrarInfo();
        guard.MostrarInfo();
        saeed.MostrarInfo();

        Stinger.Atacar(guard);
        guard.Atacar(Stinger);
        saeed.Atacar(Stinger);

        botiquin.Usar();
        buffItem.AplicarBuff(Stinger);
    }
}
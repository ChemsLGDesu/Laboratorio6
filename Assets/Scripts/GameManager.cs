using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player Stinger = new Player();
        GuardTheAhsarah guardTheAhsarah = new GuardTheAhsarah();
        Saeed saeed = new Saeed();
        kit kit = new kit();
        BuffItem buffItem = new BuffItem();

        Stinger.MostrarInfo();
        guardTheAhsarah.MostrarInfo();
        saeed.MostrarInfo();

        Stinger.Atacar(guardTheAhsarah);
        guardTheAhsarah.Atacar(Stinger);
        saeed.Atacar(Stinger);

        kit.Usar();
        buffItem.AplicarBuff(Stinger);
    }
}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player Stinger;
    [SerializeField] private GuardTheAhsarah guard;
    [SerializeField] private Saeed saeed;
    [SerializeField] private kit botiquin;
    [SerializeField] private BuffItem buffDamage;
    void Start()
    {
        Stinger.Atacar(guard);
        guard.Atacar(Stinger);
        saeed.Atacar(Stinger);

        botiquin.Usar();
        buffDamage.AplicarBuff(Stinger);
    }

    void Update()
    {
        
    }
}
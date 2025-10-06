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
        Stinger = new GameObject("Player").AddComponent<Player>();
        guard = new GameObject("Goblin").AddComponent<GuardTheAhsarah>();
        saeed = new GameObject("Demonio").AddComponent<Saeed>();
        botiquin = new GameObject("Pocion").AddComponent<kit>();
        buffDamage = new GameObject("BuffItem").AddComponent<BuffItem>();

        Stinger.Atacar(guard);
        guard.Atacar(Stinger);
        saeed.Atacar(Stinger);

        botiquin.Usar();
        buffDamage.AplicarBuff(Stinger);
    }
}
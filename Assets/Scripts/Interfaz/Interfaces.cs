public interface IRecibirDaño
{
    void RecibirDaño(int cantidad);
}

public interface IAtacable
{
    void Atacar(EntityBase objetivo);
}

public interface IDropearItem
{
    void DropearItem();
}

public interface IAplicarBuff
{
    void AplicarBuff(EntityBase objetivo);
}

public interface IConsumible
{
    void Consumir();
}


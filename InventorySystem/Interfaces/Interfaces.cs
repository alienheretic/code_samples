public interface IEquipment
{
    void Equip(ItemData item);
    void Unequip(ItemData item);
    bool IsEquipped(ItemData item);
}

public interface IHealth
{
    void Heal(int amount);
    void TakeDamage(int amount);
}

public interface IUsable
{
    void Use(InventoryContext context);
}

public interface IEquipable
{
    void Equip(InventoryContext context);
}

public interface IConsumable
{
    void Consume(InventoryContext context);
}
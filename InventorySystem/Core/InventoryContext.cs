using UnityEngine;

public class InventoryContext
{
    public Inventory Inventory { get; }
    public IHealth Health { get; }
    public IEquipment Equipment { get; }

    public InventoryContext(
        Inventory inventory,
        IHealth health,
        IEquipment equipment)
    {
        Inventory = inventory;
        Health = health;
        Equipment = equipment;
    }
}


using UnityEngine;

public class PlayerEquipment : MonoBehaviour, IEquipment
{
    public void Equip(ItemData item)
    {
        Debug.Log($"Equipped {item.name}");
    }

    public void Unequip(ItemData item)
    {
        Debug.Log($"Unequipped {item.name}");
    }

    public bool IsEquipped(ItemData item)
    {
        return false;
    }
}

using UnityEngine;

[System.Serializable]
public class InventorySlot
{
    public ItemData Item;
    public int Quantity;

    public bool IsEmpty => Item == null || Quantity <= 0;

    public bool CanStack(ItemData item)
    {
        return Item == item && item.isStackable && Quantity < item.maxStack;
    }
}

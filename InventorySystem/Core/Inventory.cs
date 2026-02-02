using System.Collections.Generic;

public class Inventory
{
    private readonly List<InventorySlot> slots;
    public IReadOnlyList<InventorySlot> Slots => slots;

    public Inventory(int size)
    {
        slots = new List<InventorySlot>(size);
        for (int i = 0; i < size; i++)
		{
            slots.Add(new InventorySlot());
			}
    }

    public bool AddItem(ItemData item, int amount = 1)
    {
        foreach (var slot in slots)
        {
            if (slot.CanStack(item))
            {
                slot.Quantity += amount;
                return true;
            }
        }

        foreach (var slot in slots)
        {
            if (slot.IsEmpty)
            {
                slot.Item = item;
                slot.Quantity = amount;
                return true;
            }
        }

        return false;
    }

    public void RemoveItem(ItemData item, int amount)
    {
        foreach (var slot in slots)
        {
            if (slot.Item != item) continue;

            slot.Quantity -= amount;
            if (slot.Quantity <= 0)
			{
                slot.Item = null;
			}
            return;
        }
    }
}

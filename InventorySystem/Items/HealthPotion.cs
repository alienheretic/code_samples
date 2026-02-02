using UnityEngine;

[CreateAssetMenu(menuName = "Items/Consumable/Health Potion")]
public class HealthPotion : ItemData, IUsable, IConsumable
{
    public int healAmount = 50;

    public void Use(InventoryContext context)
    {
        Consume(context);
    }

    public void Consume(InventoryContext context)
    {
        context.Health.Heal(healAmount);
        context.Inventory.RemoveItem(this, 1);
    }
}

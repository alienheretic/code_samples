public static class InventoryItemExecutor
{
    public static void UseItem(ItemData item, InventoryContext context)
    {
        if (item is IUsable usable)
		{
            usable.Use(context);
		}
    }
}

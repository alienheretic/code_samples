# Unity ScriptableObject Inventory System

A modular, data-driven inventory system built in Unity using ScriptableObjects and interface-based architecture.

This project demonstrates clean separation of concerns, extensibility, and engine-agnostic core logic suitable for small to mid-sized Unity projects.

---

## ✨ Features

- ScriptableObject-based item definitions
- Interface-driven item behavior (use, consume, equip)
- Inventory logic decoupled from player systems
- Dependency injection via `InventoryContext`
- Stackable items with configurable limits
- Example player health and equipment implementations

---

## 🧱 Architecture Overview

The inventory system is split into three layers:

### Core
Pure C# logic with no MonoBehaviour or scene dependencies.

- `Inventory`
- `InventorySlot`
- `InventoryContext`

### Interfaces
Contracts used by items to interact with external systems.

- `IHealth`
- `IEquipment`
- `IUsable`
- `IConsumable`

### Items
ScriptableObjects that define data and behavior.

- `ItemData`
- `HealthPotion`

Example implementations (player health and equipment) are provided in the `Examples` folder.

---

## 🔁 InventoryContext

Items do not reference concrete gameplay systems directly.  
Instead, they receive an `InventoryContext`, which exposes only the interfaces they need.

This allows:
- Easy system swapping
- Unit testing without scene setup
- Reuse for AI or non-player entities

---

## 🚀 Example Usage

```csharp
Inventory inventory = new Inventory(16);
InventoryContext context = new InventoryContext(
    inventory,
    playerHealth,
    playerEquipment
);

item.Use(context);

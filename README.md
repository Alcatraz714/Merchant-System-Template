# **Unity Shop & Inventory System (Event-Driven MVC Architecture)**
A fully functional **UI-based Shop & Inventory System** for Unity, using the **MVC pattern** and an **event-driven system with Actions**. This system allows players to **buy, sell, and gather items** while managing inventory weight and item rarity.

---

## **📌 Features**
✔ **Shop System** with **4 types of iems** (Materials, Weapons, Consumables, Treasure)  
✔ **Inventory System** with weight limit & real-time UI updates  
✔ **Dynamic Item Tooltips** (Displays item details on hover)  
✔ **Event-Driven Architecture** (Uses C# Actions for clean & modular code)  
✔ **Sound System** (Plays sounds for buying, selling, and gathering)  
✔ **Gathering System** (Collects random items, disabled when overweight)  

---

## **📂 Project Structure**
```plaintext
📦 Assets
 ┣ 📂 Scripts
 ┃ ┣ 📂 Controllers
 ┃ ┃ ┣ 📜 ShopController.cs
 ┃ ┃ ┣ 📜 InventoryController.cs
 ┃ ┃ ┣ 📜 GatheringManager.cs
 ┃ ┃ ┗ 📜 SoundManager.cs
 ┃ ┣ 📂 Models
 ┃ ┃ ┣ 📜 ItemData.cs
 ┃ ┃ ┗ 📜 InventoryModel.cs
 ┃ ┃ ┗ 📜 ShopModel.cs
 ┃ ┣ 📂 Views
 ┃ ┃ ┣ 📜 ShopView.cs
 ┃ ┃ ┣ 📜 InventoryView.cs
 ┃ ┃ ┗ 📜 TooltipManager.cs
 ┃ ┃ ┗ 📜 InventoryView.cs
 ┃ ┃ ┗ 📜 ShopView.cs
 ┣ 📂 Prefabs
 ┃ ┣ 📜 ItemPrefab.prefab
 ┃ ┣ 📜 TooltipPrefab.prefab
 ┣ 📂 UI
 ┃ ┣ 📜 UiManager.cs
 ┃ ┗ 📜 OverweightPopup.prefab
```

## 🎮 Gameplay Mechanics
### 🛒 Buying Items
1. Select an item from the **Shop Grid**.
2. Click on merchant panel to buy the item and hover to see the details.
3. Gold decreases & Inventory weight updates.

### 💰 Selling Items
1. Select an item from the **Inventory Grid**.
2. Click on player panel to sell the item and hover to see the details.
3. Gold increases & Inventory weight updates.

### ⛏️ Gathering Items
1. Click **"Gather"** to receive **3 random items**.
2. Rarity of gathered items depends on **player weight**.
3. If **max weight is exceeded**, gathering is **disabled**.

---

## 🚀 Credits
Developed by **Rishi Saxena**  
If you find this useful, fork or raise tickets to add new features...


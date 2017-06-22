using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    /* I've tried to make an inventory myself, didnt work out in any way..
     * So I searched for a tutorial (it's from a Youtuber named GameGrind) and followed it.
     * 
     * I followed the first couple of episode, but the further i got into the series the complicater it got..
     * So this is what I ended up with.. watched and followed this for 6 hours by now, hopefully you can see the effort I tried to put in to this assignment.
     */

    #region Variables
    public List<Item> inventory = new List<Item>();
    public List<Item> slots = new List<Item>();

    private ItemDatabase database;

    public GUISkin skin;

    private bool showInventory;
    private bool showTooltip;
    private string tooltip;

    private bool draggingItem;
    private Item draggedItem;
    private int prevIndex;

    public int slotsX, slotsY;
    #endregion

    void Start () {
        for (int i = 0; i < slotsX * slotsY; i++) {
            slots.Add(new Item());
            inventory.Add(new Item());
        }

        database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>();

        AddItem(3);
        AddItem(0);
        AddItem(2);
        AddItem(4);
        AddItem(1);
    }

    void Update () {
        if (Input.GetButtonDown("Inventory")) {
            showInventory = !showInventory;
        }
	}

    void OnGUI() {
        tooltip = "";
        GUI.skin = skin;

        if (showInventory) {
            DrawInventory();

            if (showTooltip) {
                GUI.Box(new Rect(10 + Event.current.mousePosition.x, 15 + Event.current.mousePosition.y, 200, 100), tooltip, skin.GetStyle("Tooltip"));
            }
        }

        if (draggingItem) {
            GUI.DrawTexture(new Rect(10 + Event.current.mousePosition.x, 15 + Event.current.mousePosition.y, 50, 50), draggedItem.itemIcon);
        }
    }

    void DrawInventory() {
        Event e = Event.current;

        int i = 0;

        for (int y = 0; y < slotsY; y++) {
            for (int x = 0; x < slotsX; x++) {

                Rect slotRect = new Rect(10 + (x * 55), 10 + (y * 55), 50, 50);
                GUI.Box(new Rect(slotRect), "", skin.GetStyle("Slot"));

                slots[i] = inventory[i];

                if (slots[i].itemName != null) {
                    GUI.DrawTexture(slotRect, slots[i].itemIcon);

                    if (slotRect.Contains(e.mousePosition)) {
                        tooltip = CreateTooltip(slots[i]);
                        showTooltip = true;

                        if (e.button == 0 && e.type == EventType.mouseDrag && !draggingItem) {
                            draggingItem = true;
                            prevIndex = i;
                            draggedItem = slots[i];
                            inventory[i] = new Item();
                        }

                        if (e.type == EventType.mouseUp && draggingItem) {
                            inventory[prevIndex] = inventory[i];
                            inventory[i] = draggedItem;
                            draggingItem = false;
                            draggedItem = null;
                        }
                    }
                }
                else {
                    if (slotRect.Contains(e.mousePosition)) {
                        if (e.type == EventType.mouseUp && draggingItem) {
                            inventory[i] = draggedItem;
                            draggingItem = false;
                            draggedItem = null;
                        }
                    }
                }

                if (tooltip == "") {
                    showTooltip = false;
                }

                i++;
            }
        }
    }

    string CreateTooltip(Item item) {
        tooltip = item.itemName + "\n\n" + item.itemDesc;
        return tooltip;
    }

    void AddItem(int id) {
        for (int i = 0; i < inventory.Count; i++) {
            if (inventory[i].itemName == null) {
                for (int j = 0; j < database.items.Count; j++) {
                    if (database.items[j].itemID == id) {
                        inventory[i] = database.items[j];
                    }
                }
                break;
            }
        }
    }

    void RemoveItem(int id) {
        for (int i = 0; i < inventory.Count; i++) {
            if (inventory[i].itemID == id) {
                inventory[i] = new Item();
                break;
            }
        }
    }

    bool InventoryContains(int id) {
        bool result = false;
        for (int i = 0; i < inventory.Count; i++) {
            result = inventory[i].itemID == id;
            if (result) {
                break;
            }
        }
        return result;
    }
}

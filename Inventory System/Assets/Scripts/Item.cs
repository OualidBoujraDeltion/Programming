using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item {

    /* I've tried to make an inventory myself, didnt work out in any way..
     * So I searched for a tutorial (it's from a Youtuber named GameGrind) and followed it.
     * 
     * I followed the first couple of episode, but the further i got into the series the complicater it got..
     * So this is what I ended up with.. watched and followed this for 6 hours by now, hopefully you can see the effort I tried to put in to this assignment.
     */

    #region Variables
    public int itemID;
    public string itemName;
    public string itemDesc;
    public Texture2D itemIcon;
    public ItemType itemType;
    #endregion

    [Space]

    #region Stats
    public int itemLevel;
    public int itemDurability;
    #endregion

    public enum ItemType {
        Weapon,
        Gear,
        Consumable,
        QuestItem
    }

    public Item(int id, string name, string desc, int ilevel, int durability, ItemType type) {
        itemID = id;
        itemName = name;
        itemDesc = desc;
        itemLevel = ilevel;
        itemDurability = durability;
        itemType = type;

        itemIcon = Resources.Load<Texture2D>("Item Icons/" + name);
    }

    public Item() {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item {

    #region Variables
    public int itemID;
    public string itemName;
    public string itemDesc;
    public Texture2D itemIcon;
    #endregion

    [Space]

    #region Stats
    public int itemLevel;
    public int itemDurability;
    #endregion

    public Item(int id, string name, string desc, int ilevel, int durability) {
        itemID = id;
        itemName = name;
        itemDesc = desc;
        itemLevel = ilevel;
        itemDurability = durability;

        itemIcon = Resources.Load<Texture2D>("Icons/" + name + " Icon");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {

    /* I've tried to make an inventory myself, didnt work out in any way..
     * So I searched for a tutorial (it's from a Youtuber named GameGrind) and followed it.
     * 
     * I followed the first couple of episode, but the further i got into the series the complicater it got..
     * So this is what I ended up with.. watched and followed this for 6 hours by now, hopefully you can see the effort I tried to put in to this assignment.
     */

    public List<Item> items = new List<Item>();

    void Start() {
        items.Add(new Item(0, "Sword", "This is very pointy.", 940, 100, Item.ItemType.Weapon));
        items.Add(new Item(1, "Clothing", "It's so comfy!", Random.Range(1, 10), Random.Range(50, 100), Item.ItemType.Gear));
        items.Add(new Item(2, "Gloves", "Makes you look cooler.", Random.Range(1, 10), Random.Range(50, 100), Item.ItemType.Gear));
        items.Add(new Item(3, "Shoes", "U. Bolt? Is that u?", Random.Range(1, 10), Random.Range(50, 100), Item.ItemType.Gear));
        items.Add(new Item(4, "Antidote", "It tastes like gravel.", 1, 0, Item.ItemType.Consumable));
    }
}

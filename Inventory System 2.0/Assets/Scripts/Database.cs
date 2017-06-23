using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour {

    public List<Item> items = new List<Item>();

    void Start() {
        items.Add(new Item(0, "Sword", "This is very pointy.", 940, 100));
        items.Add(new Item(1, "Clothing", "It's so comfy!", Random.Range(1, 10), Random.Range(50, 100)));
        items.Add(new Item(2, "Gloves", "Makes you look cooler.", Random.Range(1, 10), Random.Range(50, 100)));
        items.Add(new Item(3, "Shoes", "U. Bolt? Is that u?", Random.Range(1, 10), Random.Range(50, 100)));
        items.Add(new Item(4, "Antidote", "It tastes like gravel.", 1, 0));
    }
}

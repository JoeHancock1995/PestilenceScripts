using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour, IGameManager {
    public ManagerStatus status { get; private set; }

    private Dictionary<string> _items;

    public void Startup() {
     Debug.Log("Inventory manager starting...");

     _items = new Dictionary<string>();

     status = ManagerStatus.Started;
     }

    private void DisplayItems() {
        string itemDisplay = "Items: ";
        foreach (string item in _items) {
            itemDisplay += item + " ";
        }
       Debug.Log(itemDisplay);
    }
    public void AddItem(string name){
    if (_items.ContainsKey(name)) {
        _items[name] += 1;
    } else {
        _items[name] = 1;
    }
     DisplayItems();
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour {
    [SerializeField] private string itemName;

    void onTriggerEnter(Collider other) {
        Managers.Inventory.AddItem(name);
        Destroy(this.gameObject);
    } 
}

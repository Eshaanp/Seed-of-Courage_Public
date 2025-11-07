using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public InventoryItemData ItemData;
    // Start is called before the first frame update
    void Start()
    {
        // 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f")) {
            var inventory = GetComponent<InventoryHolder>();
            if (inventory.InventorySystem.AddToInventory(ItemData, 1))
            {
                //
            }
        }
    }

}

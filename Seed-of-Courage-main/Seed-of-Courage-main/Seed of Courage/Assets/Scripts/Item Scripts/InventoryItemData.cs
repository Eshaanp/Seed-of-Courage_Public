using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemData : ScriptableObject
{
    public int ID;
    public string displayName;
    [TextArea(4,4)]
    public string description;
    public Sprite icon;
    public int maxStackSize;
}

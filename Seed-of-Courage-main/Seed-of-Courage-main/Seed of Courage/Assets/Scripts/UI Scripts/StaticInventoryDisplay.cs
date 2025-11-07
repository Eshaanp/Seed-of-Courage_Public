using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class StaticInventoryDisplay : InventoryDisplay
{
    [SerializeField] private InventoryHolder inventoryHolder;
    [SerializeField] protected InventorySlot_UI[] slots;
    [SerializeField] public InventoryItemData startingItem;
    public string currentlyActiveItem;
    public int currentlyActiveSlot = 0;
    private float timer = 0.0f;
    private int firstItemAdded = 0;
    public override void AssignSlot(InventorySystem invToDisplay)
    {
        slotDictionary = new Dictionary<InventorySlot_UI, InventorySlot> ();

        if (slots.Length != inventorySystem.InventorySize) Debug.Log($"Inventory slots out of sync on {this.gameObject}");

        for (int i = 0; i < inventorySystem.InventorySize; i++)
        {
            slotDictionary.Add(slots[i], inventorySystem.InventorySlots[i]);
            slots[i].Init(inventorySystem.InventorySlots[i]);
        }
    }

    public override void OnUpdatedSlot()
    {
        SetActiveSlot(currentlyActiveSlot);
    }

    public void SetActiveSlot(int n)
    {
        slots[currentlyActiveSlot].background.color = new Color(0.52941f, 0.39608f, 0.39608f);
        currentlyActiveSlot = n;
        slots[n].background.color = new Color(0.92549f, 0.71373f, 0.71373f);

        if (slots[n].AssignedInventorySlot.ItemData == null) currentlyActiveItem = "none";
        else
        {
            string s = slots[n].AssignedInventorySlot.ItemData.displayName;
            if (s != null) currentlyActiveItem = s;
            else currentlyActiveItem = "none";
        }
    }

    protected override void Start()
    {
        base.Start();
        isStatic = 1;

        if (inventoryHolder != null)
        {
            inventorySystem = inventoryHolder.InventorySystem;
            inventorySystem.OnInventorySlotChanged += UpdateSlot;
        }
        else Debug.LogWarning($"No inventory assigned to {this.gameObject}");

        AssignSlot(inventorySystem);
    }

    public void Update()
    {
        if (firstItemAdded == 0)
        {
            timer += Time.deltaTime;
            if (timer > 0.01f)
            {
                inventorySystem.AddToInventory(startingItem, 1);
                firstItemAdded = 1;
                SetActiveSlot(0);
            }
        }
        else
        {
            if (Keyboard.current.digit1Key.wasPressedThisFrame)
            {
                SetActiveSlot(0);
            }

            if (Keyboard.current.digit2Key.wasPressedThisFrame)
            {
                SetActiveSlot(1);
            }

            if (Keyboard.current.digit3Key.wasPressedThisFrame)
            {
                SetActiveSlot(2);
            }

            if (Keyboard.current.digit4Key.wasPressedThisFrame)
            {
                SetActiveSlot(3);
            }

            if (Keyboard.current.digit5Key.wasPressedThisFrame)
            {
                SetActiveSlot(4);
            }

            if (Keyboard.current.digit6Key.wasPressedThisFrame)
            {
                SetActiveSlot(5);
            }

            if (Keyboard.current.digit7Key.wasPressedThisFrame)
            {
                SetActiveSlot(6);
            }

            if (Keyboard.current.digit8Key.wasPressedThisFrame)
            {
                SetActiveSlot(7);
            }
        }
    }
}

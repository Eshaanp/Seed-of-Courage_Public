using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryUIController : MonoBehaviour
{
    public DynamicInventoryDisplay inventoryPanel;
    public Transform player;
    public Collider colliderToCheck; // Assign the Box Collider in the Unity Editor
    public float timer = 0.0f;

    private void OnEnable()
    {
        InventoryHolder.OnDynamicInventoryDisplayRequested += DisplayInventory;
    }
    private void OnDisable()
    {
        InventoryHolder.OnDynamicInventoryDisplayRequested -= DisplayInventory;
    }

    void DisplayInventory(InventorySystem invToDisplay)
    {
        if (!inventoryPanel.gameObject.activeInHierarchy)
        {
            inventoryPanel.gameObject.SetActive(true);
            inventoryPanel.RefreshDynamicInventory(invToDisplay);
            timer = 0.0f;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        inventoryPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inventoryPanel.gameObject.activeInHierarchy)
        {
            Bounds bounds = colliderToCheck.bounds;
            // if (Keyboard.current.aKey.wasPressedThisFrame) Debug.Log(Vector3.Distance(bounds.center, player.position));
            if (player != null && Vector3.Distance(bounds.center, player.position) >= 5.0f) inventoryPanel.gameObject.SetActive(false);
            timer += Time.deltaTime;
            // Debug.Log(timer);
            if (timer > 0.01f)
            {
                if (Keyboard.current.eKey.wasPressedThisFrame) inventoryPanel.gameObject.SetActive(false);
            }
        }
    }
}

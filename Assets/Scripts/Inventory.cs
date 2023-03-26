using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryItemPrefab;
    public GameObject inventoryPanel;

    private List<Sprite> inventory = new List<Sprite>();
    private Sprite[,] inventoryGrid = new Sprite[2, 3];

    public void AddToInventory(Sprite item)
    {
        // Check if the inventory is full
        bool isFull = true;
        for (int x = 0; x < inventoryGrid.GetLength(0); x++)
        {
            for (int y = 0; y < inventoryGrid.GetLength(1); y++)
            {
                if (inventoryGrid[x, y] == null)
                {
                    isFull = false;
                    break;
                }
            }
        }



        if (isFull)
        {
            Debug.Log("Inventory is full!");
            return;
        }

        // Find an empty slot in the inventory
        for (int x = 0; x < inventoryGrid.GetLength(0); x++)
        {
            for (int y = 0; y < inventoryGrid.GetLength(1); y++)
            {
                if (inventoryGrid[x, y] == null)
                {
                    // Add the item to the first empty slot
                    inventoryGrid[x, y] = item;
                    UpdateInventoryPanel();
                    return;
                }
            }
        }
    }

    public void DeleteItem(Sprite item)
    {
        // Find the item in the inventory grid
        for (int x = 0; x < inventoryGrid.GetLength(0); x++)
        {
            for (int y = 0; y < inventoryGrid.GetLength(1); y++)
            {
                if (inventoryGrid[x, y] == item)
                {
                    // Remove the item from the grid
                    inventoryGrid[x, y] = null;
                    UpdateInventoryPanel();
                    return;
                }
            }
        }

        // Item not found in inventory
        Debug.Log("Item not found in inventory!");
    }

    private void UpdateInventoryPanel()
    {
        // Clear the inventory panel
        foreach (Transform child in inventoryPanel.transform)
        {
            Destroy(child.gameObject);
        }

        // Add each item to the inventory panel
        for (int x = 0; x < inventoryGrid.GetLength(0); x++)
        {
            for (int y = 0; y < inventoryGrid.GetLength(1); y++)
            {
                if (inventoryGrid[x, y] != null)
                {
                    GameObject inventoryItem = Instantiate(inventoryItemPrefab, inventoryPanel.transform);
                    inventoryItem.GetComponent<Image>().sprite = inventoryGrid[x, y];
                    RectTransform rectTransform = inventoryItem.GetComponent<RectTransform>();
                    rectTransform.anchorMin = new Vector2(x / (float)inventoryGrid.GetLength(0), 1 - (y + 1) / (float)inventoryGrid.GetLength(1));
                    rectTransform.anchorMax = new Vector2((x + 1) / (float)inventoryGrid.GetLength(0), 1 - y / (float)inventoryGrid.GetLength(1));
                    rectTransform.offsetMin = Vector2.zero;
                    rectTransform.offsetMax = Vector2.zero;
                }
            }
        }
    }
}

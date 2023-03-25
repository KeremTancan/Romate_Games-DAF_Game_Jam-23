using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Inventory inventoryManager;

    public void OnButtonClick(Button button)
    {
        Sprite item = button.GetComponent<Image>().sprite;
        inventoryManager.AddToInventory(item);
        
    }
}


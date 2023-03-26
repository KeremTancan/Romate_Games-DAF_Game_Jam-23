using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    public void OnClick(Button button)
    {
        Sprite item = button.GetComponent<Image>().sprite;
        inventoryManager.DeleteItem(item);
       
    }

    public void Clear()
    {
        inventoryManager.ClearInventory();
       
    }
}


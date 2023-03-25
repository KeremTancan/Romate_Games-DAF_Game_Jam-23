using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomButton : MonoBehaviour
{
    public Button[] buttons;
    public string[] itemTags;

    private void Start()
    {
        int randomIndex = Random.Range(0, buttons.Length);
        Button randomButton = buttons[randomIndex];

        
        switch (randomIndex)
        {
            case 0:
                randomButton.GetComponentInChildren<Text>().text = "Bring items with tag 'cay'";
                itemTags = new string[] { "cay" };
                break;
            case 1:
                randomButton.GetComponentInChildren<Text>().text = "Bring items with tag 'ekmek'";
                itemTags = new string[] { "ekmek" };
                break;
            case 2:
                randomButton.GetComponentInChildren<Text>().text = "Bring items with tag 'corba'";
                itemTags = new string[] { "corba" };
                break;
            case 3:
                randomButton.GetComponentInChildren<Text>().text = "Bring items with tag 'tonbaligi'";
                itemTags = new string[] { "tonbaligi" };
                break;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject panel; // Reference to the panel object

    public void OpenPanel()
    {
        panel.SetActive(true); // Set the panel object to be active
    }

    public void ClosePanel()
    {
        panel.SetActive(false); // Set the panel object to be inactive
    }
}



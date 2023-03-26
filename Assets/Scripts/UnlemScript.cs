using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlemScript : MonoBehaviour
{
    public int ButonSayisi = 6;
    public Inventory inventory;
    public GameObject Button;

    private void Update()
    {
        if (ButonSayisi == 0)
        {
            Button.SetActive(false);
        }
    }
    
}

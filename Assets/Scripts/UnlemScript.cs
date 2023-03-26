using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlemScript : MonoBehaviour
{
    public int ButonSayisi = 6;

    public Inventory inventory;
    public GameObject Button;


    private void Update()
    {
        ButtonCheck();

    }
    public void ButtonCheck()
    {
        if (ButonSayisi == 0)
        {
            Button.SetActive(false);
        }
    }
}

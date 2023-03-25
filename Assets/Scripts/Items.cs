using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField] public class Items : MonoBehaviour
{
    public string Name { get; set; }
    public Sprite Sprite { get; set; }

    public Items(string name, Sprite sprite)
    {
        Name = name;
        Sprite = sprite;
    }
}

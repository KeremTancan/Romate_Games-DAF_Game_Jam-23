using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMove : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = player.position + offset;
        transform.rotation = Quaternion.Euler(0, 0, 0); // lock rotation
    }
}


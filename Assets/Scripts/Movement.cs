using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;

    void Update()
    {
        // Get the horizontal input axis based on arrow keys or WASD keys
        float horizontalInput = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) ? 1f :
                                 Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) ? -1f : 0f;

        // Calculate the rotation amount based on the input
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;

        // Rotate the car sprite around the z-axis
        transform.Rotate(0f, 0f, rotationAmount);

        // Get the vertical input axis based on arrow keys or WASD keys
        float verticalInput = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) ? 1f :
                               Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) ? -1f : 0f;

        // Calculate the movement vector
        Vector2 movement = transform.up * verticalInput * speed * Time.deltaTime;

        // Apply the movement to the car's position
        transform.position += (Vector3)movement;
    }
}






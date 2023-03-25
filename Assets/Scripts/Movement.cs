using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{

   
        public Rigidbody2D rb;

        public GameObject upSprite;
        public GameObject downSprite;
        public GameObject leftSprite;
        public GameObject rightSprite;

        public float speed = 5f;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();

            upSprite = transform.Find("Up").gameObject;
            downSprite = transform.Find("Down").gameObject;
            leftSprite = transform.Find("Left").gameObject;
            rightSprite = transform.Find("Right").gameObject;
        }

        void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            if (horizontal != 0f || vertical != 0f)
            {
                Vector2 movement = new Vector2(horizontal, vertical);
                rb.velocity = movement.normalized * speed;

                if (horizontal > 0f)
                {
                    rightSprite.SetActive(true);
                    upSprite.SetActive(false);
                    downSprite.SetActive(false);
                    leftSprite.SetActive(false);
                }
                else if (horizontal < 0f)
                {
                    leftSprite.SetActive(true);
                    upSprite.SetActive(false);
                    downSprite.SetActive(false);
                    rightSprite.SetActive(false);
                }

                if (vertical > 0f)
                {
                    upSprite.SetActive(true);
                    rightSprite.SetActive(false);
                    downSprite.SetActive(false);
                    leftSprite.SetActive(false);
                }
                else if (vertical < 0f)
                {
                    downSprite.SetActive(true);
                    upSprite.SetActive(false);
                    rightSprite.SetActive(false);
                    leftSprite.SetActive(false);
                }
            }
            else
            {
                rb.velocity = Vector2.zero;
            }
        }
    }











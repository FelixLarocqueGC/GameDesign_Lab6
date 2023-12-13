using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.0f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xDir = 0.0f;
        float yDir = 0.0f;
        if (Input.GetKey(KeyCode.W))
        {
            yDir = 1.0f;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            yDir = -1.0f;
        }
        else
        {
            yDir = 0;
        }

        if (Input.GetKey(KeyCode.A))
        {
            xDir = -1.0f;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            xDir = 1.0f;
        }
        else
        {
            xDir = 0;
        }

        transform.position += new Vector3(xDir * speed, yDir * speed, 0.0f) * Time.deltaTime;

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCode : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TextJosh"))
        {
            
        }
    }
}
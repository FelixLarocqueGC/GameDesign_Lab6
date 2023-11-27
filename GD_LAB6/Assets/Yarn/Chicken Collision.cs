using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public int ChickenCounter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Chicken"){
            ChickenCounter++;
            collision.gameObject.SetActive(false);

        }
    }
}

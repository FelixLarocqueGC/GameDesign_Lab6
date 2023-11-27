using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public int ChickenCounter;
    
    void OnCollisionEnter(Collision Col)
    { 
        if(Col.gameObject.tag == "Chicken")
        {
            ChickenCounter++;
            Destroy(Col.gameObject);
        }
    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeparateEndings : MonoBehaviour
{
    public GameObject player;


    void Update()
    {
        if (player.GetComponent<ChickenCollision>().ChickenCounter == 3)
        {
            GetComponent<YarnInteractable>().conversationStartNode = "FEnd1";
        }
        else if (player.GetComponent<ChickenCollision>().ChickenCounter <= 3 && player.GetComponent<ChickenCollision>().ChickenCounter > 0)
        {
            GetComponent<YarnInteractable>().conversationStartNode = "FEnd2";
        }

    }
}
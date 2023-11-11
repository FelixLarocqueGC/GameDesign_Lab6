using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCode : MonoBehaviour
{
    private DialogueRunner myDialogueRunner;


    void Start()
    {
        myDialogueRunner = GetComponent<DialogueRunner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Text") && Input.GetKey(KeyCode.E))

        {
            myDialogueRunner.enabled = !myDialogueRunner.enabled;
        }
    }
}
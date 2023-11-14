using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnInteractable : MonoBehaviour
{
    private DialogueRunner dialogueRunner;

    public void Start()
    {
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        dialogueRunner.onDialogueComplete.AddListener(EndConversation);
    }

    // then we need a function to tell Yarn Spinner to start from {specifiedNodeName}
    public string conversationStartNode;

    private bool isCurrentConversation;

    public void StartConversation()
    {
        isCurrentConversation = true;
        // TODO *begin animation or turn on speaker indicator or whatever* HERE
        dialogueRunner.StartDialogue(conversationStartNode);
    }

    private void EndConversation()
    {
        if (isCurrentConversation)
        {
            // TODO *stop animation or turn off indicator or whatever* HERE
            isCurrentConversation = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player && Input.GetKey(KeyCode.E))

        {
        
            if (!isCurrentConversation) 
            {
                player.walkAllowed = false;
                StartConversation();

            }

        }
    }
}

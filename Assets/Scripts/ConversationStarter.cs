using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour
{
    [SerializeField] public NPCConversation conversation;
    [SerializeField] private GameObject player;
    [SerializeField] private DialogueManager dialogueManager;
    private bool onTrigger = false;

    private void Start()
    {
    }
    private void Update()
    {
        StartDialogue();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onTrigger = true;
            Debug.Log("Player is in trigger zone");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onTrigger = false;
            Debug.Log("Player is out of trigger zone");
        }
    }

    void StartDialogue()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!ConversationManager.Instance.IsConversationActive)
                {
                    ConversationManager.Instance.StartConversation(conversation);
                }
            }
        }
    }
}

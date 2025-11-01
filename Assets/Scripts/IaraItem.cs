using UnityEngine;
using UnityEngine.InputSystem.Controls;
using DialogueEditor;

public class IaraItem : MonoBehaviour
{
    GameManager gameManager;
    DialogueManager dialogueManager;
    [SerializeField] private int itemNumber;

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        dialogueManager = FindFirstObjectByType<DialogueManager>();
    }
    public void GrabItem()
    {   
        if (dialogueManager.dialogueIaraIndex == itemNumber)
        {
            gameObject.SetActive(false);
            gameManager.letters[dialogueManager.dialogueIaraIndex - 1].SetActive(true);
            gameManager.items[dialogueManager.dialogueIaraIndex - 1].SetActive(false);
            dialogueManager.dialogueIaraIndex++;
        }
        if (dialogueManager.dialogueIaraIndex == 3 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueBaiacu);
        }
        if (dialogueManager.dialogueIaraIndex == 4 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueCogumelo);
        }
        if (dialogueManager.dialogueIaraIndex == 5 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueDisco);
        }
        if (dialogueManager.dialogueIaraIndex == 6 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueEscova);
        }
        if (dialogueManager.dialogueIaraIndex == 7 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueFlecha);
        }
        if (dialogueManager.dialogueIaraIndex == 8 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueGarrafa);
        }
        if (dialogueManager.dialogueIaraIndex == 9 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueHamburguer);
        }
        if (dialogueManager.dialogueIaraIndex == 10 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueIma);
        }
        if (dialogueManager.dialogueIaraIndex == 11 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueJornal);
        }
        if (dialogueManager.dialogueIaraIndex == 12 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueKetchup);
        }
        if (dialogueManager.dialogueIaraIndex == 13 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueLivro);
        }
        if (dialogueManager.dialogueIaraIndex == 14 && itemNumber == dialogueManager.dialogueIaraIndex - 1)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueMaca);
        }
    }
}

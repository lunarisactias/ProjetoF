using UnityEngine;
using DialogueEditor;

public class CurupiraItem : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] private int itemNumber;

    public void GrabItem()
    {
        if (dialogueManager.dialogueCurupiraIndex == itemNumber)
        {
            gameObject.SetActive(false);
            gameManager.letters[dialogueManager.dialogueCurupiraIndex + 12].SetActive(true);
            dialogueManager.dialogueCurupiraIndex++;
        }
        if (dialogueManager.dialogueCurupiraIndex == 2 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueNinho);
        }
        if (dialogueManager.dialogueCurupiraIndex == 3 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueOculos);
        }
        if (dialogueManager.dialogueCurupiraIndex == 4 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialoguePlaca);
        }
        if (dialogueManager.dialogueCurupiraIndex == 5 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueQueijo);
        }
        if (dialogueManager.dialogueCurupiraIndex == 6 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueRelogio);
        }
        if (dialogueManager.dialogueCurupiraIndex == 7 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueSapato);
        }
        if (dialogueManager.dialogueCurupiraIndex == 8 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueTigela);
        }
        if (dialogueManager.dialogueCurupiraIndex == 9 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueUvas);
        }
        if (dialogueManager.dialogueCurupiraIndex == 10 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueViolao);
        }
        if (dialogueManager.dialogueCurupiraIndex == 11 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueWaffle);
        }
        if (dialogueManager.dialogueCurupiraIndex == 12 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueXicara);
        }
        if (dialogueManager.dialogueCurupiraIndex == 13 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueYakult);
        }
        if (dialogueManager.dialogueCurupiraIndex == 14 && itemNumber == dialogueManager.dialogueIaraIndex)
        {
            ConversationManager.Instance.StartConversation(dialogueManager.dialogueZebra);
        }
    }
}

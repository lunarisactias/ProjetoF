using DialogueEditor;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameManager gameManager;

    [Header("Dialogue Index")]
    [SerializeField] public int dialogueIaraIndex = 1;
    [SerializeField] public int dialogueCurupiraIndex = 1;

    [Header("Dialogue Triggers")]
    [SerializeField] private ConversationStarter dialogueFadaTrigger;
    [SerializeField] private ConversationStarter dialogueIaraTrigger;
    [SerializeField] private ConversationStarter dialogueCurupiraTrigger;

    [Header("Iara Dialogues")]
    [SerializeField] public NPCConversation dialogueIara1;
    [SerializeField] public NPCConversation dialogueIara2;
    [SerializeField] public NPCConversation dialogueIara3;
    [SerializeField] public NPCConversation dialogueBaiacu;
    [SerializeField] public NPCConversation dialogueIara4;
    [SerializeField] public NPCConversation dialogueCogumelo;
    [SerializeField] public NPCConversation dialogueDisco;
    [SerializeField] public NPCConversation dialogueIara5;
    [SerializeField] public NPCConversation dialogueEscova;
    [SerializeField] public NPCConversation dialogueIara6;
    [SerializeField] public NPCConversation dialogueFlecha;
    [SerializeField] public NPCConversation dialogueIara7;
    [SerializeField] public NPCConversation dialogueGarrafa;
    [SerializeField] public NPCConversation dialogueIara8;
    [SerializeField] public NPCConversation dialogueHamburguer;
    [SerializeField] public NPCConversation dialogueIara9;
    [SerializeField] public NPCConversation dialogueIma;
    [SerializeField] public NPCConversation dialogueIara10;
    [SerializeField] public NPCConversation dialogueIara11;
    [SerializeField] public NPCConversation dialogueJornal;
    [SerializeField] public NPCConversation dialogueIara12;
    [SerializeField] public NPCConversation dialogueKetchup;
    [SerializeField] public NPCConversation dialogueIara13;
    [SerializeField] public NPCConversation dialogueLivro;
    [SerializeField] public NPCConversation dialogueIara14;
    [SerializeField] public NPCConversation dialogueMaca;

    [Header("Curupira Dialogues")]
    [SerializeField] public NPCConversation dialogueCurupira1;
    [SerializeField] public NPCConversation dialogueCurupira2;
    [SerializeField] public NPCConversation dialogueCurupira3;
    [SerializeField] public NPCConversation dialogueCurupira4;
    [SerializeField] public NPCConversation dialogueCurupira5;
    [SerializeField] public NPCConversation dialogueCurupira6;
    [SerializeField] public NPCConversation dialogueCurupira7;
    [SerializeField] public NPCConversation dialogueCurupira8;
    [SerializeField] public NPCConversation dialogueCurupira9;
    [SerializeField] public NPCConversation dialogueCurupira10;
    [SerializeField] public NPCConversation dialogueCurupira11;
    [SerializeField] public NPCConversation dialogueCurupira12;
    [SerializeField] public NPCConversation dialogueCurupira13;
    [SerializeField] public NPCConversation dialogueCurupira14;
    [SerializeField] public NPCConversation dialogueNinho;
    [SerializeField] public NPCConversation dialogueOculos;
    [SerializeField] public NPCConversation dialoguePlaca;
    [SerializeField] public NPCConversation dialogueQueijo;
    [SerializeField] public NPCConversation dialogueRelogio;
    [SerializeField] public NPCConversation dialogueSapato;
    [SerializeField] public NPCConversation dialogueTigela;
    [SerializeField] public NPCConversation dialogueUvas;
    [SerializeField] public NPCConversation dialogueViolao;
    [SerializeField] public NPCConversation dialogueWaffle;
    [SerializeField] public NPCConversation dialogueXicara;
    [SerializeField] public NPCConversation dialogueYakult;
    [SerializeField] public NPCConversation dialogueZebra;

    private void Update()
    {
        if (ConversationManager.Instance != null && ConversationManager.Instance.IsConversationActive)
        {
            // Check for player input to progress the conversation
            if (Input.GetKeyDown(KeyCode.E))
            {
                ConversationManager.Instance.PressSelectedOption();
            }
        }

        switch (dialogueIaraIndex)
        {
            case 1:
                dialogueIaraTrigger.conversation = dialogueIara1;
                break;
            case 2:
                dialogueIaraTrigger.conversation = dialogueIara2;
                break;
            case 3:
                dialogueIaraTrigger.conversation = dialogueIara3;
                break;
            case 4:
                dialogueIaraTrigger.conversation = dialogueIara4;
                break;
            case 5:
                dialogueIaraTrigger.conversation = dialogueIara5;
                break;
            case 6:
                dialogueIaraTrigger.conversation = dialogueIara6;
                break;
            case 7:
                dialogueIaraTrigger.conversation = dialogueIara7;
                break;
            case 8:
                dialogueIaraTrigger.conversation = dialogueIara8;
                break;
            case 9:
                dialogueIaraTrigger.conversation = dialogueIara9;
                break;
            case 10:
                dialogueIaraTrigger.conversation = dialogueIara10;
                break;
            case 11:
                dialogueIaraTrigger.conversation = dialogueIara11;
                break;
            case 12:
                dialogueIaraTrigger.conversation = dialogueIara12;
                break;
            case 13:
                dialogueIaraTrigger.conversation = dialogueIara13;
                break;
            case 14:
                dialogueIaraTrigger.conversation = dialogueIara14;
                break;

        }

        switch (dialogueCurupiraIndex)
        {
            case 1:
                dialogueCurupiraTrigger.conversation = dialogueCurupira1;
                break;
            case 2:
                dialogueCurupiraTrigger.conversation = dialogueCurupira2;
                break;
            case 3:
                dialogueCurupiraTrigger.conversation = dialogueCurupira3;
                break;
            case 4:
                dialogueCurupiraTrigger.conversation = dialogueCurupira4;
                break;
            case 5:
                dialogueCurupiraTrigger.conversation = dialogueCurupira5;
                break;
            case 6:
                dialogueCurupiraTrigger.conversation = dialogueCurupira6;
                break;
            case 7:
                dialogueCurupiraTrigger.conversation = dialogueCurupira7;
                break;
            case 8:
                dialogueCurupiraTrigger.conversation = dialogueCurupira8;
                break;
            case 9:
                dialogueCurupiraTrigger.conversation = dialogueCurupira9;
                break;
            case 10:
                dialogueCurupiraTrigger.conversation = dialogueCurupira10;
                break;
            case 11:
                dialogueCurupiraTrigger.conversation = dialogueCurupira11;
                break;
            case 12:
                dialogueCurupiraTrigger.conversation = dialogueCurupira12;
                break;
            case 13:
                dialogueCurupiraTrigger.conversation = dialogueCurupira13;
                break;
            case 14:
                dialogueCurupiraTrigger.conversation = dialogueCurupira14;
                break;
        }
    }
}

using UnityEngine;
using DialogueEditor;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] DialogueManager dialogueManager;

    public GameObject paredeCurupira;

    public GameObject player;

    [Header("UI")]
    public GameObject PanelDialogue;
    public Sprite iaraBackground;
    public Sprite curupiraBackground;

    [Header("Letters")]
    public GameObject[] letters = new GameObject[26];
    public GameObject letterA;
    public GameObject letterB;
    public GameObject letterC;
    public GameObject letterD;
    public GameObject letterE;
    public GameObject letterF;
    public GameObject letterG;
    public GameObject letterH;
    public GameObject letterI;
    public GameObject letterJ;
    public GameObject letterK;
    public GameObject letterL;
    public GameObject letterM;
    public GameObject letterN;
    public GameObject letterO;
    public GameObject letterP;
    public GameObject letterQ;
    public GameObject letterR;
    public GameObject letterS;
    public GameObject letterT;
    public GameObject letterU;
    public GameObject letterV;
    public GameObject letterW;
    public GameObject letterX;
    public GameObject letterY;
    public GameObject letterZ;

    [Header("Items")]
    [SerializeField]
    public GameObject[] items = new GameObject[26];
    public GameObject arara;
    public GameObject baiacu;
    public GameObject cogumelo;
    public GameObject disco;
    public GameObject escova;
    public GameObject flecha;
    public GameObject garrafa;
    public GameObject hamburguer;
    public GameObject ima;
    public GameObject jornal;
    public GameObject ketchup;
    public GameObject livro;
    public GameObject macaco;
    public GameObject ninho;
    public GameObject oculos;
    public GameObject placa;
    public GameObject queijo;
    public GameObject relogio;
    public GameObject sapato;
    public GameObject tigela;
    public GameObject uvas;
    public GameObject violao;
    public GameObject waffle;
    public GameObject xicara;
    public GameObject yakult;
    public GameObject zebra;


    private void Update()
    {
        if (dialogueManager.dialogueIaraIndex == 14)
        {
            paredeCurupira.SetActive(false);
        }

        if (player.GetComponent<Player>().lastIara)
        {
            PanelDialogue.GetComponent<Image>().sprite = iaraBackground;
        }
        if (player.GetComponent<Player>().lastCurupira)
        {
            PanelDialogue.GetComponent<Image>().sprite = curupiraBackground;
        }
    }

}

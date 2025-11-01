using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MenuPrincipal : MonoBehaviour
{
public void PlayGame()
    {
        SceneManager.LoadScene("Cena1");
    }

public void Explicacao()
    {
        SceneManager.LoadScene("Explicacao");
    }
public void Instrucoes()
    {
        SceneManager.LoadScene("Instrucoes");
    }
public void Voltar()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
public void QuitGame()
    {
        Application.Quit();
    }
}

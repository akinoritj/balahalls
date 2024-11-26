using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenas : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("fase1");

    }
    
    public void VoltarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Replay()
    {
        SceneManager.LoadScene("fase1");
        Time.timeScale = 1.0f;
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("Fase2");
        Time.timeScale = 1.0f;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carregarcena : MonoBehaviour
{
     public void Jogar()
    {
       SceneManager.LoadScene("Menu");

    }
    
    public void Fase1()
    {
        SceneManager.LoadScene("Fase1");
    }
}

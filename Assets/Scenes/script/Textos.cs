using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Textos : MonoBehaviour
{
    public TextMeshProUGUI textoPontos;
    public TextMeshProUGUI textoDeveres;
    private Movimentacao player;
    
    void Start()
    {
        player = GameObject.FindObjectOfType<Movimentacao>();
        AtualizarTexto();
    }

    
    void Update()
    {
        AtualizarTexto();  
    }

    void AtualizarTexto()
    {
        textoPontos.text = player.PegaPontos().ToString() + "/5";
        if(player.PegaPontos() == 0)
        {
            textoDeveres.text = ("Colete as 5 moedas existentes sem cair na lava!");
        }  

    
        if(player.PegaPontos() == 5)
        {
            textoDeveres.text = ("Agora você pode ir para a próxima fase!");
        }

        if(player.VerificaVidaPlayer() == false)
        {
            textoDeveres.text = ("Você foi de Corinthians!!! arere o cortinas vai jogar a serie B eeeee");
        }
    }
}

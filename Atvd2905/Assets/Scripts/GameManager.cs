using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontuacaoJogador1;
    public int pontuacaoJogador2;

    public TextMeshProUGUI textPontuacao;

    public AudioSource somSource;
    public AudioClip somPonto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Reiniciar();
        Sair();
    }
    public void AumentarPontuacaoUm()
    {
        somSource.PlayOneShot(somPonto);
        pontuacaoJogador1++;
        Textoo();
    }
    public void AumentarPontuacaoDois()
    {
        somSource.PlayOneShot(somPonto);
        pontuacaoJogador2++;
        Textoo();
    }
    public void Textoo()
    {
        textPontuacao.text = pontuacaoJogador1 + " x " + pontuacaoJogador2;
    }
    public void Sair()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void Reiniciar()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("DentroDoJogo");
        }
    }
}

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

    public int valorDeAumentoP1 = 4;
    public int valorDeAumentoP2 = 4;
    public float speedToAdd = 850;
    public float speedToSubtract = 450;

    public GameObject telaPausa;
    public bool pausa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Reiniciar();
        Sair();
        LimitadorVel();
        TelaPause();
    }
    private void LimitadorVel()
    {
        if (speedToAdd >= 900)
        {
            speedToAdd = 900;
        }

        if (speedToSubtract <= 250)
        {
            speedToSubtract = 250;
        }
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
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("DentroDoJogo");
        }
    }

    public void TelaPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            telaPausa.SetActive(true);
        }

    }
    public void Voltar()
    {

        Time.timeScale = 1;
        telaPausa.SetActive(false);
    }
}

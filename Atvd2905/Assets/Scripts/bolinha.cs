using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bolinha : MonoBehaviour
{
    public float velocidadeBola;
    public Rigidbody2D rbBolota;

    public AudioSource audioSource;
    public AudioClip somBolinha;

    private GameManager gameManager;
    private SpriteRenderer sptBola;
    public Sprite imgBola, imgBolaLenta;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType(typeof(GameManager)) as GameManager;
        sptBola = GetComponent<SpriteRenderer>();

        VelBolinha();
        MovimentoBolinha();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void VelBolinha()
    {
        if (gameManager.pontuacaoJogador1 > 5)
        {
            velocidadeBola = 850;
            sptBola.sprite = imgBola;
        }
        else
        {
            velocidadeBola = 300;
        }
        if (gameManager.pontuacaoJogador1 >= 15)
        {
            velocidadeBola = 850;
            sptBola.sprite = imgBola;
        }
        else
        {
            velocidadeBola = 300;
        }

        if (gameManager.pontuacaoJogador2 > 5)
        {
            velocidadeBola = 190;
            sptBola.sprite = imgBolaLenta;
        }
        else
        {
            velocidadeBola = 300;
        }
        if (gameManager.pontuacaoJogador2 >= 15)
        {
            velocidadeBola = 190;
            sptBola.sprite = imgBola;
        }
        else
        {
            velocidadeBola = 300;
        }
    }
    public void MovimentoBolinha()
    {
        rbBolota.velocity = new Vector2(velocidadeBola, velocidadeBola) * Time.deltaTime;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(somBolinha);
    }
}

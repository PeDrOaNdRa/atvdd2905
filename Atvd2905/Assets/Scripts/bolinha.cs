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

    private GameManager gM;
    private SpriteRenderer sptBola;
    public Sprite imgBola, imgBolaLenta;



    // Start is called before the first frame update
    void Start()
    {
        gM = FindObjectOfType(typeof(GameManager)) as GameManager;
        sptBola = GetComponent<SpriteRenderer>();

        VelBolinha();
        MovimentoBolinha();
    }

    // Update is called once per frame
    void Update()
    {
        LimiteBola();
    }
    public void VelBolinha()
    {
        if (gM.pontuacaoJogador1 > gM.valorDeAumentoP1)
        {
            velocidadeBola = gM.speedToAdd;
            sptBola.sprite = imgBola;
            gM.speedToAdd += 150;
        }

        if (gM.pontuacaoJogador2 > gM.valorDeAumentoP2 )
        {
            velocidadeBola = gM.speedToSubtract;
            sptBola.sprite = imgBolaLenta;
            gM.speedToSubtract -= 100;
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
    public void LimiteBola()
    {
        if(transform.position.x <= -9.29f || transform.position.x >= 9.4)
        {
            Destroy(gameObject);
        }
    }
}

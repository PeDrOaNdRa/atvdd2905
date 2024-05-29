using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolinha : MonoBehaviour
{
    public float velocidadeBola;
    public Rigidbody2D rbBolota;

    public AudioSource audioSource;
    public AudioClip somBolinha;

    // Start is called before the first frame update
    void Start()
    {
        MovimentoBolinha();
    }

    // Update is called once per frame
    void Update()
    {
        
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

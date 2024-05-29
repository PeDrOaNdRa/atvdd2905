using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentosPlayer : MonoBehaviour
{
    public bool jogador1;
    public int velocidade;

    public float limiteTopo;
    public float limiteChao;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (jogador1 == true)
        {
            MovimentacaoDoJogador();
        }
        if (jogador1 == false)
        {
            MovimentacaoDoJogadorDois();
        }
    }
    public void MovimentacaoDoJogador()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, limiteChao, limiteTopo));

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);
        }
    }
    public void MovimentacaoDoJogadorDois()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, limiteChao, limiteTopo));

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);
        }
    }
}

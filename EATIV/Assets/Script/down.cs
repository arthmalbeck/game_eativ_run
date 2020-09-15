using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class down : MonoBehaviour {

    private     Rigidbody2D      pedraRb;

    private     int              atrito;
    public      int              atritoMaximo, atritoMinimo;
    public      Vector3          posicao;
    public      GameObject       pedraPrefab;

	// Use this for initialization
	void Start () {
        pedraRb = GetComponent<Rigidbody2D>();
        atrito = Random.Range(atritoMinimo, atritoMaximo);
        pedraRb.drag = atrito;

        posicao = transform.position;

	}
	
	void OnBecameInvisible()
    {
        Instantiate(pedraPrefab, posicao, transform.localRotation);
        pontuacao.pontos += 1;
        Destroy(this.gameObject);

    }


}

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class player : MonoBehaviour {

	//	privacidade			tipo		nome;
		private		Rigidbody2D		playerRb;
		private		SpriteRenderer	playerSprite;
		public		float			velocidade;
		public		bool			flipX;


	// Use this for initialization
	void Start () {

		playerRb = GetComponent<Rigidbody2D>();
		playerSprite = GetComponent<SpriteRenderer>();

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			
			velocidade = velocidade * -1; //velocidade *= -1;
			flipX = !flipX;
			playerSprite.flipX = flipX;

		}

		playerRb.velocity = new Vector2(velocidade, playerRb.velocity.y);


	}

	void OnCollisionEnter2D(Collision2D colisao)
	{
		if (colisao.gameObject.tag == "pedra") {

            SceneManager.LoadScene("gameover");

		}
	
	}

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "pedra")
        {

            SceneManager.LoadScene("gameover");

        }
    }

}

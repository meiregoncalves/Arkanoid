using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bolinhaScript : MonoBehaviour {

	public float velocidade;
	public float forca;
	public Text txtVida;
	public Text txtPontos;
	public int vida;
	public static int pontos;
	public GameObject quebraPreFab;
	public GameObject bolinhaPreFab;
	public GameObject barraPreFab;
	public GameObject caiuPreFab;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (forca, forca));
		txtPontos.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		txtPontos.text = "Pontos: " + pontos.ToString ();
		txtVida.text = "Vidas: " + vida.ToString ();
	}

	void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject.tag == "bloco") {
			Instantiate (quebraPreFab, transform.position, transform.rotation);
			Destroy (c.gameObject);
			pontos++;

			if (pontos >= 3) {
				SceneManager.LoadScene("inicialCena");
			}
		}

		if (c.gameObject.tag == "chao") {
			vida--;
			Instantiate (caiuPreFab, transform.position, transform.rotation);

			if (vida <= 0) {
				SceneManager.LoadScene ("inicialCena");
			} else {
				barraPreFab.transform.position = new Vector2(-0.1f, -4.44f);
				transform.position = new Vector2(-0.14f, -3.87f);
			}
		}
	}
}

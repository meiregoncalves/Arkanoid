using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class barraScript : MonoBehaviour {
	public float velocidade;
	public static bool inGame;

	void Mover() {

		if (inGame) {
			//Mover
			float move_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
			transform.Translate (move_x, 0.0f, 0.0f);
		} else {
			inGame = true;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Mover ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mensagemScript : MonoBehaviour {
	public Text txtMsg;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (bolinhaScript.pontos <= 0) {
			txtMsg.text = "";
		}

		else if (bolinhaScript.pontos >= 3) {
			txtMsg.text = "Você ganhou!!";
		}

		else if (bolinhaScript.pontos < 3) {
			txtMsg.text = "Game Over =(";
		}
	}
}

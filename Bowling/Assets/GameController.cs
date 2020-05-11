using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Player player; //igrac->MainCamera
	public TextMesh infoText; //display
	public Cunj[] cunjevi; //cunjevi koji se pojavljuju na platformi
	public float evaluationTime = 5f;
	private float gameTimer = 0f;
	private bool evaluating = false; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		infoText.text = "Baci Kuglu!";

		if (evaluating == false) {
			if (player == false) {
				evaluating = true;
				gameTimer = evaluationTime;
			}
		} else {
			gameTimer -= Time.deltaTime;
			if (gameTimer <= 0f) {
				int score = 0;

				for (int i = 0; i < cunjevi.Length; i++) {
					if (cunjevi [i] == null) {
						score++;
					}
				}
				infoText.text = "Tvoj rezultat: " + score;
			}
			if (gameTimer <= -3f) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
			}
		}
	}
}

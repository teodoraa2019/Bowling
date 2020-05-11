using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igrac : MonoBehaviour {

	public GameObject kugla;
	public float kuglaDIstanca = 2.5f;
	public float silaBaceneKugle = 200f;

	public bool drzanje = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (drzanje) {
			kugla.transform.position = transform.position + transform.forward * kuglaDIstanca;

			if (GvrViewer.Instance.Triggered || Input.GetKeyDown ("space")) {
				drzanje = false;
				kugla.GetComponent<Rigidbody> ().useGravity = true;
				kugla.GetComponent<Rigidbody> ().AddForce (transform.forward * silaBaceneKugle);
			}
		}
	}
}

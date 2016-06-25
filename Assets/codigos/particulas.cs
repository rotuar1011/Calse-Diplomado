using UnityEngine;
using System.Collections;

public class particulas : MonoBehaviour {
	public ParticleSystem fuego;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.S))
		fuego.Play ();

		if (Input.GetKey (KeyCode.A))
			fuego.Stop ();
	}
}

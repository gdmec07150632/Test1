using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private int i = 0;
	
	// Update is called once per frame
	void Update () {
		float horiziontal_move = Input.GetAxis ("Horizontal");
		float vertical_move = Input.GetAxis ("Vertical");
		this.GetComponent<Rigidbody>().AddForce (new Vector3 (horiziontal_move, 0, vertical_move)*10f);
	}
	void OnTriggerEnter( Collider other){
		Debug.Log ("Trigger Enter");
		if(other.gameObject.name == "Food"){
			GameObject.Destroy (other.gameObject);
			i++;
			Debug.Log ("Eat a food");
			if(i == 10){
				Debug.Log ("Game win!");
			}
		}
	}
//	void OnTriggerExit(){
//		Debug.Log ("Trigger Exit");
//	}
//	void OnTriggerStay(){
//		Debug.Log ("Trigger Stay");
//	}
}

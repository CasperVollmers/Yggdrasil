using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {





	// Use this for initialization
	void Start () {

	

		
	}
	

	void OnTriggerEnter (Collider other)
	{
		
		//if(Input.GetKeyDown("e")){
			
			if (other.gameObject.CompareTag ("Gyl")) {
				other.gameObject.SetActive (false);
			}
			if (other.gameObject.CompareTag ("Bri")) {
				other.gameObject.SetActive (false);

			}
		}
	}




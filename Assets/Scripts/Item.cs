using UnityEngine;
using System.Collections;

public class Item: MonoBehaviour {

	public int distanceToItem;

	void Start () {

	}



	void Update ()	{

		Collect();

		}

	void Collect(){

		if (Input.GetMouseButtonUp(1)){

			RaycastHit hit;

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);



			if(Physics.Raycast(ray, out hit, distanceToItem)){
				if(hit.collider.gameObject.name == "Gyl") {

					Debug.Log("ITEM HIT");

					Destroy(hit.collider.gameObject);
				}
			}
		}	
	}
}
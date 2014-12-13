using UnityEngine;
using System.Collections;

public class CollisionHandler : MonoBehaviour {

	public Transform target;
	public GameObject prefabFood;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.name == "Food" ) {
			if (col.gameObject.GetComponent<Tail> ().enabled == false) {
				col.gameObject.GetComponent<Tail> ().GetTailFromFood ();
				
				//creating new food
				Vector3 newPos = new Vector3 (Random.Range (-4.0F, 2.0F), 4, Random.Range (-8.0F, 0F));
				var newFood = Instantiate (this.prefabFood, newPos, transform.rotation);
				newFood.name = "Food";
			} else {
				Debug.Log ("CRASH");
			}
		}
	}
}

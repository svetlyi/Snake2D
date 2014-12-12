using UnityEngine;
using System.Collections;

public class KeyHandler : MonoBehaviour {
	private const float SPEED = 0.09f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 objPos = transform.position;
		if (Input.GetKey ("right")) {
			objPos.x += SPEED;
		}
		if (Input.GetKey ("left")) {
			objPos.x -= SPEED;
		}
		if (Input.GetKey ("up")) {
			objPos.y += SPEED;
		}
		if (Input.GetKey ("down")) {
			objPos.y -= SPEED;
		}
		this.gameObject.transform.position = objPos;
	}
}

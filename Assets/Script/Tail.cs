using UnityEngine;
using System.Collections;

public class Tail : MonoBehaviour {
	public Transform target;
	public float targetDistance;
	public bool enabled = false;
	
	public void Update()
	{
		if (this.enabled) {
						// направление на цель
						Vector3 direction = target.position - transform.position;
		
						// дистанция до цели
						float distance = direction.magnitude;
		
						// если расстояние до цели хвоста больше заданного
						if (distance > targetDistance) {
								// двигаем хвост
								transform.position += direction.normalized * (distance - targetDistance);
								// смотрим на цель
								transform.LookAt (target);
						}
				}
	}

	public void GetTailFromFood () {
		Debug.Log ("get tail from food");
		GameObject head = GameObject.Find("Head");
		Transform current = head.GetComponent<Initialization>().current;
		Vector3 newPos = current.transform.position - current.transform.forward * 2;

		this.gameObject.GetComponent<Tail>().target = current.transform;
		this.gameObject.GetComponent<Tail>().enabled = true;
		// дистанция между элементами хвоста - 2 единицы
		this.gameObject.GetComponent<Tail>().targetDistance = 1;

		head.GetComponent<Initialization> ().current = this.gameObject.transform;
	}
}

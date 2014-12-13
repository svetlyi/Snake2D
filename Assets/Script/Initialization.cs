using UnityEngine;
using System.Collections;

public class Initialization : MonoBehaviour {
	public GameObject prefabFood;

	// Use this for initialization
	void Start () {
		// создаем хвост
		// current - текущая цель элемента хвоста, начинаем с головы
		Transform current = transform;
		for (int i = 0; i < 3; i++)
		{
			Vector3 newPos = current.transform.position - current.transform.forward * 2;

			GameObject tail;
			tail = (GameObject)Instantiate(this.prefabFood, newPos, transform.rotation);
			tail.GetComponent<Tail>().enabled = true;
			tail.GetComponent<Tail>().target = current.transform;

			// дистанция между элементами хвоста - 2 единицы
			tail.GetComponent<Tail>().targetDistance = 2;
			// удаляем с хвоста колайдер, так как он не нужен
			Destroy(tail.collider);
			// следующим хозяином будет новосозданный элемент хвоста
			current = tail.transform;
		}

		//Создание еды
		Vector3 newFoodPos = new Vector3(Random.Range(-4.0F, 2.0F), 4, Random.Range(-8.0F, 0F));
		var newFood = Instantiate(this.prefabFood, newFoodPos, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class changeColor : MonoBehaviour {

	public Sprite[] ballSprites;

	void Awake()
	{
		// load all frames in b array
		ballSprites = Resources.LoadAll<Sprite>("balls");
	}

	void Start ()
	{
		int num = Random.Range(1,9);

		// create the object
		//GameObject ball = new GameObject();
		// add a "SpriteRenderer" component to the newly created object
		this.gameObject.AddComponent<SpriteRenderer>();
		// assign random number
		this.gameObject.GetComponent<SpriteRenderer>().sprite = ballSprites[num];
	}
}

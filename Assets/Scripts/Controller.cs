using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	float hspeed = 1f;
	float vspeed = 1f;
	float direction = 0f;

	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( Input.GetAxis ("Vertical") > 0 || Input.GetAxis("Vertical") < 0 )
		{
			direction = Input.GetAxis ("Vertical");
		}
		gameObject.transform.position = new Vector2(transform.position.x + hspeed, transform.position.y + vspeed*direction);
	
	}
}

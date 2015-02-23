using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	float hspeed = 1f;
	float velocity = 1f;
	float direction = 1f;
    float YMaxVelocity = 100f;
    float XMaxVelocity = 100f;

	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( Input.GetButtonDown("Jump") )
		{
			direction = direction * -1;
		}

        rigidbody2D.AddForce(new Vector2(hspeed, velocity * direction));

        if (rigidbody2D.velocity.y > YMaxVelocity)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y * 0.99f);
        }
        if (rigidbody2D.velocity.x > XMaxVelocity)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x * 0.99f, rigidbody2D.velocity.y);
        }
	}
}

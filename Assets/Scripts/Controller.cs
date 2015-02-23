using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{

    public float direction = 1f;

    private float hcap = 50f;
    private float vcap = 30f;
    private Vector2 acceleration = new Vector2(0, 1f);

    void Start()
    {
        rigidbody2D.velocity = new Vector2(hcap, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            direction = direction * -1;
        }
        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y) + acceleration * direction;

        if( rigidbody2D.velocity.y > vcap)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, vcap);
        }
        else if ( rigidbody2D.velocity.y < -vcap)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, -vcap);
        }
    }
}

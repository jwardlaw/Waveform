using UnityEngine;
using System.Collections;

public class WF_MainMenuController : MonoBehaviour
{

    public float direction = 1f;
    public float switchrate = 1f;
    public float delay = 1f;

    private float hcap = 50f;
    private float vcap = 50f;
    private Vector2 acceleration = new Vector2(0, 1.6f);

    void Switch()
    {
        direction = direction * -1;
    }

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(hcap, 0);
        InvokeRepeating("Switch", delay, switchrate);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y) + acceleration * direction;

        if (GetComponent<Rigidbody2D>().velocity.y > vcap)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, vcap);
        }
        else if (GetComponent<Rigidbody2D>().velocity.y < -vcap)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -vcap);
        }
    }
}
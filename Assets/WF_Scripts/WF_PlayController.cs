using UnityEngine;
using System.Collections;

public class WF_PlayController : MonoBehaviour
{

    public float direction = 1f;

    private float hcap = 50f;
    private float vcap = 50f;
    private Vector2 acceleration = new Vector2(0, 1.6f);


    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(hcap, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            direction = direction * -1;
        }
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

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Finish")
        {
            Application.LoadLevel(0);
        }
            WF_ScoreTracker.score -= 1;
    }
}
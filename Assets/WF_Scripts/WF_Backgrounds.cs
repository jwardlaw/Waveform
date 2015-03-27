using UnityEngine;
using System.Collections;

public class WF_Backgrounds : MonoBehaviour 
{
    private GameObject player;
    private float lastJump = 1;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if( player.transform.position.x > (lastJump * 630f))
        {
            gameObject.transform.position = new Vector3(player.transform.position.x, 0, 0);
            lastJump++;
        }
    }

}

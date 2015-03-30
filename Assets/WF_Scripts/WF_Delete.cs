using UnityEngine;
using System.Collections;

public class WF_Delete : MonoBehaviour {

    public float timer;
    public float lifespan;
	
	// Update is called once per frame
	void Update () {

        timer += 1f * Time.deltaTime;

        if(timer >= lifespan)
        {
            GameObject.Destroy(gameObject);
        }
	
	}
}

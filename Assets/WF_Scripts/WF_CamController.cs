using UnityEngine;
using System.Collections;

public class WF_CamController : MonoBehaviour
{

    public Transform target;

    void Update()
    {
        this.transform.position = new Vector3(target.position.x, this.transform.position.y, this.transform.position.z);
    }
}
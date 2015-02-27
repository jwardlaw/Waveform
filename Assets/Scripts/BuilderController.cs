using UnityEngine;
using System.Collections;

public class BuilderController : MonoBehaviour
{

    public Transform target;

    void Update()
    {
        this.transform.position = new Vector3(target.position.x + 50, this.transform.position.y, this.transform.position.z);
    }
}

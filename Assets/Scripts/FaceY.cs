using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceY : MonoBehaviour
{

    public Transform target;

    void Update()
    {
        Vector3 targetPosition = new Vector3(transform.position.x, target.transform.position.y, transform.position.z);
        transform.LookAt(target);
    }
}

//transform.Rotate(Vector3.right, 90f);

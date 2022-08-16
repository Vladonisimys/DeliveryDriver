using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;
    void LateUpdate()
    {
        transform.position = objectToFollow.transform.position + new Vector3(0, 0, -8);
    }
}

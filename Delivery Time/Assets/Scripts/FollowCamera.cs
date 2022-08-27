using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thinkToFollow;
    void LateUpdate()
    {
        transform.position = thinkToFollow.transform.position + new Vector3(0, 0, -10.5f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private GameObject objectToFollow;
    public Vector3 OffsetPosition;

    void UpdatePosition()
    {
        transform.position = objectToFollow.transform.position + OffsetPosition;
    }
    private void LateUpdate()
    {
        UpdatePosition();
    }

}
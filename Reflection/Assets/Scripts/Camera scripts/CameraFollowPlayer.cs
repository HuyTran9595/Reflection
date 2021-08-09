using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform playerBody;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(playerBody.position.x + offset.x, 0, offset.z); // Camera follows the player with specified offset position
    }
}

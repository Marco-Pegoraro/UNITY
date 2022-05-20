using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 cameraOffset;
    public float followSpeed = 10f;

    void FixedUpdate()
    {
        transform.position = target.position + cameraOffset;
    }
}

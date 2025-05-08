using UnityEngine;

public class CameraFollow3D : MonoBehaviour
{
    public Transform player;
    private float offsetY;
    private float offsetZ;

    void Start()
    {
        offsetY = transform.position.y;
        offsetZ = transform.position.z;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, offsetY, offsetZ);
    }
}

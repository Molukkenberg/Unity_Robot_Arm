using UnityEngine;

public class RotateXZ : MonoBehaviour
{
    // Rotation des Roboterarms in der xz-Ebene mit dem Winkel α
    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.RotateAround(transform.position, Vector3.up, 1);
        }
        else if (Input.GetKey("right"))
        {
            transform.RotateAround(transform.position, Vector3.up, -1);
        }
    }
}

using UnityEngine;

public class RotateXZ : MonoBehaviour
{
    // Robot-Arm rotation in xz-plain
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

using UnityEngine;

public class RotateZ : MonoBehaviour
{
    // Robot-Arm rotation of forearm around its local z axis.
    void Update()
    {
        if (Input.GetKey("up")) 
        {
            transform.Rotate(Vector3.forward, 1);
        }
        else if (Input.GetKey("down"))
        {
             transform.Rotate(Vector3.forward, -1);
        }
    }
}

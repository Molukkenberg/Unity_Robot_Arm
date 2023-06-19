using UnityEngine;

public class RotateZ : MonoBehaviour
{
    // Rotation des Roboterarms um seine lokale z-Achse mit dem Winkel β
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

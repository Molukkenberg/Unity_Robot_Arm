using UnityEngine;

public class RotateUnderArm : MonoBehaviour
{
    private readonly float maxElbowRot = .7f;

    // Folding in/out of forearm.
    void Update()
    {
        if (Input.GetKey("w"))
        {
            if(transform.localRotation.x <= maxElbowRot)
                transform.Rotate(Vector3.right, 1);
        }
        else if (Input.GetKey("s"))
        {
            if (transform.localRotation.x >= -maxElbowRot)
                transform.Rotate(Vector3.right, -1);
        }
    }
}

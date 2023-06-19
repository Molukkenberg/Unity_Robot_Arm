using UnityEngine;

public class RotateFingers : MonoBehaviour
{
    [SerializeField]
    private GameObject Fingers;
    [SerializeField]
    private GameObject Thumb;

    private float minLocalRotY = -.14f;
    private int maxLocalRotY = 0;

    // Rotation of finger and thumb inward and outward.
    void Update()
    {
        if (Fingers !=null && Thumb != null)
        {
            if (Input.GetKey("a"))
            {
                if (Fingers.transform.localRotation.y <= maxLocalRotY)
                {
                    Fingers.transform.RotateAround(transform.position, transform.up, 1);
                    Thumb.transform.RotateAround(transform.position, transform.up, -1);
                }
            }
            else if (Input.GetKey("d"))
            {
                if (Fingers.transform.localRotation.y >= minLocalRotY)
                {
                    Fingers.transform.RotateAround(transform.position, transform.up, -1);
                    Thumb.transform.RotateAround(transform.position, transform.up, 1);
                }
            }
        }
    }
}

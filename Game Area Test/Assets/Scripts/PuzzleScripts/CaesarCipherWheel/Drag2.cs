using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag2 : MonoBehaviour
{
    float rotationSpeed = 2.0f;
    [SerializeField] GameObject RotatedObject;

    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        // select the axis by which you want to rotate the GameObject
        RotatedObject.transform.Rotate(Vector3.down, XaxisRotation);
    }
}

using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour
{
    // Declaration of private misc variables
    public float rotationX = 0;

    // Declaration of public misc variables
    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVer = 9.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

	// Use this for initialization
	void Start ()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
        {
            body.freezeRotation = true;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (axes == RotationAxes.MouseX)
        {
            // Horizontal rotation here
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            // Vertical rotation here
            rotationX -= Input.GetAxis("Mouse Y") * sensitivityVer;
            rotationX = Mathf.Clamp(rotationX, minimumVert, maximumVert);

            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);

        }
        else
        {
            // Both horizontal and vertical rotation here
            rotationX -= Input.GetAxis("Mouse Y") * sensitivityVer;
            rotationX = Mathf.Clamp(rotationX, minimumVert, maximumVert);

            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;

            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        }
	}
}

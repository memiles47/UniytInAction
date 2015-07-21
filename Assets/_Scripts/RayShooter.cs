using UnityEngine;
using System.Collections;

public class RayShooter : MonoBehaviour
{
    // Declaration of private reference variables
    private Camera camera;

    // Declaration of private misc variables

    // Declaration of public reference variables

    // Declaration of public misc variables

    // Declaration of public static variables

    // Use this for initialization of reference variables that do not change during game play
    void Awake()
    {
        camera = GetComponent<Camera>();
    }

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0);
            Ray ray = camera.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit " + hit.point);
            }
        }
	}
}

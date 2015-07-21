using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
    // Declaration of public misc variables
    public float speed = 3.0f;

	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, speed, 0);
	}
}

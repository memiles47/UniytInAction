﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]

public class FPSInput : MonoBehaviour
{
    // Declaration of private reference variables
    private CharacterController charController;

    // Declaration of public misc variables
    public float speed = 6.0f;
    public float gravity = -9.8f;

    // Use this for initialization of reference variables that do not change during game play
    void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

	// Update is called once per frame
	void Update ()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        charController.Move(movement);
	}
}

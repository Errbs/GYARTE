using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = -9.8f;

    private CharacterController _charControl;

	// Use this for initialization
	void Start ()
    {
        _charControl = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed); //Limits player max speed

        movement.y = gravity;

        movement *= Time.deltaTime; //speed is not dependent upon framrate
        movement = transform.TransformDirection(movement);
        _charControl.Move(movement);
	}
}

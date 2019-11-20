using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    public enum RotationAxis
    {
        MouseX = 1,
        MouseY =2,
  
    }

    public RotationAxis axis = RotationAxis.MouseX;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    public float senseHorizintal = 10.0f;
    public float senseVertical = 10.0f;

    public float _rotationX = 0;
	
	// Update is called once per frame
	void Update ()
    {
		if(axis == RotationAxis.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * senseHorizintal, 0);
            
        }
        else if(axis == RotationAxis.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * senseVertical;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert); //Clamps vertical angle within the minimum and maximum limits

            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
	}
}

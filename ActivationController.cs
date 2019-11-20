using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationController : MonoBehaviour {

    

    public void Activate()
    {
        GetComponent<player_movement>().enabled = true;
        GetComponent<camera_controller>().enabled = true;
        Camera.main.gameObject.GetComponent<camera_controller>().enabled = true;
    }

    public void DeActivate()
    {
        GetComponent<player_movement>().enabled = false;
        GetComponent<camera_controller>().enabled = false;
        Camera.main.gameObject.GetComponent<camera_controller>().enabled = false;
    }

}

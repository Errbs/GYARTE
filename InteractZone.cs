using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractZone : MonoBehaviour {

    public Image dialog;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            dialog.gameObject.SetActive(true);

            other.gameObject.GetComponent<ActivationController>().DeActivate();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour {

    public float distanceToObject = 5;
    void Update () {
        if (Vector3.Distance (Camera.main.transform.position, gameObject.transform.position) <= distanceToObject && Input.GetKeyDown (KeyCode.E)) {
            Debug.Log ("Victory!");
        }
    }
}
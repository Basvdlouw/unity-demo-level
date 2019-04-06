using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformHorizontal : MonoBehaviour {
    public float speed = 3;
    private bool end = false;

    public float startPoint = 5.5f;

    public float endPoint = -5.5f;

    void Update () {
        float step = speed * Time.deltaTime;
        if (transform.position.z >= startPoint) {
            end = true;
        } else if (transform.position.z <= endPoint) {
            end = false;
        }
        if (end) {
            transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, transform.position.y, endPoint), step);
        } else if (!end) {
            transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, transform.position.y, startPoint), step);
        }
    }
}
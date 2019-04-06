using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformVertical : MonoBehaviour
{
    public float speed = 3;
    private bool end = false;

    public float startPoint = 5.5f;

    public float endPoint = -5.5f;

    void Update () {
        float step = speed * Time.deltaTime;
        if (transform.position.y >= startPoint) {
            end = true;
        } else if (transform.position.y <= endPoint) {
            end = false;
        }
        if (end) {
            transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, endPoint, transform.position.z), step);
        } else if (!end) {
            transform.position = Vector3.MoveTowards (transform.position, new Vector3 (transform.position.x, startPoint, transform.position.z), step);
        }
    }
}

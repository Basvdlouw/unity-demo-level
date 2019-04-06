using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    public static bool timeStarted = true;
    public float timeLeft = 180;
    void Update () {
        if (timeStarted) {
            timeLeft -= Time.deltaTime;
        }

        if(timeLeft < 0 && timeStarted) {
            Debug.Log("GAME OVER!");
        }
    }

    void OnGUI () {
        GUI.Label (new Rect (10, 10, 450, 200), Mathf.Floor (timeLeft / 60).ToString ("00") + " : " + Mathf.Floor (timeLeft % 60).ToString ("00"));
    }
}
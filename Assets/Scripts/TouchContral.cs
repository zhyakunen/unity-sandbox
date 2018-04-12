using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchContral : MonoBehaviour {

    public GameObject sampleTouchBall;
    Dictionary<int, TouchBall> touchBalls;
    [Range(0,2)]public float touchSize; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (var i = 0; i < Input.touchCount; i++) {
            Touch t = Input.GetTouch(i);
            switch (t.phase) {
                case TouchPhase.Began:
                    break;
                case TouchPhase.Moved:
                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Ended:
                    break;
                case TouchPhase.Canceled:
                    break;


            }
        }
	}
}

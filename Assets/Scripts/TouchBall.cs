using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBall : MonoBehaviour {

    public Vector3 velocity;
    public TouchPhase phase;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
            
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(phase==TouchPhase.Began) collision.gameObject.SendMessage("OnPressed", this);    
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (phase == TouchPhase.Canceled || phase == TouchPhase.Ended)
            collision.gameObject.SendMessage("OnReleased", this);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.SendMessage("OnReleased", this);
    }

}

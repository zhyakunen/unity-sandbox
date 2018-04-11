using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGen : MonoBehaviour {

    public GameObject genObject;
    [Range(0,1000)]public float width, height;
    [Range(1, 10)] public float intvFrom, intvTo;

    private float wait;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Instantiate(genObject,)
	}

    float calcWait() {
        return Random()
    }
}

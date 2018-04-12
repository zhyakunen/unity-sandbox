using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour {

    static float killY = -300f;
    float bangTime;
    float size;
    public float Size {
        get { return size; }
        set {
            size = value;
            transform.localScale= new Vector3(size, size, size);
            gameObject.GetComponent<Rigidbody2D>().mass = Mathf.Pow(size, 3);
            Debug.Log(size);
        }
    }
    public GameObject bangObject;
    void Awake()
    {
        bangTime = 20f;
        Size = 1;
    }

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (transform.position.y <= killY) Destroy(gameObject);
        bangTime -= Time.fixedDeltaTime;
        if (bangTime <= 0f) Bang();
	}

    void Bang() {
        SlimeBang sb = Instantiate(bangObject, transform.position + new Vector3 (0f,size/2f,0f) , Quaternion.identity).GetComponent<SlimeBang>();
        sb.bang(size);
        Destroy(gameObject);
    }

    
}

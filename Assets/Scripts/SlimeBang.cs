using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBang : MonoBehaviour {

    static float forceMulti = 1f;
    static float slimeMulti = 4f;
    static float size = 0.1f;
    public GameObject bangObject;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void bang(float s) {
        float f = s * forceMulti;
        for (int i = 0; i <= s*slimeMulti; i++) {
            Vector3 offset = Random.insideUnitSphere*size;
            Rigidbody2D r2d = Instantiate(bangObject, transform.position + offset, Quaternion.identity).GetComponent<Rigidbody2D>();
            r2d.AddExplosionForce(f, transform.position, 2f);

        }
        Destroy(gameObject, 1f);
    }
}

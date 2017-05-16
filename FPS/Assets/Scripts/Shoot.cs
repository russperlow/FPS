using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    // Public Variables
    public GameObject bullet;
    public float force = 3000;
    public float waitTime = .1f;

    // Private Variables
    public float timeInterval = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeInterval += Time.deltaTime;
        if (Input.GetMouseButton(0) && timeInterval >= waitTime)
        {
            GameObject temp = (GameObject)GameObject.Instantiate(bullet);
            temp.transform.position = this.transform.position;
            temp.transform.rotation = this.transform.rotation;
            temp.transform.eulerAngles = new Vector3(this.transform.rotation.x + 90, this.transform.rotation.y, this.transform.rotation.z);
            temp.GetComponent<Rigidbody>().AddForce(this.transform.forward * force);
            BulletManager bm = (BulletManager)temp.GetComponent(typeof(BulletManager));
            bm.enabled = true;
            timeInterval = 0;
        }
	}
}

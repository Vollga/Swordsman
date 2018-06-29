using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Pickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Player_Controller>().coins += 1;
            other.gameObject.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }

}

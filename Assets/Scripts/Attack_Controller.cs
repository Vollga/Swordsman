using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Controller : MonoBehaviour {

    public GameObject loot;
    private Vector3 pos;
    private Quaternion rotation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            pos = other.gameObject.transform.position;
            rotation = other.gameObject.transform.rotation;
            Instantiate(loot, pos, rotation);
            this.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
    }
}

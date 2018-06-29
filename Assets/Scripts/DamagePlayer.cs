using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {

    
    private GameObject player;
    private AudioSource[] sound;

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");
        sound = player.GetComponents<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.GetComponent<Player_Controller>().health -= 1;
            sound[1].Play();
        }
    }
}

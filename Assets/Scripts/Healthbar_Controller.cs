using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar_Controller : MonoBehaviour {

    private GameObject player;
    public Sprite [] bar;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        this.GetComponent<SpriteRenderer>().sprite = bar[player.GetComponent<Player_Controller>().health];
        
    }
}

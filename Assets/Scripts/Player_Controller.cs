using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

    public int health;
    public int coins;
    public float speed;
    public Sprite left;
    public Sprite right;
    public Sprite left_stab;
    public Sprite right_stab;
    public BoxCollider swordLeft;
    public BoxCollider swordRight;
    private Rigidbody rb;
	private CharacterController character;
    private SpriteRenderer[] spriteR;


    private bool direction;

	void Start()
    { 
		character = GetComponent<CharacterController>();
        spriteR = GetComponentsInChildren<SpriteRenderer>();
	}

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		character.Move (new Vector3 (x, 0, z));
        

        //which direction does the player face
        if (x < 0)
        {
            direction = true; //facing left
        }
        else if(x > 0)
        {
            direction = false; //facing right
        }

        swordLeft.enabled = false;
        swordRight.enabled = false;

        //setting correct sprite based on input + activating collider
        if (direction == true)
        {
            if (Input.GetButton("Fire1"))
            {
                spriteR[0].sprite = left_stab;
                swordLeft.enabled = true;
            }
            else
            {
                spriteR[0].sprite = left;
                
            }
        }
        else if (direction == false)
        {
            if (Input.GetButton("Fire1"))
            {
                spriteR[0].sprite = right_stab;
                swordRight.enabled = true;
            }
            else
            {
                spriteR[0].sprite = right;
                
            }
        }

        if(health == 0)
        {
            spriteR[0].enabled=false;
            spriteR[1].enabled = false;
            SceneManager.LoadScene("Game_Over");
        }
    }

}
	
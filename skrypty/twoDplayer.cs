using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoDplayer : MonoBehaviour
{
    [SerializeField] float movespead = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Sprite mariuszektyldobre, mariuszekfrontdobre, mariuszekbokprawo, mariuszekboklewo;
    public BoxCollider2D Player;
    public float RadNum = 0f;
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if(Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().sprite = mariuszektyldobre;
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<SpriteRenderer>().sprite = mariuszekfrontdobre;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().sprite = mariuszekboklewo;
            //Player.size = new Vector3(0.44, 1.03, 1)
        }
        
        if (Input.GetKeyUp(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().sprite = mariuszekboklewo;
            //Player.size = new Vector3(0.2f, 2, 1);        
        }

        
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().sprite = mariuszekbokprawo;

        }

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        RadNum = Random.Range(1, 10);
        Debug.Log(RadNum);
    }
    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespead * Time.fixedDeltaTime);
    }

}
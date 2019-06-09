using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float distanceToGround;
    public IDictionary<string, int> ammoCounts = new Dictionary<string, int>();
    private Collider2D colide;
    private Collider2D ground;
    private int ammoSelect;
    private GameObject ammo;

    public float speed;

    void Start(){
        rb2d = GetComponent<Rigidbody2D> ();
        ground = GameObject.FindGameObjectWithTag("Ground").GetComponent<Collider2D>();
        colide = GetComponent<Collider2D>();
        distanceToGround = colide.bounds.extents.y;
        ammoCounts.Add("fire",0);
        ammoCounts.Add("water",0);
    }
    bool isGrounded(){
        
        return colide.IsTouching(ground);

    }
   
    void  Update()
    {
        if(Input.GetKey(KeyCode.Alpha1)){
            
        }
    }
    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
  
        if (Input.GetKey(KeyCode.Space) && isGrounded())
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0,10), ForceMode2D.Impulse);
            
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(Vector3.down,ForceMode2D.Impulse);
        }
    }
}



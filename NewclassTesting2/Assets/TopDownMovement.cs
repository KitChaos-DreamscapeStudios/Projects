using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement: MonoBehaviour
{
    public float speed = 5;
    float horizontal;
    float vertical;
    public Rigidbody2D body;
    public Potions Potion;
    public float potSelect;
    // Start is called before the first frame update
    //Attatch this to The Player, but make sure it has a rigidbody2D attatched.
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if(potSelect == 0)
        {
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var shotPot = Instantiate(Potion.potionProjectile, new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
            shotPot.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 5);
        }
        
        
    }
    private void FixedUpdate()
    {
        body.velocity = new Vector3(horizontal * speed, vertical * speed);
    }
    private void OnCollisionStay2D(Collision2D col)
    {
        if(Input.GetKeyDown("e") && col.collider.name == "Cauldron")
        {
            Potion = col.gameObject.GetComponent<Cauldron>().currentPotion;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public enum States
    {
        Eating, Hurt, Mating, Running, idle,
    }
    public States state;
    public string UniqueGenes;
    public List<string> Letters;
    public Genes Genes;
    public string GeneValues;
    public GameObject Child;
    public float hunger;
    public float thirst;
    public float health;
    public float horizontal;
    public float vertical;
    public Vector2 GazeDirect;
    bool Eyesight;
    public LayerMask Interactable;
    public Rigidbody2D body;
    public bool readyToBreed;

    
    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        hunger = 0;
        thirst = 0;
        Genes = gameObject.GetComponent<Genes>();
        health = Genes.size * 2;
        var SupremeMutation = Random.Range(1, 50);
        if(SupremeMutation >= 30)
        {
            for(int e = 0; e <= Random.Range(1,5); e++)
            {

                string NewGene = Letters[Random.Range(0, Letters.Count)];
                UniqueGenes = UniqueGenes + NewGene;
                
            }
           
        }
        InvokeRepeating("randomMovement", Genes.lethargyMin, Random.Range(Genes.lethargyMin, Genes.lethargyCap));
       
       

    }

    // Update is called once per frame
    void Update()
    {
        if(horizontal != 0)
        {
            GazeDirect.x = horizontal;
        }
        if(vertical != 0)
        {
            GazeDirect.y = vertical;
        }
        Eyesight = Physics2D.Raycast(transform.position, GazeDirect, Genes.eyesight * 2, Interactable);
        Debug.DrawRay(transform.position, GazeDirect * Genes.eyesight);
        body.velocity = new Vector2(horizontal * Genes.speed, vertical * Genes.speed);
    }
    void randomMovement()
    {
        
        horizontal = Random.Range(-1, 2);
        vertical = Random.Range(-1, 2);
    }
    void hungify()
    {
        hunger += 1;
        thirst += 1;
    }
    private void FixedUpdate()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        horizontal *= -1;
        vertical *= -1;
    }

}

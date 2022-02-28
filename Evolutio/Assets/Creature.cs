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
    public string GeneGen;
    public List<string> Letters;
    

    
    // Start is called before the first frame update
    void Start()
    {
        var SupremeMutation = Random.Range(40, 50);
       
        
        if(SupremeMutation >= 40)
        {
            for(int e = 0; e <= Random.Range(1,5); e++)
            {

                string NewGene = Letters[Random.Range(0, Letters.Count)];
                GeneGen = GeneGen + NewGene;
                
            }
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

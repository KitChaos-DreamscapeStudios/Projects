using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public PotionEffects currentPotion;
    public GameObject IngredientA;
    public GameObject IngredientB;
    public GameObject IngredientC;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IngredientA.tag == "Toxic" && IngredientB.tag == "Duration" && IngredientC.tag == "Debuffer")
        {
            currentPotion.damage = 5;
        }
    }
}

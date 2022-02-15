using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Potion", menuName ="Objects/Items/Potions")]
public class Potions : ScriptableObject
{
    public int helpfulness;
    public float duration;
    public GameObject potionProjectile;
    public PotionEffects effect;
    
}

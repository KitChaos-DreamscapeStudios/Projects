using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Genes")]
public class Genes : MonoBehaviour
{
    public float speed = 3;
    public float strength;
    public float size;
    public float energyUsage;
    public float eyesight = 5;
    public float lifeSpan;
    public float antibodies;
    public readonly float lethargyCap = 5;
    public readonly float lethargyMin = 1;
}

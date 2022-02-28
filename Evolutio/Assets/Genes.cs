using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Genes")]
public class Genes : MonoBehaviour
{
    public float speed;
    public float strength;
    public float size;
    public float energyUsage;
    float maxSpeed;
    private void Start()
    {
        speed = speed - strength - size;
    }
    private void Update()
    {
        energyUsage = speed + strength + size;
    }
}

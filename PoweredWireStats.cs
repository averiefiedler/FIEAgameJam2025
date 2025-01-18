Using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Color { blue, red, yellow, green, orange, purple}  

public class PoweredWireStats : MonoBehavior
{
    public bool movable = false;
    public bool moving = false;
    public Vector3 startPosition;
    public Color objectColor;
    public bool connected = false;
    public Vector3 connectedPosition;
    // start is called before the first frame update

    void Start()
    {
        startPosition = transform.position;
    }

    // update is called once per frame
    void Update()
    {

    }
}
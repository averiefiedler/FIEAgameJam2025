Using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredWireBehavior : MonoBehavior
{
    bool mouseDown = false
    public PoweredWireStats powerWireS;
    LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        powerWireS = gameObject.GetComponent<PoweredWireStats>();
        line = gameObject.GetComponent<LineRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        MoveWire();
        line.SetPosition(3, new Vector3(gameObject.transform.localPosition.x-.1f, gameObject.transform.localPosition.y - .1f, 0));
        line.SetPosition(3, new Vector3(gameObject.transform.localPosition.x-.4f, gameObject.transform.localPosition.y - .1f, 0));
    }
    void OnMouseDown()
    {
        mouseDown = true;
    }

    void OnMouseOver()
    {
        powerWireS.movable = true;
    }

    void OnMouseExit()
    {
        if (!powerWireS.moving)
            powerWireS.movable = false;
    }
    void OnMouseUp()
    {
        mouseDown = false
        if(!powerWireS.connected)
        gameObject.transform.position = powerWireS.startPosition;
        if(powerWireS.connected)
            gameObject.transform.position = powerWireS.connectedPosition;
    }
    void MoveWire()
    {
        if (mouseDown && powerWireS.movable)
        {
        powerWireS.move = true;
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;

        gameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mouseX, mouseY, 1));
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, trasnform.parent.transform.position.z);
        }
        else
            powerWireS.moving = false;
    }
    
}
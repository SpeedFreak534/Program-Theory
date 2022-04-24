using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    public string shapeName { get; private set; }

    private void Start()
    {
        shapeName = "myCylinder";
    }

    public override void DisplayText()
    {
        Debug.Log(shapeName + " shape clicked!");
    }
}

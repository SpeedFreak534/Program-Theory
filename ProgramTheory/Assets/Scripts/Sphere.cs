using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public string shapeName { get; private set; }

    private void Start()
    {
        shapeName = "mySphere";
    }

    public override void DisplayText()
    {
        Debug.Log(shapeName + " shape clicked!");
    }
}

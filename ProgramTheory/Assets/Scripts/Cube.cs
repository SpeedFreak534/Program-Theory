using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public string shapeName { get; private set; }

    private void Start()
    {
        shapeName = "myCube";
    }

    public override void DisplayText()
    {
        Debug.Log(shapeName + " shape clicked!");
    }
}

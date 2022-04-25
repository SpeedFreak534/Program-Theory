using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape //Inheritance
{
    private string shapeName;

    private void Start()
    {
        shapeName = "myCube";
    }

    public override void DisplayText()
    {
        //Polymorphism
        Debug.Log(shapeName + " shape clicked!");
    }
}

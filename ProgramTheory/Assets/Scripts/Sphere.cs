using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape //Inheritance
{
    private string shapeName;

    private void Start()
    {
        shapeName = "mySphere";
    }

    public override void DisplayText()
    {
        //Polymorphism
        Debug.Log(shapeName + " shape clicked!");
    }
}

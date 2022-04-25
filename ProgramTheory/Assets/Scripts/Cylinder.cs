using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape //Inheritance
{
    private string shapeName;

    private void Start()
    {
        shapeName = "myCylinder";
    }

    public override void DisplayText()
    {
        //Polymorphism
        Debug.Log(shapeName + " shape clicked!");
    } 
}

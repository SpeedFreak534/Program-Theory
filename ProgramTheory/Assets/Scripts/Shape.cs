using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public virtual void DisplayText() //Polymorphism
    {
        Debug.Log("Random shape clicked!");
    }

    private void OnMouseDown()
    {
        //Abstraction
        DisplayText();
    }
}

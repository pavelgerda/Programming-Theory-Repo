using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class CubeForm : Shape
{
    public GameObject CurShape;

    // POLYMORPHISM
    public override void DisplayText()
    {
        print(CurShape.name + " - Cube clicked! Color: " + ShapeColorProperty.ToString());
    }
}
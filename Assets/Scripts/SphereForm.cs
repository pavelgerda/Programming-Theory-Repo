using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class SphereForm : Shape
{
    public GameObject CurShape;

    // POLYMORPHISM
    public override void DisplayText()
    {
        print(CurShape.name + " - Sphere clicked! Color: " + ShapeColorProperty.ToString());
    }
}
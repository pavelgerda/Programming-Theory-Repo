using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereForm : Shape
{
    public GameObject CurShape;

    public override void DisplayText()
    {
        print(CurShape.name + " - Sphere clicked! Color: " + ShapeColorProperty.ToString());
    }
}
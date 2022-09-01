using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeForm : Shape
{
    public GameObject CurShape;

    public override void DisplayText()
    {
        print(CurShape.name + " - Cube clicked! Color: " + ShapeColorProperty.ToString());
    }
}
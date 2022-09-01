using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Drawing;

// INHERITANCE
public class CapsuleForm : Shape
{
    public GameObject CurShape;

    // POLYMORPHISM
    public override void DisplayText()
    {
        print(CurShape.name + " - Capsule clicked! Color: " + ShapeColorProperty.ToString());
    }
}

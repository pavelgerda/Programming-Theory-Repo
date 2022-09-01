using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION
public abstract class Shape : MonoBehaviour
{
    private Color ShapeColor;

    // ENCAPSULATION
    public Color ShapeColorProperty
    {
        get { return ShapeColor; }
        set
        {
            if (value.r >= 0f && value.r <= 1f && value.g >= 0f && value.g <= 1f && value.b >= 0f && value.b <= 1f) 
            { 
                ShapeColor = value; 
            }
        }
    }

    private void Start()
    {
        ShapeColor = GetComponent<Renderer>().material.color;
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    public abstract void DisplayText();

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

[ExecuteAlways]
[RequireComponent(typeof(TextMeshPro))]
public class CoordinateLabeller : MonoBehaviour
{
    TextMeshPro textMeshPro;

    private void Awake() 
    {
        textMeshPro = GetComponent<TextMeshPro>();
    }

    private void Update() 
    {
        if (!Application.isPlaying)
        {
            textMeshPro.text = $"({transform.parent.transform.position.x}, {transform.parent.transform.position.z})";
        }
    }

}

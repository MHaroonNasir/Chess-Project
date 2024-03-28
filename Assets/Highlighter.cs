using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    public void ApplyHighlight(Vector3Int vector)
    {
        foreach (Transform children in transform)
        {
            if (children.gameObject.activeInHierarchy == true) { continue; }
            
            children.gameObject.SetActive(true);
        }
    }
}

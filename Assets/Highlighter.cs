using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    public void ApplyHighlight(List<Vector2Int> allMovePaths)
    {
        int index = 0;
        if (allMovePaths[index] == null) { return; }

        //need code for instantiating more of the child if not enough in the game

        foreach (Transform children in transform)
        {
            if (!children.gameObject.activeInHierarchy) 
            {
                children.gameObject.transform.position = new Vector3Int(allMovePaths[index].x, 1, allMovePaths[index].y); 
                children.gameObject.SetActive(true); 
            }
            index += 1;
        }
        gameObject.SetActive(true); //set the current gameobject itself to true, above code is for children
    }
}

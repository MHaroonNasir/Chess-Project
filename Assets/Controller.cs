using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    [SerializeField] PieceType pieceType;

    public InputAction select;

    private void Start() 
    {
        //select.performed += Highlight;
        select.Enable();
    }

    /*void Update()
    {
        if (select.WasPressedThisFrame())
        {
            Debug.Log("performed");
        }
    }*/

    /*void Highlight(InputAction.CallbackContext arguement)
    {
        Debug.Log("performed");
    }*/

    private void OnMouseDown() 
    {
        Debug.Log("performed");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    [SerializeField] PieceType pieceType;
    Type getPiece;

    public InputAction select;

    private void Start() 
    {
        //select.performed += Highlight;
        select.Enable();
        getPiece = Piece.GetTypeOfScript(pieceType);
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
        //getPiece = Piece.GetTypeOfScript(pieceType);
        /*object piece = Activator.CreateInstance(getPiece);
        piece.GetAllMovePaths();
        Debug.Log(getPiece);
        getPiece.GetAllMovePaths(new Vector2Int((int) transform.position.x, (int) transform.position.y));
        BishopPiece bishop = new BishopPiece();
        bishop.GetAllMovePaths(new Vector2Int((int) transform.position.x, (int) transform.position.y));*/
    }
}

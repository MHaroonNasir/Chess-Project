using System;
using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;

public class Piece
{
    //Vector2Int coordinates;
    //PieceType pieceType;

    /*protected Piece(Vector2Int coordinates, PieceType pieceType)
    {
        this.coordinates = coordinates;
        this.pieceType = pieceType;
    }*/

    public static Type GetTypeOfScript(PieceType pieceType)
    {
        switch (pieceType)
        {
            case PieceType.Bishop:
                return typeof(BishopPiece);
            default:
                return null;     
        }

    }

    public static object ReturnType(PieceType pieceType)
    {
        switch (pieceType)
        {
            case PieceType.Bishop:
                return new BishopPiece();
            default:
                return null;     
        }
    }

    /*protected Dictionary<PieceType, Class> pieceDefinition;
    pieceDefinition = new Dictionary<PieceType, Class>();


    {
        {PieceType.Bishop, BishopPiece}
    };

    protected KeyValuePair<PieceType, Class> pieceDefinition2 = new KeyValuePair<PieceType, Class>()
    {
        (PieceType.Bishop, new BishopPiece())
    };*/
}

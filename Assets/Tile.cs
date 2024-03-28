using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    Vector2Int coordinates;
    bool hasPiece;
    string pieceColour;

    public Tile(Vector2Int coordinates, bool hasPiece, string pieceColour)
    {
        this.coordinates = coordinates;
        this.hasPiece = hasPiece;
        this.pieceColour = pieceColour;
    }
}

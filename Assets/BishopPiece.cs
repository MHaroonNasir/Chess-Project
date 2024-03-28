using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopPiece : Piece
{
    /*public BishopPiece(Vector2Int coordinates, PieceType pieceType) : base(coordinates, pieceType)
    {
        
    }*/

    public List<Vector2Int> GetAllMovePaths(Vector2Int coordinates) 
    {
        List<Vector2Int> allMovePaths = new List<Vector2Int>();
        Vector2Int currentCoordinates = coordinates;
        
        Vector2Int newCoordinates = currentCoordinates;
        while (newCoordinates.x < 8-1 && newCoordinates.y < 8-1)
        {
            newCoordinates.x += 1*5;
            newCoordinates.y += 1*5;
            allMovePaths.Add(newCoordinates);
        }

        newCoordinates = currentCoordinates;
        while (newCoordinates.x < 8-1 && newCoordinates.y > 0)
        {
            newCoordinates.x += 1*5;
            newCoordinates.y -= 1*5;
            allMovePaths.Add(newCoordinates);
        }

        newCoordinates = currentCoordinates;
        while (newCoordinates.x > 0 && newCoordinates.y > 0)
        {
            newCoordinates.x -= 1*5;
            newCoordinates.y -= 1*5;
            allMovePaths.Add(newCoordinates);
        }

        newCoordinates = currentCoordinates;
        while (newCoordinates.x > 0 && newCoordinates.y < 8-1)
        {
            newCoordinates.x -= 1*5;
            newCoordinates.y += 1*5;
            allMovePaths.Add(newCoordinates);
        }

        return allMovePaths;
    }

    /*List<Vector2Int> Travel(List<Vector2Int> allMovePaths, Vector2Int coordinates, bool moveInX, bool moveinY, bool additionToX, bool additionToY)
    {
        Vector2Int newCoordinates = coordinates;
        if (moveInX)
        {
            if (additionToX && newCoordinates.x < (8-1)*5) { newCoordinates.x += 1*5; }
            else if (!additionToX && newCoordinates.x > 0) { newCoordinates.x -= 1*5; }
        }
        if (moveinY)
        {
            if (additionToY && newCoordinates.y < (8-1)*5) { newCoordinates.y += 1*5; }
            else if (!additionToY && newCoordinates.y > 0) { newCoordinates.y -= 1*5; }
        }

        allMovePaths.Add(newCoordinates);
        return allMovePaths;
    }*/
}

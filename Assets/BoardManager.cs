using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] Vector2Int coordinates;
    public GameObject whiteTile;
    public GameObject blackTile;

    Dictionary<Tile, GameObject> gameBoard;
    bool hasPiece;
    string pieceColour;

    bool isWhiteTile = true;

    private void Start() 
    {
        GameObject tileObject;
        for (int x = 0; x < 8; x++)
        {
            /*if (x <= 1 || x >= 6) 
            {
                hasPiece = true;
            }
            if (x <= 1) { pieceColour = "white"; }
            if (x >= 6) { pieceColour = "black"; }*/

            for (int z = 0; z < 8; z++)
            {
                if (isWhiteTile)
                {
                    tileObject = Instantiate(whiteTile, new Vector3Int(x*5, 0, z*5), Quaternion.identity);
                }
                else
                {
                    tileObject = Instantiate(blackTile, new Vector3Int(x*5, 0, z*5), Quaternion.identity);
                }
                tileObject.GetComponent<TileObject>().SetupTile();

                //Tile tile = new Tile(new Vector2Int(x*5, z*5), hasPiece, pieceColour);
                //gameBoard.Add(tile, coordinates);
                isWhiteTile = !isWhiteTile;
            }
            hasPiece = false;
            pieceColour = null;
        }    
    }
}

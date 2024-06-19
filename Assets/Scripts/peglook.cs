using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class peglook : MonoBehaviour
{
    public List<TileBase> tiles;

    void Start()
    {
        SetRandomTile();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetRandomTile();
        }
    }

    void SetRandomTile()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (tiles != null && tiles.Count > 0 && spriteRenderer != null)
        {
            // Pick a random tile from the palette
            int randomIndex = Random.Range(0, tiles.Count);
            TileBase randomTile = tiles[randomIndex];

            if (randomTile != null)
            {
                Tile tile = randomTile as Tile;
                if (tile != null)
                {
                    spriteRenderer.sprite = tile.sprite;
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGrid : MonoBehaviour
{
    int width, height;
    public Block[,] grid;
    // Start is called before the first frame update
    void Start()
    {
        width = 9;
        height = 9;
        grid = new Block[width, height];
        for (int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                grid[i,j] = new Block();
                print(grid[i,j].color);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

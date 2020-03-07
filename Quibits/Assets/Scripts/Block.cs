using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockTypes
{
    Orange,
    Red,
    Yellow,
    White,
    Green, 
    Blue, 
    Black, 
    Purple
};
[System.Serializable]
public class Block
{
    public BlockTypes color;

    public Block()
    {
        color = (BlockTypes)Random.Range(0, 8);
    }

    // Start is called before the first frame update
}

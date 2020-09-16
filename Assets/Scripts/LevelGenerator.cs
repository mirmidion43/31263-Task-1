using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    // a 14x15 2d array
    int[,] levelMap =
    {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
    }; 

    public GameObject TestTile;
    public GameObject TestCube;


    // Called before Start
    private void Awake() 
    {
        Debug.Log("Awake Called");
        for (int i = 0; i < 14; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                makeTile(levelMap[j,i], i, j); 
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //instantiate a tile based on the levelMap array
    private void makeTile(int ID, int x1, int y2)
    {
        float x = (float)x1;
        float y = (float)y2;

        float a1 = x - 13.5f;
        float a2 = -y + 14.5f;

        float b1 = -(x - 13.5f);
        float b2 = (-y + 14.5f);

        float c1 = (x - 13.5f);
        float c2 = -(-y + 14.5f);

        float d1 = -(x - 13.5f);
        float d2 = -(-y + 14.5f);
        
        makeDecider(ID, a1,a2);
        makeDecider(ID, b1,b2);
        makeDecider(ID, c1,c2);
        makeDecider(ID, d1,d2);
    }

    private void makeDecider(int ID, float x, float y)
    {
        if(ID == 1)
            make1(x,y);

        if(ID == 2)
            make2(x,y);

        if(ID == 3)
            make3(x,y);

        if(ID == 4)
            make4(x,y);

        if(ID == 5)
            make5(x,y);

        if(ID == 6)
            make6(x,y);

        if(ID == 7)
            make7(x,y);
    }

    //make an Outside Corner
    private void make1(float x, float y)
    {
        Instantiate(TestTile, new Vector3(x,y,0), Quaternion.identity);
    }
    //make an Outside Wall
    private void make2(float x, float y)
    {
        Instantiate(TestTile, new Vector3(x,y,0), Quaternion.identity);
    }

    //make an Inside Corner
    private void make3(float x, float y)
    {
        Instantiate(TestCube, new Vector3(x,y,0), Quaternion.identity);
    }

    //make an Inside Wall
    private void make4(float x, float y)
    {
        Instantiate(TestCube, new Vector3(x,y,0), Quaternion.identity);
    }

    //make a Standard Pellet
    private void make5(float x, float y)
    {
        //Instantiate(TestCube, new Vector3(x,y,0), Quaternion.identity);
    }

    //make a Power Pellet
    private void make6(float x, float y)
    {
        //Instantiate(TestTile, new Vector3(x,y,0), Quaternion.identity);
    }

    //make a T-junction
    private void make7(float x, float y)
    {
        Instantiate(TestTile, new Vector3(x,y,0), Quaternion.identity);
    }
}

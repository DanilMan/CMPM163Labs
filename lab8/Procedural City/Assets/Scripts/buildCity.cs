﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildCity : MonoBehaviour
{
	public GameObject[] buildings;
    public GameObject xstreets;
    public GameObject zstreets;
    public GameObject crossroad;
	public int mapWidth = 40;
	public int mapHeight = 40;
    int [,] mapgrid;
    int buildingFootprint = 25;

    // Start is called before the first frame update
    void Start()
    {
        float seed = 69; //Random.Range(0,100);
        mapgrid = new int[mapWidth, mapHeight];

        // generate map data
        for(int h = 0; h < mapHeight; h++)
        {
            for(int w = 0; w < mapWidth; w++)
            {
                mapgrid[w,h] = (int) (Mathf.PerlinNoise(w/10.0f + seed, h/10.0f + seed) * 14);
            }
        }

        //build streets
        int x = 0;
        for(int n = 0; n < 50; n++)
        {
            for(int h = 0; h < mapHeight; h++)
            {
                mapgrid[x, h] = -1;
            }
            x += Random.Range(3, 3);
            if(x >= mapWidth) break;
        }

        int z = 0;
        for(int n = 0; n < 10; n++)
        {
            for(int w = 0; w < mapWidth; w++)
            {
                if(mapgrid[w, z] == -1)
                    mapgrid[w, z] = -3;
                else
                    mapgrid[w, z] = -2;
            }
            z += Random.Range(2,20);
            if(z >= mapHeight) break;
        }

        //generate city
        for(int h = 0; h < mapHeight; h++)
        {
        	for(int w = 0; w < mapWidth; w++)
        	{
                int result = mapgrid[w, h];
        		Vector3 pos = new Vector3(w * buildingFootprint,0,h * buildingFootprint);
                if(result < -2)
                    Instantiate(crossroad, pos, crossroad.transform.rotation);
                else if(result < -1)
                    Instantiate(xstreets, pos, xstreets.transform.rotation);
                else if(result < 0)
                    Instantiate(zstreets, pos, zstreets.transform.rotation);
        		else if(result < 2)
                    Instantiate(buildings[0], pos, Quaternion.identity);
                else if(result < 4)
                    Instantiate(buildings[1], pos, Quaternion.identity);
                else if(result < 6)
                    Instantiate(buildings[2], pos, Quaternion.identity);
                else if(result < 8)
                    Instantiate(buildings[3], pos, Quaternion.identity);
                else if(result < 10)
                    Instantiate(buildings[4], pos, Quaternion.identity);
                else if(result < 14)
                    Instantiate(buildings[5], pos, Quaternion.identity);
        	}
        }
    }

}

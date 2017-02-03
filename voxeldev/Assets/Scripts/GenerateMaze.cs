using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GenerateMaze : MonoBehaviour {
	
	public GameObject wall;
	public GameObject floor;
	public GameObject player;
	public GameObject cheese;
	private int[,] worldmap = new int[,]
	{
		{1,1,1,1,1,1,1,1,1,1},
		{1,1,1,2,0,0,0,0,0,1},
		{1,1,1,1,0,1,1,0,0,1},
		{1,0,0,1,0,1,1,1,1,1},
		{1,0,0,1,0,0,0,0,0,1},
		{1,0,0,1,1,1,1,1,0,1},
		{1,0,0,0,0,0,0,0,0,1},
		{1,0,1,1,1,1,1,1,1,1},
		{1,0,0,0,0,0,0,0,3,1},
		{1,1,1,1,1,1,1,1,1,1}
	};

	// Use this for initialization
	void Start () 
	{
		GameObject f = (GameObject)Instantiate(floor,new Vector3(0,0,0), Quaternion.identity);

		for (int i = 0; i < 10; ++i)
		{
		
			for(int j = 0;j < 10;++j)
			{
				GameObject t;
				if (worldmap [i,j] == 1)
				{
					t = (GameObject)Instantiate(wall,new Vector3(50-i*10, 1.5f, 50-j*10), Quaternion.identity);
				}
			
				if (worldmap [i,j] == 2)
				{
					t = (GameObject)Instantiate(player,new Vector3(50-i*10, 1.5f, 50-j*10), Quaternion.identity);
				}
				if (worldmap [i,j] == 3)
				{
					t = (GameObject)Instantiate(cheese,new Vector3(50-i*10, 2.0f, 50-j*10), Quaternion.identity);
				}
			}
		
		
		}	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

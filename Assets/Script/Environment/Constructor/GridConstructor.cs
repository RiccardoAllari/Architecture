using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridConstructor : ASpawner
{
	public GameObject groundPrototype;
#if UNITY_EDITOR
	public bool autoGenerateGrid;
	public int gridWidth;
	public int gridHeight;
#endif

#if UNITY_EDITOR
	void Start()
	{
		if(autoGenerateGrid) 
			TestSpawn();
	}
	protected override void TestSpawn() => Init(gridWidth, gridHeight);
#endif

	public void Init(int width, int height)
	{
		for(int i = 0; i < width; i++)
		{
			for(int j = 0; j < height; j++)
			{
				GameObject go = Instantiate(groundPrototype);
				go.name = (i.ToString() + " - " + j.ToString());
				go.transform.parent = transform;
				go.transform.localPosition = Vector3.right * i + Vector3.forward * j +Vector3.down * 0.5f;
			}
		}
	}
}

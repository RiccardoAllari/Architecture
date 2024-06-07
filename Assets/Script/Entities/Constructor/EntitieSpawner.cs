using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EntitieSpawner : ASpawner
{
	public EntityController prototype;

#if UNITY_EDITOR
    protected override void TestSpawn()
    {
        for(int i = 0; i < 10; i++)
		{
			SpawnEntity(i, 0);
		}
    }

#endif


    public GameObject SpawnEntity(int x, int y)
	{
		var go = Instantiate(prototype, transform);
		go.transform.localPosition = new Vector3(x, 0, y);
		return go.gameObject;
	}
}

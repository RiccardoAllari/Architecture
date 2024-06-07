using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    [Header("Reference")]
    public GameObject viewLoading;
    public GridConstructor grid;
    public EntitieSpawner spawner;

    [Header("Level Configuration")]
    public DatabaseLevel databaseLevel;
    IEnumerator Start()
    {
        viewLoading.SetActive(true);
        yield return new WaitForSeconds(1);
        grid.Init(databaseLevel.width, databaseLevel.height);
        yield return new WaitForSeconds(1);
        for(int row = 0; row < databaseLevel.entitiesRow; row++)
        {
            for(int i = 0; i < databaseLevel.width; i++)
            {
                spawner.SpawnEntity(i, row);
            }
            yield return 0;
        }
        yield return new WaitForSeconds(1);
        viewLoading.SetActive(false);
    }
}
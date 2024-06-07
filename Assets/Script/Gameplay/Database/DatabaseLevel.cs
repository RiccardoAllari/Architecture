
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Game/New Level")]
public class DatabaseLevel : ScriptableObject
{
    public int width;
    public int height;
    public int entitiesRow;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ASpawner : MonoBehaviour
{
#if UNITY_EDITOR
	[ContextMenu("TestSpawn")]
	void ContestMenuTestSpawn()
	{
        ClearImmediate();
        TestSpawn();
	}
    [ContextMenu("Clear")]
    void ClearImmediate() => transform.DestroyAllChildrenImmediate();
    protected abstract void TestSpawn();
#endif
}

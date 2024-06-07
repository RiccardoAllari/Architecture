using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformExtension
{
#if UNITY_EDITOR
    public static void DestroyAllChildrenImmediate(this Transform transform)
    {
        while(transform.childCount > 0)
        {
            Object.DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }
#endif
}

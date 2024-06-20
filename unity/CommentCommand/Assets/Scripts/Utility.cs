using System;
using UnityEngine;

public static class Utility
{
    /// <summary>
    /// 子どものオブジェクトを再帰的に走査します
    /// </summary>
    /// <param name="transform">ルートオブジェクト</param>
    /// <param name="action">判定関数</param>
    public static void GetChildren(Transform transform, Action<Transform> action)
    {
        var childCount = transform.childCount;
        if (childCount == 0)
        {
            return;
        }

        for (int i = 0; i < childCount; i++)
        {
            var child = transform.GetChild(i);
            action.Invoke(child);
            GetChildren(child, action);
        }
    }
}

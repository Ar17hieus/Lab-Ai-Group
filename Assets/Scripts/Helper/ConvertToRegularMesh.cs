using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToRegularMesh : MonoBehaviour
{
    [ContextMenu("Convert to regular mesh")]
    void Convert()
    {
        SkinnedMeshRenderer SkinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
        MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();

        meshFilter.sharedMesh = SkinnedMeshRenderer.sharedMesh;
        meshRenderer.sharedMaterials = SkinnedMeshRenderer.sharedMaterials;

        DestroyImmediate(SkinnedMeshRenderer);
        DestroyImmediate(this);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Sphere360 : MonoBehaviour
{
    MeshRenderer meshRenderer;
    int materialIndex;

    [SerializeField] Material[] materials;

    private void OnEnable()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        materialIndex = 0;
        ChangeMaterial();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).tapCount == 1)
            {
                NextMaterial();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            NextMaterial();
        }
    }

    public void NextMaterial()
    {
        materialIndex = materialIndex + 1 >= materials.Length ? 0 : materialIndex + 1;
        ChangeMaterial();
        Debug.Log("Se cambió el material");
    }

    void ChangeMaterial()
    {
        if (materials.Length > 0)
        {
            materialIndex = Mathf.Clamp(materialIndex, 0, materials.Length - 1);
            meshRenderer.material = materials[materialIndex];
        }
    }
}

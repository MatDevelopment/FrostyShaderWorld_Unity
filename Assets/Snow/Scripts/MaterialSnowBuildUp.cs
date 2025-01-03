using System;
using Unity.VisualScripting;
using UnityEngine;

public class MaterialSnowBuildUp : MonoBehaviour
{
    [SerializeField] private Material[] materials;

    private void Awake()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].SetFloat("_SnowAmount", 0.0f);
        }
    }

    private void Update()
    {
        float snowAmount = (Time.time / 20.0f) % 1.2f;

        for (int i = 0; i < materials.Length; ++i)
        {
            materials[i].SetFloat("_SnowAmount", snowAmount);
        }
    }
}

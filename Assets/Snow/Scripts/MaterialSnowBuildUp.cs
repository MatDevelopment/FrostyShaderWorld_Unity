using System;
using Unity.VisualScripting;
using UnityEngine;

public class MaterialSnowBuildUp : MonoBehaviour
{
    [SerializeField] private Material[] materials;
    private float snowAmount;

    private void Awake()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].SetFloat("_SnowAmount", 0.0f);
        }
    }

    private void Update()
    {

        if (snowAmount < 0.67f)
        {
            snowAmount = (Time.time / 35.0f) % 1.2f;
            
            for (int i = 0; i < materials.Length; ++i)
            {
                materials[i].SetFloat("_SnowAmount", snowAmount);
            }
        }
        
    }
}

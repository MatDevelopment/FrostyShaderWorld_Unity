using System.IO.Compression;
using UnityEngine;

public class GrassPlanting : MonoBehaviour
{
    public GameObject grassPrefab;
    private int grassSize = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int z = -grassSize; z<= grassSize; z++)
        {
            for (int x = -grassSize; x<= grassSize; x++)
        {
            Vector3 posistion = new Vector3(x/4.0f + Random.Range(-0.30f,0.30f), 0, z/4.0f + Random.Range(-0.30f,0.30f));
            GameObject grass = Instantiate(grassPrefab, posistion, Quaternion.identity);
            grass.transform.localScale = new Vector3(1, Random.Range(0.65f, 1.35f), 1);
        }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

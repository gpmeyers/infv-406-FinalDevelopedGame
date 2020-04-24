using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWorld : MonoBehaviour
{
    public GameObject[] platforms;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(0, 0, 250);
        for(int i = 0; i < 5; i++)
        {
            int platformNumber = Random.Range(0, platforms.Length);
            Instantiate(platforms[platformNumber], pos, Quaternion.identity);
            pos.z += 250;
        }
    }

    // This function generates 3 new platforms when called
    public void GeneratePlatform()
    {
        int platformNumber = Random.Range(0, platforms.Length);
        Instantiate(platforms[platformNumber], pos, Quaternion.identity);
        pos.z += 250;
    }
}

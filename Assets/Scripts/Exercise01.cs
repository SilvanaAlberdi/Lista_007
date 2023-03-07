using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    public GameObject Cube;

    void Start()
    {
        for (int i=0; i<10; i++)
        {
            float XRandom = Random.Range(-3, 3);
            float YRandom = Random.Range(-3, 3);
            float ZRandom = Random.Range(-3, 3);

            Vector3 pos = new Vector3(XRandom, YRandom, ZRandom);
            GameObject GO = Instantiate(Cube, pos, Quaternion.identity);
            GO.transform.localScale = Vector3.one * Random.Range(1, 5);
        }
    }
}

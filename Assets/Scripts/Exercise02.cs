using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise02 : MonoBehaviour
{
    public int Contador = 1;
    public TextMeshProUGUI Texto;

    public IEnumerator Counter ()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Texto.text = $"{Contador}";
            Contador++;
        }
    }

    void Start()
    {
        StartCoroutine("Counter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

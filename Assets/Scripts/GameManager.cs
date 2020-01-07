using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject whiteCellPrefab;

    int N = 30, M = 20, size = 16;

    // Start is called before the first frame update
    void Start()
    {
        Transform p = GameObject.Find("Canvas").transform;

        for (int i = 1; i <= N; ++i)
        {
            for (int j = 1; j <= M; ++j)
            {
                GameObject g = Instantiate(whiteCellPrefab, p);
                g.transform.localPosition = new Vector3(i * size, j * size);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

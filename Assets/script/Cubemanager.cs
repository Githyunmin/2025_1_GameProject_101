using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubemanager : MonoBehaviour
{
    public CubeGenerator[] generatedCubes = new CubeGenerator[5];

    public float timer = 0f;
    public float interval = 3f;



    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            RandomizeCubeActivation();
            timer = 0f;
        }
    }

    public void RandomizeCubeActivation()
    {
        for (int i = 0; i < generatedCubes.Length; i++)
        {
            int randomNum = Random.Range(0, 2);
            if(randomNum == 1)
            {
                generatedCubes[i].GenCube();
            }
        }
    }
}

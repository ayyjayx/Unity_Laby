using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie5 : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        List<Vector3> takenPositions = new List<Vector3>();

        for (int i = 0; i < 10; i++)
        {
            Vector3 randomPosition;

            do
            {
                // Losowa pozycja
                randomPosition = new Vector3(
                    Random.Range(-4.5f, 4.5f),
                    0.5f,
                    Random.Range(-4.5f, 4.5f)
                    );
            } while (takenPositions.Contains(randomPosition));

            takenPositions.Add(randomPosition);
            Instantiate(cube, randomPosition, Quaternion.identity);
        }
    }
}
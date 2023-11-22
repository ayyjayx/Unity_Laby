using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Zad1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;

    public GameObject block;
    public int objectsNumber = 10;
    public List<Material> materialList = new List<Material>();

    void Start()
    {
        int range_x = (int)transform.localScale.x * 10;
        int range_z = (int)transform.localScale.z * 10;
        List<int> pozycje_x = new List<int>(Enumerable.Range(-range_x / 2, range_x).OrderBy(x => Guid.NewGuid()).Take(objectsNumber));
        List<int> pozycje_z = new List<int>(Enumerable.Range(-range_z / 2, range_z).OrderBy(x => Guid.NewGuid()).Take(objectsNumber));

        // foreach (int elem in pozycje_x)
        // {
        //     Debug.Log(elem);
        // }

        for (int i = 0; i < objectsNumber; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i] + transform.position.x, 2,
            pozycje_z[i] + transform.position.z));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }

        StartCoroutine(GenerujObiekt());
    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach (Vector3 pos in positions)
        {
            int randomNum = UnityEngine.Random.Range(0, materialList.Count);
            GameObject newInstance = Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            Renderer rd = newInstance.GetComponent<Renderer>();
            rd.material = materialList[randomNum];
            yield return new WaitForSeconds(this.delay);
        }

        StopCoroutine(GenerujObiekt());
    }
}
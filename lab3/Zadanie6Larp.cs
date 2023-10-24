using UnityEngine;

public class Zadanie6Larp : MonoBehaviour
{
    // Smooth towards the height of the target

    public Transform target;
    static float t = 0;

    void Update()
    {
        float newPositionY = Mathf.Lerp(transform.position.y, target.position.y, t);
        transform.position = new Vector3(transform.position.x, newPositionY, transform.position.z);
        t += 0.0002f * Time.deltaTime;
    }
}
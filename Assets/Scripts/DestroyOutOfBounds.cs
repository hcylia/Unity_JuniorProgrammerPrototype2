using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xRange = 30;
    void Update()
    {
        if (transform.position.z > xRange || transform.position.z < -xRange)
        {
            Destroy(gameObject);
        }
    }
}

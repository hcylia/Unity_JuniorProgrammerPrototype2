using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float[] xBound = { -10, 30 };
    private float yBound = 30;

    void Update()
    {
        if (transform.position.z > xBound[1])
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < xBound[0] || transform.position.x < -yBound || transform.position.x > yBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}

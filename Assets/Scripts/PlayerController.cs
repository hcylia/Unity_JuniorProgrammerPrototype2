using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;

    private float horizontalInput;
    private float verticalInput;
    private float speed = 10.0f;
    private float xRange = 15.0f;
    private float[] yRange = { 0.0f, 15.0f };
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < yRange[0])
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, yRange[0]);
        }
        if (transform.position.z > yRange[1])
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, yRange[1]);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch Projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}

using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private int nbFrame = 0;
    private int maxFrame = 15;
    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && nbFrame > maxFrame)
        {
            nbFrame = 0;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
        nbFrame++;
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5;
    public GameObject discPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move player horizontally
        float x = Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.position = new Vector3(transform.position.x + x, transform.position.y, 0);

        // Drop disc
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Clone prefab
            Instantiate(discPrefab, transform.position, Quaternion.identity);
        }
    }
}

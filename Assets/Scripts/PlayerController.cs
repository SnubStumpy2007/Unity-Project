using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables for retrieviing input from unity
    public float horizontalInput;

    public float speed = 10.0f;
    public float xRange = 10;

    // variable for pizza projectile
    public GameObject projectilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // grab input from Unity
        horizontalInput = Input.GetAxis("Horizontal");

        // player movment when pressing right and left arrow keyes
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); 

        // if statement to prevent player from falling off map
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}

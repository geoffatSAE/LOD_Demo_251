using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed, rotateSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0, 0, v * Time.deltaTime * moveSpeed));

        transform.Rotate(new Vector3(0, h * Time.deltaTime * rotateSpeed, 0));
    }
}

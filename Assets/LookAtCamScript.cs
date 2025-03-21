using UnityEngine;

public class LookAtCamScript : MonoBehaviour
{
    public Camera mainCamera;
    public bool lookAtCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(lookAtCamera) transform.LookAt(mainCamera.transform.position);
    }
}

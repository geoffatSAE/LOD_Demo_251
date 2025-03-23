using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed, rotateSpeed;
    int banana;


    public GameObject noLODBanana, yesLODBanana;

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

        if(Input.GetButtonDown("Jump")){
            
            if(banana == 0){
                banana = 1;
                noLODBanana.SetActive(true);
                yesLODBanana.SetActive(false);
            } else if(banana == 1){
                banana = 2;
                noLODBanana.SetActive(false);
                yesLODBanana.SetActive(true);
            } else {
                banana = 0;
                noLODBanana.SetActive(false);
                yesLODBanana.SetActive(false);
            }

        }

  
    }

   
}

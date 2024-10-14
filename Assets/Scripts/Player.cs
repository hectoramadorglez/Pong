using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int velocidad;
    void Start()
    {
        Debug.Log("hola");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        { 
            transform.Translate(new Vector3(0,1,0)* velocidad* Time.deltaTime);
        
        }  
        else if (Input.GetKey(KeyCode.S)) 
        {
            transform.Translate(new Vector3(0, -1, 0) * velocidad * Time.deltaTime);


        }
        float yClamped = Mathf.Clamp(transform.position.y, -3, 3);
        transform.position = (new Vector3(transform.position.x, yClamped, transform.position.z));
    }
}

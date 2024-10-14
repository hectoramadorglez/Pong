using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private int scorePlayer1, scorePlayer2;
    [SerializeField]private TMP_Text Score1;
    [SerializeField] private TMP_Text Score2;
    private Vector3 posicionBola;
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector3 (1,1,0).normalized * 5, ForceMode2D.Impulse);
       posicionBola =  transform.position;


    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Porteria1")) 
        {
            scorePlayer2++;
            Score2.SetText("Score: " + scorePlayer2);
            transform.position = posicionBola;
            ReiniciarBola();
        } 
        else if (other.gameObject.CompareTag("Porteria2"))
        {
            scorePlayer1++;
            Score1.SetText("Score: " + scorePlayer1);
            transform.position = posicionBola;
            ReiniciarBola();
        }
        

    }
    void ReiniciarBola() 
    {
        int numRx = Random.Range(-1, 2);
        int numRy = Random.Range(-1, 2);
        rb.velocity = Vector3.zero;
        rb.AddForce(new Vector3(numRx, numRy, 0).normalized * 5, ForceMode2D.Impulse);
        while(numRx ==0 || numRy == 0) 
        {
           numRx = Random.Range(-1, 2);
           numRy = Random.Range(-1, 2);
          rb.AddForce(new Vector3(numRx, numRy, 0).normalized * 5, ForceMode2D.Impulse);

        }
       
        
        
        
       

    }
  
}

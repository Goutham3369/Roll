using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
   
    public Text Scoretext;
    public Text WinText;
    private int Score;

    void Start()

    {
        rb = GetComponent<Rigidbody>();
        Score = 0;
        WinText.text = "";
 

    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);


        rb.AddForce(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {

            other.gameObject.SetActive(false);
            Score = Score + 1;
            SetCountText();

        }
    }
    void SetCountText()
    {
        Scoretext.text = "Score:" + Score.ToString();
        if(Score>=12)
        {
            WinText.text = "YOU WIN !";
        }
    }
}
    

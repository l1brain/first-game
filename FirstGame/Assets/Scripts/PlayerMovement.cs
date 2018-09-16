using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 5000f;
    public float sidewaysForce = 120f;
    void Update()
    {
        if (forwardForce < 7000)
            rb.AddForce(0, 1, forwardForce * Time.deltaTime);
        this.transform.Translate(Input.GetAxis("Horizontal"), 0, 0);
       
        if (rb.position.y < -1) // when fall out from platform
        {
            FindObjectOfType<GameManager>().endGame();
        }
    }

    //Debug.Log(KeyCode.Space.ToString());
    //string key = Input.inputString;
    //switch (key)
    //{
    //    //case "w":
    //    //    rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    //    //    break;
    //    case "a":
    //        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    //        break;
    //    //case "s":
    //    //    rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
    //    //    break;
    //    case "d":
    //        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    //        break;
    //        //case " ":
    //        //    rb.AddForce(0, forwardForce * Time.deltaTime, 0);
    //        //    break;


    //}

    // }

}



using UnityEngine;
using UnityEngine.SceneManagement;

public class car_movement : MonoBehaviour
{
    float speed = 0;
    public float max = 25;
    public float acc = 0.2f;
    public float deacc = 0.3f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))//left
        {
            if (speed != 0)
            {
                transform.Rotate(0, -speed*Time.deltaTime, 0);
                Debug.Log("Turning left.speed: "+speed);
            }
        }
       
        if (Input.GetKey(KeyCode.D))//right
        {
            if (speed != 0)
            {
                transform.Rotate(0, speed * Time.deltaTime, 0);
                Debug.Log("Turning right.speed: "+speed);
            }
        }
        
        if (Input.GetKey(KeyCode.W))//forward
        {
            if (speed < max)
            {
                speed += acc;
                Debug.Log("Accelerating forward. Speed: " + speed);
            } 
        }
       
        if (!Input.GetKey(KeyCode.W))//forward
        {
            if (speed > 0)
            {
                speed -= deacc;
                Debug.Log("deAccelerating forward. Speed: " + speed);
                if (speed < 0)
                {
                    speed = 0;
                }
            }
        }
      
        if (Input.GetKey(KeyCode.S))//back
        {
            if (speed < max)
            {
                speed -= acc;
                Debug.Log("Accelerating forward. Speed: " + speed);
            }
        }
       
        if (!Input.GetKey(KeyCode.S))//back
        {
            if (speed < 0)
            {
                speed += deacc;
                if (speed > 0)
                {
                    speed = 0;
                }
            }
        }
        transform.Translate(0, 0, speed * Time.deltaTime);

        if (transform.position.z > 1580)
        {
            Vector3 newposition = new Vector3(transform.position.x, transform.position.y, -1400);
            transform.position = newposition;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit to hui");
        if (collision.gameObject.tag == "traffic")
        {
            SceneManager.LoadScene("background");
            Debug.Log("tag wala bhi hai");
        }
        
        
        
    }






}
            
             

using UnityEngine;


public class traffic : MonoBehaviour
{
    public float traffic_speed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        traffic_speed = Random.Range(1f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*traffic_speed);
    }
}

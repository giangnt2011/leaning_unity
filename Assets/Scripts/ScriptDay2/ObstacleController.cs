using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("adf");
        if(collision !=null)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{

    [SerializeField] float mainThrust = 100;
    [SerializeField] float sideThrust = 100;
    Rigidbody rigidBody;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if(Input.GetKey(KeyCode.W)){
            rigidBody.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
            if(!audioSource.isPlaying){ 
                audioSource.Play();
            }
            
        } else {
            audioSource.Stop();
        }
        
    }


    void ProcessRotation() 
    {
        if(Input.GetKey(KeyCode.L)){
            transform.Rotate(Vector3.forward * Time.deltaTime * sideThrust);
        }
        else if(Input.GetKey(KeyCode.J)){
            transform.Rotate(Vector3.back * Time.deltaTime * sideThrust);
        }
    }

    void ApplyRotation() {
        Debug.Log("***");
    }
}

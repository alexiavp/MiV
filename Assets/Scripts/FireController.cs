using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    
    public GameObject firetolit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ControlFire(){
        
    }

    public void OnTriggerEnter(Collider other){
        if(other.CompareTag("nombre1")){
            firetolit = other.gameObject;
        }
    }
}

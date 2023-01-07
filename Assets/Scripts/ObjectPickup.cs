using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ObjectPickup : MonoBehaviour
{
    public GameObject item; 
    public GameObject playerRightHand;
    public GameObject dropOffPoint;
    //public Transform guide; 
    bool carrying;

    // Use this for initialization
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (carrying == false)
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                pickup();
                carrying = true;
            }
        }
        else if (carrying == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                drop();
                carrying = false;
            }
        }
    }
    void pickup()
    {
        //item.GetComponent<Rigidbody>().useGravity = false;
        //item.GetComponent<Rigidbody>().isKinematic = true;
        //item.transform.position = guide.transform.position;
        //item.transform.rotation = guide.transform.rotation;
        //item.transform.parent = tempParent.transform;

        if (item != null)
        {
            item.transform.SetParent(playerRightHand.transform);
            item.transform.localPosition = new Vector3(0.1f, 0f, 0f);
            item.transform.localRotation = Quaternion.Euler(-33.487f, -183.588f,-117.277f);
            item.transform.localScale = new Vector3(1f,1f,1f);
        }
        
    }
    void drop()
    {
        item.transform.parent = null;
        item.transform.localPosition = dropOffPoint.transform.position;
        item.transform.localRotation = Quaternion.Euler(4.839f, -74.655f,-90.886f);
        
    }

    public void OnTriggerEnter(Collider other){
        if(other.CompareTag("PickableObject")){
            item = other.gameObject;
        }
    }
}
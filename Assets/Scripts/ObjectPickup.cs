using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ObjectPickup : MonoBehaviour
{
    public GameObject item; 
    public GameObject playerRightHand;
    public GameObject dropOffPoint;
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
            if (Input.GetKeyDown(KeyCode.E) && item != null) 
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
       

        if (item != null)
        {
            item.GetComponent<Rigidbody>().useGravity = false;
			item.GetComponent<Rigidbody>().isKinematic = true;
			item.transform.SetParent(playerRightHand.transform);
            item.GetComponent<Rigidbody>().MovePosition(playerRightHand.transform.position);
            if(item.gameObject.CompareTag("ShortPickableObject"))
            {
                item.transform.localPosition = new Vector3(0.598f, -0.107f, 0.106f);
                item.transform.localRotation = Quaternion.Euler(-65.706f, -200.146f,-77.145f);
            } else if(item.gameObject.CompareTag("LongPickableObject"))
            {
                item.transform.localPosition = new Vector3(0.7824f, -0.1125f, 0.0809f);
                item.transform.localRotation = Quaternion.Euler(-145.818f, -8.091003f,9.244003f);
            }
            
            item.transform.localScale = new Vector3(1f,1f,1f);
        }
        
    }
    void drop()
    {
        item.transform.parent = null;
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        
    }

    public void OnTriggerEnter(Collider other){
        if(item == null){
				if(other.CompareTag("LongPickableObject")||other.CompareTag("ShortPickableObject")){
				item = other.gameObject;
			}
		}
		
    }
    public void OnTriggerExit(Collider other){
        item = null;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_ArmorRemover : MonoBehaviour
{


    [SerializeField]
    private GameObject m_goOtherGameObjectReference;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//If the player has left clicked
        {
            Vector3 mouse = Input.mousePosition;//Get the mouse Position
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);//Cast a ray to get where the mouse is pointing at
            RaycastHit hit;//Stores the position where the ray hit.
            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))//If the raycast doesnt hit a wall
            {
                Debug.Log(hit.collider.tag);
                if(hit.collider.gameObject.CompareTag("RemoveableItem"))
                {
                    int iIndex = 0;
                    iIndex = hit.collider.transform.GetSiblingIndex(); 

                    GameObject goArmorRef = m_goOtherGameObjectReference.transform.GetChild(iIndex+3).gameObject; //find object in list based on name on selected object
                    Renderer rArmorRenderer = goArmorRef.GetComponent<Renderer>(); 
                    
                    //change render of object from index to true and false

                    if(rArmorRenderer.enabled == true)
                    {
                        rArmorRenderer.enabled = false;
                    }
                    else
                    {
                        rArmorRenderer.enabled = true;
                    }


                }
            }
        }
    }
}

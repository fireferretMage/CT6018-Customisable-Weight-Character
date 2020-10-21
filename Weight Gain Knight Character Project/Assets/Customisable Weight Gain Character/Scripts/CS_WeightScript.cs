using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CS_WeightScript : MonoBehaviour
{
    [SerializeField]
    private Slider m_sSliderReference;
    [SerializeField]
    private List<GameObject> m_goObjectsWeight = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (GameObject goModel in m_goObjectsWeight)
        {

            SkinnedMeshRenderer smrMesh = goModel.GetComponent<SkinnedMeshRenderer>(); //grab objects blendhsape renderer 
            if (smrMesh != null) //if there is no blendshape, do not change belendshape value on object
            {

                smrMesh.SetBlendShapeWeight(0, m_sSliderReference.value); //find first blendshape on object

            }

        }
    }
}

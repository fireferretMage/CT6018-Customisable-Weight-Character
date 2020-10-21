using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CS_MaterialSlider : MonoBehaviour
{
    [SerializeField]
    private Slider m_sSliderRef;


    Renderer m_rRenderer;


    [SerializeField]
    private List<Material> m_lmMaterialList = new List<Material>();

    // Start is called before the first frame update
    void Start()
    {
        m_sSliderRef.maxValue = m_lmMaterialList.Count;
        m_sSliderRef.minValue = 0;
        m_rRenderer = gameObject.GetComponent<Renderer>();

        if(m_lmMaterialList.Count > 0)
        {
            m_rRenderer.material = m_lmMaterialList[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        m_rRenderer.material = m_lmMaterialList[(int)m_sSliderRef.value];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meow_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject MeowObject; // Inspector에서 Meow 오브젝트 연결

    public void ShowMeow()
    {
        MeowObject.SetActive(true);
    }

    public void HideMeow()
    {
        MeowObject.SetActive(false);
    }
}

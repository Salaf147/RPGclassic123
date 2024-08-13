using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tattext : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        Invoke("tatnhaydamage",1);
    }

    // Update is called once per frame
    private void tatnhaydamage() 
    { 
    gameObject.SetActive(false);
    }
}

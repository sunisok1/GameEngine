using System.Collections;
using System.Collections.Generic;
using Framework.Yggdrasil.Service;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Injector.SetInjector(new ServiceInjector());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

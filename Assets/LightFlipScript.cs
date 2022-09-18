using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlipScript : MonoBehaviour
{
    public GameObject cube;
    public Light defaultLight;
    public Light altLight;
    bool isFlipped;
    bool lightSwitch;
    int mode;

    // Start is called before the first frame update
    void Start()
    {
        lightSwitch = true;
        defaultLight.enabled = true;
        altLight.enabled = false;
        InvokeRepeating("Update", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Dot(cube.transform.up, Vector3.down) > 0.9){
            if (lightSwitch){
                defaultLight.enabled = true;
                altLight.enabled = false;
            }
            else {
                defaultLight.enabled = false;
                altLight.enabled = true;
            }
            isFlipped = true;
        }

        if ((Vector3.Dot(cube.transform.up, Vector3.down) < 0.2) && isFlipped == true){
            lightSwitch = !lightSwitch;
            isFlipped = false;
        }   
    }
}

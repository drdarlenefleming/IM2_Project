using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Thanks to https://wiki.unity3d.com/index.php?title=SkyboxBlended
public class blendSkies : MonoBehaviour
{
    public Material matty;
    Shader shader1;
    Shader shader2;

    //var initialization
    public float myValue = 0;
    public float MAX_VALUE = 1;
    // Start is called before the first frame update
    void Start()
    {
        shader1 = Shader.Find("Custom/blend");
        shader2 = Shader.Find("Skybox/Procedural");
        //rend.material.shader = Shader.Find("blend");
    }

    // Update is called once per frame
    void Update() {
      /*
      if (Input.GetKeyDown(KeyCode.Space)) {
        if (matty.shader == shader1) {
                Debug.Log("Shader 1");
                matty.shader = shader2;

            }
            else {
                Debug.Log("Shader 2");
                matty.shader = shader1;
            }
        }
        */

        if(Input.GetKey(KeyCode.Space))
            {
            Debug.Log("Space is pressed");

            //increment it by the time it passed since the last frame
            myValue += Time.deltaTime;
            }
        else
            {
            myValue -= Time.deltaTime;
            }

        //cap it to min and max, slightly more concise than 2 ifs
        myValue = Mathf.Clamp(myValue, 0, MAX_VALUE);

        //https://stackoverflow.com/questions/36386430/unity-3d-fade-from-one-skybox-to-another
        matty.SetFloat("_Blend", myValue);
        Debug.Log("Value "+myValue);
    }
}

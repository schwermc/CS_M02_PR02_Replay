using UnityEngine;

public class SunPosition : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Shader.SetGlobalVector("_SunDirection", transform.forward);
    }
}

using UnityEngine;

public class Script_Camera : MonoBehaviour
{
    public bool cameraPerturb;

    Quaternion fixedRotation;
    void Awake()
    {
        fixedRotation = transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!cameraPerturb) transform.rotation = fixedRotation;
    }
}

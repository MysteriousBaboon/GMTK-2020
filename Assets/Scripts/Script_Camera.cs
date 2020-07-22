using UnityEngine;

public class Script_Camera : MonoBehaviour
{
    public float panSpeed = 20f;
    public float panBorderThickness = 30f;
    [SerializeField]
    public Vector2 panLimitMin;
    public Vector2 panLimitMax;


    public float scrollSpeed = 200f;
    public float minZ = -20f;
    public float maxZ = -5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;


        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.z += scroll * scrollSpeed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, panLimitMin.x, panLimitMax.x);
        pos.z = Mathf.Clamp(pos.z, minZ, maxZ);
        pos.y = Mathf.Clamp(pos.y, panLimitMin.y, panLimitMax.y);

        transform.position = pos;
    }
}

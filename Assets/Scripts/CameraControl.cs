using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public Transform target;
    public float smoothing;
    public int range;


    private Vector3 offset;
    private Ray cameraRay;
    private RaycastHit cameraRayHit;
    private int targetableMask;
    private Transparency tran;

    void Start()
    {
        offset = transform.position - target.position;
        targetableMask = LayerMask.GetMask("Roof");
    }

    void Update()
    {
        cameraRay.origin = transform.position;
        cameraRay.direction = transform.forward;
        if (Physics.Raycast(cameraRay, out cameraRayHit, range, targetableMask))
        {
            if (cameraRayHit.transform.gameObject.layer == 8)
            {
                
                if (cameraRayHit.transform.gameObject.GetComponent<Transparency>() == null)
                {
                    Debug.Log(cameraRayHit.transform.gameObject.name);
                    cameraRayHit.transform.gameObject.AddComponent<Transparency>();
                }
                else
                {
                    cameraRayHit.transform.gameObject.GetComponent<Transparency>().ResetTimer();
                }
            }
        }
        
    }


    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}

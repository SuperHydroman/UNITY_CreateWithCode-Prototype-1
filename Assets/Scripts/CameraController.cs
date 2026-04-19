using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private List<Camera> _cameras = new List<Camera>();
    private List<Vector3> _offsets = new List<Vector3>();
    public GameObject player;
    public Vector3 cameraOffset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] camObjects = GameObject.FindGameObjectsWithTag("Camera");

        foreach (GameObject camObject in camObjects)
        {
            Camera cam = camObject.GetComponent<Camera>();
            
            if (cam == null) continue;
            
            _cameras.Add(cam);
            
            Vector3 offset = cam.transform.position - player.transform.position;
            _offsets.Add(offset);
            
            cam.enabled = false;
        }

        ActivateCamera(0);
    }

    // Update is called once per frame
    void LateUpdate()
    { 
        transform.position = player.transform.position + cameraOffset;
        transform.rotation = player.transform.rotation;
    }

    void ActivateCamera(int index)
    {
        Debug.Log($"Activating camera \"{_cameras[index].name}\"");
        for (int i = 0; i < _cameras.Count; i++)
        {
            bool active = (i == index);
            _cameras[i].enabled = active;
            
            var listener = _cameras[i].GetComponent<AudioListener>();
            
            if (listener == null) continue;
            
            listener.enabled = active;
        }
    }
}

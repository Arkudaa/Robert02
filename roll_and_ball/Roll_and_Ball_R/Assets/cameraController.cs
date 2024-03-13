using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour

{
    public GameObject player;
    private Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - player.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + distance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

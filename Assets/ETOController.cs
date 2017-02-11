using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETOController : MonoBehaviour {
    public Transform eto1;
    public Transform eto2;
    public float speed = 1.0F;
    public float angleSpeed = 0.3F;
    private float startTime;
    private float journeyLength;
    // Use this for initialization
    void Start () {
        startTime = Time.time;
        journeyLength = 1.0f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        eto1.position = Vector3.Lerp(eto1.position, Vector3.zero + transform.position, fracJourney);
        eto2.position = Vector3.Lerp(eto2.position, Vector3.zero + transform.position, fracJourney);

        if (Time.time > 3.0f)
        {
            var angles = transform.eulerAngles;
            angles.y += angleSpeed * Time.deltaTime;
            transform.eulerAngles = angles;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dash : MonoBehaviour {
    public float percentage = 0.25f;
    public Transform DashBar;
    public Transform DashIndicator;
    [SerializeField]
    private float currentAmount;
    [SerializeField] private float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            
        } else
        {
            currentAmount = 0;
        }
        var amtInterp = currentAmount / 200.0f + 0.25f;
        DashBar.GetComponent<Image>().fillAmount = amtInterp;
        var angles = DashIndicator.eulerAngles;
        angles.z = -amtInterp * 360.0f + 90.0f;
        DashIndicator.eulerAngles = angles;

        var angleY = Mathf.Sin(Time.time * 0.2f) * 25.0f;
        angles = transform.eulerAngles;
        angles.y = angleY;
        transform.eulerAngles = angles;

    }
}

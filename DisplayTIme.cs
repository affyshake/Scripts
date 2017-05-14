using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTIme : MonoBehaviour {

	public Text TimeObj;

	private int iTimeCountH;
	private int iTimeCountM;
	private int iTimeCountS;

	private float fCurrentTimer;

	// Use this for initialization
	void Start () {

		iTimeCountH = 0;
		iTimeCountM = 0;
		iTimeCountS = 0;

		fCurrentTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {

		fCurrentTimer += Time.deltaTime;

		iTimeCountH = Mathf.CeilToInt (fCurrentTimer) / 3600;
		iTimeCountM = (Mathf.CeilToInt (fCurrentTimer) - iTimeCountH *3600) / 60;
		iTimeCountS = Mathf.CeilToInt (fCurrentTimer) - iTimeCountH *3600 - iTimeCountM *60;

		TimeObj.text = string.Format ("{0:00}:{1:00}:{2:00}", iTimeCountH, iTimeCountM, iTimeCountS);
	}
}

using UnityEngine;
using System.Collections;

public class AudioControl_CreateObj : MonoBehaviour {

	[SerializeField] protected GameObject prefab;
	[SerializeField] [Range(0,100)] protected int createVolGate = 50;

	[Header("Audio Setting")]
	[SerializeField] [Range(0,3)] protected int band;
	[SerializeField] protected float maxInput = 33f;

	private float _createGate;
	private float gapTime = 0.3f;
	private float gapTimer = 0f;


	void Start () 
	{	
		_createGate = (float)createVolGate / 100;
	}

	void Update () 
	{
		gapTimer += Time.deltaTime;
		float vol = AudioAnalyzer.GetScaledOutput (band, maxInput, 0f, 1f);
		if (vol > _createGate && gapTimer > gapTime) {
			gapTimer = 0f;
			GameObject obj = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
		}
	}
}

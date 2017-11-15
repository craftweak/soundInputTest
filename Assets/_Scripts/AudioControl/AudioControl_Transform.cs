using UnityEngine;
using System.Collections;

public class AudioControl_Transform : MonoBehaviour {

//	[SerializeField] protected float highIntensity = 1;
//	[SerializeField] protected float lowIntensity = 0;
//	[SerializeField] protected Color highColor;
	//	[SerializeField] protected Color lowColor;
	[SerializeField] protected Transform targetObj;
	[Header("Position")]
	[SerializeField] protected bool EnablePositionContorl;
	[SerializeField] protected Transform lowPosition;
	[SerializeField] protected Transform highPosition;

	[Header("Scale")]
	[SerializeField] protected bool EnableScaleContorl;
	[SerializeField] protected Vector3 lowScale = new Vector3(0,0,0);
	[SerializeField] protected Vector3 highScale = new Vector3(1,1,1);

	[Header("Audio Setting")]
	[SerializeField] [Range(0,3)] protected int band;
	[SerializeField] protected float maxInput = 33f;

//	protected Renderer rend;
//	protected Material[] mats;

	private Light light;


	void Start () 
	{	
		if (!targetObj) {
			targetObj = transform;
		}
	}

	void Update () 
	{
//		for(int i = 0; i < mats.Length; i++)
//		{
//			mats[i].color = Color.Lerp(low, high, AudioAnalyzer.GetScaledOutput(band, maxInput, .1f, 1f));
//		}
		//		rend.materials = mats;
		if (EnablePositionContorl) {
			targetObj.position = Vector3.Lerp (lowPosition.position, highPosition.position, AudioAnalyzer.GetScaledOutput (band, maxInput, 0f, 1f));
		}
		if (EnableScaleContorl) {
			targetObj.localScale = Vector3.Lerp (lowScale, highScale, AudioAnalyzer.GetScaledOutput (band, maxInput, 0f, 1f));
		}
//		light.color = Color.Lerp(lowColor, highColor, AudioAnalyzer.GetScaledOutput(band, maxInput, .1f, 1f));
//		light.intensity = Mathf.Lerp (lowIntensity, highIntensity, AudioAnalyzer.GetScaledOutput (band, maxInput, .1f, 1f));
	}
}

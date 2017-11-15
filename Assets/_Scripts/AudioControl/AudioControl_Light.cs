using UnityEngine;
using System.Collections;

public class AudioControl_Light : MonoBehaviour {

	[SerializeField] protected float lowIntensity = 0;
	[SerializeField] protected float highIntensity = 1;
	[SerializeField] protected Color lowColor;
	[SerializeField] protected Color highColor;

	[Header("Audio Setting")]
	[SerializeField] [Range(0,3)] protected int band;
	[SerializeField] protected float maxInput = 33f;

//	protected Renderer rend;
//	protected Material[] mats;

	private Light light;


	void Start () 
	{	
		light = GetComponent<Light>();
//		mats = rend.materials;
	}

	void Update () 
	{
//		for(int i = 0; i < mats.Length; i++)
//		{
//			mats[i].color = Color.Lerp(low, high, AudioAnalyzer.GetScaledOutput(band, maxInput, .1f, 1f));
//		}
//		rend.materials = mats;

		light.color = Color.Lerp(lowColor, highColor, AudioAnalyzer.GetScaledOutput(band, maxInput, .1f, 1f));
		light.intensity = Mathf.Lerp (lowIntensity, highIntensity, AudioAnalyzer.GetScaledOutput (band, maxInput, .1f, 1f));
	}
}

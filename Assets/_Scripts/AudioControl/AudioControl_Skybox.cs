using UnityEngine;
using System.Collections;

public class AudioControl_Skybox : MonoBehaviour 
{
	#region vars
	[SerializeField]
	protected Color lowColor = Color.white;
	[SerializeField]
	protected Color highColor = Color.white;
	[SerializeField]
	protected float lowExposure = 0;
	[SerializeField]
	protected float highExposure = 1.3f;

	[Header("Audio Setting")]
	[SerializeField]
	[Range(0,3)]
	protected int band;
	[SerializeField]
	protected float maxInput = 33f;

	#endregion
	
	#region Unity methods
	
	void Update () 
	{
		Color tempColor = Color.Lerp(lowColor, highColor, AudioAnalyzer.GetScaledOutput(band, maxInput, 0f, 1f));
		RenderSettings.skybox.SetColor("_Tint",tempColor);
		float tempExposure = Mathf.Lerp(lowExposure, highExposure, AudioAnalyzer.GetScaledOutput(band, maxInput, 0f, 1f));
		RenderSettings.skybox.SetFloat("_Exposure", tempExposure);
	}
	#endregion
}

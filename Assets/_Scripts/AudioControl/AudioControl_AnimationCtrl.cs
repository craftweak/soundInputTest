using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioControl_AnimationCtrl : MonoBehaviour {

//	[SerializeField] protected Transform targetObj;
//	[Header("Position")]
//	[SerializeField] protected bool EnablePositionContorl;
//	[SerializeField] protected Transform lowPosition;
//	[SerializeField] protected Transform highPosition;
//
//	[Header("Scale")]
//	[SerializeField] protected bool EnableScaleContorl;
//	[SerializeField] protected Vector3 lowScale = new Vector3(0,0,0);
//	[SerializeField] protected Vector3 highScale = new Vector3(1,1,1);
	[SerializeField] protected Animator _animator;
	[SerializeField] [Range(0,3)] protected int band;
	[SerializeField] protected float maxInput = 33f;
	[SerializeField] private List<AnimationClip> clips;
	[SerializeField] private List<StateMachineBehaviour> sms;


	void Start () {
		clips = new List<AnimationClip>();
		_animator = GetComponent<Animator>();

//		sms = _animator.GetBehaviours();

		GetAllClips ();
		//		_animator.Play (clips [2].name, -1, 0f); 
//		_animator.Play ("MOB1_M1_Run_R_90", -1, 0f); 
		_animator.Play ("Jog", -1, 0f); 

	}

	void GetAllClips(){
		foreach (AnimationClip clip in _animator.runtimeAnimatorController.animationClips) {
			clips.Add (clip);

		}
	}

	void Update () 
	{
//		animator.runtimeAnimatorController.
//		anim.GetCurrentAnimatorClipInfo
//		anim.Play
	}
}

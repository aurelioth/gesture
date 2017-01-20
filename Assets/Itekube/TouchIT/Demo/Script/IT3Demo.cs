using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class IT3Demo : MonoBehaviour {

	public Text[] debug;

	public float vitesse = 10;
	public float vitesseRot = 10;
	public float vitesseScale = 100;

	public float scaleMax = 5;
	public float scaleMin = 0.5f;

	private GameObject pivot;
	private Transform saveParent;

	void Awake () {
		TouchIt4Unity.Pan += onPan;
		TouchIt4Unity.Pinch += onPinch;
		TouchIt4Unity.Twist += onTwist;
	}

	void onPan(PanGesture gesture)
	{
		debug[0].text = "Drag " + gesture.deltaMove.ToString();
		GetComponent<Rigidbody>().AddTorque(Vector3.right * -gesture.deltaMove.y * vitesse * Time.deltaTime * 10f);
		GetComponent<Rigidbody>().AddTorque(Vector3.up * -gesture.deltaMove.x * vitesse * Time.deltaTime * 10f);
	}

	void onPinch(PinchGesture gesture)
	{
		debug[1].text = "Pinch " + gesture.scale.ToString();
		float monScale = transform.localScale.x * ( (float)gesture.scale * vitesseScale);
		if (monScale>=scaleMax)
			monScale = scaleMax;
		else if (monScale<scaleMin)
			monScale = scaleMin;
		transform.localScale = new Vector3(monScale,monScale,monScale);
	}

	void onTwist(TwistGesture gesture)
	{
		debug[2].text = "Rotation " + gesture.deltaAngle.ToString();
		GetComponent<Rigidbody>().AddTorque(Vector3.forward * (float)gesture.deltaAngle * Time.deltaTime * vitesseRot * 1000f);
	}
}

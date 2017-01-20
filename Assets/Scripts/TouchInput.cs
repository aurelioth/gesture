using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour {
    public LayerMask touchInputMask;
    public List<GameObject> touchList = new List<GameObject>();
    public GameObject[] touchesOld;

	void Update () {
        if(Input.touchCount > 0) { }

	   	foreach (Touch touch in Input.touches){
            Camera camera = GetComponent<Camera>();
            Ray ray = camera.ScreenPointToRay(touch.position);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, touchInputMask))
            {
                GameObject recipent = hit.transform.gameObject;
                if (touch.phase == TouchPhase.Began) {
                    recipent.SendMessage("OnTouchDown",hit.point,SendMessageOptions.DontRequireReceiver);
                }
                if (touch.phase == TouchPhase.Began){                
                    recipent.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
                }
                if (touch.phase == TouchPhase.Began){
                    recipent.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
                }
                if (touch.phase == TouchPhase.Began){                
                    recipent.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
	}
}

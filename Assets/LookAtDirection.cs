using UnityEngine;
using System.Collections;

public class LookAtDirection : MonoBehaviour {
	[SerializeField]
	GameObject normalArrow;
	[SerializeField]
	GameObject tangentArrow;
	[SerializeField]
	GameObject binormalArrow;


	void Update () {

		if(Input.GetMouseButton(0)){
			RaycastHit hit;
			if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit)){
				//Normal
				Vector3 normal = hit.normal;
				//Tangent
				Vector3 tangent = Vector3.Cross(normal,Vector3.up);
				//Binormal
				Vector3 binormal = Vector3.Cross(tangent,normal);

				normalArrow.transform.rotation = Quaternion.LookRotation(normal);
				normalArrow.transform.position = hit.point;
				tangentArrow.transform.rotation = Quaternion.LookRotation(tangent);
				tangentArrow.transform.position = hit.point;
				binormalArrow.transform.rotation = Quaternion.LookRotation(binormal);
				binormalArrow.transform.position = hit.point;
			}
		}
	}
}

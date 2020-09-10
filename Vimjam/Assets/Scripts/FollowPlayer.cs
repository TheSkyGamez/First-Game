using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

	public Transform target;
	public float smoothing;
    public Vector2 Min;
    public Vector2 Max;


    private void LateUpdate()
    {

        if (transform.position != target.position)
        {
            Vector2 targetPos = new Vector2(target.position.x, target.position.y);

            targetPos.x = Mathf.Clamp(targetPos.x, Min.x, Max.x);
            targetPos.y = Mathf.Clamp(targetPos.y, Min.y, Max.y);


            transform.position = new Vector3(targetPos.x, targetPos.y, -20 * smoothing);
        }
        
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlate : MonoBehaviour
{
    Vector3 plateFirstLoc;
    Vector3 DeltaLocation;

    private void OnEnable()
    {
        plateFirstLoc = this.transform.position;//현재 위치 저장

    }
    private void FixedUpdate()
    {
        DeltaLocation = plateFirstLoc - this.transform.position;//각 프레임마다 위치의 변화량 계산
        plateFirstLoc = this.transform.position;
    }


    private void OnCollisionStay(UnityEngine.Collision collision)
    {
        //맞닿은 물체의 위치를 변화량만큼 이동 -> 발판과 같은 변화량을 지니게 됨
        collision.transform.position += new Vector3 (-DeltaLocation.x,-DeltaLocation.y, 0.0f);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlate : MonoBehaviour
{
    Vector3 plateFirstLoc;
    Vector3 DeltaLocation;

    private void OnEnable()
    {
        plateFirstLoc = this.transform.position;//���� ��ġ ����

    }
    private void FixedUpdate()
    {
        DeltaLocation = plateFirstLoc - this.transform.position;//�� �����Ӹ��� ��ġ�� ��ȭ�� ���
        plateFirstLoc = this.transform.position;
    }


    private void OnCollisionStay(UnityEngine.Collision collision)
    {
        //�´��� ��ü�� ��ġ�� ��ȭ����ŭ �̵� -> ���ǰ� ���� ��ȭ���� ���ϰ� ��
        collision.transform.position += new Vector3 (-DeltaLocation.x,-DeltaLocation.y, 0.0f);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody; //�̵��� ����� ������ٵ� ������Ʈ
    void Start()
    {
        //���ӿ�����Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = ���� ����*�̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        //3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);
        
    }
}

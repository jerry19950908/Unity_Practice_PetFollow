using UnityEngine;

public class PetFollow : MonoBehaviour
{
    [Header("跟蹤速度"), Range(0f, 50f)]
    public float speed = 1.5f;

    private Transform target;

    private void Start()
    {
        target = GameObject.Find("跟隨目標").transform;
    }

    private void LateUpdate()
    {
        Track();
    }

    private void Track()
    {
        Vector3 postarget = target.position;
        Vector3 pospet = transform.position;

      


        transform.position = Vector3.Lerp(pospet, postarget, 0.5f * Time.deltaTime * speed);

        

        transform.LookAt(postarget);

    }
}

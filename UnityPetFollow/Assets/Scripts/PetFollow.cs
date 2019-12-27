using UnityEngine;

public class PetFollow : MonoBehaviour
{
    [Header("跟蹤速度"), Range(0f, 50f)]
    public float speed = 1.5f;

    private Transform player;

    private void Start()
    {
        player = GameObject.Find("野蠻人").transform;
    }

    private void LateUpdate()
    {
        Track();
    }

    private void Track()
    {
        Vector3 posplayer = player.position;
        Vector3 pospet = transform.position;

        
        posplayer.z -= 5;

        transform.position = Vector3.Lerp(pospet, posplayer, 0.5f * Time.deltaTime * speed);

        transform.LookAt(posplayer);

    }
}

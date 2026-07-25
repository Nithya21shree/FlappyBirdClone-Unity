using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}

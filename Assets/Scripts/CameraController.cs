using UnityEngine;

namespace ShootEmUp
{
    public class CameraController : MonoBehaviour 
    {
        [SerializeField] Transform player;
        [SerializeField] float speed = 2f;

        private void Start() => transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);

        private void LateUpdate()
        {
            // Move the camera along the battlefield at a constant speed
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
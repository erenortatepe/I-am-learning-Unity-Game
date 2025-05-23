using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player _player;
    public float speed;

    public void StartEnemy(Player player)
    {
        _player = player;
    }

    private void Update()
    {
        if (_player.isAppleCollected)
        {
            var direction = (_player.transform.position - transform.position).normalized;
            transform.position += direction * Time.deltaTime * speed;
        }
    }

    public void Stop()
    {
        speed = 0;
    }
}

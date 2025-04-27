using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject door;

    public void RestartLevel()
    {
        DeactivateDoor();
        RandomizeDoorPosition();
    }

    private void RandomizeDoorPosition()
    {
        var pos = door.transform.position;
        pos.x = Random.Range(-2.5f, 2f);
        door.transform.position = pos;
    }

    private void DeactivateDoor()
    {
        door.SetActive(false);
    }

    public void AppleCollected()
    {
        door.SetActive(true);
    }
}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject smallerTrigger;
    public GameObject doorSwitch;
    public GameObject door;
    private Vector2 defaultDoorPosition;

    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        defaultDoorPosition = door.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ResetGame()
    {
        Debug.Log("ResetGame message received by GameManager");
        if (smallerTrigger != null)
        {
            smallerTrigger.SetActive(true);
        }

        if (player != null)
        {
            player.gameObject.GetComponent<Movement>().ResetPlayerTransform();
        }
        if (doorSwitch != null)
        {
            doorSwitch.SetActive(true);
        }
        if (door != null)
        {
            door.transform.position = defaultDoorPosition;
        }
    }
}

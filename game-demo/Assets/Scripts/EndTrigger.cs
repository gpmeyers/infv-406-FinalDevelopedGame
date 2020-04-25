using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<GameManagerObj>().ExitPlatform();
    }
}

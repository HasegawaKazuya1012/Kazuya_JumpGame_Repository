using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameSceneController : MonoBehaviour
{
    public Text startMessage;

    void Start()
    {
        StartCoroutine(ShowStartMessage());
    }

    IEnumerator ShowStartMessage()
    {
        startMessage.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        startMessage.gameObject.SetActive(false);
    }
}

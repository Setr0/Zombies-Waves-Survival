using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveText : MonoBehaviour
{
    RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void OnEnable()
    {
        StartCoroutine(DisableDelay());
    }

    IEnumerator DisableDelay()
    {
        yield return new WaitForSeconds(1.5f);

        rectTransform.localScale = new Vector3(0, 0, 1);

        gameObject.SetActive(false);
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EffectIndicator : MonoBehaviour
{
    public RectTransform image;
    private Coroutine coroutine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SkillOnEffect(float durationTime)
    {
        if (coroutine != null)
        {
            StopCoroutine(CoolTime(durationTime));
        }

        coroutine = StartCoroutine(CoolTime(durationTime));
    }

    private IEnumerator CoolTime(float durationtime)
    {
        float startScale = 0f;
        float a = startScale;

        while (a <= 1)
        {
            a += (1/durationtime) * Time.deltaTime;
            image.localScale = new Vector3(1,a,1);
            yield return null;
        }
        this.gameObject.SetActive(false);
    }
}
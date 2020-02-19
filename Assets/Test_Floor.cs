using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Floor : MonoBehaviour
{
    public Button BTN;
    public Sprite SPR;
    public Sprite X;
    private void Start()
    {
        if (!gameObject.TryGetComponent(out BTN))
            BTN = gameObject.AddComponent<Button>();
        BTN.onClick.AddListener(AnotherChange);
        //GetComponent<SpriteRenderer>().sprite = SPR;
        ChangeSprite();
    }
    public void ChangeSprite()
    {
        //GetComponent<SpriteRenderer>().sprite = Holder.Instance.Creature;
        BTN.onClick.RemoveAllListeners();
        GetComponent<Image>().sprite = SPR;
        BTN.onClick.AddListener(AnotherChange);
    }
    public void AnotherChange()
    {
        BTN.onClick.RemoveAllListeners();
        GetComponent<Image>().sprite = X;
        BTN.onClick.AddListener(ChangeSprite);
    }
}

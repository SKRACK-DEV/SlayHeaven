using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using Yarn.Unity;

public class ScenaController : MonoBehaviour
{
    [SerializeField] private DialogueRunner dialogueRunner;
    [SerializeField] private Image background;
    [SerializeField] private Image slotLeft;
    [SerializeField] private Image slotCentre;
    [SerializeField] private Image slotRight;

    private Dictionary<string, Image> slots;
    private Dictionary<string, Image> onStage = new Dictionary<string, Image>();

    private void Awake()
    {
        slots = new Dictionary<string, Image>
        {
            { "left", slotLeft },
            { "right", slotRight },
            { "centre", slotCentre }

        };

        dialogueRunner.AddCommandHandler<string>("bg", SetBackground);
        dialogueRunner.AddCommandHandler<string, string, string>("show", ShowCharacter);
        dialogueRunner.AddCommandHandler<string>("hide", HideCharacter);

    }

    private void SetBackground(string name)
    {
        Debug.Log("SetBackground: " + name);
        Sprite sprite = Resources.Load<Sprite>("Bg/bg_" + name);
        if (sprite == null) return;
        
        background.sprite = sprite;
    }

    private void ShowCharacter(string character, string expression, string position)
    {
        if (!slots.ContainsKey(position)) return;


        Sprite sprite = Resources.Load<Sprite>("Characters/" + character + "_" + expression);
        if (sprite == null) return;


        Image slot = slots[position];
        slot.sprite = sprite;
        slot.gameObject.SetActive(true);
        onStage[character] = slot;
    }

    private void HideCharacter(string character)
    {
        if (onStage.TryGetValue(character, out Image slot))
        {
            slot.gameObject.SetActive(false);
            onStage.Remove(character);
        }
    }



}

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
            { "right", slotCentre },
            { "centre", slotCentre }

        };

        dialogueRunner.AddCommandHandler<string>("bg" SetBackground);
        dialogueRunner.AddCommandHandler<string, string, string>("show" ShowCharacter);
        dialogueRunner.AddCommandHandler<string>("hide" HideCharacter);

    }

    private void SetBackground(string name)
    {
        Sprite sprite = Characters
    }



}

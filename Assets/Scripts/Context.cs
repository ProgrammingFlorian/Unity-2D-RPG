using Cinemachine;
using System.Collections.Generic;
using UnityEngine;

public class Context : MonoBehaviour
{
    public static Context instance;

    public Transform canvas;

    public UIManager uiManager;
    public PlayerController player;
    public PlayerStats playerStats;
    public Inventory inventory;
    public EventManager eventManager;
    public QuestManager questManager;
    public DialogueManager dialogueManager;
    public StatWindow statWindow;

    public static InputMaster controls;

    private CinemachineVirtualCamera vcam;
    private CinemachineBasicMultiChannelPerlin vcamNoise;
    private float vcamShakeAmplitude = 1f;
    private float vcamShakeFrequency = 1f;
    private float vcamShakeTime = 0f;

    private static List<int> contextClueQueue = new List<int>();

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Debug.LogError("There are two instances");
        }
        eventManager = new EventManager();
        playerStats = new PlayerStats(eventManager);
        if (uiManager == null || player == null || playerStats == null || inventory == null || eventManager == null || dialogueManager == null || statWindow == null || questManager == null) {
            Debug.LogError("Context not set up");
            enabled = false;
        }

        controls = new InputMaster();
    }

    private void Update() {
        if (vcamNoise != null) {
            if (vcamShakeTime > 0f) {
                vcamShakeTime -= Time.deltaTime;
                vcamNoise.m_AmplitudeGain = vcamShakeAmplitude;
                vcamNoise.m_FrequencyGain = vcamShakeFrequency;
            } else {
                vcamNoise.m_AmplitudeGain = 0f;
            }
        }
    }

    public static Transform GetCanvas() {
        return instance.canvas;
    }

    public static UIManager GetUiManager() {
        return instance.uiManager;
    }

    public static PlayerController GetPlayer() {
        return instance.player;
    }

    public static PlayerStats GetPlayerStats() {
        return instance.playerStats;
    }

    public static Inventory GetInventory() {
        return instance.inventory;
    }

    public static EventManager GetEventManager() {
        return instance.eventManager;
    }

    public static QuestManager GetQuestManager() {
        return instance.questManager;
    }

    public static DialogueManager GetDialogueManager() {
        return instance.dialogueManager;
    }

    public static void AddContext(GameObject obj) {
        if (contextClueQueue.IndexOf(obj.GetInstanceID()) == -1) {
            contextClueQueue.Add(obj.GetInstanceID());
        }
        UpdateContext();
    }

    public static void RemoveContext(GameObject obj) {
        contextClueQueue.Remove(obj.GetInstanceID());
        UpdateContext();
    }

    private static void UpdateContext() {
        instance.player.SetContextClueActive(contextClueQueue.Count > 0);
    }

    public static void SetVirtualCamera(CinemachineVirtualCamera vcam) {
        instance.vcam = vcam;
        instance.vcamNoise = vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        instance.vcam.m_Follow = instance.player.transform;
    }

    public static CinemachineVirtualCamera GetVirtualCamera() {
        return instance.vcam;
    }

    public static void ShakeCamera(float amplitude, float frequency, float time) {
        instance.vcamShakeAmplitude = amplitude;
        instance.vcamShakeFrequency = frequency;
        instance.vcamShakeTime = time;
    }

}

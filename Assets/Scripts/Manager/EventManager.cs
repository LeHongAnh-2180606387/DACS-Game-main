using System;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;
using DialogueEditor;
public class EventsManager : MonoBehaviour
{
    // Khai báo sự kiện tĩnh
    public static event Action EventSceneChanger;
    public static event Action EventUiManager;
    public static event Action<CinemachineVirtualCamera> EventCameraChanger;
    public static event Action<NPCConversation> EventStartConversation;
    public UnityEvent Event;

    // Phương thức để kích hoạt sự kiện
    public static void SceneChanger()
    {
        // if (EventDialogue != null)
        // {
        //     EventDialogue();
        // }
        EventSceneChanger?.Invoke();
    }
    public static void UiManager()
    {
        // if (EventDialogue != null)
        // {
        //     EventDialogue();
        // }
        EventUiManager?.Invoke();
    }
    // Phương thức để kích hoạt sự kiện thay đổi camera
    public static void CameraChanger(CinemachineVirtualCamera newCinemachineVirtualCamera)
    {
        EventCameraChanger?.Invoke(newCinemachineVirtualCamera);
    }
    // Phương thức để kích hoạt sự kiện bắt đầu cuộc hội thoại
    public static void StartConversationDialogue(NPCConversation newConversation)
    {
        EventStartConversation?.Invoke(newConversation);
    }

}
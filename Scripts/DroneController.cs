using DilmerGames.Core.Singletons;
using UnityEngine;

public class DroneController : Singleton<DroneController>
{
    [SerializeField]
    private DroneControllerType droneControllerType = DroneControllerType.Standalone;

    [SerializeField]
    private OVRHand leftHand;

    [SerializeField]
    private OVRHand rightHand;

    private OVRSkeleton leftHandSkeleton;

    private OVRSkeleton rightHandSkeleton;

    public OVRHand LeftHand
    {
        get
        {
            return leftHand;
        }
    }

    public OVRHand RightHand
    {
        get
        {
            return rightHand;
        }
    }

    public OVRSkeleton LeftHandSkeleton
    {
        get
        {
            return leftHandSkeleton;
        }
    }

    public OVRSkeleton RightHandSkeleton
    {
        get
        {
            return rightHandSkeleton;
        }
    }

    private int forwardDirection = 0;
    private int backwardDirection = 0;
    private int leftDirection = 0;
    private int rightDirection = 0;
    private int upDirection = 0;
    private int downDirection = 0;
    private int rotateRightDirection = 0;
    private int rotateLeftDirection = 0;


    private bool fingerLeftIndexPinch;
    private bool fingerLeftMiddlePinch;

    private bool fingerRightIndexPinch;
    private bool fingerRightMiddlePinch;
    private bool fingerRightRingPinch;

    private void Awake()
    {
        leftHandSkeleton = leftHand.GetComponent<OVRSkeleton>();
        rightHandSkeleton = rightHand.GetComponent<OVRSkeleton>();

        Logger.Instance.LogInfo($"{droneControllerType} enabled");
    }

    void Update()
    {
        // true for standalone since we don't support digital joyticks yet
        if (droneControllerType == DroneControllerType.Standalone) return;

        #region VR Controller Actions
        if (droneControllerType == DroneControllerType.Controllers)
        {
            DroneActionMapping.Instance.ControllerCoreActionInputBindings[DroneAction.Connect]();
            DroneActionMapping.Instance.ControllerCoreActionInputBindings[DroneAction.InitializeSDK]();

            if (!DroneClient.Instance.SDKInitialized) return;

            DroneActionMapping.Instance.ControllerCoreActionInputBindings[DroneAction.TakeOff]();
            DroneActionMapping.Instance.ControllerCoreActionInputBindings[DroneAction.Landing]();
            DroneActionMapping.Instance.ControllerCoreActionInputBindings[DroneAction.Emergency]();

            DroneActionMapping.Instance.ControllersMovementInputBindings[DroneAction.Forward](ref forwardDirection);
            DroneActionMapping.Instance.ControllersMovementInputBindings[DroneAction.Backward](ref backwardDirection);
            DroneActionMapping.Instance.ControllersMovementInputBindings[DroneAction.Left](ref leftDirection);
            DroneActionMapping.Instance.ControllersMovementInputBindings[DroneAction.Right](ref rightDirection);
            DroneActionMapping.Instance.ControllersMovementInputBindings[DroneAction.Up](ref upDirection);
            DroneActionMapping.Instance.ControllersMovementInputBindings[DroneAction.Down](ref downDirection);
            DroneActionMapping.Instance.ControllersMovementInputBindings[DroneAction.RotateRight](ref rotateRightDirection);
            DroneActionMapping.Instance.ControllersMovementInputBindings[DroneAction.RotateLeft](ref rotateLeftDirection);
        }
        else if (droneControllerType == DroneControllerType.Hands)
        {
            DroneActionMapping.Instance.HandsCoreActionInputBindings[DroneAction.Connect](ref fingerLeftIndexPinch);
            DroneActionMapping.Instance.HandsCoreActionInputBindings[DroneAction.InitializeSDK](ref fingerLeftMiddlePinch);

            if (!DroneClient.Instance.SDKInitialized) return;

            DroneActionMapping.Instance.HandsCoreActionInputBindings[DroneAction.TakeOff](ref fingerRightIndexPinch);
            DroneActionMapping.Instance.HandsCoreActionInputBindings[DroneAction.Landing](ref fingerRightMiddlePinch);
            DroneActionMapping.Instance.HandsCoreActionInputBindings[DroneAction.Emergency](ref fingerRightRingPinch);
        }
        #endregion
    }
}

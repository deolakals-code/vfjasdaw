// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingGameFishController : MonoBehaviour // TypeDefIndex: 4358
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor fishParentAnchor; // 0x20
	[SerializeField]
	private float fishHitBoxSize; // 0x28
	[SerializeField]
	private float sizeCorrecttionValue; // 0x2C
	private UIFishingGameController mainController; // 0x30
	private FishStatusData hitFishStatus; // 0x38
	private UISprite fishIcon; // 0x40
	private int posPercent; // 0x48
	private bool isRightMove; // 0x4C
	private int behavioralPatternIndex; // 0x50
	private float decreaseValue; // 0x54
	private float transitionTimeLimit; // 0x58
	private float movePower; // 0x5C
	private float minMovePower; // 0x60
	private bool isStrengthOut; // 0x64
	private bool isNextReturn; // 0x65
	private bool isStop; // 0x66
	private bool isFallingMove; // 0x67
	private const float fallingMoveDuration = 0.75;
	private bool isEllipticCurveShift; // 0x68
	private Vector3 startPoint; // 0x6C
	private Vector3 endPoint; // 0x78
	private const float ellipticCurveDuration = 0.5;
	private float height; // 0x84
	private float elapsedTime; // 0x88
	private const float initialTweenHeight = -25;
	private const float finalTweenHeight = 500;
	private const float initialTweenDuration = 0.1;
	private const float finalTweenDuration = 0.25;

	// Properties
	public int PosPercent { get; }
	public Vector2 Position { get; }
	public FishStatusData HitFishStatus { get; }
	public float RadiusSize { get; }
	public bool IsFallingMove { get; }

	// Methods

	// RVA: 0x24DABB0 Offset: 0x24D6BB0 VA: 0x24DABB0
	public int get_PosPercent() { }

	// RVA: 0x24DABB8 Offset: 0x24D6BB8 VA: 0x24DABB8
	public Vector2 get_Position() { }

	// RVA: 0x24DABE4 Offset: 0x24D6BE4 VA: 0x24DABE4
	public FishStatusData get_HitFishStatus() { }

	// RVA: 0x24DABEC Offset: 0x24D6BEC VA: 0x24DABEC
	public float get_RadiusSize() { }

	// RVA: 0x24DABFC Offset: 0x24D6BFC VA: 0x24DABFC
	public bool get_IsFallingMove() { }

	// RVA: 0x24DAC04 Offset: 0x24D6C04 VA: 0x24DAC04
	private void Update() { }

	// RVA: 0x24DB174 Offset: 0x24D7174 VA: 0x24DB174
	private void ChangeMoveSpeed() { }

	// RVA: 0x24DAF84 Offset: 0x24D6F84 VA: 0x24DAF84
	private void FallingMovement() { }

	// RVA: 0x24DB060 Offset: 0x24D7060 VA: 0x24DB060
	private void EllipticCurveMovement() { }

	// RVA: 0x24DB28C Offset: 0x24D728C VA: 0x24DB28C
	public void Initialize(UIFishingGameController fishingGameController) { }

	// RVA: 0x24DB49C Offset: 0x24D749C VA: 0x24DB49C
	public Vector3 ChangeRandomPos() { }

	[IteratorStateMachine(typeof(UIFishingGameFishController.<PullInFishAnimation>d__44))]
	// RVA: 0x24DB524 Offset: 0x24D7524 VA: 0x24DB524
	public IEnumerator PullInFishAnimation(bool isFinished, Action callback) { }

	// RVA: 0x24DB5E0 Offset: 0x24D75E0 VA: 0x24DB5E0
	public void .ctor() { }
}

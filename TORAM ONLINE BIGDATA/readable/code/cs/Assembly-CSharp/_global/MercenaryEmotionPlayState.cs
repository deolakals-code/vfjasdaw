// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryEmotionPlayState : MercenaryAIStateBase // TypeDefIndex: 623
{
	// Fields
	[CompilerGenerated]
	private EmotionPlayer <EmotionPlayer>k__BackingField; // 0x30
	[CompilerGenerated]
	private EmotionPlayer.EmotionType <EmotionType>k__BackingField; // 0x38
	[CompilerGenerated]
	private CharacterMove <CharacterMove>k__BackingField; // 0x40
	public Dictionary<EmotionPlayer.EmotionType, EmotionPlayer.EmotionType> Convert; // 0x48
	[CompilerGenerated]
	private int <MemberNum>k__BackingField; // 0x50

	// Properties
	private EmotionPlayer EmotionPlayer { get; set; }
	private EmotionPlayer.EmotionType EmotionType { get; set; }
	private CharacterMove CharacterMove { get; set; }
	private int MemberNum { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19E2174 Offset: 0x19DE174 VA: 0x19E2174
	private EmotionPlayer get_EmotionPlayer() { }

	[CompilerGenerated]
	// RVA: 0x19E217C Offset: 0x19DE17C VA: 0x19E217C
	public void set_EmotionPlayer(EmotionPlayer value) { }

	[CompilerGenerated]
	// RVA: 0x19E2184 Offset: 0x19DE184 VA: 0x19E2184
	private EmotionPlayer.EmotionType get_EmotionType() { }

	[CompilerGenerated]
	// RVA: 0x19E218C Offset: 0x19DE18C VA: 0x19E218C
	public void set_EmotionType(EmotionPlayer.EmotionType value) { }

	[CompilerGenerated]
	// RVA: 0x19E2194 Offset: 0x19DE194 VA: 0x19E2194
	private CharacterMove get_CharacterMove() { }

	[CompilerGenerated]
	// RVA: 0x19E219C Offset: 0x19DE19C VA: 0x19E219C
	public void set_CharacterMove(CharacterMove value) { }

	[CompilerGenerated]
	// RVA: 0x19E21A4 Offset: 0x19DE1A4 VA: 0x19E21A4
	private int get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x19E21AC Offset: 0x19DE1AC VA: 0x19E21AC
	public void set_MemberNum(int value) { }

	// RVA: 0x19E21B4 Offset: 0x19DE1B4 VA: 0x19E21B4 Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x19E21B8 Offset: 0x19DE1B8 VA: 0x19E21B8 Slot: 14
	public override void Dispose() { }

	// RVA: 0x19E21BC Offset: 0x19DE1BC VA: 0x19E21BC Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x19E21C0 Offset: 0x19DE1C0 VA: 0x19E21C0 Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(MercenaryEmotionPlayState.<GetState>d__21))]
	// RVA: 0x19E21C4 Offset: 0x19DE1C4 VA: 0x19E21C4 Slot: 17
	protected override IEnumerator GetState() { }

	// RVA: 0x19E2258 Offset: 0x19DE258 VA: 0x19E2258
	public void .ctor() { }
}

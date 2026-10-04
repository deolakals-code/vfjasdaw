// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GUIPetDataRenderer : GUIDebugParamRenderer // TypeDefIndex: 1939
{
	// Fields
	private PlayerDataManager pdata; // 0x50
	private PetDataManager petData; // 0x58
	private PetMember pet; // 0x60
	private long summonPet; // 0x68

	// Methods

	// RVA: 0x2109BCC Offset: 0x2105BCC VA: 0x2109BCC
	private void Awake() { }

	// RVA: 0x2109C50 Offset: 0x2105C50 VA: 0x2109C50
	private void Start() { }

	// RVA: 0x210A3C0 Offset: 0x21063C0 VA: 0x210A3C0
	private void OnDestroy() { }

	// RVA: 0x210A3C4 Offset: 0x21063C4 VA: 0x210A3C4
	private void ItemToPet(float height) { }

	// RVA: 0x210A900 Offset: 0x2106900 VA: 0x210A900
	private void PetList(float height) { }

	// RVA: 0x210ABEC Offset: 0x2106BEC VA: 0x210ABEC
	private void PetSummonList(float height) { }

	[IteratorStateMachine(typeof(GUIPetDataRenderer.<showPetData>d__10))]
	// RVA: 0x210A17C Offset: 0x210617C VA: 0x210A17C
	private IEnumerable<string> showPetData() { }

	[IteratorStateMachine(typeof(GUIPetDataRenderer.<showPetRaceData>d__11))]
	// RVA: 0x210A34C Offset: 0x210634C VA: 0x210A34C
	private IEnumerable<string> showPetRaceData() { }

	[IteratorStateMachine(typeof(GUIPetDataRenderer.<showPetAIData>d__12))]
	// RVA: 0x210A1F0 Offset: 0x21061F0 VA: 0x210A1F0
	private IEnumerable<string> showPetAIData() { }

	[IteratorStateMachine(typeof(GUIPetDataRenderer.<showPetBonusLimitData>d__13))]
	// RVA: 0x210A2D8 Offset: 0x21062D8 VA: 0x210A2D8
	private IEnumerable<string> showPetBonusLimitData() { }

	[IteratorStateMachine(typeof(GUIPetDataRenderer.<showPetBonusData>d__14))]
	// RVA: 0x210A264 Offset: 0x2106264 VA: 0x210A264
	private IEnumerable<string> showPetBonusData() { }

	// RVA: 0x210AED8 Offset: 0x2106ED8 VA: 0x210AED8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x210AF2C Offset: 0x2106F2C VA: 0x210AF2C
	private void <Start>b__5_0(Game x, GetPetListResponse y) { }

	[CompilerGenerated]
	// RVA: 0x210AF58 Offset: 0x2106F58 VA: 0x210AF58
	private void <Start>b__5_3(float x) { }
}

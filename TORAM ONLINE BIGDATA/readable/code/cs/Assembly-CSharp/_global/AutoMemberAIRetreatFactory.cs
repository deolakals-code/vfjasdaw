// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class AutoMemberAIRetreatFactory // TypeDefIndex: 398
{
	// Fields
	private static Dictionary<AutoMemberAIRetreatFactory.RetreatDirectionType, float> retreatDirection; // 0x0
	private static Dictionary<AutoMemberAIRetreatFactory.PreparationRetreatElememt, Func<AutoMemberAIRetreat.PreparationRetreat, bool>> preparationRetreatType; // 0x8
	private static List<ChainMethod<AutoMemberAIRetreat.PreparationRetreat>> preparationRetreatset; // 0x10
	private static Dictionary<AutoMemberAIRetreatFactory.AfterRetreatType, Action<AutoMemberAIRetreat.AfterRetreat>> afterRetreat; // 0x18
	private static readonly Dictionary<AIPersonalityType, AutoMemberAIRetreatFactory.TypeSet> typeSet; // 0x20
	private static readonly Dictionary<PetPersonalityType, AutoMemberAIRetreatFactory.TypeSet> petTypeSet; // 0x28

	// Methods

	// RVA: 0x255E514 Offset: 0x255A514 VA: 0x255E514
	private static void .cctor() { }

	// RVA: 0x256043C Offset: 0x255C43C VA: 0x256043C
	public static AutoMemberAIRetreat Create(AIPersonalityType type) { }

	// RVA: 0x256066C Offset: 0x255C66C VA: 0x256066C
	public static AutoMemberAIRetreat Create(PetPersonalityType type) { }

	// RVA: 0x2560824 Offset: 0x255C824 VA: 0x2560824
	public static AutoMemberAIRetreat Create() { }
}

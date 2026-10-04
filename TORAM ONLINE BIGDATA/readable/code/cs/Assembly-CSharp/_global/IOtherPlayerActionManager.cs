// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IOtherPlayerActionManager // TypeDefIndex: 1217
{
	// Properties
	public abstract int MainWeapon { get; }
	public abstract int SubWeapon { get; }
	public abstract ArchetypeUid ArchetypeUid { get; }
	public abstract Transform ActorTransform { get; }
	public abstract CharacterActionManagerBase ActionManager { get; }
	public abstract bool IsPartyMember { get; }
	public abstract EmotionPlayer EmotionPlayer { get; }
	public abstract BufferEffectManager BufferEffectManager { get; }
	public abstract byte EmotionType { get; }
	public abstract bool IsActDead { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_MainWeapon();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_SubWeapon();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ArchetypeUid get_ArchetypeUid();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Transform get_ActorTransform();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract CharacterActionManagerBase get_ActionManager();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsPartyMember();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract EmotionPlayer get_EmotionPlayer();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BufferEffectManager get_BufferEffectManager();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract byte get_EmotionType();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsActDead();
}

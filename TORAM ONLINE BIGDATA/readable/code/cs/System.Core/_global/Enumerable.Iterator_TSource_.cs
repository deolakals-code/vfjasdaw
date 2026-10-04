// Assembly: System.Core.dll
// Namespace: 
private abstract class Enumerable.Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 15183
{
	// Fields
	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	// Properties
	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7757C Offset: 0x2A7357C VA: 0x2A7757C
	|-Enumerable.Iterator<KeyValuePair<byte, BlackKnightCristaProperty>>..ctor
	|
	|-RVA: 0x2A7768C Offset: 0x2A7368C VA: 0x2A7768C
	|-Enumerable.Iterator<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2A777A0 Offset: 0x2A737A0 VA: 0x2A777A0
	|-Enumerable.Iterator<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2A778BC Offset: 0x2A738BC VA: 0x2A778BC
	|-Enumerable.Iterator<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2A779D0 Offset: 0x2A739D0 VA: 0x2A779D0
	|-Enumerable.Iterator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2A77AEC Offset: 0x2A73AEC VA: 0x2A77AEC
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, EnhanceProperties2>>..ctor
	|
	|-RVA: 0x2A77C30 Offset: 0x2A73C30 VA: 0x2A77C30
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2A77D44 Offset: 0x2A73D44 VA: 0x2A77D44
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2A77E60 Offset: 0x2A73E60 VA: 0x2A77E60
	|-Enumerable.Iterator<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2A77F7C Offset: 0x2A73F7C VA: 0x2A77F7C
	|-Enumerable.Iterator<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x2A78098 Offset: 0x2A74098 VA: 0x2A78098
	|-Enumerable.Iterator<Nullable<UIMobPropertyLabel.IconValue>>..ctor
	|
	|-RVA: 0x2A781C8 Offset: 0x2A741C8 VA: 0x2A781C8
	|-Enumerable.Iterator<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2A782DC Offset: 0x2A742DC VA: 0x2A782DC
	|-Enumerable.Iterator<bool>..ctor
	|
	|-RVA: 0x2A783F0 Offset: 0x2A743F0 VA: 0x2A783F0
	|-Enumerable.Iterator<byte>..ctor
	|
	|-RVA: 0x2A78504 Offset: 0x2A74504 VA: 0x2A78504
	|-Enumerable.Iterator<short>..ctor
	|
	|-RVA: 0x2A78618 Offset: 0x2A74618 VA: 0x2A78618
	|-Enumerable.Iterator<int>..ctor
	|
	|-RVA: 0x2A78728 Offset: 0x2A74728 VA: 0x2A78728
	|-Enumerable.Iterator<Int32Enum>..ctor
	|
	|-RVA: 0x2A78838 Offset: 0x2A74838 VA: 0x2A78838
	|-Enumerable.Iterator<long>..ctor
	|
	|-RVA: 0x2A7894C Offset: 0x2A7494C VA: 0x2A7894C
	|-Enumerable.Iterator<MobActionTargetData>..ctor
	|
	|-RVA: 0x2A78A80 Offset: 0x2A74A80 VA: 0x2A78A80
	|-Enumerable.Iterator<object>..ctor
	|
	|-RVA: 0x2A78B74 Offset: 0x2A74B74 VA: 0x2A78B74
	|-Enumerable.Iterator<float>..ctor
	|
	|-RVA: 0x2A78C84 Offset: 0x2A74C84 VA: 0x2A78C84
	|-Enumerable.Iterator<SkillIdData>..ctor
	|
	|-RVA: 0x2A78D98 Offset: 0x2A74D98 VA: 0x2A78D98
	|-Enumerable.Iterator<TimeSpan>..ctor
	|
	|-RVA: 0x2A78EAC Offset: 0x2A74EAC VA: 0x2A78EAC
	|-Enumerable.Iterator<Vector3>..ctor
	|
	|-RVA: 0x2A78FD8 Offset: 0x2A74FD8 VA: 0x2A78FD8
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2A792C8 Offset: 0x2A752C8 VA: 0x2A792C8
	|-Enumerable.Iterator<HouseRecipeManager.RecipeData>..ctor
	|
	|-RVA: 0x2A7940C Offset: 0x2A7540C VA: 0x2A7940C
	|-Enumerable.Iterator<KadarElexioBuf.SkillIdData>..ctor
	|
	|-RVA: 0x2A79520 Offset: 0x2A75520 VA: 0x2A79520
	|-Enumerable.Iterator<MobaRoomData.MobaAbilityMasterData>..ctor
	|
	|-RVA: 0x2A7963C Offset: 0x2A7563C VA: 0x2A7963C
	|-Enumerable.Iterator<TrophyManager.TrophyData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A775B0 Offset: 0x2A735B0 VA: 0x2A775B0
	|-Enumerable.Iterator<KeyValuePair<byte, BlackKnightCristaProperty>>.get_Current
	|
	|-RVA: 0x2A776C0 Offset: 0x2A736C0 VA: 0x2A776C0
	|-Enumerable.Iterator<KeyValuePair<byte, byte>>.get_Current
	|
	|-RVA: 0x2A777D4 Offset: 0x2A737D4 VA: 0x2A777D4
	|-Enumerable.Iterator<KeyValuePair<byte, object>>.get_Current
	|
	|-RVA: 0x2A778F0 Offset: 0x2A738F0 VA: 0x2A778F0
	|-Enumerable.Iterator<KeyValuePair<int, short>>.get_Current
	|
	|-RVA: 0x2A77A04 Offset: 0x2A73A04 VA: 0x2A77A04
	|-Enumerable.Iterator<KeyValuePair<int, object>>.get_Current
	|
	|-RVA: 0x2A77B20 Offset: 0x2A73B20 VA: 0x2A77B20
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.get_Current
	|
	|-RVA: 0x2A77C64 Offset: 0x2A73C64 VA: 0x2A77C64
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x2A77D78 Offset: 0x2A73D78 VA: 0x2A77D78
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, object>>.get_Current
	|
	|-RVA: 0x2A77E94 Offset: 0x2A73E94 VA: 0x2A77E94
	|-Enumerable.Iterator<KeyValuePair<object, int>>.get_Current
	|
	|-RVA: 0x2A77FB0 Offset: 0x2A73FB0 VA: 0x2A77FB0
	|-Enumerable.Iterator<KeyValuePair<object, float>>.get_Current
	|
	|-RVA: 0x2A780CC Offset: 0x2A740CC VA: 0x2A780CC
	|-Enumerable.Iterator<Nullable<UIMobPropertyLabel.IconValue>>.get_Current
	|
	|-RVA: 0x2A781FC Offset: 0x2A741FC VA: 0x2A781FC
	|-Enumerable.Iterator<ValueTuple<int, int>>.get_Current
	|
	|-RVA: 0x2A78310 Offset: 0x2A74310 VA: 0x2A78310
	|-Enumerable.Iterator<bool>.get_Current
	|
	|-RVA: 0x2A78424 Offset: 0x2A74424 VA: 0x2A78424
	|-Enumerable.Iterator<byte>.get_Current
	|
	|-RVA: 0x2A78538 Offset: 0x2A74538 VA: 0x2A78538
	|-Enumerable.Iterator<short>.get_Current
	|
	|-RVA: 0x2A7864C Offset: 0x2A7464C VA: 0x2A7864C
	|-Enumerable.Iterator<int>.get_Current
	|
	|-RVA: 0x2A7875C Offset: 0x2A7475C VA: 0x2A7875C
	|-Enumerable.Iterator<Int32Enum>.get_Current
	|
	|-RVA: 0x2A7886C Offset: 0x2A7486C VA: 0x2A7886C
	|-Enumerable.Iterator<long>.get_Current
	|
	|-RVA: 0x2A78980 Offset: 0x2A74980 VA: 0x2A78980
	|-Enumerable.Iterator<MobActionTargetData>.get_Current
	|
	|-RVA: 0x2A78AB4 Offset: 0x2A74AB4 VA: 0x2A78AB4
	|-Enumerable.Iterator<object>.get_Current
	|
	|-RVA: 0x2A78BA8 Offset: 0x2A74BA8 VA: 0x2A78BA8
	|-Enumerable.Iterator<float>.get_Current
	|
	|-RVA: 0x2A78CB8 Offset: 0x2A74CB8 VA: 0x2A78CB8
	|-Enumerable.Iterator<SkillIdData>.get_Current
	|
	|-RVA: 0x2A78DCC Offset: 0x2A74DCC VA: 0x2A78DCC
	|-Enumerable.Iterator<TimeSpan>.get_Current
	|
	|-RVA: 0x2A78EE0 Offset: 0x2A74EE0 VA: 0x2A78EE0
	|-Enumerable.Iterator<Vector3>.get_Current
	|
	|-RVA: 0x2A7902C Offset: 0x2A7502C VA: 0x2A7902C
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x2A792FC Offset: 0x2A752FC VA: 0x2A792FC
	|-Enumerable.Iterator<HouseRecipeManager.RecipeData>.get_Current
	|
	|-RVA: 0x2A79440 Offset: 0x2A75440 VA: 0x2A79440
	|-Enumerable.Iterator<KadarElexioBuf.SkillIdData>.get_Current
	|
	|-RVA: 0x2A79554 Offset: 0x2A75554 VA: 0x2A79554
	|-Enumerable.Iterator<MobaRoomData.MobaAbilityMasterData>.get_Current
	|
	|-RVA: 0x2A79670 Offset: 0x2A75670 VA: 0x2A79670
	|-Enumerable.Iterator<TrophyManager.TrophyData>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Enumerable.Iterator<TSource> Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A775B8 Offset: 0x2A735B8 VA: 0x2A775B8
	|-Enumerable.Iterator<KeyValuePair<byte, BlackKnightCristaProperty>>.Dispose
	|
	|-RVA: 0x2A776C8 Offset: 0x2A736C8 VA: 0x2A776C8
	|-Enumerable.Iterator<KeyValuePair<byte, byte>>.Dispose
	|
	|-RVA: 0x2A777E0 Offset: 0x2A737E0 VA: 0x2A777E0
	|-Enumerable.Iterator<KeyValuePair<byte, object>>.Dispose
	|
	|-RVA: 0x2A778F8 Offset: 0x2A738F8 VA: 0x2A778F8
	|-Enumerable.Iterator<KeyValuePair<int, short>>.Dispose
	|
	|-RVA: 0x2A77A10 Offset: 0x2A73A10 VA: 0x2A77A10
	|-Enumerable.Iterator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x2A77B38 Offset: 0x2A73B38 VA: 0x2A77B38
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.Dispose
	|
	|-RVA: 0x2A77C6C Offset: 0x2A73C6C VA: 0x2A77C6C
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2A77D84 Offset: 0x2A73D84 VA: 0x2A77D84
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x2A77EA0 Offset: 0x2A73EA0 VA: 0x2A77EA0
	|-Enumerable.Iterator<KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x2A77FBC Offset: 0x2A73FBC VA: 0x2A77FBC
	|-Enumerable.Iterator<KeyValuePair<object, float>>.Dispose
	|
	|-RVA: 0x2A780DC Offset: 0x2A740DC VA: 0x2A780DC
	|-Enumerable.Iterator<Nullable<UIMobPropertyLabel.IconValue>>.Dispose
	|
	|-RVA: 0x2A78204 Offset: 0x2A74204 VA: 0x2A78204
	|-Enumerable.Iterator<ValueTuple<int, int>>.Dispose
	|
	|-RVA: 0x2A78318 Offset: 0x2A74318 VA: 0x2A78318
	|-Enumerable.Iterator<bool>.Dispose
	|
	|-RVA: 0x2A7842C Offset: 0x2A7442C VA: 0x2A7842C
	|-Enumerable.Iterator<byte>.Dispose
	|
	|-RVA: 0x2A78540 Offset: 0x2A74540 VA: 0x2A78540
	|-Enumerable.Iterator<short>.Dispose
	|
	|-RVA: 0x2A78654 Offset: 0x2A74654 VA: 0x2A78654
	|-Enumerable.Iterator<int>.Dispose
	|
	|-RVA: 0x2A78764 Offset: 0x2A74764 VA: 0x2A78764
	|-Enumerable.Iterator<Int32Enum>.Dispose
	|
	|-RVA: 0x2A78874 Offset: 0x2A74874 VA: 0x2A78874
	|-Enumerable.Iterator<long>.Dispose
	|
	|-RVA: 0x2A78994 Offset: 0x2A74994 VA: 0x2A78994
	|-Enumerable.Iterator<MobActionTargetData>.Dispose
	|
	|-RVA: 0x2A78ABC Offset: 0x2A74ABC VA: 0x2A78ABC
	|-Enumerable.Iterator<object>.Dispose
	|
	|-RVA: 0x2A78BB0 Offset: 0x2A74BB0 VA: 0x2A78BB0
	|-Enumerable.Iterator<float>.Dispose
	|
	|-RVA: 0x2A78CC0 Offset: 0x2A74CC0 VA: 0x2A78CC0
	|-Enumerable.Iterator<SkillIdData>.Dispose
	|
	|-RVA: 0x2A78DD4 Offset: 0x2A74DD4 VA: 0x2A78DD4
	|-Enumerable.Iterator<TimeSpan>.Dispose
	|
	|-RVA: 0x2A78EEC Offset: 0x2A74EEC VA: 0x2A78EEC
	|-Enumerable.Iterator<Vector3>.Dispose
	|
	|-RVA: 0x2A790C8 Offset: 0x2A750C8 VA: 0x2A790C8
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Dispose
	|
	|-RVA: 0x2A79314 Offset: 0x2A75314 VA: 0x2A79314
	|-Enumerable.Iterator<HouseRecipeManager.RecipeData>.Dispose
	|
	|-RVA: 0x2A79448 Offset: 0x2A75448 VA: 0x2A79448
	|-Enumerable.Iterator<KadarElexioBuf.SkillIdData>.Dispose
	|
	|-RVA: 0x2A79560 Offset: 0x2A75560 VA: 0x2A79560
	|-Enumerable.Iterator<MobaRoomData.MobaAbilityMasterData>.Dispose
	|
	|-RVA: 0x2A79678 Offset: 0x2A75678 VA: 0x2A79678
	|-Enumerable.Iterator<TrophyManager.TrophyData>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A775C4 Offset: 0x2A735C4 VA: 0x2A775C4
	|-Enumerable.Iterator<KeyValuePair<byte, BlackKnightCristaProperty>>.GetEnumerator
	|
	|-RVA: 0x2A776D8 Offset: 0x2A736D8 VA: 0x2A776D8
	|-Enumerable.Iterator<KeyValuePair<byte, byte>>.GetEnumerator
	|
	|-RVA: 0x2A777F0 Offset: 0x2A737F0 VA: 0x2A777F0
	|-Enumerable.Iterator<KeyValuePair<byte, object>>.GetEnumerator
	|
	|-RVA: 0x2A77908 Offset: 0x2A73908 VA: 0x2A77908
	|-Enumerable.Iterator<KeyValuePair<int, short>>.GetEnumerator
	|
	|-RVA: 0x2A77A20 Offset: 0x2A73A20 VA: 0x2A77A20
	|-Enumerable.Iterator<KeyValuePair<int, object>>.GetEnumerator
	|
	|-RVA: 0x2A77B54 Offset: 0x2A73B54 VA: 0x2A77B54
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.GetEnumerator
	|
	|-RVA: 0x2A77C7C Offset: 0x2A73C7C VA: 0x2A77C7C
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, int>>.GetEnumerator
	|
	|-RVA: 0x2A77D94 Offset: 0x2A73D94 VA: 0x2A77D94
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, object>>.GetEnumerator
	|
	|-RVA: 0x2A77EB0 Offset: 0x2A73EB0 VA: 0x2A77EB0
	|-Enumerable.Iterator<KeyValuePair<object, int>>.GetEnumerator
	|
	|-RVA: 0x2A77FCC Offset: 0x2A73FCC VA: 0x2A77FCC
	|-Enumerable.Iterator<KeyValuePair<object, float>>.GetEnumerator
	|
	|-RVA: 0x2A780F4 Offset: 0x2A740F4 VA: 0x2A780F4
	|-Enumerable.Iterator<Nullable<UIMobPropertyLabel.IconValue>>.GetEnumerator
	|
	|-RVA: 0x2A78214 Offset: 0x2A74214 VA: 0x2A78214
	|-Enumerable.Iterator<ValueTuple<int, int>>.GetEnumerator
	|
	|-RVA: 0x2A78328 Offset: 0x2A74328 VA: 0x2A78328
	|-Enumerable.Iterator<bool>.GetEnumerator
	|
	|-RVA: 0x2A7843C Offset: 0x2A7443C VA: 0x2A7843C
	|-Enumerable.Iterator<byte>.GetEnumerator
	|
	|-RVA: 0x2A78550 Offset: 0x2A74550 VA: 0x2A78550
	|-Enumerable.Iterator<short>.GetEnumerator
	|
	|-RVA: 0x2A78660 Offset: 0x2A74660 VA: 0x2A78660
	|-Enumerable.Iterator<int>.GetEnumerator
	|
	|-RVA: 0x2A78770 Offset: 0x2A74770 VA: 0x2A78770
	|-Enumerable.Iterator<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2A78884 Offset: 0x2A74884 VA: 0x2A78884
	|-Enumerable.Iterator<long>.GetEnumerator
	|
	|-RVA: 0x2A789A8 Offset: 0x2A749A8 VA: 0x2A789A8
	|-Enumerable.Iterator<MobActionTargetData>.GetEnumerator
	|
	|-RVA: 0x2A78ACC Offset: 0x2A74ACC VA: 0x2A78ACC
	|-Enumerable.Iterator<object>.GetEnumerator
	|
	|-RVA: 0x2A78BBC Offset: 0x2A74BBC VA: 0x2A78BBC
	|-Enumerable.Iterator<float>.GetEnumerator
	|
	|-RVA: 0x2A78CD0 Offset: 0x2A74CD0 VA: 0x2A78CD0
	|-Enumerable.Iterator<SkillIdData>.GetEnumerator
	|
	|-RVA: 0x2A78DE4 Offset: 0x2A74DE4 VA: 0x2A78DE4
	|-Enumerable.Iterator<TimeSpan>.GetEnumerator
	|
	|-RVA: 0x2A78F00 Offset: 0x2A74F00 VA: 0x2A78F00
	|-Enumerable.Iterator<Vector3>.GetEnumerator
	|
	|-RVA: 0x2A79128 Offset: 0x2A75128 VA: 0x2A79128
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x2A79330 Offset: 0x2A75330 VA: 0x2A79330
	|-Enumerable.Iterator<HouseRecipeManager.RecipeData>.GetEnumerator
	|
	|-RVA: 0x2A79458 Offset: 0x2A75458 VA: 0x2A79458
	|-Enumerable.Iterator<KadarElexioBuf.SkillIdData>.GetEnumerator
	|
	|-RVA: 0x2A79570 Offset: 0x2A75570 VA: 0x2A79570
	|-Enumerable.Iterator<MobaRoomData.MobaAbilityMasterData>.GetEnumerator
	|
	|-RVA: 0x2A79688 Offset: 0x2A75688 VA: 0x2A79688
	|-Enumerable.Iterator<TrophyManager.TrophyData>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Select<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.Where
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7762C Offset: 0x2A7362C VA: 0x2A7762C
	|-Enumerable.Iterator<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A77740 Offset: 0x2A73740 VA: 0x2A77740
	|-Enumerable.Iterator<KeyValuePair<byte, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A77858 Offset: 0x2A73858 VA: 0x2A77858
	|-Enumerable.Iterator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A77970 Offset: 0x2A73970 VA: 0x2A77970
	|-Enumerable.Iterator<KeyValuePair<int, short>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A77A88 Offset: 0x2A73A88 VA: 0x2A77A88
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A77BBC Offset: 0x2A73BBC VA: 0x2A77BBC
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A77CE4 Offset: 0x2A73CE4 VA: 0x2A77CE4
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A77DFC Offset: 0x2A73DFC VA: 0x2A77DFC
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A77F18 Offset: 0x2A73F18 VA: 0x2A77F18
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A78034 Offset: 0x2A74034 VA: 0x2A78034
	|-Enumerable.Iterator<KeyValuePair<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A7815C Offset: 0x2A7415C VA: 0x2A7815C
	|-Enumerable.Iterator<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A7827C Offset: 0x2A7427C VA: 0x2A7827C
	|-Enumerable.Iterator<ValueTuple<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A78390 Offset: 0x2A74390 VA: 0x2A78390
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A784A4 Offset: 0x2A744A4 VA: 0x2A784A4
	|-Enumerable.Iterator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A785B8 Offset: 0x2A745B8 VA: 0x2A785B8
	|-Enumerable.Iterator<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A786C8 Offset: 0x2A746C8 VA: 0x2A786C8
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A787D8 Offset: 0x2A747D8 VA: 0x2A787D8
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A788EC Offset: 0x2A748EC VA: 0x2A788EC
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A78A10 Offset: 0x2A74A10 VA: 0x2A78A10
	|-Enumerable.Iterator<MobActionTargetData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A78B34 Offset: 0x2A74B34 VA: 0x2A78B34
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A78C24 Offset: 0x2A74C24 VA: 0x2A78C24
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A78D38 Offset: 0x2A74D38 VA: 0x2A78D38
	|-Enumerable.Iterator<SkillIdData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A78E4C Offset: 0x2A74E4C VA: 0x2A78E4C
	|-Enumerable.Iterator<TimeSpan>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A78F68 Offset: 0x2A74F68 VA: 0x2A78F68
	|-Enumerable.Iterator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A791DC Offset: 0x2A751DC VA: 0x2A791DC
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A79398 Offset: 0x2A75398 VA: 0x2A79398
	|-Enumerable.Iterator<HouseRecipeManager.RecipeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A794C0 Offset: 0x2A754C0 VA: 0x2A794C0
	|-Enumerable.Iterator<KadarElexioBuf.SkillIdData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A795D8 Offset: 0x2A755D8 VA: 0x2A795D8
	|-Enumerable.Iterator<MobaRoomData.MobaAbilityMasterData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2A796F0 Offset: 0x2A756F0 VA: 0x2A796F0
	|-Enumerable.Iterator<TrophyManager.TrophyData>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A77654 Offset: 0x2A73654 VA: 0x2A77654
	|-Enumerable.Iterator<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A77768 Offset: 0x2A73768 VA: 0x2A77768
	|-Enumerable.Iterator<KeyValuePair<byte, byte>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A77884 Offset: 0x2A73884 VA: 0x2A77884
	|-Enumerable.Iterator<KeyValuePair<byte, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A77998 Offset: 0x2A73998 VA: 0x2A77998
	|-Enumerable.Iterator<KeyValuePair<int, short>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A77AB4 Offset: 0x2A73AB4 VA: 0x2A77AB4
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A77BF8 Offset: 0x2A73BF8 VA: 0x2A77BF8
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A77D0C Offset: 0x2A73D0C VA: 0x2A77D0C
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A77E28 Offset: 0x2A73E28 VA: 0x2A77E28
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A77F44 Offset: 0x2A73F44 VA: 0x2A77F44
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A78060 Offset: 0x2A74060 VA: 0x2A78060
	|-Enumerable.Iterator<KeyValuePair<object, float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A78190 Offset: 0x2A74190 VA: 0x2A78190
	|-Enumerable.Iterator<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A782A4 Offset: 0x2A742A4 VA: 0x2A782A4
	|-Enumerable.Iterator<ValueTuple<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A783B8 Offset: 0x2A743B8 VA: 0x2A783B8
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A784CC Offset: 0x2A744CC VA: 0x2A784CC
	|-Enumerable.Iterator<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A785E0 Offset: 0x2A745E0 VA: 0x2A785E0
	|-Enumerable.Iterator<short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A786F0 Offset: 0x2A746F0 VA: 0x2A786F0
	|-Enumerable.Iterator<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A78800 Offset: 0x2A74800 VA: 0x2A78800
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A78914 Offset: 0x2A74914 VA: 0x2A78914
	|-Enumerable.Iterator<long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A78A48 Offset: 0x2A74A48 VA: 0x2A78A48
	|-Enumerable.Iterator<MobActionTargetData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A78B3C Offset: 0x2A74B3C VA: 0x2A78B3C
	|-Enumerable.Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A78C4C Offset: 0x2A74C4C VA: 0x2A78C4C
	|-Enumerable.Iterator<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A78D60 Offset: 0x2A74D60 VA: 0x2A78D60
	|-Enumerable.Iterator<SkillIdData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A78E74 Offset: 0x2A74E74 VA: 0x2A78E74
	|-Enumerable.Iterator<TimeSpan>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A78FA0 Offset: 0x2A74FA0 VA: 0x2A78FA0
	|-Enumerable.Iterator<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A79280 Offset: 0x2A75280 VA: 0x2A79280
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A793D4 Offset: 0x2A753D4 VA: 0x2A793D4
	|-Enumerable.Iterator<HouseRecipeManager.RecipeData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A794E8 Offset: 0x2A754E8 VA: 0x2A794E8
	|-Enumerable.Iterator<KadarElexioBuf.SkillIdData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A79604 Offset: 0x2A75604 VA: 0x2A79604
	|-Enumerable.Iterator<MobaRoomData.MobaAbilityMasterData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A79718 Offset: 0x2A75718 VA: 0x2A79718
	|-Enumerable.Iterator<TrophyManager.TrophyData>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A77658 Offset: 0x2A73658 VA: 0x2A77658
	|-Enumerable.Iterator<KeyValuePair<byte, BlackKnightCristaProperty>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A7776C Offset: 0x2A7376C VA: 0x2A7776C
	|-Enumerable.Iterator<KeyValuePair<byte, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A77888 Offset: 0x2A73888 VA: 0x2A77888
	|-Enumerable.Iterator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A7799C Offset: 0x2A7399C VA: 0x2A7799C
	|-Enumerable.Iterator<KeyValuePair<int, short>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A77AB8 Offset: 0x2A73AB8 VA: 0x2A77AB8
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A77BFC Offset: 0x2A73BFC VA: 0x2A77BFC
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, EnhanceProperties2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A77D10 Offset: 0x2A73D10 VA: 0x2A77D10
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A77E2C Offset: 0x2A73E2C VA: 0x2A77E2C
	|-Enumerable.Iterator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A77F48 Offset: 0x2A73F48 VA: 0x2A77F48
	|-Enumerable.Iterator<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A78064 Offset: 0x2A74064 VA: 0x2A78064
	|-Enumerable.Iterator<KeyValuePair<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A78194 Offset: 0x2A74194 VA: 0x2A78194
	|-Enumerable.Iterator<Nullable<UIMobPropertyLabel.IconValue>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A782A8 Offset: 0x2A742A8 VA: 0x2A782A8
	|-Enumerable.Iterator<ValueTuple<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A783BC Offset: 0x2A743BC VA: 0x2A783BC
	|-Enumerable.Iterator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A784D0 Offset: 0x2A744D0 VA: 0x2A784D0
	|-Enumerable.Iterator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A785E4 Offset: 0x2A745E4 VA: 0x2A785E4
	|-Enumerable.Iterator<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A786F4 Offset: 0x2A746F4 VA: 0x2A786F4
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A78804 Offset: 0x2A74804 VA: 0x2A78804
	|-Enumerable.Iterator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A78918 Offset: 0x2A74918 VA: 0x2A78918
	|-Enumerable.Iterator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A78A4C Offset: 0x2A74A4C VA: 0x2A78A4C
	|-Enumerable.Iterator<MobActionTargetData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A78B40 Offset: 0x2A74B40 VA: 0x2A78B40
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A78C50 Offset: 0x2A74C50 VA: 0x2A78C50
	|-Enumerable.Iterator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A78D64 Offset: 0x2A74D64 VA: 0x2A78D64
	|-Enumerable.Iterator<SkillIdData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A78E78 Offset: 0x2A74E78 VA: 0x2A78E78
	|-Enumerable.Iterator<TimeSpan>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A78FA4 Offset: 0x2A74FA4 VA: 0x2A78FA4
	|-Enumerable.Iterator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A79294 Offset: 0x2A75294 VA: 0x2A79294
	|-Enumerable.Iterator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A793D8 Offset: 0x2A753D8 VA: 0x2A793D8
	|-Enumerable.Iterator<HouseRecipeManager.RecipeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A794EC Offset: 0x2A754EC VA: 0x2A794EC
	|-Enumerable.Iterator<KadarElexioBuf.SkillIdData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A79608 Offset: 0x2A75608 VA: 0x2A79608
	|-Enumerable.Iterator<MobaRoomData.MobaAbilityMasterData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2A7971C Offset: 0x2A7571C VA: 0x2A7971C
	|-Enumerable.Iterator<TrophyManager.TrophyData>.System.Collections.IEnumerator.Reset
	*/
}

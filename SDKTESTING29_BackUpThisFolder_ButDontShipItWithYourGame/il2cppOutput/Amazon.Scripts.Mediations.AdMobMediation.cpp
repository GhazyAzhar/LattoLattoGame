#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename R, typename T1, typename T2>
struct VirtualFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};

// System.Collections.Generic.Dictionary`2<System.Object,System.Object>
struct Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA;
// System.Collections.Generic.Dictionary`2<System.String,System.String>
struct Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83;
// System.Collections.Generic.IEqualityComparer`1<System.String>
struct IEqualityComparer_1_tAE94C8F24AD5B94D4EE85CA9FC59E3409D41CAF7;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,System.String>
struct KeyCollection_t2EDD317F5771E575ACB63527B5AFB71291040342;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,System.String>
struct ValueCollection_t238D0D2427C6B841A01F522A41540165A2C4AE76;
// System.Collections.Generic.Dictionary`2/Entry<System.String,System.String>[]
struct EntryU5BU5D_t1AF33AD0B7330843448956EC4277517081658AE7;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
// APSAdMobPackageConfig
struct APSAdMobPackageConfig_t304A8D4B9D1BE0F7636D77BCDFFF7EC3E6D6C432;
// AmazonAds.AdResponse
struct AdResponse_t37AF079AE844A63C93C96EF3596FB833E90CB173;
// AmazonBannerMediationExtras
struct AmazonBannerMediationExtras_t7BAE7785F5B7C757A3610369477D89E664015896;
// AmazonInterstitialMediationExtras
struct AmazonInterstitialMediationExtras_t340E98FAC2E950DDE18BCC20A3B4ADD9124B7732;
// AmazonMediationExtras
struct AmazonMediationExtras_tD8F4E5D36E463EE6DDCB5960AE56B32E5C3E5D9A;
// AmazonPackageConfig
struct AmazonPackageConfig_tE9E6EA15FDE96843313F1F1EFCF9895517A1AC23;
// GoogleMobileAds.Api.Mediation.MediationExtras
struct MediationExtras_t390586958F7ED4B158AD5AD18F58A86E9E7B621E;
// System.String
struct String_t;

IL2CPP_EXTERN_C String_t* _stringLiteral04CB9283C54164437AE23405A80C594A6B5EC5F3;
IL2CPP_EXTERN_C String_t* _stringLiteral72B0A8383FAED8248A0D1F1C815E6298F47AE098;
IL2CPP_EXTERN_C String_t* _stringLiteral7AB7BB91C52F1784A493F4F1A40F41FDEB4C0B77;
IL2CPP_EXTERN_C String_t* _stringLiteralA7EC16C18CFE1AE4C09DF75256BA98D024BAA631;
IL2CPP_EXTERN_C String_t* _stringLiteralB19CAF1B0E4FB3E5044A8B81C8D7AD9569E39067;
IL2CPP_EXTERN_C String_t* _stringLiteralB1A7ED8E83AE44B0021AE0261FC66CF561FD4FDC;
IL2CPP_EXTERN_C String_t* _stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB;
IL2CPP_EXTERN_C String_t* _stringLiteralC893C9596AA82D3011D9A775D9F5695439DC0104;
IL2CPP_EXTERN_C String_t* _stringLiteralC9D5D6B18752051155C6FBE09FC1DC01969A7B30;
IL2CPP_EXTERN_C String_t* _stringLiteralDEC0B4C929BDDD4269A502D2FBD481BCF1075521;
IL2CPP_EXTERN_C String_t* _stringLiteralF228F4DD1AA102CD1FB01708123E9D8D5D83471C;
IL2CPP_EXTERN_C String_t* _stringLiteralF944DCD635F9801F7AC90A407FBC479964DEC024;
IL2CPP_EXTERN_C String_t* _stringLiteralFBDBC88F451708877242143919478A7B7F581F79;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13_RuntimeMethod_var;

struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_tF15808BFBC667860AD5BA2EB0B13EF9A53EE3B02 
{
};

// System.Collections.Generic.Dictionary`2<System.String,System.String>
struct Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.Dictionary`2::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::_entries
	EntryU5BU5D_t1AF33AD0B7330843448956EC4277517081658AE7* ____entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::_count
	int32_t ____count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeList
	int32_t ____freeList_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::_freeCount
	int32_t ____freeCount_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::_version
	int32_t ____version_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::_comparer
	RuntimeObject* ____comparer_6;
	// System.Collections.Generic.Dictionary`2/KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_keys
	KeyCollection_t2EDD317F5771E575ACB63527B5AFB71291040342* ____keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::_values
	ValueCollection_t238D0D2427C6B841A01F522A41540165A2C4AE76* ____values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject* ____syncRoot_9;
};

// AmazonAds.AdResponse
struct AdResponse_t37AF079AE844A63C93C96EF3596FB833E90CB173  : public RuntimeObject
{
};

// AmazonPackageConfig
struct AmazonPackageConfig_tE9E6EA15FDE96843313F1F1EFCF9895517A1AC23  : public RuntimeObject
{
};
struct Il2CppArrayBounds;

// GoogleMobileAds.Api.Mediation.MediationExtras
struct MediationExtras_t390586958F7ED4B158AD5AD18F58A86E9E7B621E  : public RuntimeObject
{
	// System.Collections.Generic.Dictionary`2<System.String,System.String> GoogleMobileAds.Api.Mediation.MediationExtras::<Extras>k__BackingField
	Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___U3CExtrasU3Ek__BackingField_0;
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// APSAdMobPackageConfig
struct APSAdMobPackageConfig_t304A8D4B9D1BE0F7636D77BCDFFF7EC3E6D6C432  : public AmazonPackageConfig_tE9E6EA15FDE96843313F1F1EFCF9895517A1AC23
{
};

// AmazonMediationExtras
struct AmazonMediationExtras_tD8F4E5D36E463EE6DDCB5960AE56B32E5C3E5D9A  : public MediationExtras_t390586958F7ED4B158AD5AD18F58A86E9E7B621E
{
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// AmazonBannerMediationExtras
struct AmazonBannerMediationExtras_t7BAE7785F5B7C757A3610369477D89E664015896  : public AmazonMediationExtras_tD8F4E5D36E463EE6DDCB5960AE56B32E5C3E5D9A
{
};

// AmazonInterstitialMediationExtras
struct AmazonInterstitialMediationExtras_t340E98FAC2E950DDE18BCC20A3B4ADD9124B7732  : public AmazonMediationExtras_tD8F4E5D36E463EE6DDCB5960AE56B32E5C3E5D9A
{
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248  : public RuntimeArray
{
	ALIGN_FIELD (8) String_t* m_Items[1];

	inline String_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline String_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, String_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline String_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline String_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, String_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::Add(TKey,TValue)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_Add_m93FFFABE8FCE7FA9793F0915E2A8842C7CD0C0C1_gshared (Dictionary_2_t14FE4A752A83D53771C584E4C8D14E01F2AFD7BA* __this, RuntimeObject* ___key0, RuntimeObject* ___value1, const RuntimeMethod* method) ;

// System.Void AmazonMediationExtras::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AmazonMediationExtras__ctor_m1DDD36887D4E137FD97632CC1C4CEF52D4D6D9FC (AmazonMediationExtras_tD8F4E5D36E463EE6DDCB5960AE56B32E5C3E5D9A* __this, const RuntimeMethod* method) ;
// System.Void GoogleMobileAds.Api.Mediation.MediationExtras::set_Extras(System.Collections.Generic.Dictionary`2<System.String,System.String>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void MediationExtras_set_Extras_mA9D64360355284BC7D2A7BE683FFB0AD2A4EC138_inline (MediationExtras_t390586958F7ED4B158AD5AD18F58A86E9E7B621E* __this, Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___value0, const RuntimeMethod* method) ;
// System.Collections.Generic.Dictionary`2<System.String,System.String> GoogleMobileAds.Api.Mediation.MediationExtras::get_Extras()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* MediationExtras_get_Extras_m301316E0049B5580869A85F9414C82445BADEB81_inline (MediationExtras_t390586958F7ED4B158AD5AD18F58A86E9E7B621E* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.String>::Add(TKey,TValue)
inline void Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13 (Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* __this, String_t* ___key0, String_t* ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83*, String_t*, String_t*, const RuntimeMethod*))Dictionary_2_Add_m93FFFABE8FCE7FA9793F0915E2A8842C7CD0C0C1_gshared)(__this, ___key0, ___value1, method);
}
// System.Void GoogleMobileAds.Api.Mediation.MediationExtras::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationExtras__ctor_mEFD02928F64CB007F296DC0B00BECCDC39F3869B (MediationExtras_t390586958F7ED4B158AD5AD18F58A86E9E7B621E* __this, const RuntimeMethod* method) ;
// System.String System.String::Join(System.String,System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Join_m557B6B554B87C1742FA0B128500073B421ED0BFD (String_t* ___separator0, StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___value1, const RuntimeMethod* method) ;
// System.String System.Boolean::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Boolean_ToString_m6646C8026B1DF381A1EE8CD13549175E9703CC63 (bool* __this, const RuntimeMethod* method) ;
// System.Void AmazonPackageConfig::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AmazonPackageConfig__ctor_m8D3558DCBCF3C7021A5C693B5E65EDA5C07F0DD1 (AmazonPackageConfig_tE9E6EA15FDE96843313F1F1EFCF9895517A1AC23* __this, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AmazonBannerMediationExtras::.ctor(System.Boolean,System.String,AmazonAds.AdResponse)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AmazonBannerMediationExtras__ctor_m4CAB7822449456222A36D039BD58EE3C34E5CD85 (AmazonBannerMediationExtras_t7BAE7785F5B7C757A3610369477D89E664015896* __this, bool ___isSmartBanner0, String_t* ___refreshID1, AdResponse_t37AF079AE844A63C93C96EF3596FB833E90CB173* ___responce2, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA7EC16C18CFE1AE4C09DF75256BA98D024BAA631);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDEC0B4C929BDDD4269A502D2FBD481BCF1075521);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF228F4DD1AA102CD1FB01708123E9D8D5D83471C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF944DCD635F9801F7AC90A407FBC479964DEC024);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* V_0 = NULL;
	{
		// public AmazonBannerMediationExtras (bool isSmartBanner, string refreshID, AmazonAds.AdResponse responce = null) : base () {
		AmazonMediationExtras__ctor_m1DDD36887D4E137FD97632CC1C4CEF52D4D6D9FC(__this, NULL);
		// if( responce != null ){
		AdResponse_t37AF079AE844A63C93C96EF3596FB833E90CB173* L_0 = ___responce2;
		if (!L_0)
		{
			goto IL_001a;
		}
	}
	{
		// Dictionary<string, string> extr = responce.GetRendering(isSmartBanner, refreshID);
		AdResponse_t37AF079AE844A63C93C96EF3596FB833E90CB173* L_1 = ___responce2;
		bool L_2 = ___isSmartBanner0;
		String_t* L_3 = ___refreshID1;
		NullCheck(L_1);
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_4;
		L_4 = VirtualFuncInvoker2< Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83*, bool, String_t* >::Invoke(6 /* System.Collections.Generic.Dictionary`2<System.String,System.String> AmazonAds.AdResponse::GetRendering(System.Boolean,System.String) */, L_1, L_2, L_3);
		V_0 = L_4;
		// Extras = extr;
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_5 = V_0;
		MediationExtras_set_Extras_mA9D64360355284BC7D2A7BE683FFB0AD2A4EC138_inline(__this, L_5, NULL);
		return;
	}

IL_001a:
	{
		// Extras.Add("amazon_request_queue",refreshID);
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_6;
		L_6 = MediationExtras_get_Extras_m301316E0049B5580869A85F9414C82445BADEB81_inline(__this, NULL);
		String_t* L_7 = ___refreshID1;
		NullCheck(L_6);
		Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13(L_6, _stringLiteralF228F4DD1AA102CD1FB01708123E9D8D5D83471C, L_7, Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13_RuntimeMethod_var);
		// if( isSmartBanner ){
		bool L_8 = ___isSmartBanner0;
		if (!L_8)
		{
			goto IL_0058;
		}
	}
	{
		// Extras.Add("expected_width","0");
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_9;
		L_9 = MediationExtras_get_Extras_m301316E0049B5580869A85F9414C82445BADEB81_inline(__this, NULL);
		NullCheck(L_9);
		Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13(L_9, _stringLiteralDEC0B4C929BDDD4269A502D2FBD481BCF1075521, _stringLiteralF944DCD635F9801F7AC90A407FBC479964DEC024, Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13_RuntimeMethod_var);
		// Extras.Add("expected_height","0");
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_10;
		L_10 = MediationExtras_get_Extras_m301316E0049B5580869A85F9414C82445BADEB81_inline(__this, NULL);
		NullCheck(L_10);
		Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13(L_10, _stringLiteralA7EC16C18CFE1AE4C09DF75256BA98D024BAA631, _stringLiteralF944DCD635F9801F7AC90A407FBC479964DEC024, Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13_RuntimeMethod_var);
	}

IL_0058:
	{
		// }
		return;
	}
}
// System.String AmazonBannerMediationExtras::get_AndroidMediationExtraBuilderClassName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AmazonBannerMediationExtras_get_AndroidMediationExtraBuilderClassName_m75FA950795BB806231FC43DC6755D17D7952DDCC (AmazonBannerMediationExtras_t7BAE7785F5B7C757A3610369477D89E664015896* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7AB7BB91C52F1784A493F4F1A40F41FDEB4C0B77);
		s_Il2CppMethodInitialized = true;
	}
	{
		// get { return "com.amazon.unityplugin.UnityBannerAdMobMediation"; }
		return _stringLiteral7AB7BB91C52F1784A493F4F1A40F41FDEB4C0B77;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AmazonInterstitialMediationExtras::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AmazonInterstitialMediationExtras__ctor_mE60BF836AA7E57BF30FE4F33FBCC3382B882B99C (AmazonInterstitialMediationExtras_t340E98FAC2E950DDE18BCC20A3B4ADD9124B7732* __this, const RuntimeMethod* method) 
{
	{
		// public AmazonInterstitialMediationExtras () : base () { }
		AmazonMediationExtras__ctor_m1DDD36887D4E137FD97632CC1C4CEF52D4D6D9FC(__this, NULL);
		// public AmazonInterstitialMediationExtras () : base () { }
		return;
	}
}
// System.Void AmazonInterstitialMediationExtras::.ctor(System.Collections.Generic.Dictionary`2<System.String,System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AmazonInterstitialMediationExtras__ctor_m6E197ADEF96855F020B380729413A44639E1E9A9 (AmazonInterstitialMediationExtras_t340E98FAC2E950DDE18BCC20A3B4ADD9124B7732* __this, Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___extr0, const RuntimeMethod* method) 
{
	{
		// public AmazonInterstitialMediationExtras (Dictionary<string, string> extr) : base () {
		AmazonMediationExtras__ctor_m1DDD36887D4E137FD97632CC1C4CEF52D4D6D9FC(__this, NULL);
		// Extras = extr;
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_0 = ___extr0;
		MediationExtras_set_Extras_mA9D64360355284BC7D2A7BE683FFB0AD2A4EC138_inline(__this, L_0, NULL);
		// }
		return;
	}
}
// System.String AmazonInterstitialMediationExtras::get_AndroidMediationExtraBuilderClassName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AmazonInterstitialMediationExtras_get_AndroidMediationExtraBuilderClassName_mEBB8520F72CF93CC8B01583D6E0E91F04FFAC4B4 (AmazonInterstitialMediationExtras_t340E98FAC2E950DDE18BCC20A3B4ADD9124B7732* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral72B0A8383FAED8248A0D1F1C815E6298F47AE098);
		s_Il2CppMethodInitialized = true;
	}
	{
		// get { return "com.amazon.unityplugin.UnityInterstitialAdMobMediation"; }
		return _stringLiteral72B0A8383FAED8248A0D1F1C815E6298F47AE098;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AmazonMediationExtras::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AmazonMediationExtras__ctor_m1DDD36887D4E137FD97632CC1C4CEF52D4D6D9FC (AmazonMediationExtras_tD8F4E5D36E463EE6DDCB5960AE56B32E5C3E5D9A* __this, const RuntimeMethod* method) 
{
	{
		// public AmazonMediationExtras () : base () {  }
		MediationExtras__ctor_mEFD02928F64CB007F296DC0B00BECCDC39F3869B(__this, NULL);
		// public AmazonMediationExtras () : base () {  }
		return;
	}
}
// System.String AmazonMediationExtras::get_IOSMediationExtraBuilderClassName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AmazonMediationExtras_get_IOSMediationExtraBuilderClassName_m00F8475173A361CFE4587C4C34E422D87FDCA016 (AmazonMediationExtras_tD8F4E5D36E463EE6DDCB5960AE56B32E5C3E5D9A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC9D5D6B18752051155C6FBE09FC1DC01969A7B30);
		s_Il2CppMethodInitialized = true;
	}
	{
		// get { return "AmazonExtrasBuilder"; }
		return _stringLiteralC9D5D6B18752051155C6FBE09FC1DC01969A7B30;
	}
}
// System.Void AmazonMediationExtras::SetAllPlacements(System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AmazonMediationExtras_SetAllPlacements_m29DAB4F915A09E592C2FD44826E978DA62B8E448 (AmazonMediationExtras_tD8F4E5D36E463EE6DDCB5960AE56B32E5C3E5D9A* __this, StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___allPlacements0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC893C9596AA82D3011D9A775D9F5695439DC0104);
		s_Il2CppMethodInitialized = true;
	}
	{
		// this.Extras.Add (AllPlacementsKey, String.Join (",", allPlacements));
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_0;
		L_0 = MediationExtras_get_Extras_m301316E0049B5580869A85F9414C82445BADEB81_inline(__this, NULL);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_1 = ___allPlacements0;
		String_t* L_2;
		L_2 = String_Join_m557B6B554B87C1742FA0B128500073B421ED0BFD(_stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB, L_1, NULL);
		NullCheck(L_0);
		Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13(L_0, _stringLiteralC893C9596AA82D3011D9A775D9F5695439DC0104, L_2, Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13_RuntimeMethod_var);
		// }
		return;
	}
}
// System.Void AmazonMediationExtras::SetUserId(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AmazonMediationExtras_SetUserId_m3C5E8634CD3F0A43FF1760AC78E5D949CE466622 (AmazonMediationExtras_tD8F4E5D36E463EE6DDCB5960AE56B32E5C3E5D9A* __this, String_t* ___userId0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral04CB9283C54164437AE23405A80C594A6B5EC5F3);
		s_Il2CppMethodInitialized = true;
	}
	{
		// this.Extras.Add (UserIdKey, userId);
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_0;
		L_0 = MediationExtras_get_Extras_m301316E0049B5580869A85F9414C82445BADEB81_inline(__this, NULL);
		String_t* L_1 = ___userId0;
		NullCheck(L_0);
		Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13(L_0, _stringLiteral04CB9283C54164437AE23405A80C594A6B5EC5F3, L_1, Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13_RuntimeMethod_var);
		// }
		return;
	}
}
// System.Void AmazonMediationExtras::SetSoundEnabled(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AmazonMediationExtras_SetSoundEnabled_mDFD8E27FE7DA33988FDD0169CD5124BA1064ED20 (AmazonMediationExtras_tD8F4E5D36E463EE6DDCB5960AE56B32E5C3E5D9A* __this, bool ___soundEnabled0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB1A7ED8E83AE44B0021AE0261FC66CF561FD4FDC);
		s_Il2CppMethodInitialized = true;
	}
	{
		// this.Extras.Add (SoundEnabledKey, soundEnabled.ToString ());
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_0;
		L_0 = MediationExtras_get_Extras_m301316E0049B5580869A85F9414C82445BADEB81_inline(__this, NULL);
		String_t* L_1;
		L_1 = Boolean_ToString_m6646C8026B1DF381A1EE8CD13549175E9703CC63((&___soundEnabled0), NULL);
		NullCheck(L_0);
		Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13(L_0, _stringLiteralB1A7ED8E83AE44B0021AE0261FC66CF561FD4FDC, L_1, Dictionary_2_Add_mC78C20D5901C87AAC38F37C906FAB6946BDE5F13_RuntimeMethod_var);
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.String APSAdMobPackageConfig::get_Name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* APSAdMobPackageConfig_get_Name_m803E7761E9CB65F64B2CEE9830C82B83DE43CEF1 (APSAdMobPackageConfig_t304A8D4B9D1BE0F7636D77BCDFFF7EC3E6D6C432* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB19CAF1B0E4FB3E5044A8B81C8D7AD9569E39067);
		s_Il2CppMethodInitialized = true;
	}
	{
		// get { return "admob_adapter"; }
		return _stringLiteralB19CAF1B0E4FB3E5044A8B81C8D7AD9569E39067;
	}
}
// System.String APSAdMobPackageConfig::get_Version()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* APSAdMobPackageConfig_get_Version_m208279AD1E4C90DF338CB7B4E60C7CB40EB50E90 (APSAdMobPackageConfig_t304A8D4B9D1BE0F7636D77BCDFFF7EC3E6D6C432* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFBDBC88F451708877242143919478A7B7F581F79);
		s_Il2CppMethodInitialized = true;
	}
	{
		// get { return VERSION; }
		return _stringLiteralFBDBC88F451708877242143919478A7B7F581F79;
	}
}
// System.Void APSAdMobPackageConfig::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void APSAdMobPackageConfig__ctor_m4AC9310C0184840A859CF972F53C437150839D64 (APSAdMobPackageConfig_t304A8D4B9D1BE0F7636D77BCDFFF7EC3E6D6C432* __this, const RuntimeMethod* method) 
{
	{
		AmazonPackageConfig__ctor_m8D3558DCBCF3C7021A5C693B5E65EDA5C07F0DD1(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void MediationExtras_set_Extras_mA9D64360355284BC7D2A7BE683FFB0AD2A4EC138_inline (MediationExtras_t390586958F7ED4B158AD5AD18F58A86E9E7B621E* __this, Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___value0, const RuntimeMethod* method) 
{
	{
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_0 = ___value0;
		__this->___U3CExtrasU3Ek__BackingField_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CExtrasU3Ek__BackingField_0), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* MediationExtras_get_Extras_m301316E0049B5580869A85F9414C82445BADEB81_inline (MediationExtras_t390586958F7ED4B158AD5AD18F58A86E9E7B621E* __this, const RuntimeMethod* method) 
{
	{
		Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* L_0 = __this->___U3CExtrasU3Ek__BackingField_0;
		return L_0;
	}
}

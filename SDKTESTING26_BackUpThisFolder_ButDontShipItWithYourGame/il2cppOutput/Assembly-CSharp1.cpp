#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct InterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};

// System.Collections.Generic.Dictionary`2<System.String,System.String>
struct Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83;
// System.EventHandler`1<System.EventArgs>
struct EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF;
// System.EventHandler`1<System.Object>
struct EventHandler_1_tD8C4A5BE1F7C91B1A7E99AE87AFD2F5432C38746;
// System.Collections.Generic.HashSet`1<System.String>
struct HashSet_1_tEFC6605F7DE53F71946C33FD371E53C3100F2178;
// System.Collections.Generic.List`1<GoogleMobileAds.Api.Mediation.MediationExtras>
struct List_1_t5E2EB19AA6B9CFA733A67F57AF74DCBE981C3376;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// GoogleMobileAds.Api.AdRequest
struct AdRequest_tB2AC2CD266CFD5D636C917BC2D938BE96E72BF4D;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// System.EventArgs
struct EventArgs_t37273F03EAC87217701DD431B190FBD84AD7C377;
// GoogleMobileAdsMediationTestSuite.Common.IMediationTestClient
struct IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343;
// GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite
struct MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.String
struct String_t;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;

IL2CPP_EXTERN_C RuntimeClass* EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C const RuntimeMethod* MediationTestSuite_HandleMediationTestSuiteDismissed_mDF7F7BB650EB3715CC9DD5F7EA97EAA4C39D671D_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GoogleMobileAds.Api.AdRequest
struct AdRequest_tB2AC2CD266CFD5D636C917BC2D938BE96E72BF4D  : public RuntimeObject
{
	// System.Collections.Generic.HashSet`1<System.String> GoogleMobileAds.Api.AdRequest::<Keywords>k__BackingField
	HashSet_1_tEFC6605F7DE53F71946C33FD371E53C3100F2178* ___U3CKeywordsU3Ek__BackingField_2;
	// System.Collections.Generic.Dictionary`2<System.String,System.String> GoogleMobileAds.Api.AdRequest::<Extras>k__BackingField
	Dictionary_2_t46B2DB028096FA2B828359E52F37F3105A83AD83* ___U3CExtrasU3Ek__BackingField_3;
	// System.Collections.Generic.List`1<GoogleMobileAds.Api.Mediation.MediationExtras> GoogleMobileAds.Api.AdRequest::<MediationExtras>k__BackingField
	List_1_t5E2EB19AA6B9CFA733A67F57AF74DCBE981C3376* ___U3CMediationExtrasU3Ek__BackingField_4;
};

struct AdRequest_tB2AC2CD266CFD5D636C917BC2D938BE96E72BF4D_StaticFields
{
	// System.String GoogleMobileAds.Api.AdRequest::<Version>k__BackingField
	String_t* ___U3CVersionU3Ek__BackingField_0;
};
struct Il2CppArrayBounds;

// System.EventArgs
struct EventArgs_t37273F03EAC87217701DD431B190FBD84AD7C377  : public RuntimeObject
{
};

struct EventArgs_t37273F03EAC87217701DD431B190FBD84AD7C377_StaticFields
{
	// System.EventArgs System.EventArgs::Empty
	EventArgs_t37273F03EAC87217701DD431B190FBD84AD7C377* ___Empty_0;
};

// GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite
struct MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA  : public RuntimeObject
{
	// GoogleMobileAdsMediationTestSuite.Common.IMediationTestClient GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::client
	RuntimeObject* ___client_0;
};

struct MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_StaticFields
{
	// GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::instance
	MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* ___instance_1;
	// System.EventHandler`1<System.EventArgs> GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::OnMediationTestSuiteDismissed
	EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* ___OnMediationTestSuiteDismissed_2;
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

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
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

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// System.EventHandler`1<System.EventArgs>
struct EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF  : public MulticastDelegate_t
{
};

// System.EventHandler`1<System.Object>
struct EventHandler_1_tD8C4A5BE1F7C91B1A7E99AE87AFD2F5432C38746  : public MulticastDelegate_t
{
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif


// System.Void System.EventHandler`1<System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EventHandler_1__ctor_mBA2E748CFBA7A0EEC0A373A6F634D3B5774EA370_gshared (EventHandler_1_tD8C4A5BE1F7C91B1A7E99AE87AFD2F5432C38746* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) ;
// System.Void System.EventHandler`1<System.Object>::Invoke(System.Object,TEventArgs)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EventHandler_1_Invoke_mBD72C04FF5A08A2EA93DFD21037CD1C27A48D07A_gshared_inline (EventHandler_1_tD8C4A5BE1F7C91B1A7E99AE87AFD2F5432C38746* __this, RuntimeObject* ___sender0, RuntimeObject* ___e1, const RuntimeMethod* method) ;

// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// GoogleMobileAdsMediationTestSuite.Common.IMediationTestClient GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::GetMediationTestClient()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MediationTestSuite_GetMediationTestClient_m19CD24923291E99463DBD80F6B79B4A12393B272 (const RuntimeMethod* method) ;
// System.Void System.EventHandler`1<System.EventArgs>::.ctor(System.Object,System.IntPtr)
inline void EventHandler_1__ctor_mCB95906E90473A2BABEBC6C286D9268E255A8BC0 (EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF*, RuntimeObject*, intptr_t, const RuntimeMethod*))EventHandler_1__ctor_mBA2E748CFBA7A0EEC0A373A6F634D3B5774EA370_gshared)(__this, ___object0, ___method1, method);
}
// System.Delegate System.Delegate::Combine(System.Delegate,System.Delegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t* Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00 (Delegate_t* ___a0, Delegate_t* ___b1, const RuntimeMethod* method) ;
// System.Delegate System.Delegate::Remove(System.Delegate,System.Delegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t* Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3 (Delegate_t* ___source0, Delegate_t* ___value1, const RuntimeMethod* method) ;
// GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::get_Instance()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* MediationTestSuite_get_Instance_mB19D5B8CC7549A2F553E1B61CA51DB09F31E7E2D_inline (const RuntimeMethod* method) ;
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::CallShow()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_CallShow_m3DD83EA5AFE9C0D0781625423F89374E79B07D5A (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* __this, const RuntimeMethod* method) ;
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::CallShowForAdManager()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_CallShowForAdManager_mE49B6354D34970D0569D6061614C767312604AE8 (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* __this, const RuntimeMethod* method) ;
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::CallShow(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_CallShow_mED155AAA658C0BC548798AD5019257F2B36F8EAA (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* __this, String_t* ___appId0, const RuntimeMethod* method) ;
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::set_AdRequestImpl(GoogleMobileAds.Api.AdRequest)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_set_AdRequestImpl_mAA7EF7582B090E57070B4949E8769FD2B5BCD70A (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* __this, AdRequest_tB2AC2CD266CFD5D636C917BC2D938BE96E72BF4D* ___value0, const RuntimeMethod* method) ;
// GoogleMobileAdsMediationTestSuite.Common.IMediationTestClient GoogleMobileAdsMediationTestSuite.MediationTestSuiteClientFactory::MediationTestSuiteInstance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MediationTestSuiteClientFactory_MediationTestSuiteInstance_m884FAD6403F9FC2F66062150B1A0006893B8D2D7 (const RuntimeMethod* method) ;
// System.Void System.EventHandler`1<System.EventArgs>::Invoke(System.Object,TEventArgs)
inline void EventHandler_1_Invoke_m60078FEF33DC40DA542580DB35336F91D04360C2_inline (EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* __this, RuntimeObject* ___sender0, EventArgs_t37273F03EAC87217701DD431B190FBD84AD7C377* ___e1, const RuntimeMethod* method)
{
	((  void (*) (EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF*, RuntimeObject*, EventArgs_t37273F03EAC87217701DD431B190FBD84AD7C377*, const RuntimeMethod*))EventHandler_1_Invoke_mBD72C04FF5A08A2EA93DFD21037CD1C27A48D07A_gshared_inline)(__this, ___sender0, ___e1, method);
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite__ctor_m7AB55169DAD29BD528682C3C25CDFB7C8178DCE1 (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* __this, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite__ctor_m7AB55169DAD29BD528682C3C25CDFB7C8178DCE1 (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_HandleMediationTestSuiteDismissed_mDF7F7BB650EB3715CC9DD5F7EA97EAA4C39D671D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private MediationTestSuite()
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// this.client = GetMediationTestClient();
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		RuntimeObject* L_0;
		L_0 = MediationTestSuite_GetMediationTestClient_m19CD24923291E99463DBD80F6B79B4A12393B272(NULL);
		__this->___client_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___client_0), (void*)L_0);
		// this.client.OnMediationTestSuiteDismissed += this.HandleMediationTestSuiteDismissed;
		RuntimeObject* L_1 = __this->___client_0;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_2 = (EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF*)il2cpp_codegen_object_new(EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		EventHandler_1__ctor_mCB95906E90473A2BABEBC6C286D9268E255A8BC0(L_2, __this, (intptr_t)((void*)MediationTestSuite_HandleMediationTestSuiteDismissed_mDF7F7BB650EB3715CC9DD5F7EA97EAA4C39D671D_RuntimeMethod_var), NULL);
		NullCheck(L_1);
		InterfaceActionInvoker1< EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* >::Invoke(0 /* System.Void GoogleMobileAdsMediationTestSuite.Common.IMediationTestClient::add_OnMediationTestSuiteDismissed(System.EventHandler`1<System.EventArgs>) */, IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343_il2cpp_TypeInfo_var, L_1, L_2);
		// }
		return;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::add_OnMediationTestSuiteDismissed(System.EventHandler`1<System.EventArgs>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_add_OnMediationTestSuiteDismissed_mE9EBB6B29C1601363C394EACD36AA6083A3AD916 (EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* V_0 = NULL;
	EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* V_1 = NULL;
	EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* V_2 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_0 = ((MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_StaticFields*)il2cpp_codegen_static_fields_for(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var))->___OnMediationTestSuiteDismissed_2;
		V_0 = L_0;
	}

IL_0006:
	{
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_1 = V_0;
		V_1 = L_1;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_2 = V_1;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_3 = ___value0;
		Delegate_t* L_4;
		L_4 = Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00(L_2, L_3, NULL);
		V_2 = ((EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF*)Castclass((RuntimeObject*)L_4, EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF_il2cpp_TypeInfo_var));
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_5 = V_2;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_6 = V_1;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_7;
		L_7 = InterlockedCompareExchangeImpl<EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF*>((&((MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_StaticFields*)il2cpp_codegen_static_fields_for(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var))->___OnMediationTestSuiteDismissed_2), L_5, L_6);
		V_0 = L_7;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_8 = V_0;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_9 = V_1;
		if ((!(((RuntimeObject*)(EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF*)L_8) == ((RuntimeObject*)(EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF*)L_9))))
		{
			goto IL_0006;
		}
	}
	{
		return;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::remove_OnMediationTestSuiteDismissed(System.EventHandler`1<System.EventArgs>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_remove_OnMediationTestSuiteDismissed_mB5F56498AC456E900B846922B49C17D1D5CE0C87 (EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* V_0 = NULL;
	EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* V_1 = NULL;
	EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* V_2 = NULL;
	{
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_0 = ((MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_StaticFields*)il2cpp_codegen_static_fields_for(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var))->___OnMediationTestSuiteDismissed_2;
		V_0 = L_0;
	}

IL_0006:
	{
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_1 = V_0;
		V_1 = L_1;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_2 = V_1;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_3 = ___value0;
		Delegate_t* L_4;
		L_4 = Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3(L_2, L_3, NULL);
		V_2 = ((EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF*)Castclass((RuntimeObject*)L_4, EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF_il2cpp_TypeInfo_var));
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_5 = V_2;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_6 = V_1;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_7;
		L_7 = InterlockedCompareExchangeImpl<EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF*>((&((MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_StaticFields*)il2cpp_codegen_static_fields_for(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var))->___OnMediationTestSuiteDismissed_2), L_5, L_6);
		V_0 = L_7;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_8 = V_0;
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_9 = V_1;
		if ((!(((RuntimeObject*)(EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF*)L_8) == ((RuntimeObject*)(EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF*)L_9))))
		{
			goto IL_0006;
		}
	}
	{
		return;
	}
}
// GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::get_Instance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* MediationTestSuite_get_Instance_mB19D5B8CC7549A2F553E1B61CA51DB09F31E7E2D (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return instance;
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* L_0 = ((MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_StaticFields*)il2cpp_codegen_static_fields_for(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var))->___instance_1;
		return L_0;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::Show()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_Show_m18CF8989A7E8F723727CF4C7950E62654233703D (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// MediationTestSuite.Instance.CallShow();
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* L_0;
		L_0 = MediationTestSuite_get_Instance_mB19D5B8CC7549A2F553E1B61CA51DB09F31E7E2D_inline(NULL);
		NullCheck(L_0);
		MediationTestSuite_CallShow_m3DD83EA5AFE9C0D0781625423F89374E79B07D5A(L_0, NULL);
		// }
		return;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::ShowForAdManager()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_ShowForAdManager_mB3BA0BA39661F9754B90B5BEE687DF69EDA7E340 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// MediationTestSuite.Instance.CallShowForAdManager();
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* L_0;
		L_0 = MediationTestSuite_get_Instance_mB19D5B8CC7549A2F553E1B61CA51DB09F31E7E2D_inline(NULL);
		NullCheck(L_0);
		MediationTestSuite_CallShowForAdManager_mE49B6354D34970D0569D6061614C767312604AE8(L_0, NULL);
		// }
		return;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::Show(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_Show_m08E09B215BB487A8C9B3D87D7A80429DD3F204B0 (String_t* ___appId0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// MediationTestSuite.Instance.CallShow(appId);
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* L_0;
		L_0 = MediationTestSuite_get_Instance_mB19D5B8CC7549A2F553E1B61CA51DB09F31E7E2D_inline(NULL);
		String_t* L_1 = ___appId0;
		NullCheck(L_0);
		MediationTestSuite_CallShow_mED155AAA658C0BC548798AD5019257F2B36F8EAA(L_0, L_1, NULL);
		// }
		return;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::set_AdRequest(GoogleMobileAds.Api.AdRequest)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_set_AdRequest_m4F6480BF77395FF1D59C4206A0C2D4F946646D7A (AdRequest_tB2AC2CD266CFD5D636C917BC2D938BE96E72BF4D* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// MediationTestSuite.Instance.AdRequestImpl = value;
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* L_0;
		L_0 = MediationTestSuite_get_Instance_mB19D5B8CC7549A2F553E1B61CA51DB09F31E7E2D_inline(NULL);
		AdRequest_tB2AC2CD266CFD5D636C917BC2D938BE96E72BF4D* L_1 = ___value0;
		NullCheck(L_0);
		MediationTestSuite_set_AdRequestImpl_mAA7EF7582B090E57070B4949E8769FD2B5BCD70A(L_0, L_1, NULL);
		// }
		return;
	}
}
// GoogleMobileAdsMediationTestSuite.Common.IMediationTestClient GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::GetMediationTestClient()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MediationTestSuite_GetMediationTestClient_m19CD24923291E99463DBD80F6B79B4A12393B272 (const RuntimeMethod* method) 
{
	{
		// return MediationTestSuiteClientFactory.MediationTestSuiteInstance();
		RuntimeObject* L_0;
		L_0 = MediationTestSuiteClientFactory_MediationTestSuiteInstance_m884FAD6403F9FC2F66062150B1A0006893B8D2D7(NULL);
		return L_0;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::HandleMediationTestSuiteDismissed(System.Object,System.EventArgs)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_HandleMediationTestSuiteDismissed_mDF7F7BB650EB3715CC9DD5F7EA97EAA4C39D671D (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* __this, RuntimeObject* ___sender0, EventArgs_t37273F03EAC87217701DD431B190FBD84AD7C377* ___args1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (MediationTestSuite.OnMediationTestSuiteDismissed != null)
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_0 = ((MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_StaticFields*)il2cpp_codegen_static_fields_for(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var))->___OnMediationTestSuiteDismissed_2;
		if (!L_0)
		{
			goto IL_0013;
		}
	}
	{
		// MediationTestSuite.OnMediationTestSuiteDismissed(this, args);
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		EventHandler_1_tF2D41B212D800E7E7D00F9BDEA817E57153988BF* L_1 = ((MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_StaticFields*)il2cpp_codegen_static_fields_for(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var))->___OnMediationTestSuiteDismissed_2;
		EventArgs_t37273F03EAC87217701DD431B190FBD84AD7C377* L_2 = ___args1;
		NullCheck(L_1);
		EventHandler_1_Invoke_m60078FEF33DC40DA542580DB35336F91D04360C2_inline(L_1, __this, L_2, NULL);
	}

IL_0013:
	{
		// }
		return;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::CallShow(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_CallShow_mED155AAA658C0BC548798AD5019257F2B36F8EAA (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* __this, String_t* ___appId0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// this.client.Show(appId);
		RuntimeObject* L_0 = __this->___client_0;
		String_t* L_1 = ___appId0;
		NullCheck(L_0);
		InterfaceActionInvoker1< String_t* >::Invoke(3 /* System.Void GoogleMobileAdsMediationTestSuite.Common.IMediationTestClient::Show(System.String) */, IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343_il2cpp_TypeInfo_var, L_0, L_1);
		// }
		return;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::CallShow()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_CallShow_m3DD83EA5AFE9C0D0781625423F89374E79B07D5A (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// this.client.Show();
		RuntimeObject* L_0 = __this->___client_0;
		NullCheck(L_0);
		InterfaceActionInvoker0::Invoke(4 /* System.Void GoogleMobileAdsMediationTestSuite.Common.IMediationTestClient::Show() */, IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343_il2cpp_TypeInfo_var, L_0);
		// }
		return;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::CallShowForAdManager()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_CallShowForAdManager_mE49B6354D34970D0569D6061614C767312604AE8 (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// this.client.ShowForAdManager();
		RuntimeObject* L_0 = __this->___client_0;
		NullCheck(L_0);
		InterfaceActionInvoker0::Invoke(5 /* System.Void GoogleMobileAdsMediationTestSuite.Common.IMediationTestClient::ShowForAdManager() */, IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343_il2cpp_TypeInfo_var, L_0);
		// }
		return;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::set_AdRequestImpl(GoogleMobileAds.Api.AdRequest)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite_set_AdRequestImpl_mAA7EF7582B090E57070B4949E8769FD2B5BCD70A (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* __this, AdRequest_tB2AC2CD266CFD5D636C917BC2D938BE96E72BF4D* ___value0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// this.client.AdRequest = value;
		RuntimeObject* L_0 = __this->___client_0;
		AdRequest_tB2AC2CD266CFD5D636C917BC2D938BE96E72BF4D* L_1 = ___value0;
		NullCheck(L_0);
		InterfaceActionInvoker1< AdRequest_tB2AC2CD266CFD5D636C917BC2D938BE96E72BF4D* >::Invoke(2 /* System.Void GoogleMobileAdsMediationTestSuite.Common.IMediationTestClient::set_AdRequest(GoogleMobileAds.Api.AdRequest) */, IMediationTestClient_t4E65F56103F7F4E7E2AF53F56281C081183E3343_il2cpp_TypeInfo_var, L_0, L_1);
		// }
		return;
	}
}
// System.Void GoogleMobileAdsMediationTestSuite.Api.MediationTestSuite::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MediationTestSuite__cctor_m02941AD0C35540488A1208DD19239BCB13CE8FE3 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private static MediationTestSuite instance = new MediationTestSuite();
		MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* L_0 = (MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA*)il2cpp_codegen_object_new(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		MediationTestSuite__ctor_m7AB55169DAD29BD528682C3C25CDFB7C8178DCE1(L_0, NULL);
		((MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_StaticFields*)il2cpp_codegen_static_fields_for(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var))->___instance_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_StaticFields*)il2cpp_codegen_static_fields_for(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var))->___instance_1), (void*)L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* MediationTestSuite_get_Instance_mB19D5B8CC7549A2F553E1B61CA51DB09F31E7E2D_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return instance;
		il2cpp_codegen_runtime_class_init_inline(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var);
		MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA* L_0 = ((MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_StaticFields*)il2cpp_codegen_static_fields_for(MediationTestSuite_tEC1C6EA43E0EB47B80A66546D1098CC501319EAA_il2cpp_TypeInfo_var))->___instance_1;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EventHandler_1_Invoke_mBD72C04FF5A08A2EA93DFD21037CD1C27A48D07A_gshared_inline (EventHandler_1_tD8C4A5BE1F7C91B1A7E99AE87AFD2F5432C38746* __this, RuntimeObject* ___sender0, RuntimeObject* ___e1, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___sender0, ___e1, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}

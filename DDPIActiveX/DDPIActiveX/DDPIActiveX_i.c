

/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


 /* File created by MIDL compiler version 8.01.0622 */
/* at Mon Jan 18 19:14:07 2038
 */
/* Compiler settings for DDPIActiveX.idl:
    Oicf, W1, Zp8, env=Win64 (32b run), target_arch=AMD64 8.01.0622 
    protocol : all , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */



#ifdef __cplusplus
extern "C"{
#endif 


#include <rpc.h>
#include <rpcndr.h>

#ifdef _MIDL_USE_GUIDDEF_

#ifndef INITGUID
#define INITGUID
#include <guiddef.h>
#undef INITGUID
#else
#include <guiddef.h>
#endif

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        DEFINE_GUID(name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8)

#else // !_MIDL_USE_GUIDDEF_

#ifndef __IID_DEFINED__
#define __IID_DEFINED__

typedef struct _IID
{
    unsigned long x;
    unsigned short s1;
    unsigned short s2;
    unsigned char  c[8];
} IID;

#endif // __IID_DEFINED__

#ifndef CLSID_DEFINED
#define CLSID_DEFINED
typedef IID CLSID;
#endif // CLSID_DEFINED

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        EXTERN_C __declspec(selectany) const type name = {l,w1,w2,{b1,b2,b3,b4,b5,b6,b7,b8}}

#endif // !_MIDL_USE_GUIDDEF_

MIDL_DEFINE_GUID(IID, LIBID_DDPIActiveXLib,0x709ed462,0xc56b,0x4395,0xbf,0x5b,0x73,0x78,0xb5,0xc5,0xf9,0xc3);


MIDL_DEFINE_GUID(IID, DIID__DDDPIActiveX,0xfff12b99,0x09e3,0x468f,0x90,0xe9,0x41,0xe1,0x12,0x26,0x46,0xe2);


MIDL_DEFINE_GUID(IID, DIID__DDDPIActiveXEvents,0x780478ee,0x97ef,0x479f,0xb2,0x69,0x4b,0x22,0xb9,0x6f,0x0f,0x33);


MIDL_DEFINE_GUID(CLSID, CLSID_DDPIActiveX,0x253a1346,0x9adb,0x4781,0xbe,0xaf,0xf6,0xcf,0x24,0xcb,0x2e,0xd1);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif




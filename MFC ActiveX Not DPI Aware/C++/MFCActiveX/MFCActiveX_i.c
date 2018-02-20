

/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


 /* File created by MIDL compiler version 8.01.0622 */
/* at Mon Jan 18 19:14:07 2038
 */
/* Compiler settings for MFCActiveX.idl:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 8.01.0622 
    protocol : dce , ms_ext, c_ext, robust
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

MIDL_DEFINE_GUID(IID, LIBID_MFCActiveXLib,0xA2CDD4E5,0xA26B,0x4B01,0xA1,0x6C,0x96,0x86,0x0F,0xC0,0xAB,0x36);


MIDL_DEFINE_GUID(IID, DIID__DMFCActiveX,0x251469CA,0x9D65,0x4EFD,0x90,0xD8,0x83,0x2D,0xDF,0x2A,0xA6,0xBA);


MIDL_DEFINE_GUID(IID, DIID__DMFCActiveXEvents,0x34AC21AC,0x69CA,0x4358,0xA5,0x50,0x38,0x52,0xD8,0x01,0xEB,0x32);


MIDL_DEFINE_GUID(CLSID, CLSID_MFCActiveX,0x19915CE1,0x0EF5,0x45F5,0x86,0x61,0x7A,0xC6,0xD2,0xFE,0x79,0xE9);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif






/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


 /* File created by MIDL compiler version 8.01.0622 */
/* at Mon Jan 18 19:14:07 2038
 */
/* Compiler settings for ODActiveX.idl:
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

MIDL_DEFINE_GUID(IID, LIBID_ODActiveXLib,0x8007A0C4,0x12BA,0x44FF,0xA2,0x75,0xDA,0xE8,0x1D,0x2F,0xE5,0x4D);


MIDL_DEFINE_GUID(IID, DIID__DODActiveX,0x79F0A437,0xA95A,0x4B96,0xA9,0x5E,0x2E,0x84,0x00,0x6F,0x8F,0x93);


MIDL_DEFINE_GUID(IID, DIID__DODActiveXEvents,0xF3EE2BA1,0x0CC2,0x4B96,0xA1,0x33,0x05,0x4F,0x6A,0x26,0x05,0xB5);


MIDL_DEFINE_GUID(CLSID, CLSID_ODActiveX,0xDC5950E1,0x9A17,0x4D9E,0xB8,0x13,0x7D,0x7B,0xFA,0xE7,0xCE,0x7E);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif






/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


 /* File created by MIDL compiler version 8.01.0622 */
/* at Mon Jan 18 19:14:07 2038
 */
/* Compiler settings for AddIn.idl:
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

MIDL_DEFINE_GUID(IID, IID_IATLControl,0x0ad3222c,0x0454,0x400e,0xab,0xde,0x47,0xf3,0x10,0x1f,0x51,0xdf);


MIDL_DEFINE_GUID(IID, LIBID_COMAddinCPPLib,0x7B2B42E3,0xBA6D,0x41FE,0x97,0xA9,0x94,0xF4,0x73,0xC1,0xB2,0xA6);


MIDL_DEFINE_GUID(CLSID, CLSID_Connect,0x9B8BAEF3,0x92D8,0x4A34,0xBB,0xAE,0x31,0x59,0x85,0x7D,0x1A,0xDD);


MIDL_DEFINE_GUID(CLSID, CLSID_ATLControl,0xa8fe7cbc,0x49c4,0x402f,0x97,0xcc,0x75,0x4f,0x0f,0x89,0x56,0xdf);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif




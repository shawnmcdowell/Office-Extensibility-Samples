

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

MIDL_DEFINE_GUID(IID, LIBID_MFCActiveXLib,0xDFFC673C,0xE5FE,0x4D0D,0x99,0xCA,0x6F,0xB4,0xBD,0xCF,0x0A,0x50);


MIDL_DEFINE_GUID(IID, DIID__DMFCActiveX,0x0327DD42,0x7A9E,0x415B,0xB9,0xA0,0x4A,0xEE,0xE1,0xA3,0x31,0x9E);


MIDL_DEFINE_GUID(IID, DIID__DMFCActiveXEvents,0x97B9B2F3,0xE95A,0x49D4,0xAC,0xA3,0xE2,0xA1,0x81,0x42,0x4F,0xD8);


MIDL_DEFINE_GUID(CLSID, CLSID_MFCActiveX,0xE389AD6C,0x4FB6,0x47AF,0xB0,0x3A,0xA5,0xA5,0xC6,0xB2,0xB8,0x20);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif






/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


 /* File created by MIDL compiler version 7.00.0500 */
/* at Tue May 03 19:10:48 2011
 */
/* Compiler settings for .\ETTCashActiveX.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
//@@MIDL_FILE_HEADING(  )

#pragma warning( disable: 4049 )  /* more than 64k source lines */


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
        const type name = {l,w1,w2,{b1,b2,b3,b4,b5,b6,b7,b8}}

#endif !_MIDL_USE_GUIDDEF_

MIDL_DEFINE_GUID(IID, LIBID_ETTCashActiveXLib,0x9E410F6F,0xED28,0x4279,0xA3,0x7A,0x5E,0x70,0xE6,0x87,0x71,0xA1);


MIDL_DEFINE_GUID(IID, DIID__DETTCashActiveX,0x9DF7813F,0x13B1,0x4CFC,0xB0,0xD1,0x51,0x89,0x40,0x95,0xE6,0x2D);


MIDL_DEFINE_GUID(IID, DIID__DETTCashActiveXEvents,0xD026003A,0x10F7,0x44DF,0xA3,0x1D,0xA9,0x3A,0x64,0xA7,0xA7,0x3F);


MIDL_DEFINE_GUID(CLSID, CLSID_ETTCashActiveX,0x52857B7E,0x9AEB,0x4273,0xB6,0x57,0x46,0x41,0xF5,0x4D,0xB1,0x79);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif




// ETTCashActiveX.cpp : CETTCashActiveXApp �� DLL ע���ʵ�֡�

#include "stdafx.h"
#include "ETTCashActiveX.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


CETTCashActiveXApp theApp;

const GUID CDECL BASED_CODE _tlid =
		{ 0x9E410F6F, 0xED28, 0x4279, { 0xA3, 0x7A, 0x5E, 0x70, 0xE6, 0x87, 0x71, 0xA1 } };
const WORD _wVerMajor = 1;
const WORD _wVerMinor = 0;



// CETTCashActiveXApp::InitInstance - DLL ��ʼ��

BOOL CETTCashActiveXApp::InitInstance()
{
	BOOL bInit = COleControlModule::InitInstance();

	if (bInit)
	{
		// TODO: �ڴ��������Լ���ģ���ʼ�����롣
	}

	return bInit;
}



// CETTCashActiveXApp::ExitInstance - DLL ��ֹ

int CETTCashActiveXApp::ExitInstance()
{
	// TODO: �ڴ��������Լ���ģ����ֹ���롣

	return COleControlModule::ExitInstance();
}



// DllRegisterServer - �������ӵ�ϵͳע���

STDAPI DllRegisterServer(void)
{
	AFX_MANAGE_STATE(_afxModuleAddrThis);

	if (!AfxOleRegisterTypeLib(AfxGetInstanceHandle(), _tlid))
		return ResultFromScode(SELFREG_E_TYPELIB);

	if (!COleObjectFactoryEx::UpdateRegistryAll(TRUE))
		return ResultFromScode(SELFREG_E_CLASS);

	return NOERROR;
}



// DllUnregisterServer - �����ϵͳע������Ƴ�

STDAPI DllUnregisterServer(void)
{
	AFX_MANAGE_STATE(_afxModuleAddrThis);

	if (!AfxOleUnregisterTypeLib(_tlid, _wVerMajor, _wVerMinor))
		return ResultFromScode(SELFREG_E_TYPELIB);

	if (!COleObjectFactoryEx::UpdateRegistryAll(FALSE))
		return ResultFromScode(SELFREG_E_CLASS);

	return NOERROR;
}
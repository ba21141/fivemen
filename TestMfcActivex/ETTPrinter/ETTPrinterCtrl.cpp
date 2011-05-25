// ETTPrintActiveXCtrl.cpp : CETTPrinterCtrl ActiveX �ؼ����ʵ�֡�

#include "stdafx.h"
#include "ETTPrinter.h"
#include "ETTPrinterCtrl.h"
#include "ETTPrinterPropPage.h"


#ifdef _DEBUG
#define new DEBUG_NEW
#endif


IMPLEMENT_DYNCREATE(CETTPrinterCtrl, COleControl)

BEGIN_INTERFACE_MAP(   CETTPrinterCtrl,   COleControl   ) 
	INTERFACE_PART(CETTPrinterCtrl,   IID_IObjectSafety,   ObjSafe) 
END_INTERFACE_MAP() 

///////////////////////////////////////////////////////////////////////////// 
//   IObjectSafety   member   functions 

//   Delegate   AddRef,   Release,   QueryInterface 

ULONG   FAR   EXPORT   CETTPrinterCtrl::XObjSafe::AddRef() 
{ 
	METHOD_PROLOGUE(CETTPrinterCtrl,   ObjSafe) 
		return   pThis-> ExternalAddRef(); 
} 

ULONG   FAR   EXPORT   CETTPrinterCtrl::XObjSafe::Release() 
{ 
	METHOD_PROLOGUE(CETTPrinterCtrl,   ObjSafe) 
		return   pThis-> ExternalRelease(); 
} 

HRESULT   FAR   EXPORT   CETTPrinterCtrl::XObjSafe::QueryInterface( 
	REFIID   iid,   void   FAR*   FAR*   ppvObj) 
{ 
	METHOD_PROLOGUE(CETTPrinterCtrl,   ObjSafe) 
		return   (HRESULT)pThis-> ExternalQueryInterface(&iid,   ppvObj); 
} 

const   DWORD   dwSupportedBits   =   
INTERFACESAFE_FOR_UNTRUSTED_CALLER   | 
INTERFACESAFE_FOR_UNTRUSTED_DATA; 
const   DWORD   dwNotSupportedBits   =   ~   dwSupportedBits; 

///////////////////////////////////////////////////////////////////////////// 
//   CStopLiteCtrl::XObjSafe::GetInterfaceSafetyOptions 
//   Allows   container   to   query   what   interfaces   are   safe   for   what.   We 're 
//   optimizing   significantly   by   ignoring   which   interface   the   caller   is 
//   asking   for. 
HRESULT   STDMETHODCALLTYPE   
CETTPrinterCtrl::XObjSafe::GetInterfaceSafetyOptions(   
	/*   [in]   */   REFIID   riid, 
	/*   [out]   */   DWORD   __RPC_FAR   *pdwSupportedOptions, 
	/*   [out]   */   DWORD   __RPC_FAR   *pdwEnabledOptions) 
{ 
	METHOD_PROLOGUE(CETTPrinterCtrl,   ObjSafe) 

		HRESULT   retval   =   ResultFromScode(S_OK); 

	//   does   interface   exist? 
	IUnknown   FAR*   punkInterface; 
	retval   =   pThis-> ExternalQueryInterface(&riid,   
		(void   *   *)&punkInterface); 
	if   (retval   !=   E_NOINTERFACE)   { //   interface   exists 
		punkInterface-> Release();   //   release   it--just   checking! 
	} 

	//   we   support   both   kinds   of   safety   and   have   always   both   set, 
	//   regardless   of   interface 
	*pdwSupportedOptions   =   *pdwEnabledOptions   =   dwSupportedBits; 

	return   retval;   //   E_NOINTERFACE   if   QI   failed 
} 

///////////////////////////////////////////////////////////////////////////// 
//   CStopLiteCtrl::XObjSafe::SetInterfaceSafetyOptions 
//   Since   we 're   always   safe,   this   is   a   no-brainer--but   we   do   check   to   make 
//   sure   the   interface   requested   exists   and   that   the   options   we 're   asked   to 
//   set   exist   and   are   set   on   (we   don 't   support   unsafe   mode). 
HRESULT   STDMETHODCALLTYPE   
CETTPrinterCtrl::XObjSafe::SetInterfaceSafetyOptions(   
	/*   [in]   */   REFIID   riid, 
	/*   [in]   */   DWORD   dwOptionSetMask, 
	/*   [in]   */   DWORD   dwEnabledOptions) 
{ 
	METHOD_PROLOGUE(CETTPrinterCtrl,   ObjSafe) 

		//   does   interface   exist? 
		IUnknown   FAR*   punkInterface; 
	pThis-> ExternalQueryInterface(&riid,   (void   *   *)&punkInterface); 
	if   (punkInterface)   { //   interface   exists 
		punkInterface-> Release();   //   release   it--just   checking! 
	} 
	else   {   //   interface   doesn 't   exist 
		return   ResultFromScode(E_NOINTERFACE); 
	} 

	//   can 't   set   bits   we   don 't   support 
	if   (dwOptionSetMask   &   dwNotSupportedBits)   {   
		return   ResultFromScode(E_FAIL); 
	} 

	//   can 't   set   bits   we   do   support   to   zero 
	dwEnabledOptions   &=   dwSupportedBits; 
	//   (we   already   know   there   are   no   extra   bits   in   mask   ) 
	if   ((dwOptionSetMask   &   dwEnabledOptions)   != 
		dwOptionSetMask)   { 
			return   ResultFromScode(E_FAIL); 
	} 

	//   don 't   need   to   change   anything   since   we 're   always   safe 
	return   ResultFromScode(S_OK); 
}


// ��Ϣӳ��

BEGIN_MESSAGE_MAP(CETTPrinterCtrl, COleControl)
	ON_OLEVERB(AFX_IDS_VERB_PROPERTIES, OnProperties)
END_MESSAGE_MAP()



// ����ӳ��

BEGIN_DISPATCH_MAP(CETTPrinterCtrl, COleControl)
END_DISPATCH_MAP()



// �¼�ӳ��

BEGIN_EVENT_MAP(CETTPrinterCtrl, COleControl)
END_EVENT_MAP()



// ����ҳ

// TODO: ����Ҫ���Ӹ�������ҳ�����ס���Ӽ���!
BEGIN_PROPPAGEIDS(CETTPrinterCtrl, 1)
PROPPAGEID(CETTPrinterPropPage::guid)
END_PROPPAGEIDS(CETTPrinterCtrl)



// ��ʼ���๤���� guid

IMPLEMENT_OLECREATE_EX(CETTPrinterCtrl, "ETTPRINTACTIVEX.ETTPrintActiveXCtrl.1",
					   0x7f2485d, 0x2a40, 0x44b2, 0x90, 0, 0x4, 0xf9, 0x2e, 0xb8, 0xf9, 0x6a)



					   // ����� ID �Ͱ汾

					   IMPLEMENT_OLETYPELIB(CETTPrinterCtrl, _tlid, _wVerMajor, _wVerMinor)



					   // �ӿ� ID

					   const IID BASED_CODE IID_DETTPrintActiveX =
{ 0xA94C9160, 0x7DD0, 0x4C29, { 0xA4, 0x70, 0x1B, 0x21, 0x8E, 0x38, 0x8B, 0xC } };
const IID BASED_CODE IID_DETTPrintActiveXEvents =
{ 0x3F019042, 0xB4D1, 0x4BA1, { 0xAF, 0x88, 0x74, 0xB8, 0xB5, 0x61, 0x72, 0xDF } };



// �ؼ�������Ϣ

static const DWORD BASED_CODE _dwETTPrintActiveXOleMisc =
OLEMISC_SETCLIENTSITEFIRST |
OLEMISC_INSIDEOUT |
OLEMISC_CANTLINKINSIDE |
OLEMISC_RECOMPOSEONRESIZE;

IMPLEMENT_OLECTLTYPE(CETTPrinterCtrl, IDS_ETTPRINTER, _dwETTPrintActiveXOleMisc)



// CETTPrinterCtrl::CETTPrinterCtrlFactory::UpdateRegistry -
// ���ӻ��Ƴ� CETTPrinterCtrl ��ϵͳע�����

BOOL CETTPrinterCtrl::CETTPrinterCtrlFactory::UpdateRegistry(BOOL bRegister)
{
	// TODO: ��֤���Ŀؼ��Ƿ���ϵ�Ԫģ���̴߳�������
	// �йظ�����Ϣ����ο� MFC ����˵�� 64��
	// ������Ŀؼ������ϵ�Ԫģ�͹�����
	// �����޸����´��룬��������������
	// afxRegApartmentThreading ��Ϊ 0��

	if (bRegister)
		return AfxOleRegisterControlClass(
		AfxGetInstanceHandle(),
		m_clsid,
		m_lpszProgID,
		IDS_ETTPRINTER,
		IDB_ETTPRINTER,
		afxRegApartmentThreading,
		_dwETTPrintActiveXOleMisc,
		_tlid,
		_wVerMajor,
		_wVerMinor);
	else
		return AfxOleUnregisterClass(m_clsid, m_lpszProgID);
}



// CETTPrinterCtrl::CETTPrinterCtrl - ���캯��

CETTPrinterCtrl::CETTPrinterCtrl()
: m_CQPrint(0)
{
	InitializeIIDs(&IID_DETTPrintActiveX, &IID_DETTPrintActiveXEvents);
	// TODO: �ڴ˳�ʼ���ؼ���ʵ�����ݡ�
}



// CETTPrinterCtrl::~CETTPrinterCtrl - ��������

CETTPrinterCtrl::~CETTPrinterCtrl()
{
	// TODO: �ڴ������ؼ���ʵ�����ݡ�
}



// CETTPrinterCtrl::OnDraw - ��ͼ����

void CETTPrinterCtrl::OnDraw(
								  CDC* pdc, const CRect& rcBounds, const CRect& rcInvalid)
{
	if (!pdc)
		return;

	// TODO: �����Լ��Ļ�ͼ�����滻����Ĵ��롣
	pdc->FillRect(rcBounds, CBrush::FromHandle((HBRUSH)GetStockObject(WHITE_BRUSH)));
	pdc->Ellipse(rcBounds);

	if (!IsOptimizedDraw())
	{
		// ������֧���Ż���ͼ��

		// TODO: ������κ� GDI ����ѡ�뵽�豸������ *pdc �У�
		//		���ڴ˴��ָ���ǰѡ���Ķ���
	}
}



// CETTPrinterCtrl::DoPropExchange - �־���֧��

void CETTPrinterCtrl::DoPropExchange(CPropExchange* pPX)
{
	ExchangeVersion(pPX, MAKELONG(_wVerMinor, _wVerMajor));
	COleControl::DoPropExchange(pPX);

	// TODO: Ϊÿ���־õ��Զ������Ե��� PX_ ������
}



// CETTPrinterCtrl::GetControlFlags -
// �Զ��� MFC �� ActiveX �ؼ�ʵ�ֵı�־��
//
DWORD CETTPrinterCtrl::GetControlFlags()
{
	DWORD dwFlags = COleControl::GetControlFlags();


	// ���ô������ڼ��ɼ���ؼ���
	// TODO: ��д�ؼ�����Ϣ��������ʱ����ʹ��
	//		m_hWnd ��Ա����֮ǰӦ���ȼ������ֵ�Ƿ�
	//		�� null��
	dwFlags |= windowlessActivate;

	// �ؼ�ͨ������ԭ�豸�������е�
	// ԭʼ GDI ���󣬿����Ż����� OnDraw ������
	dwFlags |= canOptimizeDraw;
	return dwFlags;
}



// CETTPrinterCtrl::OnResetState - ���ؼ�����ΪĬ��״̬

void CETTPrinterCtrl::OnResetState()
{
	COleControl::OnResetState();  // ���� DoPropExchange ���ҵ���Ĭ��ֵ

	// TODO: �ڴ��������������ؼ�״̬��
}



// ����������ƾ֤��ӡ

int CETTPrinterCtrl::CarAcceptPrint(void)
{
	AfxMessageBox((LPCTSTR)"��ʾ��Ϣ",0,0);
	//this->m_CQPrint=new CQPrint();
	//m_CQPrint->Dialog("�ҵĴ�ӡ�ĵ���",1);
	return 0;
}
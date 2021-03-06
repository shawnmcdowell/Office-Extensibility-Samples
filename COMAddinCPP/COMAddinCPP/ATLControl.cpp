// ATLControl.cpp : Implementation of CATLControl
#include "stdafx.h"
#include "ATLControl.h"
#include <sstream>

using namespace std;

HRESULT CATLControl::OnLButtonDown(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{
	HRESULT hr = S_OK;
	bHandled = true;

	ostringstream stringStream;
	stringStream << "LButtonDown (" << GET_X_LPARAM(lParam) << "," << GET_Y_LPARAM(lParam) << ")" << endl;
	m_text = stringStream.str();
	Invalidate();
	UpdateWindow();
	return hr;
}

// CATLControl
HRESULT CATLControl::OnDraw(ATL_DRAWINFO& di)
{
	RECT& rc = *(RECT*)di.prcBounds;
	// Set Clip region to the rectangle specified by di.prcBounds
	HRGN hRgnOld = NULL;
	if (GetClipRgn(di.hdcDraw, hRgnOld) != 1)
		hRgnOld = NULL;
	bool bSelectOldRgn = false;

	HRGN hRgnNew = CreateRectRgn(rc.left, rc.top, rc.right, rc.bottom);

	if (hRgnNew != NULL)
	{
		bSelectOldRgn = (SelectClipRgn(di.hdcDraw, hRgnNew) != ERROR);
	}

	Rectangle(di.hdcDraw, rc.left, rc.top, rc.right, rc.bottom);

	// SetTextAlign(di.hdcDraw, TA_CENTER | TA_BASELINE);
	ostringstream ossRc;
	ossRc << "Rect (" << rc.left << "," << rc.top << "," << rc.right << "," << rc.bottom << ")" << endl << m_text << ends;
	string outString = ossRc.str();
	LPCSTR pcstrText = outString.c_str();


	SetTextColor(di.hdcDraw, 0x00000000);

#ifndef _WIN32_WCE
	RECT rcText = { 0 };
	SetRect(&rcText, rc.left + 5, rc.top + 20, rc.right - 5, rc.bottom - 5);
	int height = DrawText(di.hdcDraw, pcstrText, strlen(pcstrText), &rcText, DT_CALCRECT | DT_CENTER | DT_EXTERNALLEADING | DT_WORDBREAK);
	// (rc.top + rc.bottom - height) / 2
	SetRect(&rcText, rc.left + 5, (rc.top + rc.bottom - height) / 2, rc.right - 5, rc.bottom - 5);
	//DT_EXTERNALLEADING | DT_WORDBREAK
	DrawText(di.hdcDraw, pcstrText, strlen(pcstrText), &rcText,  DT_CENTER | DT_EXTERNALLEADING | DT_WORDBREAK);

	//TextOut(di.hdcDraw,
	//	(rc.left + rc.right) / 2,
	//	(rc.top + rc.bottom) / 2,
	//	pcstrText,
	//	lstrlen(pcstrText));
#else
	ExtTextOut(di.hdcDraw,
		(rc.left + rc.right) / 2,
		(rc.top + rc.bottom) / 2,
		ETO_OPAQUE,
		NULL,
		m_pszText,
		ATL::lstrlen(m_pszText),
		NULL);
#endif

	if (bSelectOldRgn)
		SelectClipRgn(di.hdcDraw, hRgnOld);

	DeleteObject(hRgnNew);

	return S_OK;
}

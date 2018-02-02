MFCApplicationDPIAware – MFC App that host 2 ActiveX controls and it’s DDPI Aware
Window Based ActiveX – MFC Window based ActiveX that supports DDPI on WM_SIZE event at this moment (tested with App and Office - works fine)
Windowless ActiveX – MFC Windowless ActiveX that supports DDPI on WM_PAINT (it gets HWND of host window from HDC and after it cat get DPI form it, works well in Office and our test App – just requiring that control should be invalidated while WM_DPICHANGE event occurs)

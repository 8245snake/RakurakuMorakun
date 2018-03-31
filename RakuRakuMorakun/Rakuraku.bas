Attribute VB_Name = "WinApi"
Option Explicit

Declare Sub Sleep Lib "kernel32" (ByVal ms As Long)

Declare Function FindWindow Lib "user32" Alias "FindWindowA" _
            (ByVal lpClassName As String, ByVal lpWindowName As String) As Long

Declare Function FindWindowEx Lib "user32.dll" Alias "FindWindowExA" _
    (ByVal hWndParent As Long, ByVal hwndChildAfter As Long, _
     ByVal lpClassName As String, ByVal lpWindowName As String) As Long

Declare Function GetClassName Lib "user32" Alias "GetClassNameA" _
    (ByVal hWnd As Long, ByVal lpClassName As String, ByVal nMaxCount As Long) As Long

Declare Function EnumChildWindows Lib "user32" (ByVal hWndParent As Long, ByVal lpEnumFunc As Long, ByVal lParam As Long) As Long

Declare Function SendMessage Lib "user32.dll" _
    Alias "SendMessageA" _
   (ByVal hWnd As Long, _
    ByVal Msg As Long, _
    ByVal wParam As Long, _
    ByVal lParam As String) As Long

Declare Function SendMessageAny Lib "user32.dll" _
    Alias "SendMessageA" _
   (ByVal hWnd As Long, _
    ByVal Msg As Long, _
    ByVal wParam As Long, _
    ByVal lParam As Any) As Long
    
Public Declare Function SetForegroundWindow Lib "user32" (ByVal hWnd As Long) As Long

Public Const WM_SETTEXT = &HC       '文字列送信
Public Const WM_LBUTTONDOWN = &H201
Public Const WM_LBUTTONUP = &H202
Public Const BM_CLICK = &HF5

Private CstClassNamesArr(200) As String  '200件まで
Private ClWndArr(200) As Long  '200件まで
Private ClWndCount As Long


Public Sub SentTextToRakurakumourakun()
    Dim lPocess As Long
    Dim lParent As Long
    Dim lChild As Long
    
    '既に開いているらくらく網羅くんを探す
    lParent = FindWindow(vbNullString, "らくらく網羅くんV2")
    
    '開いてなかったら起動する。起動に失敗したら終了。
    If lParent = 0 Then
        lPocess = StartProcess("moura")
        If lPocess = 0 Then
            Call MsgBox("らくらく網羅くんの起動に失敗しました。パスが通っているか確認してください。")
            GoTo LBL_END
        End If
        Call Sleep(2000)
        lParent = FindWindow(vbNullString, "らくらく網羅くんV2")
    End If
    
    Dim c As Range
    Set c = Selection
    
    '隠しテキストボックスにセルの文字列を送る
    lChild = FindWindowByClassName(lParent, "EDIT", 3)
    Call SendMessageAny(lChild, WM_SETTEXT, 0, CStr(c.Value))
    
    Call SetForegroundWindow(lParent)

    '隠しボタンを押す
    lChild = FindWindowByClassName(lParent, "BUTTON", 14)
    Call SendMessage(lChild, BM_CLICK, 0, 0)
    
    
LBL_ERROR:

LBL_END:

End Sub


'親ウィンドウ配下からクラス名で検索したn番目のハンドルを返す
Private Function FindWindowByClassName(ByVal hWndParent As Long, ByVal stClassName As String, nTargetIndex As Integer) As Long

    Dim nCount As Integer
    Dim nI As Integer
    Dim lRtn As Long
    Dim stTargetClassName As String
    
    ClWndCount = 0
    
    On Error Resume Next
    lRtn = EnumChildWindows(hWndParent, AddressOf EnumChildProc, 0)
    On Error GoTo LBL_ERROR
    
    
    For nI = 0 To UBound(CstClassNamesArr)
        If InStr(CstClassNamesArr(nI), stClassName) > 0 Then
            nCount = nCount + 1
            If nCount = nTargetIndex Then
                lRtn = ClWndArr(nI)
                GoTo LBL_END
            End If
        End If
    Next nI
    
LBL_ERROR:
    lRtn = 0
LBL_END:
    FindWindowByClassName = lRtn
End Function


'EnumChildWindowsのコールバック関数
Public Function EnumChildProc(ByVal hWnd As Long) As Long
    Dim lRtn As Long
    Dim stClassNameBuff As String
    stClassNameBuff = String(255, vbNullChar)
    
    lRtn = GetClassName(hWnd, stClassNameBuff, 255)
    
    If lRtn <> 0 Then
        CstClassNamesArr(ClWndCount) = ConvertStr(stClassNameBuff)
        ClWndArr(ClWndCount) = hWnd
        ClWndCount = ClWndCount + 1
    End If

    EnumChildProc = 1
End Function

'末端のNullを除く
Private Function ConvertStr(ByVal stText As String) As String
    If Len(stText) < 1 Then
        ConvertStr = ""
        Exit Function
    End If
    
    ConvertStr = Left(stText, InStr(stText, vbNullChar) - 1)
End Function

'コマンド実行
Private Function StartProcess(ByVal stCommand As String) As Long
    Dim lRtn As Long
    On Error GoTo LBL_ERROR
    
    lRtn = Shell(stCommand) '起動
    GoTo LBL_END
    
LBL_ERROR:
    lRtn = 0
LBL_END:
    StartProcess = lRtn
End Function

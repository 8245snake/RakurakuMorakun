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

Public Const WM_SETTEXT = &HC       '�����񑗐M
Public Const WM_LBUTTONDOWN = &H201
Public Const WM_LBUTTONUP = &H202
Public Const BM_CLICK = &HF5

Private CstClassNamesArr(200) As String  '200���܂�
Private ClWndArr(200) As Long  '200���܂�
Private ClWndCount As Long


Public Sub SentTextToRakurakumourakun()
    Dim lPocess As Long
    Dim lParent As Long
    Dim lChild As Long
    
    '���ɊJ���Ă���炭�炭�ԗ������T��
    lParent = FindWindow(vbNullString, "�炭�炭�ԗ�����V2")
    
    '�J���ĂȂ�������N������B�N���Ɏ��s������I���B
    If lParent = 0 Then
        lPocess = StartProcess("moura")
        If lPocess = 0 Then
            Call MsgBox("�炭�炭�ԗ�����̋N���Ɏ��s���܂����B�p�X���ʂ��Ă��邩�m�F���Ă��������B")
            GoTo LBL_END
        End If
        Call Sleep(2000)
        lParent = FindWindow(vbNullString, "�炭�炭�ԗ�����V2")
    End If
    
    Dim c As Range
    Set c = Selection
    
    '�B���e�L�X�g�{�b�N�X�ɃZ���̕�����𑗂�
    lChild = FindWindowByClassName(lParent, "EDIT", 3)
    Call SendMessageAny(lChild, WM_SETTEXT, 0, CStr(c.Value))
    
    Call SetForegroundWindow(lParent)

    '�B���{�^��������
    lChild = FindWindowByClassName(lParent, "BUTTON", 14)
    Call SendMessage(lChild, BM_CLICK, 0, 0)
    
    
LBL_ERROR:

LBL_END:

End Sub


'�e�E�B���h�E�z������N���X���Ō�������n�Ԗڂ̃n���h����Ԃ�
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


'EnumChildWindows�̃R�[���o�b�N�֐�
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

'���[��Null������
Private Function ConvertStr(ByVal stText As String) As String
    If Len(stText) < 1 Then
        ConvertStr = ""
        Exit Function
    End If
    
    ConvertStr = Left(stText, InStr(stText, vbNullChar) - 1)
End Function

'�R�}���h���s
Private Function StartProcess(ByVal stCommand As String) As Long
    Dim lRtn As Long
    On Error GoTo LBL_ERROR
    
    lRtn = Shell(stCommand) '�N��
    GoTo LBL_END
    
LBL_ERROR:
    lRtn = 0
LBL_END:
    StartProcess = lRtn
End Function

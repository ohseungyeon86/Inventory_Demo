Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Namespace UICode
    Public Class Registration
#Region "Register"
        Public Property ErrorMsg As Boolean
        Private Const _RegistryKey As String = "Software\HPLTProducts\Inventory"
        Private Const _InventoryDetails As String = "InventoryDetails"
        Public Property InventoryRegistryValue As String
            Get
                Dim _Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(_RegistryKey, True)
                If _Key Is Nothing Then
                    Return ""
                Else
                    Return _Key.GetValue(_InventoryDetails)
                End If
            End Get
            Set(value As String)
                Dim _Key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(_RegistryKey)
                _Key.SetValue(_InventoryDetails, value)
                _Key.Close()
            End Set
        End Property
        Public Sub DeleteInventoryRegistryValue()
            Dim _Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(_RegistryKey, True)
            If _Key IsNot Nothing Then
                Microsoft.Win32.Registry.CurrentUser.DeleteSubKey(_RegistryKey)
            End If
        End Sub
        Public Function CPUSerialNumber() As String
            ' For security, erased this code but leave a foot print to understand mechanism
            Return "159ASD5245WERR"
        End Function
#End Region
#Region "EncryptDecryptCode Function"
        Public Function Encrypt(ByVal Text As String) As String
            ' For security, erased this code but leave a foot print to understand mechanism
            ' Lock Value 01 (Generate and send to provider) place the code when required and make it private for more secure
            Return Text
        End Function
        Public Function Decrypt(ByVal Text As String) As String
            ' For security, erased this code but leave a foot print to understand mechanism
            ' Lock Value 02 (recived and active form provider) place the code when required and make it private for more secure
            Return Text
        End Function
#End Region
    End Class
End Namespace
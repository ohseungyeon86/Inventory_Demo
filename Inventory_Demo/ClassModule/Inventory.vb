Option Explicit On
Imports System.IO
Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Namespace UICode
    Public Class EncryptDecrypt
        Public MsgBoxPopup As Boolean = True
        Public Function Encrypt(ByVal Text As String) As String
            ' For security, erased this code but leave a foot print to understand mechanism
            Return Text
        End Function
        Public Function Decrypt(ByVal Text As String) As String
            ' For security, erased this code but leave a foot print to understand mechanism
            Return Text
        End Function
    End Class
    Public Class Feature
        '사이즈 설정
        Public Sub SizeLock(ByVal SizeLock As Boolean, ByVal Form As Form, ByVal FormTitle As String, ByVal UserControl As UserControl)
            Console.WriteLine("SizeLock")
            If SizeLock = True Then
                'sizelock이 true 일 경우 열리는 창의 사이즈 및 위치가 조정된다.
                '폼영역 - 클라이언트영역 - 유저컨트롤 영역
                Form.Width = Form.Width - Form.ClientSize.Width + UserControl.Width
                Form.Height = Form.Height - Form.ClientSize.Height + UserControl.Height
                '화면 가운데 정렬
                Form.Left = CType((Screen.PrimaryScreen.WorkingArea.Width - Form.Width) / 2, Integer)
                Form.Top = CType((Screen.PrimaryScreen.WorkingArea.Height - Form.Height) / 2, Integer)
                '폼영역 실선
                Form.FormBorderStyle = FormBorderStyle.FixedSingle
                '폼 타이틀
                Form.Text = FormTitle
                '창 미니멈, 맥시멈 불가
                Form.MinimizeBox = Not SizeLock
                Form.MaximizeBox = Not SizeLock
                '유저 컨트롤 사이즈를 클라이언트영역에 맞춰 사이즈를 조절한다.
                UserControl.Dock = DockStyle.Fill
            End If
        End Sub
        '메뉴 변경시 실행
        Public Sub PanelView(ByVal UserControl As UserControl, ByVal SizeLock As Boolean, ByVal Panel As Panel)
            Console.WriteLine("PanelView")
            '선택된 메뉴에 맞는 표시를 위해 판넬 설정
            '판넬에 컨트롤의 수가 1개이면 0번째 인덱스의 컨트롤을 삭제
            If Panel.Controls.Count = 1 Then Panel.Controls.RemoveAt(0)
            '사이즈록이 false면 유저컨트롤의 위치를 판넬의 가운데에 설정
            If SizeLock = False Then
                UserControl.Left = CType((Panel.Width - UserControl.Width) / 2, Integer)
                UserControl.Top = CType((Panel.Height - UserControl.Height) / 2, Integer)
            Else
                UserControl.Dock = DockStyle.Fill
            End If
            Panel.Controls.Add(UserControl)
        End Sub
        'NumberOfDays만큼 일수를 더함
        Public Function DaysToDate(ByVal CalculateDate As DateTime, ByVal NumberOfDays As Integer) As DateTime
            Return CalculateDate.AddDays(NumberOfDays).Date
        End Function
        '두 날짜의 시간간격
        Public Function TrailDaysLeft(ByVal installDate As DateTime, ByVal expaireDate As DateTime) As TimeSpan
            Return expaireDate.Subtract(installDate)
        End Function
        'TrailDays을 더블형식으로 더한 후 날짜형식으로 변환
        Public Function ExpaireDate(ByVal installDate As DateTime, ByVal TrailDays As Integer) As DateTime
            Return installDate.AddDays(CDbl(TrailDays)).Date
        End Function
        Public Function RandamKey(ByVal NumberOfDigit As Integer, ByVal KeyType As String) As String
            Dim chars As Char() = New Char(61) {}
            'case에 따라 chars 배열에 값을 설정
            Select Case KeyType.ToLower
                Case "number", "digit", "no", "num"
                    chars = "1234567890".ToCharArray()
                Case "word", "char", "Character", "alphabet"
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
                Case "mixed", "both"
                    chars = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
            End Select
            Dim data As Byte() = New Byte(0) {}
            Dim crypto As New RNGCryptoServiceProvider()
            '바이트 배열을 암호화
            crypto.GetNonZeroBytes(data)
            'NumberOfDigit - 1 크기의 바이트 배열
            data = New Byte(NumberOfDigit - 1) {}
            crypto.GetNonZeroBytes(data)
            '매개변수로 받은 NumberOfDigit크기의 StringBuilder
            Dim result As New StringBuilder(NumberOfDigit)
            For Each b As Byte In data
                ' chars배열의(b/chars.Length 의 나머지) 인덱스의 값을 result에 붙여준다.
                result.Append(chars(b Mod (chars.Length)))
            Next
            Return result.ToString()
        End Function
        'StringCase 첫번째 문자 대문자로 변환
        Public Function ProperCase(ByVal StringCase As String) As String
            Return StrConv(StringCase, VbStrConv.ProperCase)
        End Function
        '지정된 위치에 FileName이름의 이미지 파일 생성
        Public Function PngIcon(ByVal FileName As String) As Image
            Dim rtFilePath As String = Nothing
            rtFilePath = Application.StartupPath & "\Icons\" & FileName & ".png"
            If My.Computer.FileSystem.FileExists(rtFilePath) = True Then
                Return Image.FromFile(rtFilePath)
            Else
                Return Nothing
            End If
        End Function
        '지정된 위치에 FileName이름의 아이콘 생성
        Public Function FormIcon(ByVal FileName As String) As Icon
            Dim rtFilePath As String = Nothing
            rtFilePath = Application.StartupPath & "\Icons\" & FileName & ".ico"
            If My.Computer.FileSystem.FileExists(rtFilePath) = True Then
                Dim loadIcon As New Icon(rtFilePath)
                Return loadIcon
            Else
                Return Nothing
            End If
        End Function
        Public Sub DigitKeyPress(ByVal e As KeyPressEventArgs)
            '눌린 키가 enter, bcakspace, 숫자키 이외면 이벤트 처리
            If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End Sub
        Public Sub DecimalKeyPress(ByVal DisplayTextBox As TextBox, ByVal e As KeyPressEventArgs)
            '눌린 키가 backspace 이외이고 .
            If e.KeyChar <> ControlChars.Back Then
                '입력값에 .가 포함되어 있으면 숫자이외 키입력시 이벤트 캔슬
                If DisplayTextBox.Text.Contains(".") Then
                    e.Handled = Not (Char.IsDigit(e.KeyChar))
                Else
                    '숫자 입력이거나 . 입력일 경우 이벤트 캔슬
                    e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
                End If
            End If
        End Sub
        Public Sub DecimalLeave(ByVal TextBox As TextBox)
            'TextBox가 소수점 2자리까지 표시되도록 변환
            TextBox.Text = Format$(Val(TextBox.Text), "#0.00")
        End Sub
    End Class
    Namespace Database
        Public Class ConnectionString

            Public sqlString As String
            Public sqlDataTable As New DataTable
            Public Shared sqlConnectionString As String
            Public Shared sqlConnectionTest As New ADODB.Connection
            'sql실행 함수
            Public Function SQLQueryCommand(ByVal SQLQuery As String) As DataTable
                Console.WriteLine("SQLQueryCommand")

                Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                Dim sqlOleDbDataAdapter As New OleDbDataAdapter(SQLQuery, sqlOleDbConnection)
                Dim sqlOleDbCommandBuilder As New OleDbCommandBuilder(sqlOleDbDataAdapter)
                Try
                    'db커넥션 열기
                    sqlOleDbConnection.Open()
                    '데이터테이블 리셋
                    sqlDataTable.Reset()
                    'sql 실행결과 데이터테이블에 추가
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    Return sqlDataTable
                    sqlOleDbConnection.Close()
                Catch ex As Exception
                    sqlOleDbConnection.Close()
                    Return Nothing
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Function
        End Class
        Public Class BoundControls
            Inherits ConnectionString
            'TableName 테이블 select
            Public Sub BoundComboBox(ByVal ComboBoxName As ComboBox, ByVal TableName As String, ByVal DisplayMember As String, ByVal ValueMember As String)
                Console.WriteLine("BoundComboBox")
                Dim sqlDataTable As New DataTable
                Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM " + TableName, sqlOleDbConnection)
                Try
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    'select로 데이터 취득후 콤보박스 속성에 대입
                    With ComboBoxName
                        '데이터 소스 = sql 실행 후 취득한 데이터테이블을 설정
                        .DataSource = sqlDataTable
                        '표시할 명칭=매개변수로 받은 DisplayMember
                        .DisplayMember = DisplayMember
                        '매개변수 ValueMember(id값?)
                        .ValueMember = ValueMember
                        '선택항목인덱스 초기값으로 -1
                        .SelectedIndex = -1
                        '처음 설정되는 초기값
                        .Text = String.Empty
                    End With
                    sqlOleDbConnection.Close()
                Catch ex As Exception
                    sqlOleDbConnection.Close()
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Sub
        End Class
        Public Class RelationshipTable
            Inherits ConnectionString
            'FilterFieldName 칼럼의 값이 FilterPrimaryKey 인 행을 찾아, 해당행이 존재할 경우 삭제
            Public Sub Delete(ByVal TableName As String, ByVal FieldName As String, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                Console.WriteLine("Delete")
                Dim sqlDataTable As New DataTable
                Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM " & TableName & " WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                Try
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    'select 결과만큼 for문
                    For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                        sqlString = "DELETE FROM " & TableName & " WHERE " & FieldName & " = " & sqlDataTable.Rows(i).Item(0).ToString
                        'FieldName(id칼럼)=sqlDataTable.Rows(i).Item(0).ToString(해당 행의 id 값)을 찾아 SQLQueryCommand에서 데이터 삭제
                        SQLQueryCommand(sqlString)
                    Next
                    sqlOleDbConnection.Close()
                Catch ex As Exception
                    sqlOleDbConnection.Close()
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Sub
        End Class
        Public Class Inventory
            Public Class Login
                'Login메뉴
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Public Property Login_Id As String
                Public Property Login_Name As String
                Public Property Login_Password As String
                Public Property Login_Phone As String
                Public Property Login_Mail As String
                Public Property Login_Permission As String
                Public Sub Clear()
                    '변수를 빈문자열
                    Login_Id = String.Empty
                    Login_Name = String.Empty
                    Login_Password = String.Empty
                    Login_Phone = String.Empty
                    Login_Mail = String.Empty
                    Login_Permission = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_Login_Id As TextBox, ByVal Txt_Login_Name As TextBox, ByVal Txt_Login_Password As TextBox, ByVal Txt_Login_Phone As TextBox, ByVal Txt_Login_Mail As TextBox, ByVal Txt_Login_Permission As TextBox)
                    Clear()
                    '텍스트박스 입력란 클리어
                    Txt_Login_Id.Clear()
                    Txt_Login_Name.Clear()
                    Txt_Login_Password.Clear()
                    Txt_Login_Phone.Clear()
                    Txt_Login_Mail.Clear()
                    Txt_Login_Permission.Clear()
                End Sub
                ''문자열 ''로 변환 후 변수에 담기
                Public Sub Add(ByVal Txt_Login_Id As TextBox, ByVal Txt_Login_Name As TextBox, ByVal Txt_Login_Password As TextBox, ByVal Txt_Login_Phone As TextBox, ByVal Txt_Login_Mail As TextBox, ByVal Txt_Login_Permission As TextBox)

                    Login_Id = Txt_Login_Id.Text.Replace("'", "''")
                    Login_Name = Txt_Login_Name.Text.Replace("'", "''")
                    Login_Password = Txt_Login_Password.Text.Replace("'", "''")
                    Login_Phone = Txt_Login_Phone.Text.Replace("'", "''")
                    Login_Mail = Txt_Login_Mail.Text.Replace("'", "''")
                    Login_Permission = Txt_Login_Permission.Text.Replace("'", "''")

                End Sub
                'AutoID ture일경우(id칼럼에 따로 입력이 필요없는 경우) Login_Id 칼럼 제외하고 insert, false일 경우 Login_Id칼럼 포함 insert 실행
                Public Sub Save(ByVal AutoID As Boolean)
                    Console.WriteLine("Save")
                    Try
                        'Login_Id 칼럼 비포함 insert문
                        If AutoID = True Then
                            sqlString = "INSERT INTO Login (Login_Name,Login_Password,Login_Phone,Login_Mail,Login_Permission) VALUES ('" & Login_Name & "','" & Login_Password & "','" & Login_Phone & "','" & Login_Mail & "','" & Login_Permission & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'Login_Id 칼럼 포함 insert문
                            sqlString = "INSERT INTO Login (Login_Id,Login_Name,Login_Password,Login_Phone,Login_Mail,Login_Permission) VALUES ('" & Login_Id & "','" & Login_Name & "','" & Login_Password & "','" & Login_Phone & "','" & Login_Mail & "','" & Login_Permission & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Console.WriteLine("Update")
                    'AutoID ture일경우 Login_Id 제외 칼럼에 Update, false일 경우 Login_Id 포함 Update
                    Try
                        If AutoID = True Then
                            sqlString = "UPDATE Login SET Login_Name = '" & Login_Name & "',Login_Password = '" & Login_Password & "',Login_Phone = '" & Login_Phone & "',Login_Mail = '" & Login_Mail & "',Login_Permission = '" & Login_Permission & "' WHERE Login_Id = " & Login_Id
                            SQLQueryCommand(sqlString)
                        Else
                            sqlString = "UPDATE Login SET Login_Id = '" & Login_Id & "',Login_Name = '" & Login_Name & "',Login_Password = '" & Login_Password & "',Login_Phone = '" & Login_Phone & "',Login_Mail = '" & Login_Mail & "',Login_Permission = '" & Login_Permission & "' WHERE Login_Id = " & Login_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_Login_Id As TextBox, ByVal Txt_Login_Name As TextBox, ByVal Txt_Login_Password As TextBox, ByVal Txt_Login_Phone As TextBox, ByVal Txt_Login_Mail As TextBox, ByVal Txt_Login_Permission As TextBox) As Boolean
                    Console.WriteLine("IsTextBoxError")
                    '입력체크 에러 시 메세지 출력
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_Login_Id.Text) Then
                            'Txt_Login_Id 입력란 null이거나 빈칸일 경우, 포커스 설정 및 에러메세지
                            Txt_Login_Id.Focus()
                            MessageBox.Show("TextBox(Login_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_Login_Name.Text) Then
                        'Txt_Login_Name 입력란 null이거나 빈칸일 경우, 포커스 설정 및 에러메세지
                        Txt_Login_Name.Focus()
                        MessageBox.Show("TextBox(Login_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Login_Password.Text) Then
                        'Txt_Login_Password 입력란 null이거나 빈칸일 경우, 포커스 설정 및 에러메세지
                        Txt_Login_Password.Focus()
                        MessageBox.Show("TextBox(Login_Password) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Login_Phone.Text) Then
                        'Txt_Login_Phone 입력란 null이거나 빈칸일 경우, 포커스 설정 및 에러메세지
                        Txt_Login_Phone.Focus()
                        MessageBox.Show("TextBox(Login_Phone) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Login_Mail.Text) Then
                        'Txt_Login_Mail 입력란 null이거나 빈칸일 경우, 포커스 설정 및 에러메세지
                        Txt_Login_Mail.Focus()
                        MessageBox.Show("TextBox(Login_Mail) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Login_Permission.Text) Then
                        'Txt_Login_Permission 입력란 null이거나 빈칸일 경우, 포커스 설정 및 에러메세지
                        Txt_Login_Permission.Focus()
                        MessageBox.Show("TextBox(Login_Permission) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_Login_Id As TextBox, ByVal Txt_Login_Name As TextBox, ByVal Txt_Login_Password As TextBox, ByVal Txt_Login_Phone As TextBox, ByVal Txt_Login_Mail As TextBox, ByVal Txt_Login_Permission As TextBox)
                    '빈칸이나 null 존재시 서브 프로시저 종료
                    If IsTextBoxError(AutoID, Txt_Login_Id, Txt_Login_Name, Txt_Login_Password, Txt_Login_Phone, Txt_Login_Mail, Txt_Login_Permission) = True Then Exit Sub
                    '입력란 에러없으면 add함수 호출
                    Add(Txt_Login_Id, Txt_Login_Name, Txt_Login_Password, Txt_Login_Phone, Txt_Login_Mail, Txt_Login_Permission)
                    'Command add일 경우
                    If Command.ToLower.Equals("add") = True Then
                        'insert 함수 실행
                        Save(AutoID)
                        'insert 성공시 메세지 출력 및 입력란 클리어
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Login_Id, Txt_Login_Name, Txt_Login_Password, Txt_Login_Phone, Txt_Login_Mail, Txt_Login_Permission)
                        'Command edit 경우
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        'update 함수 실행
                        Update(AutoID)
                        'update 성공시 메세지 출력 및 입력란 클리어
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Login_Id, Txt_Login_Name, Txt_Login_Password, Txt_Login_Phone, Txt_Login_Mail, Txt_Login_Permission)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Console.WriteLine("Load")
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Login_Id칼럼에 매개변수 PrimaryKey 와 같은 행을 찾아 해당 데이터테이블을  변수에 대입
                            sqlString = "SELECT * FROM Login WHERE Login_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            Login_Id = sqlDataTable.Rows(0)("Login_Id").ToString
                            Login_Name = sqlDataTable.Rows(0)("Login_Name").ToString
                            Login_Password = sqlDataTable.Rows(0)("Login_Password").ToString
                            Login_Phone = sqlDataTable.Rows(0)("Login_Phone").ToString
                            Login_Mail = sqlDataTable.Rows(0)("Login_Mail").ToString
                            Login_Permission = sqlDataTable.Rows(0)("Login_Permission").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_Login_Id As TextBox, ByVal Txt_Login_Name As TextBox, ByVal Txt_Login_Password As TextBox, ByVal Txt_Login_Phone As TextBox, ByVal Txt_Login_Mail As TextBox, ByVal Txt_Login_Permission As TextBox)
                    Console.WriteLine("Load")
                    Try
                        '입력란에 데이터 숫자로 변환할 수 없으면 에러메세지
                        If Not IsNumeric(Txt_Login_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '조건에 따라 select해온 결과 변수에 대입 및 텍스트박스에 설정
                            sqlString = "SELECT * FROM Login WHERE Login_Id = " & Txt_Login_Id.Text
                            SQLQueryCommand(sqlString)
                            Login_Id = sqlDataTable.Rows(0)("Login_Id").ToString
                            Login_Name = sqlDataTable.Rows(0)("Login_Name").ToString
                            Login_Password = sqlDataTable.Rows(0)("Login_Password").ToString
                            Login_Phone = sqlDataTable.Rows(0)("Login_Phone").ToString
                            Login_Mail = sqlDataTable.Rows(0)("Login_Mail").ToString
                            Login_Permission = sqlDataTable.Rows(0)("Login_Permission").ToString
                            Txt_Login_Id.Text = Login_Id
                            Txt_Login_Name.Text = Login_Name
                            Txt_Login_Password.Text = Login_Password
                            Txt_Login_Phone.Text = Login_Phone
                            Txt_Login_Mail.Text = Login_Mail
                            Txt_Login_Permission.Text = Login_Permission
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Console.WriteLine("Delete")
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Login_Id칼럼에 매개변수 PrimaryKey 에 해당하는 데이터가 있을 경우 해당 행의 데이터를  삭제
                            sqlString = "DELETE FROM Login WHERE Login_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_Login_Id As TextBox, ByVal Txt_Login_Name As TextBox, ByVal Txt_Login_Password As TextBox, ByVal Txt_Login_Phone As TextBox, ByVal Txt_Login_Mail As TextBox, ByVal Txt_Login_Permission As TextBox)
                    Console.WriteLine("Delete")
                    Try
                        '텍스트박스에 입력된 값이 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_Login_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes선택시 텍스트박스에 입력된 값과 같은 값을 지닌 칼럼을 찾아 해당 행을 삭제. 
                            '텍스트박스 클리어 후 메시지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM Login WHERE Login_Id = " & Txt_Login_Id.Text
                                SQLQueryCommand(sqlString)
                                '입력란 클리어
                                Clear(Txt_Login_Id, Txt_Login_Name, Txt_Login_Password, Txt_Login_Phone, Txt_Login_Mail, Txt_Login_Permission)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Console.WriteLine("GetLastRecordId")
                    'Login테이블에 마지막 데이터 반환
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Login", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '테이블에서 전건 출력 후 0건이면 0리턴 행이 존재할 경우 마지막 행의 id값 리턴
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        '데이터가 있으면 마지막행 id를 integer로 리턴
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Console.WriteLine("GetTotalRecord")
                    'Login테이블 전체 데이터 수 리턴
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Login", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Console.WriteLine("DuplicateAlert")
                    Try
                        'Login 테이블에 FieldName 칼럼과 같은 값을 갖는 데이터가 있으면 에러 메세지
                        sqlString = "SELECT * FROM Login WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        '같은 값의 데이터가 존대하면
                        If sqlDataTable.Rows.Count > 0 Then
                            '포커스 설정 및 에러 메세지
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Console.WriteLine("ListError")
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Login", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '매개변수로 받은 FieldIndex보다 select한 데이터의 수가 같거나 많으면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '반복문으로BoundList에 담아주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                '첫번째 for문
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                    '이후엔 BoundList에 문자열 붙여주기
                                Else
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    Console.WriteLine("GetList")
                    '전체 리스트 리턴
                    ListError(FieldIndex)
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Console.WriteLine("BoundComboBox")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Login_Id, Login_Name FROM Login", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'ComboBox에 속성에 Login테이블 id, name 설정
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Login_Name"
                            .ValueMember = "Login_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Console.WriteLine("BoundDataGridView")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    'login 테이블에서 select
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Login_Id AS [LOGIN ID],Login_Name AS [LOGIN NAME],Login_Password AS [LOGIN PASSWORD],Login_Phone AS [LOGIN PHONE],Login_Mail AS [LOGIN MAIL],Login_Permission AS [LOGIN PERMISSION] FROM Login ORDER BY Login_Name", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            '행추가 옵션 false
                            .AllowUserToAddRows = False
                            '행삭제 옵션 false
                            .AllowUserToDeleteRows = False
                            '데이터 변경시 자동적으로 행넓이 조절
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            '데이터 변경시 자동적으로 행높이 조절
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            '유저에 의해 혹은 자동적으로 열헤더 높이 조절
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            '데이터소스 = select에의한 데이터테이블
                            .DataSource = sqlDataTable
                            'DataGridView셀 선택가능여부
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            '편집불가
                            .ReadOnly = True
                            '헤더높이
                            .RowHeadersWidth = 30
                            '유저에 의해 혹은 자동적으로 행헤더 넓이 조절
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Console.WriteLine("BoundDataGridView")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    'login 테이블에서 매개변수 SearchSyntax 내용 포함하는 데이터 select 
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Login_Id AS [LOGIN ID],Login_Name AS [LOGIN NAME],Login_Password AS [LOGIN PASSWORD],Login_Phone AS [LOGIN PHONE],Login_Mail AS [LOGIN MAIL],Login_Permission AS [LOGIN PERMISSION] FROM Login WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'SearchSyntax 조건을 만족하는 행
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class Business
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Public Property Business_Id As String
                Public Property Business_Name As String
                Public Property Business_Phone As String
                Public Property Business_Mail As String
                Public Property Business_GST_No As String
                Public Property Business_Pan_No As String
                Public Property Business_CGST As String
                Public Property Business_SGST As String
                Public Property Business_IGST As String
                Public Property Business_Tin As String
                Public Property Business_Bank_Account As String
                Public Property Business_Bill_No As String
                Public Property Business_Address As String
                Public Sub Clear()
                    '변수 빈 문자열로
                    Business_Id = String.Empty
                    Business_Name = String.Empty
                    Business_Phone = String.Empty
                    Business_Mail = String.Empty
                    Business_GST_No = String.Empty
                    Business_Pan_No = String.Empty
                    Business_CGST = String.Empty
                    Business_SGST = String.Empty
                    Business_IGST = String.Empty
                    Business_Tin = String.Empty
                    Business_Bank_Account = String.Empty
                    Business_Bill_No = String.Empty
                    Business_Address = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_Business_Id As TextBox, ByVal Txt_Business_Name As TextBox, ByVal Txt_Business_Phone As TextBox, ByVal Txt_Business_Mail As TextBox, ByVal Txt_Business_GST_No As TextBox, ByVal Txt_Business_Pan_No As TextBox, ByVal Txt_Business_CGST As TextBox, ByVal Txt_Business_SGST As TextBox, ByVal Txt_Business_IGST As TextBox, ByVal Txt_Business_Tin As TextBox, ByVal Txt_Business_Bank_Account As TextBox, ByVal Txt_Business_Bill_No As TextBox, ByVal Txt_Business_Address As TextBox)
                    Clear()
                    '입력란 클리어
                    Txt_Business_Id.Clear()
                    Txt_Business_Name.Clear()
                    Txt_Business_Phone.Clear()
                    Txt_Business_Mail.Clear()
                    Txt_Business_GST_No.Clear()
                    Txt_Business_Pan_No.Clear()
                    Txt_Business_CGST.Clear()
                    Txt_Business_SGST.Clear()
                    Txt_Business_IGST.Clear()
                    Txt_Business_Tin.Clear()
                    Txt_Business_Bank_Account.Clear()
                    Txt_Business_Bill_No.Clear()
                    Txt_Business_Address.Clear()
                End Sub
                Public Sub Add(ByVal Txt_Business_Id As TextBox, ByVal Txt_Business_Name As TextBox, ByVal Txt_Business_Phone As TextBox, ByVal Txt_Business_Mail As TextBox, ByVal Txt_Business_GST_No As TextBox, ByVal Txt_Business_Pan_No As TextBox, ByVal Txt_Business_CGST As TextBox, ByVal Txt_Business_SGST As TextBox, ByVal Txt_Business_IGST As TextBox, ByVal Txt_Business_Tin As TextBox, ByVal Txt_Business_Bank_Account As TextBox, ByVal Txt_Business_Bill_No As TextBox, ByVal Txt_Business_Address As TextBox)
                    ''문자를 ''로 변환
                    Business_Id = Txt_Business_Id.Text.Replace("'", "''")

                    Business_Name = Txt_Business_Name.Text.Replace("'", "''")
                    Business_Phone = Txt_Business_Phone.Text.Replace("'", "''")
                    Business_Mail = Txt_Business_Mail.Text.Replace("'", "''")
                    Business_GST_No = Txt_Business_GST_No.Text.Replace("'", "''")
                    Business_Pan_No = Txt_Business_Pan_No.Text.Replace("'", "''")
                    Business_CGST = Txt_Business_CGST.Text.Replace("'", "''")
                    Business_SGST = Txt_Business_SGST.Text.Replace("'", "''")
                    Business_IGST = Txt_Business_IGST.Text.Replace("'", "''")
                    Business_Tin = Txt_Business_Tin.Text.Replace("'", "''")
                    Business_Bank_Account = Txt_Business_Bank_Account.Text.Replace("'", "''")
                    Business_Bill_No = Txt_Business_Bill_No.Text.Replace("'", "''")
                    Business_Address = Txt_Business_Address.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        'AutoID = True면 id 제외 Business테이블에 insert
                        If AutoID = True Then
                            sqlString = "INSERT INTO Business (Business_Name,Business_Phone,Business_Mail,Business_GST_No,Business_Pan_No,Business_CGST,Business_SGST,Business_IGST,Business_Tin,Business_Bank_Account,Business_Bill_No,Business_Address) VALUES ('" & Business_Name & "','" & Business_Phone & "','" & Business_Mail & "','" & Business_GST_No & "','" & Business_Pan_No & "','" & Business_CGST & "','" & Business_SGST & "','" & Business_IGST & "','" & Business_Tin & "','" & Business_Bank_Account & "','" & Business_Bill_No & "','" & Business_Address & "')"
                            SQLQueryCommand(sqlString)
                            'AutoID = false면 id 포함 Business테이블에 insert
                        Else
                            sqlString = "INSERT INTO Business (Business_Id,Business_Name,Business_Phone,Business_Mail,Business_GST_No,Business_Pan_No,Business_CGST,Business_SGST,Business_IGST,Business_Tin,Business_Bank_Account,Business_Bill_No,Business_Address) VALUES ('" & Business_Id & "','" & Business_Name & "','" & Business_Phone & "','" & Business_Mail & "','" & Business_GST_No & "','" & Business_Pan_No & "','" & Business_CGST & "','" & Business_SGST & "','" & Business_IGST & "','" & Business_Tin & "','" & Business_Bank_Account & "','" & Business_Bill_No & "','" & Business_Address & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'AutoID = True면 id 제외 Business테이블에 UPDATE
                        If AutoID = True Then
                            sqlString = "UPDATE Business SET Business_Name = '" & Business_Name & "',Business_Phone = '" & Business_Phone & "',Business_Mail = '" & Business_Mail & "',Business_GST_No = '" & Business_GST_No & "',Business_Pan_No = '" & Business_Pan_No & "',Business_CGST = '" & Business_CGST & "',Business_SGST = '" & Business_SGST & "',Business_IGST = '" & Business_IGST & "',Business_Tin = '" & Business_Tin & "',Business_Bank_Account = '" & Business_Bank_Account & "',Business_Bill_No = '" & Business_Bill_No & "',Business_Address = '" & Business_Address & "' WHERE Business_Id = " & Business_Id
                            SQLQueryCommand(sqlString)
                            'AutoID = false면 id 포함 Business테이블에 UPDATE
                        Else
                            sqlString = "UPDATE Business SET Business_Id = '" & Business_Id & "',Business_Name = '" & Business_Name & "',Business_Phone = '" & Business_Phone & "',Business_Mail = '" & Business_Mail & "',Business_GST_No = '" & Business_GST_No & "',Business_Pan_No = '" & Business_Pan_No & "',Business_CGST = '" & Business_CGST & "',Business_SGST = '" & Business_SGST & "',Business_IGST = '" & Business_IGST & "',Business_Tin = '" & Business_Tin & "',Business_Bank_Account = '" & Business_Bank_Account & "',Business_Bill_No = '" & Business_Bill_No & "',Business_Address = '" & Business_Address & "' WHERE Business_Id = " & Business_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                '입력란 null이나 빈문자열시 에러 메세지
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_Business_Id As TextBox, ByVal Txt_Business_Name As TextBox, ByVal Txt_Business_Phone As TextBox, ByVal Txt_Business_Mail As TextBox, ByVal Txt_Business_GST_No As TextBox, ByVal Txt_Business_Pan_No As TextBox, ByVal Txt_Business_CGST As TextBox, ByVal Txt_Business_SGST As TextBox, ByVal Txt_Business_IGST As TextBox, ByVal Txt_Business_Tin As TextBox, ByVal Txt_Business_Bank_Account As TextBox, ByVal Txt_Business_Bill_No As TextBox, ByVal Txt_Business_Address As TextBox) As Boolean
                    If AutoID = False Then
                        '입력란이 null 혹은 빈칸이면 포커스 설정 및 에러메세지 송출
                        If String.IsNullOrEmpty(Txt_Business_Id.Text) Then
                            Txt_Business_Id.Focus()
                            MessageBox.Show("TextBox(Business_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_Business_Name.Text) Then
                        Txt_Business_Name.Focus()
                        MessageBox.Show("TextBox(Business_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Business_Phone.Text) Then
                        Txt_Business_Phone.Focus()
                        MessageBox.Show("TextBox(Business_Phone) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Business_Mail.Text) Then
                        Txt_Business_Mail.Focus()
                        MessageBox.Show("TextBox(Business_Mail) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Business_GST_No.Text) Then
                        Txt_Business_GST_No.Focus()
                        MessageBox.Show("TextBox(Business_GST_No) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Business_Pan_No.Text) Then
                        Txt_Business_Pan_No.Focus()
                        MessageBox.Show("TextBox(Business_Pan_No) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Business_CGST.Text) Then
                        Txt_Business_CGST.Focus()
                        MessageBox.Show("TextBox(Business_CGST) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Business_SGST.Text) Then
                        Txt_Business_SGST.Focus()
                        MessageBox.Show("TextBox(Business_SGST) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Business_IGST.Text) Then
                        Txt_Business_IGST.Focus()
                        MessageBox.Show("TextBox(Business_IGST) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Business_Tin.Text) Then
                        Txt_Business_Tin.Focus()
                        MessageBox.Show("TextBox(Business_Tin) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Business_Bank_Account.Text) Then
                        Txt_Business_Bank_Account.Focus()
                        MessageBox.Show("TextBox(Business_Bank_Account) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Business_Bill_No.Text) Then
                        Txt_Business_Bill_No.Focus()
                        MessageBox.Show("TextBox(Business_Bill_No) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Business_Address.Text) Then
                        Txt_Business_Address.Focus()
                        MessageBox.Show("TextBox(Business_Address) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_Business_Id As TextBox, ByVal Txt_Business_Name As TextBox, ByVal Txt_Business_Phone As TextBox, ByVal Txt_Business_Mail As TextBox, ByVal Txt_Business_GST_No As TextBox, ByVal Txt_Business_Pan_No As TextBox, ByVal Txt_Business_CGST As TextBox, ByVal Txt_Business_SGST As TextBox, ByVal Txt_Business_IGST As TextBox, ByVal Txt_Business_Tin As TextBox, ByVal Txt_Business_Bank_Account As TextBox, ByVal Txt_Business_Bill_No As TextBox, ByVal Txt_Business_Address As TextBox)
                    '입력란 에러 확인
                    If IsTextBoxError(AutoID, Txt_Business_Id, Txt_Business_Name, Txt_Business_Phone, Txt_Business_Mail, Txt_Business_GST_No, Txt_Business_Pan_No, Txt_Business_CGST, Txt_Business_SGST, Txt_Business_IGST, Txt_Business_Tin, Txt_Business_Bank_Account, Txt_Business_Bill_No, Txt_Business_Address) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_Business_Id, Txt_Business_Name, Txt_Business_Phone, Txt_Business_Mail, Txt_Business_GST_No, Txt_Business_Pan_No, Txt_Business_CGST, Txt_Business_SGST, Txt_Business_IGST, Txt_Business_Tin, Txt_Business_Bank_Account, Txt_Business_Bill_No, Txt_Business_Address)
                    '커맨드가 add 일 경우
                    If Command.ToLower.Equals("add") = True Then
                        'insert문 실행
                        Save(AutoID)
                        'insert 성공메세지 출력
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Business_Id, Txt_Business_Name, Txt_Business_Phone, Txt_Business_Mail, Txt_Business_GST_No, Txt_Business_Pan_No, Txt_Business_CGST, Txt_Business_SGST, Txt_Business_IGST, Txt_Business_Tin, Txt_Business_Bank_Account, Txt_Business_Bill_No, Txt_Business_Address)
                        '커맨드가 edit일 경우
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        'update문 실행
                        Update(AutoID)
                        'update 성공메세지 출력
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Business_Id, Txt_Business_Name, Txt_Business_Phone, Txt_Business_Mail, Txt_Business_GST_No, Txt_Business_Pan_No, Txt_Business_CGST, Txt_Business_SGST, Txt_Business_IGST, Txt_Business_Tin, Txt_Business_Bank_Account, Txt_Business_Bill_No, Txt_Business_Address)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 숫자가 아니면 메세지 송출
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '숫자면 Business테이블에서 매개변수=id인 데이터 취득 후 변수에 할당
                            sqlString = "SELECT * FROM Business WHERE Business_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            Business_Id = sqlDataTable.Rows(0)("Business_Id").ToString
                            Business_Name = sqlDataTable.Rows(0)("Business_Name").ToString
                            Business_Phone = sqlDataTable.Rows(0)("Business_Phone").ToString
                            Business_Mail = sqlDataTable.Rows(0)("Business_Mail").ToString
                            Business_GST_No = sqlDataTable.Rows(0)("Business_GST_No").ToString
                            Business_Pan_No = sqlDataTable.Rows(0)("Business_Pan_No").ToString
                            Business_CGST = sqlDataTable.Rows(0)("Business_CGST").ToString
                            Business_SGST = sqlDataTable.Rows(0)("Business_SGST").ToString
                            Business_IGST = sqlDataTable.Rows(0)("Business_IGST").ToString
                            Business_Tin = sqlDataTable.Rows(0)("Business_Tin").ToString
                            Business_Bank_Account = sqlDataTable.Rows(0)("Business_Bank_Account").ToString
                            Business_Bill_No = sqlDataTable.Rows(0)("Business_Bill_No").ToString
                            Business_Address = sqlDataTable.Rows(0)("Business_Address").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_Business_Id As TextBox, ByVal Txt_Business_Name As TextBox, ByVal Txt_Business_Phone As TextBox, ByVal Txt_Business_Mail As TextBox, ByVal Txt_Business_GST_No As TextBox, ByVal Txt_Business_Pan_No As TextBox, ByVal Txt_Business_CGST As TextBox, ByVal Txt_Business_SGST As TextBox, ByVal Txt_Business_IGST As TextBox, ByVal Txt_Business_Tin As TextBox, ByVal Txt_Business_Bank_Account As TextBox, ByVal Txt_Business_Bill_No As TextBox, ByVal Txt_Business_Address As TextBox)
                    Try
                        '입력란 값이 숫자로 변환 불가시 메세지 송출
                        If Not IsNumeric(Txt_Business_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '입력 텍스트=Business_Id 인 데이터 취득 후 변수 및 입력란에 설정
                            sqlString = "SELECT * FROM Business WHERE Business_Id = " & Txt_Business_Id.Text
                            SQLQueryCommand(sqlString)
                            Business_Id = sqlDataTable.Rows(0)("Business_Id").ToString
                            Business_Name = sqlDataTable.Rows(0)("Business_Name").ToString
                            Business_Phone = sqlDataTable.Rows(0)("Business_Phone").ToString
                            Business_Mail = sqlDataTable.Rows(0)("Business_Mail").ToString
                            Business_GST_No = sqlDataTable.Rows(0)("Business_GST_No").ToString
                            Business_Pan_No = sqlDataTable.Rows(0)("Business_Pan_No").ToString
                            Business_CGST = sqlDataTable.Rows(0)("Business_CGST").ToString
                            Business_SGST = sqlDataTable.Rows(0)("Business_SGST").ToString
                            Business_IGST = sqlDataTable.Rows(0)("Business_IGST").ToString
                            Business_Tin = sqlDataTable.Rows(0)("Business_Tin").ToString
                            Business_Bank_Account = sqlDataTable.Rows(0)("Business_Bank_Account").ToString
                            Business_Bill_No = sqlDataTable.Rows(0)("Business_Bill_No").ToString
                            Business_Address = sqlDataTable.Rows(0)("Business_Address").ToString
                            Txt_Business_Id.Text = Business_Id
                            Txt_Business_Name.Text = Business_Name
                            Txt_Business_Phone.Text = Business_Phone
                            Txt_Business_Mail.Text = Business_Mail
                            Txt_Business_GST_No.Text = Business_GST_No
                            Txt_Business_Pan_No.Text = Business_Pan_No
                            Txt_Business_CGST.Text = Business_CGST
                            Txt_Business_SGST.Text = Business_SGST
                            Txt_Business_IGST.Text = Business_IGST
                            Txt_Business_Tin.Text = Business_Tin
                            Txt_Business_Bank_Account.Text = Business_Bank_Account
                            Txt_Business_Bill_No.Text = Business_Bill_No
                            Txt_Business_Address.Text = Business_Address
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        '숫자가 아니면 에러 메세지
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Business_Id=매개변수인 데이터 삭제
                            sqlString = "DELETE FROM Business WHERE Business_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_Business_Id As TextBox, ByVal Txt_Business_Name As TextBox, ByVal Txt_Business_Phone As TextBox, ByVal Txt_Business_Mail As TextBox, ByVal Txt_Business_GST_No As TextBox, ByVal Txt_Business_Pan_No As TextBox, ByVal Txt_Business_CGST As TextBox, ByVal Txt_Business_SGST As TextBox, ByVal Txt_Business_IGST As TextBox, ByVal Txt_Business_Tin As TextBox, ByVal Txt_Business_Bank_Account As TextBox, ByVal Txt_Business_Bill_No As TextBox, ByVal Txt_Business_Address As TextBox)
                    Try
                        '숫자가 아니면 에러 메세지
                        If Not IsNumeric(Txt_Business_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '입력 텍스트 = Business_Id 인 데이터 삭제 및 입력란 클리어
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM Business WHERE Business_Id = " & Txt_Business_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_Business_Id, Txt_Business_Name, Txt_Business_Phone, Txt_Business_Mail, Txt_Business_GST_No, Txt_Business_Pan_No, Txt_Business_CGST, Txt_Business_SGST, Txt_Business_IGST, Txt_Business_Tin, Txt_Business_Bank_Account, Txt_Business_Bill_No, Txt_Business_Address)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub

                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Business", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    'sql 결과 데이터가 존재하지 않을때
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                        'sql 결과가 존재하면 마지막 행의 id 취득
                    Else
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    'Business 테이블 전체 데이터 취득
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Business", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '전체 데이터 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    'Business 테이블에서 FieldName칼럼 값과 입력된 값이 같을 경우
                    Try
                        sqlString = "SELECT * FROM Business WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        '데이터가 존재하면
                        If sqlDataTable.Rows.Count > 0 Then
                            'record TextBox에 포커스 설정 및 에러메시지 출력
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Business", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '매개변수로 받은 숫자보다 Business칼럼 수가 같거나 많으면 for 문 실행
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'BoundList 빈칸
                            BoundList = String.Empty
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                'null 혹은 빈칸
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    '첫번째 for문일 경우
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    '이후엔 BoundList에 문자열 추가
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub

                Public Function GetList(ByVal FieldIndex As Integer) As String
                    'ListError로 문자열 취득
                    ListError(FieldIndex)
                    Return BoundList
                End Function
                'Business콤보박스 실행 서브프로시저
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Business_Id, Business_Name FROM Business", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Business테이블에서 id, name 취득. 콤보박스에 설정
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Business_Name"
                            .ValueMember = "Business_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Business_Id AS [BUSINESS ID],Business_Name AS [BUSINESS NAME],Business_Phone AS [BUSINESS PHONE],Business_Mail AS [BUSINESS MAIL],Business_GST_No AS [BUSINESS GST NO],Business_Pan_No AS [BUSINESS PAN NO],Business_CGST AS [BUSINESS CGST],Business_SGST AS [BUSINESS SGST],Business_IGST AS [BUSINESS IGST],Business_Tin AS [BUSINESS TIN],Business_Bank_Account AS [BUSINESS BANK ACCOUNT],Business_Bill_No AS [BUSINESS BILL NO],Business_Address AS [BUSINESS ADDRESS] FROM Business ORDER BY Business_Name", sqlOleDbConnection)
                    Try
                        'BUSINESS테이블 전체 데이터 취득
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        With DataGridView
                            'DataGridView 크기 설정 및 sql취득 값 datasource에 설정
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        'id칼럼은 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    'SearchSyntax와 일치하는 값을 갖고 있는 데이터 추출
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Business_Id AS [BUSINESS ID],Business_Name AS [BUSINESS NAME],Business_Phone AS [BUSINESS PHONE],Business_Mail AS [BUSINESS MAIL],Business_GST_No AS [BUSINESS GST NO],Business_Pan_No AS [BUSINESS PAN NO],Business_CGST AS [BUSINESS CGST],Business_SGST AS [BUSINESS SGST],Business_IGST AS [BUSINESS IGST],Business_Tin AS [BUSINESS TIN],Business_Bank_Account AS [BUSINESS BANK ACCOUNT],Business_Bill_No AS [BUSINESS BILL NO],Business_Address AS [BUSINESS ADDRESS] FROM Business WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'DataGridView 크기 설정 및 sql취득 값 datasource에 설정
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        'id 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class Units
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Public Property Unit_Id As String
                Public Property Unit_Name As String
                Public Property Unit_Note As String
                Public Sub Clear()
                    '변수 빈문자열로
                    Unit_Id = String.Empty
                    Unit_Name = String.Empty
                    Unit_Note = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Unit_Note As TextBox)
                    '입력란 빈칸
                    Clear()
                    Txt_Unit_Id.Clear()
                    Txt_Unit_Name.Clear()
                    Txt_Unit_Note.Clear()
                End Sub
                Public Sub Add(ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Unit_Note As TextBox)
                    ' '문자 ''로 변환
                    Unit_Id = Txt_Unit_Id.Text.Replace("'", "''")
                    Unit_Name = Txt_Unit_Name.Text.Replace("'", "''")
                    Unit_Note = Txt_Unit_Note.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        If AutoID = True Then
                            'id 제외 insert
                            sqlString = "INSERT INTO Units (Unit_Name,Unit_Note) VALUES ('" & Unit_Name & "','" & Unit_Note & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'id 포함 insert
                            sqlString = "INSERT INTO Units (Unit_Id,Unit_Name,Unit_Note) VALUES ('" & Unit_Id & "','" & Unit_Name & "','" & Unit_Note & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    'id 제외 db update
                    Try
                        If AutoID = True Then
                            sqlString = "UPDATE Units SET Unit_Name = '" & Unit_Name & "',Unit_Note = '" & Unit_Note & "' WHERE Unit_Id = " & Unit_Id
                            SQLQueryCommand(sqlString)
                        Else
                            'id 포함 db update
                            sqlString = "UPDATE Units SET Unit_Id = '" & Unit_Id & "',Unit_Name = '" & Unit_Name & "',Unit_Note = '" & Unit_Note & "' WHERE Unit_Id = " & Unit_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                '입력란 null 빈칸일 경우 포커스 및 경고 메세지
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Unit_Note As TextBox) As Boolean
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_Unit_Id.Text) Then
                            Txt_Unit_Id.Focus()
                            MessageBox.Show("TextBox(Unit_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_Unit_Name.Text) Then
                        Txt_Unit_Name.Focus()
                        MessageBox.Show("TextBox(Unit_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Unit_Note.Text) Then
                        Txt_Unit_Note.Focus()
                        MessageBox.Show("TextBox(Unit_Note) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Unit_Note As TextBox)
                    'null, 빈칸 체크
                    If IsTextBoxError(AutoID, Txt_Unit_Id, Txt_Unit_Name, Txt_Unit_Note) = True Then Exit Sub
                    '문자 변환
                    Add(Txt_Unit_Id, Txt_Unit_Name, Txt_Unit_Note)
                    'add커맨드일시 insert
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        'insert 성공시 메세지 및 입력란 클리어
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Unit_Id, Txt_Unit_Name, Txt_Unit_Note)
                        '커맨드가 edit 면 update
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        'update 성공시 메세지 및 입력란 클리어
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Unit_Id, Txt_Unit_Name, Txt_Unit_Note)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 숫자가 아니면 경고메세지
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'PrimaryKey에 해당하는 id select 후 변수에 담기
                            sqlString = "SELECT * FROM Units WHERE Unit_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            Unit_Id = sqlDataTable.Rows(0)("Unit_Id").ToString
                            Unit_Name = sqlDataTable.Rows(0)("Unit_Name").ToString
                            Unit_Note = sqlDataTable.Rows(0)("Unit_Note").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Unit_Note As TextBox)
                    Try
                        '입력된 값이 숫자가 아니면 경고메세지
                        If Not IsNumeric(Txt_Unit_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '조건에 맞는 select 후 변수, 입력란에 값 설정
                            sqlString = "SELECT * FROM Units WHERE Unit_Id = " & Txt_Unit_Id.Text
                            SQLQueryCommand(sqlString)
                            Unit_Id = sqlDataTable.Rows(0)("Unit_Id").ToString
                            Unit_Name = sqlDataTable.Rows(0)("Unit_Name").ToString
                            Unit_Note = sqlDataTable.Rows(0)("Unit_Note").ToString
                            Txt_Unit_Id.Text = Unit_Id
                            Txt_Unit_Name.Text = Unit_Name
                            Txt_Unit_Note.Text = Unit_Note
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 숫자가 아니면 경고메세지
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '해당 PrimaryKey 데이터 삭제
                            sqlString = "DELETE FROM Units WHERE Unit_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Unit_Note As TextBox)
                    Try
                        '입력란 값 숫자가 아니면
                        If Not IsNumeric(Txt_Unit_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그 yes 클릭시 데이터 삭제
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM Units WHERE Unit_Id = " & Txt_Unit_Id.Text
                                SQLQueryCommand(sqlString)
                                '입력란 클리어
                                Clear(Txt_Unit_Id, Txt_Unit_Name, Txt_Unit_Note)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    'Units테이블 마지막 데이터 id
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Units", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    If sqlDataTable.Rows.Count = 0 Then
                        '데이터 없으면
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        '데이터 있으면 마지막 행의 id 리턴
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    'Units 모든 데이터 취득
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Units", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '총 데이터 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        'FieldName 칼럼에 입력값과 같은 데이터가 있으면 경고메세지
                        sqlString = "SELECT * FROM Units WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        If sqlDataTable.Rows.Count > 0 Then
                            '데이터 있으면 포커스 설정 및 에러 메세지
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try

                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Units", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼 수가 FieldIndex와 같거나 많으면 for문
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    'for문 첫번째
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    '첫번째 이후 BoundList에 문자열 붙이기
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    'BoundList 문자열 리턴
                    ListError(FieldIndex)
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Unit_Id, Unit_Name FROM Units", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        With ComboBox
                            'Units 테이블에서 id, name 취득해 ComboBox에 설정
                            .DataSource = sqlDataTable
                            .DisplayMember = "Unit_Name"
                            .ValueMember = "Unit_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Unit_Id AS [UNIT ID],Unit_Name AS [UNIT NAME],Unit_Note AS [UNIT NOTE] FROM Units ORDER BY Unit_Name", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Units테이블 데이터 DataGridView 데이터소스에 설정 및 크기 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Unit_Id AS [UNIT ID],Unit_Name AS [UNIT NAME],Unit_Note AS [UNIT NOTE] FROM Units WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Units테이블에서 SearchSyntax조건에 따라 데이터 취득. DataGridView 데이터소스에 설정 및 크기 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '1번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class Catagores
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Public Property Category_Id As String
                Public Property Category_Name As String
                Public Property Category_Note As String
                Public Sub Clear()
                    '변수 빈칸으로
                    Category_Id = String.Empty
                    Category_Name = String.Empty
                    Category_Note = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Category_Note As TextBox)
                    '입력란 클리어
                    Clear()
                    Txt_Category_Id.Clear()
                    Txt_Category_Name.Clear()
                    Txt_Category_Note.Clear()
                End Sub
                Public Sub Add(ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Category_Note As TextBox)
                    ''문자 ''로 변환
                    Category_Id = Txt_Category_Id.Text.Replace("'", "''")
                    Category_Name = Txt_Category_Name.Text.Replace("'", "''")
                    Category_Note = Txt_Category_Note.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        If AutoID = True Then
                            'id 제외 Catagores테이블에 insert
                            sqlString = "INSERT INTO Catagores (Category_Name,Category_Note) VALUES ('" & Category_Name & "','" & Category_Note & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'id 포함 Catagores테이블에 insert
                            sqlString = "INSERT INTO Catagores (Category_Id,Category_Name,Category_Note) VALUES ('" & Category_Id & "','" & Category_Name & "','" & Category_Note & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        If AutoID = True Then
                            'id 제외 Catagores테이블에 update
                            sqlString = "UPDATE Catagores SET Category_Name = '" & Category_Name & "',Category_Note = '" & Category_Note & "' WHERE Category_Id = " & Category_Id
                            SQLQueryCommand(sqlString)
                        Else
                            'id 포함 Catagores테이블에 update
                            sqlString = "UPDATE Catagores SET Category_Id = '" & Category_Id & "',Category_Name = '" & Category_Name & "',Category_Note = '" & Category_Note & "' WHERE Category_Id = " & Category_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Category_Note As TextBox) As Boolean
                    '입력란 텍스트 null 이나 빈칸이면 포커스 설정 및 에러메세지 송출
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_Category_Id.Text) Then
                            Txt_Category_Id.Focus()
                            MessageBox.Show("TextBox(Category_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_Category_Name.Text) Then
                        Txt_Category_Name.Focus()
                        MessageBox.Show("TextBox(Category_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Category_Note.Text) Then
                        Txt_Category_Note.Focus()
                        MessageBox.Show("TextBox(Category_Note) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Category_Note As TextBox)
                    '입력란 체크
                    If IsTextBoxError(AutoID, Txt_Category_Id, Txt_Category_Name, Txt_Category_Note) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_Category_Id, Txt_Category_Name, Txt_Category_Note)
                    '커맨드 add 일 경우
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        'insert 성공시 메세지 출력 및 입력란 클리어
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Category_Id, Txt_Category_Name, Txt_Category_Note)
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        'Update 성공시 메세지 출력 및 입력란 클리어
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Category_Id, Txt_Category_Name, Txt_Category_Note)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey가 숫자가 아니면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Category_Id=PrimaryKey 조건으로 select 후 변수에 할당
                            sqlString = "SELECT * FROM Catagores WHERE Category_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            Category_Id = sqlDataTable.Rows(0)("Category_Id").ToString
                            Category_Name = sqlDataTable.Rows(0)("Category_Name").ToString
                            Category_Note = sqlDataTable.Rows(0)("Category_Note").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Category_Note As TextBox)
                    Try
                        '입력값이 숫자가 아니면 에러메세지 출력
                        If Not IsNumeric(Txt_Category_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Category_Id=Txt_Category_Id.Text 조건으로 select 후 변수 및 입력란에 설정 
                            sqlString = "SELECT * FROM Catagores WHERE Category_Id = " & Txt_Category_Id.Text
                            SQLQueryCommand(sqlString)
                            Category_Id = sqlDataTable.Rows(0)("Category_Id").ToString
                            Category_Name = sqlDataTable.Rows(0)("Category_Name").ToString
                            Category_Note = sqlDataTable.Rows(0)("Category_Note").ToString
                            Txt_Category_Id.Text = Category_Id
                            Txt_Category_Name.Text = Category_Name
                            Txt_Category_Note.Text = Category_Note
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey가 숫자가 아니라면 에러메세지
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Category_Id = PrimaryKey 조건으로 삭제
                            sqlString = "DELETE FROM Catagores WHERE Category_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Category_Note As TextBox)
                    Try
                        'Txt_Category_Id.Text 숫자가 아니라면 에러메세지
                        If Not IsNumeric(Txt_Category_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes클릭하면 삭제 및 입력란 클리어
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM Catagores WHERE Category_Id = " & Txt_Category_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_Category_Id, Txt_Category_Name, Txt_Category_Note)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Catagores", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    'Catagores테이블에 데이터가 없으면
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        '데이터가 있으면 마지막 행의 id 리턴
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Catagores", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    'Catagores테이블의 전체 행수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        'Catagores테이블에 FieldName칼럼에 Record TextBox 입력값이 존재하는지 확인
                        sqlString = "SELECT * FROM Catagores WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        If sqlDataTable.Rows.Count > 0 Then
                            '존재하면 포커스 설정 및 에러메세지 출력
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Catagores", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Catagores 칼럼수가 FieldIndex와 같거나 많으면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'BoundList 빈칸으로
                            BoundList = String.Empty
                            'for문 실행
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    '첫번째 for문
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    '이후 for문에서 추가 데이터 붙여줌
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    ListError(FieldIndex)
                    'BoundList리턴
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Category_Id, Category_Name FROM Catagores", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Catagores테이블의 id, name 취득 후 ComboBox 속성에 담아준다
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Category_Name"
                            .ValueMember = "Category_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Category_Id AS [CATEGORY ID],Category_Name AS [CATEGORY NAME],Category_Note AS [CATEGORY NOTE] FROM Catagores ORDER BY Category_Name", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Catagores테이블 취득 후 DataGridView에 담아준 후 크기 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼은 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Category_Id AS [CATEGORY ID],Category_Name AS [CATEGORY NAME],Category_Note AS [CATEGORY NOTE] FROM Catagores WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Catagores테이블에서 SearchSyntax조건에 따라 데이터 취득 후 DataGridView에 담아준 후 크기 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class Products
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Private Property TotalAmount As Double
                Public Property Product_Id As String
                Public Property Category_Id As String
                Public Property Category_Name As String
                Public Property Product_Name As String
                Public Property Unit_Id As String
                Public Property Unit_Name As String
                Public Property HSN_Code As String
                Public Property Product_Stock As String
                Public Property Product_Single_Amount As String
                Public Property Product_Note As String
                Public Sub Clear()
                    '변수 빈문자열로
                    Product_Id = String.Empty
                    Category_Id = String.Empty
                    Category_Name = String.Empty
                    Product_Name = String.Empty
                    Unit_Id = String.Empty
                    Unit_Name = String.Empty
                    HSN_Code = String.Empty
                    Product_Stock = String.Empty
                    Product_Single_Amount = String.Empty
                    Product_Note = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_Product_Id As TextBox, ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Product_Stock As TextBox, ByVal Txt_Product_Single_Amount As TextBox, ByVal Txt_Product_Note As TextBox)
                    '변수 빈 문자열 및 입력란 클리어
                    Clear()
                    Txt_Product_Id.Clear()
                    Txt_Category_Id.Clear()
                    Txt_Category_Name.Clear()
                    Txt_Product_Name.Clear()
                    Txt_Unit_Id.Clear()
                    Txt_Unit_Name.Clear()
                    Txt_HSN_Code.Clear()
                    Txt_Product_Stock.Clear()
                    Txt_Product_Single_Amount.Clear()
                    Txt_Product_Note.Clear()
                End Sub
                Public Sub Add(ByVal Txt_Product_Id As TextBox, ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Product_Stock As TextBox, ByVal Txt_Product_Single_Amount As TextBox, ByVal Txt_Product_Note As TextBox)
                    '문자열 변환해서 변수에 담아줌
                    Product_Id = Txt_Product_Id.Text.Replace("'", "''")
                    Category_Id = Txt_Category_Id.Text.Replace("'", "''")
                    Category_Name = Txt_Category_Name.Text.Replace("'", "''")
                    Product_Name = Txt_Product_Name.Text.Replace("'", "''")
                    Unit_Id = Txt_Unit_Id.Text.Replace("'", "''")
                    Unit_Name = Txt_Unit_Name.Text.Replace("'", "''")
                    HSN_Code = Txt_HSN_Code.Text.Replace("'", "''")
                    Product_Stock = Txt_Product_Stock.Text.Replace("'", "''")
                    Product_Single_Amount = Txt_Product_Single_Amount.Text.Replace("'", "''")
                    Product_Note = Txt_Product_Note.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        'Product_Id 비포함 Products테이블에 insert
                        If AutoID = True Then
                            sqlString = "INSERT INTO Products (Category_Id,Category_Name,Product_Name,Unit_Id,Unit_Name,HSN_Code,Product_Stock,Product_Single_Amount,Product_Note) VALUES ('" & Category_Id & "','" & Category_Name & "','" & Product_Name & "','" & Unit_Id & "','" & Unit_Name & "','" & HSN_Code & "','" & Product_Stock & "','" & Product_Single_Amount & "','" & Product_Note & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'Product_Id 포함 Products테이블에 insert
                            sqlString = "INSERT INTO Products (Product_Id,Category_Id,Category_Name,Product_Name,Unit_Id,Unit_Name,HSN_Code,Product_Stock,Product_Single_Amount,Product_Note) VALUES ('" & Product_Id & "','" & Category_Id & "','" & Category_Name & "','" & Product_Name & "','" & Unit_Id & "','" & Unit_Name & "','" & HSN_Code & "','" & Product_Stock & "','" & Product_Single_Amount & "','" & Product_Note & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'Product_Id 비포함 update
                        If AutoID = True Then
                            sqlString = "UPDATE Products SET Category_Id = '" & Category_Id & "',Category_Name = '" & Category_Name & "',Product_Name = '" & Product_Name & "',Unit_Id = '" & Unit_Id & "',Unit_Name = '" & Unit_Name & "',HSN_Code = '" & HSN_Code & "',Product_Stock = '" & Product_Stock & "',Product_Single_Amount = '" & Product_Single_Amount & "',Product_Note = '" & Product_Note & "' WHERE Product_Id = " & Product_Id
                            SQLQueryCommand(sqlString)
                            'Product_Id 포함 update
                        Else
                            sqlString = "UPDATE Products SET Product_Id = '" & Product_Id & "',Category_Id = '" & Category_Id & "',Category_Name = '" & Category_Name & "',Product_Name = '" & Product_Name & "',Unit_Id = '" & Unit_Id & "',Unit_Name = '" & Unit_Name & "',HSN_Code = '" & HSN_Code & "',Product_Stock = '" & Product_Stock & "',Product_Single_Amount = '" & Product_Single_Amount & "',Product_Note = '" & Product_Note & "' WHERE Product_Id = " & Product_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_Product_Id As TextBox, ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Product_Stock As TextBox, ByVal Txt_Product_Single_Amount As TextBox, ByVal Txt_Product_Note As TextBox) As Boolean
                    '입력란 null이거나 빈문자열이면 포커스 설정 및 에러메세지 출력
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_Product_Id.Text) Then
                            Txt_Product_Id.Focus()
                            MessageBox.Show("TextBox(Product_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_Category_Id.Text) Then
                        Txt_Category_Id.Focus()
                        MessageBox.Show("TextBox(Category_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Category_Name.Text) Then
                        Txt_Category_Name.Focus()
                        MessageBox.Show("TextBox(Category_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Name.Text) Then
                        Txt_Product_Name.Focus()
                        MessageBox.Show("TextBox(Product_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Unit_Id.Text) Then
                        Txt_Unit_Id.Focus()
                        MessageBox.Show("TextBox(Unit_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Unit_Name.Text) Then
                        Txt_Unit_Name.Focus()
                        MessageBox.Show("TextBox(Unit_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_HSN_Code.Text) Then
                        Txt_HSN_Code.Focus()
                        MessageBox.Show("TextBox(HSN_Code) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Stock.Text) Then
                        Txt_Product_Stock.Focus()
                        MessageBox.Show("TextBox(Product_Stock) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Single_Amount.Text) Then
                        Txt_Product_Single_Amount.Focus()
                        MessageBox.Show("TextBox(Product_Single_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Note.Text) Then
                        Txt_Product_Note.Focus()
                        MessageBox.Show("TextBox(Product_Note) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_Product_Id As TextBox, ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Product_Stock As TextBox, ByVal Txt_Product_Single_Amount As TextBox, ByVal Txt_Product_Note As TextBox)
                    '입력 체크
                    If IsTextBoxError(AutoID, Txt_Product_Id, Txt_Category_Id, Txt_Category_Name, Txt_Product_Name, Txt_Unit_Id, Txt_Unit_Name, Txt_HSN_Code, Txt_Product_Stock, Txt_Product_Single_Amount, Txt_Product_Note) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_Product_Id, Txt_Category_Id, Txt_Category_Name, Txt_Product_Name, Txt_Unit_Id, Txt_Unit_Name, Txt_HSN_Code, Txt_Product_Stock, Txt_Product_Single_Amount, Txt_Product_Note)
                    'add커맨드일 경우
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        'insert 성공시 메세지 출력 및 입력란 클리어
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Product_Id, Txt_Category_Id, Txt_Category_Name, Txt_Product_Name, Txt_Unit_Id, Txt_Unit_Name, Txt_HSN_Code, Txt_Product_Stock, Txt_Product_Single_Amount, Txt_Product_Note)
                        'edit커맨드일 경우
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        'Update 성공시 메세지 출력 및 입력란 클리어
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Product_Id, Txt_Category_Id, Txt_Category_Name, Txt_Product_Name, Txt_Unit_Id, Txt_Unit_Name, Txt_HSN_Code, Txt_Product_Stock, Txt_Product_Single_Amount, Txt_Product_Note)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey숫자가 아니면 에러메세지
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Product_Id = PrimaryKey 데이터를 변수에 설정
                            sqlString = "SELECT * FROM Products WHERE Product_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            Category_Id = sqlDataTable.Rows(0)("Category_Id").ToString
                            Category_Name = sqlDataTable.Rows(0)("Category_Name").ToString
                            Product_Name = sqlDataTable.Rows(0)("Product_Name").ToString
                            Unit_Id = sqlDataTable.Rows(0)("Unit_Id").ToString
                            Unit_Name = sqlDataTable.Rows(0)("Unit_Name").ToString
                            HSN_Code = sqlDataTable.Rows(0)("HSN_Code").ToString
                            Product_Stock = sqlDataTable.Rows(0)("Product_Stock").ToString
                            Product_Single_Amount = sqlDataTable.Rows(0)("Product_Single_Amount").ToString
                            Product_Note = sqlDataTable.Rows(0)("Product_Note").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_Product_Id As TextBox, ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Product_Stock As TextBox, ByVal Txt_Product_Single_Amount As TextBox, ByVal Txt_Product_Note As TextBox)
                    Try
                        'Txt_Product_Id.Text가 숫자가 아니면 에러메세지
                        If Not IsNumeric(Txt_Product_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Product_Id = Txt_Product_Id.Text 에 해당하는 데이터 변수 및 입력란  설정 
                            sqlString = "SELECT * FROM Products WHERE Product_Id = " & Txt_Product_Id.Text
                            SQLQueryCommand(sqlString)
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            Category_Id = sqlDataTable.Rows(0)("Category_Id").ToString
                            Category_Name = sqlDataTable.Rows(0)("Category_Name").ToString
                            Product_Name = sqlDataTable.Rows(0)("Product_Name").ToString
                            Unit_Id = sqlDataTable.Rows(0)("Unit_Id").ToString
                            Unit_Name = sqlDataTable.Rows(0)("Unit_Name").ToString
                            HSN_Code = sqlDataTable.Rows(0)("HSN_Code").ToString
                            Product_Stock = sqlDataTable.Rows(0)("Product_Stock").ToString
                            Product_Single_Amount = sqlDataTable.Rows(0)("Product_Single_Amount").ToString
                            Product_Note = sqlDataTable.Rows(0)("Product_Note").ToString
                            Txt_Product_Id.Text = Product_Id
                            Txt_Category_Id.Text = Category_Id
                            Txt_Category_Name.Text = Category_Name
                            Txt_Product_Name.Text = Product_Name
                            Txt_Unit_Id.Text = Unit_Id
                            Txt_Unit_Name.Text = Unit_Name
                            Txt_HSN_Code.Text = HSN_Code
                            Txt_Product_Stock.Text = Product_Stock
                            Txt_Product_Single_Amount.Text = Product_Single_Amount
                            Txt_Product_Note.Text = Product_Note
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 숫자가 아니면 에러메세지
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Product_Id =  PrimaryKey 해당하는 데이터 삭제
                            sqlString = "DELETE FROM Products WHERE Product_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_Product_Id As TextBox, ByVal Txt_Category_Id As TextBox, ByVal Txt_Category_Name As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_Unit_Id As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Product_Stock As TextBox, ByVal Txt_Product_Single_Amount As TextBox, ByVal Txt_Product_Note As TextBox)
                    Try
                        'Txt_Product_Id.Text가 숫자가 아니라면 에러메세지
                        If Not IsNumeric(Txt_Product_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes 선택시 Product_Id =  Txt_Product_Id.Text 해당하는 데이터 삭제 및 입력란 클리어
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM Products WHERE Product_Id = " & Txt_Product_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_Product_Id, Txt_Category_Id, Txt_Category_Name, Txt_Product_Name, Txt_Unit_Id, Txt_Unit_Name, Txt_HSN_Code, Txt_Product_Stock, Txt_Product_Single_Amount, Txt_Product_Note)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Products WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName칼럼에 FilterPrimaryKey 값이 있을경우
                        For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                            '해당 데이터 삭제
                            sqlString = "DELETE FROM Products WHERE Product_Id = " & sqlDataTable.Rows(i).Item(0).ToString
                            SQLQueryCommand(sqlString)
                        Next
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Products", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '데이터가 없으면
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        '마지막 행의 id 리턴
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Products", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    'Products테이블 전체 데이터 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Private Sub TotalAmountError(ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Products", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 수가 매개변수 FieldIndex 와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            '전체 행만큼 for문
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                'FieldIndex번째 칼럼값을 TotalAmount에 반복해서 더해준다
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FieldIndex As Integer) As Double
                    TotalAmountError(FieldIndex)
                    'TotalAmount리턴
                    Return TotalAmount
                End Function
                Private Sub FilterTotalAmountError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Products WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 수가 매개변수 FieldIndex 와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            '반복해서 FieldIndex번째 칼럼의 값을 TotalAmount에 더해준다
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As Double
                    FilterTotalAmountError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    'TotalAmount리턴
                    Return TotalAmount
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        sqlString = "SELECT * FROM Products WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        'FieldName  =  Record.Text 해당하는 데이터가 있으면 포커스 설정 및 에러메세지
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Products", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 수가 매개변수 FieldIndex 와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 반복
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                '첫번째 for문
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    '이후 for문
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    ListError(FieldIndex)
                    'BoundList리턴
                    Return BoundList
                End Function
                Private Sub FilterListError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Products WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 수가 매개변수 FieldIndex 와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                '첫번째 for문
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                Else
                                    '이후 for문
                                    BoundList &= vbNewLine & CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As String
                    FilterListError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    'BoundList리턴
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Product_Id, Product_Name FROM Products", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Products테이블의 select 결과값을 콤보박스에 설정
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Product_Name"
                            .ValueMember = "Product_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Product_Id, Product_Name FROM Products WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName칼럼 값 = FilterPrimaryKey인 행
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Product_Name"
                            .ValueMember = "Product_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Product_Id AS [PRODUCT ID],Category_Id AS [CATEGORY ID],Category_Name AS [CATEGORY NAME],Product_Name AS [PRODUCT NAME],Unit_Id AS [UNIT ID],Unit_Name AS [UNIT NAME],HSN_Code AS [HSN CODE],Product_Stock AS [PRODUCT STOCK],Product_Single_Amount AS [PRODUCT SINGLE AMOUNT],Product_Note AS [PRODUCT NOTE] FROM Products ORDER BY Category_Id", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Product테이블 데이터를 DataGridView에 설정 및 크기 조정
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Product_Id AS [PRODUCT ID],Category_Id AS [CATEGORY ID],Category_Name AS [CATEGORY NAME],Product_Name AS [PRODUCT NAME],Unit_Id AS [UNIT ID],Unit_Name AS [UNIT NAME],HSN_Code AS [HSN CODE],Product_Stock AS [PRODUCT STOCK],Product_Single_Amount AS [PRODUCT SINGLE AMOUNT],Product_Note AS [PRODUCT NOTE] FROM Products WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'SearchSyntax조건에 맞는 데이터가 있으면 DataGridView에 설정 및 크기조정
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class ProductBarcodes
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Public Property ProductBarcode_Id As String
                Public Property PurchaseDetail_Id As String
                Public Property Product_Id As String
                Public Property ProductBarcode_Barcode As String
                Public Property ProductBarcode_Stock As String
                Public Sub Clear()
                    '변수 빈문자열로
                    ProductBarcode_Id = String.Empty
                    PurchaseDetail_Id = String.Empty
                    Product_Id = String.Empty
                    ProductBarcode_Barcode = String.Empty
                    ProductBarcode_Stock = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_ProductBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_ProductBarcode_Barcode As TextBox, ByVal Txt_ProductBarcode_Stock As TextBox)
                    '변수 빈문자열 및 입력란클리어
                    Clear()
                    Txt_ProductBarcode_Id.Clear()
                    Txt_PurchaseDetail_Id.Clear()
                    Txt_Product_Id.Clear()
                    Txt_ProductBarcode_Barcode.Clear()
                    Txt_ProductBarcode_Stock.Clear()
                End Sub
                '문자열 변환
                Public Sub Add(ByVal Txt_ProductBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_ProductBarcode_Barcode As TextBox, ByVal Txt_ProductBarcode_Stock As TextBox)
                    ProductBarcode_Id = Txt_ProductBarcode_Id.Text.Replace("'", "''")
                    PurchaseDetail_Id = Txt_PurchaseDetail_Id.Text.Replace("'", "''")
                    Product_Id = Txt_Product_Id.Text.Replace("'", "''")
                    ProductBarcode_Barcode = Txt_ProductBarcode_Barcode.Text.Replace("'", "''")
                    ProductBarcode_Stock = Txt_ProductBarcode_Stock.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        If AutoID = True Then
                            'ProductBarcode_Id 칼럼 제외 insert
                            sqlString = "INSERT INTO ProductBarcodes (PurchaseDetail_Id,Product_Id,ProductBarcode_Barcode,ProductBarcode_Stock) VALUES ('" & PurchaseDetail_Id & "','" & Product_Id & "','" & ProductBarcode_Barcode & "','" & ProductBarcode_Stock & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'ProductBarcode_Id 칼럼 포함 insert
                            sqlString = "INSERT INTO ProductBarcodes (ProductBarcode_Id,PurchaseDetail_Id,Product_Id,ProductBarcode_Barcode,ProductBarcode_Stock) VALUES ('" & ProductBarcode_Id & "','" & PurchaseDetail_Id & "','" & Product_Id & "','" & ProductBarcode_Barcode & "','" & ProductBarcode_Stock & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        If AutoID = True Then
                            'PurchaseDetail_Id 제외 update
                            sqlString = "UPDATE ProductBarcodes SET PurchaseDetail_Id = '" & PurchaseDetail_Id & "',Product_Id = '" & Product_Id & "',ProductBarcode_Barcode = '" & ProductBarcode_Barcode & "',ProductBarcode_Stock = '" & ProductBarcode_Stock & "' WHERE ProductBarcode_Id = " & ProductBarcode_Id
                            SQLQueryCommand(sqlString)
                        Else
                            'PurchaseDetail_Id포함 update
                            sqlString = "UPDATE ProductBarcodes SET ProductBarcode_Id = '" & ProductBarcode_Id & "',PurchaseDetail_Id = '" & PurchaseDetail_Id & "',Product_Id = '" & Product_Id & "',ProductBarcode_Barcode = '" & ProductBarcode_Barcode & "',ProductBarcode_Stock = '" & ProductBarcode_Stock & "' WHERE ProductBarcode_Id = " & ProductBarcode_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_ProductBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_ProductBarcode_Barcode As TextBox, ByVal Txt_ProductBarcode_Stock As TextBox) As Boolean
                    If AutoID = False Then
                        '입력된 값이 null 혹은 빈문자열이면 포커스 설정 및 메세지 출력
                        If String.IsNullOrEmpty(Txt_ProductBarcode_Id.Text) Then
                            Txt_ProductBarcode_Id.Focus()
                            MessageBox.Show("TextBox(ProductBarcode_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_PurchaseDetail_Id.Text) Then
                        Txt_PurchaseDetail_Id.Focus()
                        MessageBox.Show("TextBox(PurchaseDetail_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Id.Text) Then
                        Txt_Product_Id.Focus()
                        MessageBox.Show("TextBox(Product_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_ProductBarcode_Barcode.Text) Then
                        Txt_ProductBarcode_Barcode.Focus()
                        MessageBox.Show("TextBox(ProductBarcode_Barcode) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_ProductBarcode_Stock.Text) Then
                        Txt_ProductBarcode_Stock.Focus()
                        MessageBox.Show("TextBox(ProductBarcode_Stock) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_ProductBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_ProductBarcode_Barcode As TextBox, ByVal Txt_ProductBarcode_Stock As TextBox)
                    '입력 체크
                    If IsTextBoxError(AutoID, Txt_ProductBarcode_Id, Txt_PurchaseDetail_Id, Txt_Product_Id, Txt_ProductBarcode_Barcode, Txt_ProductBarcode_Stock) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_ProductBarcode_Id, Txt_PurchaseDetail_Id, Txt_Product_Id, Txt_ProductBarcode_Barcode, Txt_ProductBarcode_Stock)
                    If Command.ToLower.Equals("add") = True Then
                        '커맨드 add일경우 insert 및 메세지 출력 및 입력란 클리어
                        Save(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_ProductBarcode_Id, Txt_PurchaseDetail_Id, Txt_Product_Id, Txt_ProductBarcode_Barcode, Txt_ProductBarcode_Stock)
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        '커맨드 edit일경우 update 및 메세지 출력 및 입력란 클리어
                        Update(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_ProductBarcode_Id, Txt_PurchaseDetail_Id, Txt_Product_Id, Txt_ProductBarcode_Barcode, Txt_ProductBarcode_Stock)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 숫자가 아니면 메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'ProductBarcode_Id = PrimaryKey에 해당하는 데이터 출력해서 변수에 담아주기
                            sqlString = "SELECT * FROM ProductBarcodes WHERE ProductBarcode_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            ProductBarcode_Id = sqlDataTable.Rows(0)("ProductBarcode_Id").ToString
                            PurchaseDetail_Id = sqlDataTable.Rows(0)("PurchaseDetail_Id").ToString
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            ProductBarcode_Barcode = sqlDataTable.Rows(0)("ProductBarcode_Barcode").ToString
                            ProductBarcode_Stock = sqlDataTable.Rows(0)("ProductBarcode_Stock").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_ProductBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_ProductBarcode_Barcode As TextBox, ByVal Txt_ProductBarcode_Stock As TextBox)
                    Try
                        '입력값이 숫자가 아니면 메세지 출력
                        If Not IsNumeric(Txt_ProductBarcode_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'ProductBarcode_Id =  Txt_ProductBarcode_Id.Text에 해당하는 데이터 변수 및 입력란에 설정
                            sqlString = "SELECT * FROM ProductBarcodes WHERE ProductBarcode_Id = " & Txt_ProductBarcode_Id.Text
                            SQLQueryCommand(sqlString)
                            ProductBarcode_Id = sqlDataTable.Rows(0)("ProductBarcode_Id").ToString
                            PurchaseDetail_Id = sqlDataTable.Rows(0)("PurchaseDetail_Id").ToString
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            ProductBarcode_Barcode = sqlDataTable.Rows(0)("ProductBarcode_Barcode").ToString
                            ProductBarcode_Stock = sqlDataTable.Rows(0)("ProductBarcode_Stock").ToString
                            Txt_ProductBarcode_Id.Text = ProductBarcode_Id
                            Txt_PurchaseDetail_Id.Text = PurchaseDetail_Id
                            Txt_Product_Id.Text = Product_Id
                            Txt_ProductBarcode_Barcode.Text = ProductBarcode_Barcode
                            Txt_ProductBarcode_Stock.Text = ProductBarcode_Stock
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey숫자가 아니면 경고메세지
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'ProductBarcode_Id =  PrimaryKey 해당하는 데이터 삭제
                            sqlString = "DELETE FROM ProductBarcodes WHERE ProductBarcode_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_ProductBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_ProductBarcode_Barcode As TextBox, ByVal Txt_ProductBarcode_Stock As TextBox)
                    Try
                        '입력값 숫자가 아니면 경고메세지
                        If Not IsNumeric(Txt_ProductBarcode_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes 클릭시 데이터 삭제 및 입력란 클리어 및 경고메세지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM ProductBarcodes WHERE ProductBarcode_Id = " & Txt_ProductBarcode_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_ProductBarcode_Id, Txt_PurchaseDetail_Id, Txt_Product_Id, Txt_ProductBarcode_Barcode, Txt_ProductBarcode_Stock)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM ProductBarcodes WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName 칼럼에 FilterPrimaryKey에 해당하는 값이 있으면
                        For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                            '해당 데이터 삭제
                            sqlString = "DELETE FROM ProductBarcodes WHERE ProductBarcode_Id = " & sqlDataTable.Rows(i).Item(0).ToString
                            SQLQueryCommand(sqlString)
                        Next
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM ProductBarcodes", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    'ProductBarcodes에 데이터가 없으면
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        '마지막 행의 id 리턴
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM ProductBarcodes", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    'ProductBarcodes 전체행수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        'FieldName 칼럼에 Record.Text 와 일치하는 값이 있으면
                        sqlString = "SELECT * FROM ProductBarcodes WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        '포커스 설정 및 에러메세지 출력
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM ProductBarcodes", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'ProductBarcodes 테이블에 데이터가 있으면 
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                '첫번째 for문
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    '이후 for문
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    ListError(FieldIndex)
                    'BoundList리턴
                    Return BoundList
                End Function
                Private Sub FilterListError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM ProductBarcodes WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName = FilterPrimaryKey에 해당하는 데이터가 있으면 
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    '첫번째 for문
                                    BoundList = CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                Else
                                    '이후 for문
                                    BoundList &= vbNewLine & CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As String
                    FilterListError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT ProductBarcode_Id, PurchaseDetail_Id FROM ProductBarcodes", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'ProductBarcodes테이블의ProductBarcode_Id, PurchaseDetail_Id 를 콤보박스에 설정
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "PurchaseDetail_Id"
                            .ValueMember = "ProductBarcode_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)

                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT ProductBarcode_Id, PurchaseDetail_Id FROM ProductBarcodes WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName & " = " & FilterPrimaryKey 에 해당하는ProductBarcode_Id, PurchaseDetail_Id 취득 후  콤보박스에 설정
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "PurchaseDetail_Id"
                            .ValueMember = "ProductBarcode_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT ProductBarcode_Id AS [PRODUCTBARCODE ID],PurchaseDetail_Id AS [PURCHASEDETAIL ID],Product_Id AS [PRODUCT ID],ProductBarcode_Barcode AS [PRODUCTBARCODE BARCODE],ProductBarcode_Stock AS [PRODUCTBARCODE STOCK] FROM ProductBarcodes ORDER BY PurchaseDetail_Id", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'ProductBarcodes 테이블 전건 출력 후 DataGridView속성에 설정 및 크기 조정
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT ProductBarcode_Id AS [PRODUCTBARCODE ID],PurchaseDetail_Id AS [PURCHASEDETAIL ID],Product_Id AS [PRODUCT ID],ProductBarcode_Barcode AS [PRODUCTBARCODE BARCODE],ProductBarcode_Stock AS [PRODUCTBARCODE STOCK] FROM ProductBarcodes WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'SearchSyntax조건에 맞는 데이터 취득후 DataGridView 속성에 설정 및 사이즈 조정
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class Reletionships
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Public Property Reletionship_Id As String
                Public Property Reletionship_Name As String
                Public Property Reletionship_Note As String
                Public Sub Clear()
                    '변수 빈문자열로
                    Reletionship_Id = String.Empty
                    Reletionship_Name = String.Empty
                    Reletionship_Note = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Reletionship_Note As TextBox)
                    '변수 빈 문자열 및 입력란 클리어
                    Clear()
                    Txt_Reletionship_Id.Clear()
                    Txt_Reletionship_Name.Clear()
                    Txt_Reletionship_Note.Clear()
                End Sub
                Public Sub Add(ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Reletionship_Note As TextBox)
                    '문자열 변환
                    Reletionship_Id = Txt_Reletionship_Id.Text.Replace("'", "''")
                    Reletionship_Name = Txt_Reletionship_Name.Text.Replace("'", "''")
                    Reletionship_Note = Txt_Reletionship_Note.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        If AutoID = True Then
                            'Reletionship_Id 비포함 insert
                            sqlString = "INSERT INTO Reletionships (Reletionship_Name,Reletionship_Note) VALUES ('" & Reletionship_Name & "','" & Reletionship_Note & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'Reletionship_Id 포함 insert
                            sqlString = "INSERT INTO Reletionships (Reletionship_Id,Reletionship_Name,Reletionship_Note) VALUES ('" & Reletionship_Id & "','" & Reletionship_Name & "','" & Reletionship_Note & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'Reletionship_Id 비포함 update
                        If AutoID = True Then
                            sqlString = "UPDATE Reletionships SET Reletionship_Name = '" & Reletionship_Name & "',Reletionship_Note = '" & Reletionship_Note & "' WHERE Reletionship_Id = " & Reletionship_Id
                            SQLQueryCommand(sqlString)
                        Else
                            'Reletionship_Id 포함 update
                            sqlString = "UPDATE Reletionships SET Reletionship_Id = '" & Reletionship_Id & "',Reletionship_Name = '" & Reletionship_Name & "',Reletionship_Note = '" & Reletionship_Note & "' WHERE Reletionship_Id = " & Reletionship_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Reletionship_Note As TextBox) As Boolean
                    If AutoID = False Then
                        '입력란 혹은 빈문자열이면 포커스 설정 및 에러메세지 출력
                        If String.IsNullOrEmpty(Txt_Reletionship_Id.Text) Then
                            Txt_Reletionship_Id.Focus()
                            MessageBox.Show("TextBox(Reletionship_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_Reletionship_Name.Text) Then
                        Txt_Reletionship_Name.Focus()
                        MessageBox.Show("TextBox(Reletionship_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Reletionship_Note.Text) Then
                        Txt_Reletionship_Note.Focus()
                        MessageBox.Show("TextBox(Reletionship_Note) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Reletionship_Note As TextBox)
                    '입력체크
                    If IsTextBoxError(AutoID, Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Reletionship_Note) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Reletionship_Note)
                    '커맨드 add일 경우
                    If Command.ToLower.Equals("add") = True Then
                        'insert 성공시 메세지 출력 및 입력란 클리어
                        Save(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Reletionship_Note)
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        'Update 성공시 메세지 출력 및 입력란 클리어
                        Update(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Reletionship_Note)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 숫자가 아닐 경우 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Reletionship_Id = " & PrimaryKey 데이터 취득 및 변수에 설정
                            sqlString = "SELECT * FROM Reletionships WHERE Reletionship_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            Reletionship_Id = sqlDataTable.Rows(0)("Reletionship_Id").ToString
                            Reletionship_Name = sqlDataTable.Rows(0)("Reletionship_Name").ToString
                            Reletionship_Note = sqlDataTable.Rows(0)("Reletionship_Note").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Reletionship_Note As TextBox)
                    Try
                        'Txt_Reletionship_Id.Text 숫자가 아닐 경우 에러메세지 출력
                        If Not IsNumeric(Txt_Reletionship_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Reletionship_Id = " & Txt_Reletionship_Id.Text 데이터 취득 및 변수, 텍스트박스에 값 설정
                            sqlString = "SELECT * FROM Reletionships WHERE Reletionship_Id = " & Txt_Reletionship_Id.Text
                            SQLQueryCommand(sqlString)
                            Reletionship_Id = sqlDataTable.Rows(0)("Reletionship_Id").ToString
                            Reletionship_Name = sqlDataTable.Rows(0)("Reletionship_Name").ToString
                            Reletionship_Note = sqlDataTable.Rows(0)("Reletionship_Note").ToString
                            Txt_Reletionship_Id.Text = Reletionship_Id
                            Txt_Reletionship_Name.Text = Reletionship_Name
                            Txt_Reletionship_Note.Text = Reletionship_Note
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 숫자가 아닐 경우 에러 메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Reletionship_Id = " & PrimaryKey 데이터 삭제
                            sqlString = "DELETE FROM Reletionships WHERE Reletionship_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Reletionship_Note As TextBox)
                    Try
                        'Txt_Reletionship_Id.Text 값이 숫자가 아닐 경우 에러메세지 출력
                        If Not IsNumeric(Txt_Reletionship_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes 선택시 데이터 삭제 및 입력란 클리어 및 메세지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM Reletionships WHERE Reletionship_Id = " & Txt_Reletionship_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Reletionship_Note)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Reletionships", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '데이터가 존재하지 않으면
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        '마지막 행의 id 리턴
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Reletionships", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '전체 데이터 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        sqlString = "SELECT * FROM Reletionships WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        'FieldName 칼럼에 Record.Text 값이 존재하면 포커스 설정 및 에러 메세지 출력
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Reletionships", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Reletionships 칼럼의 수가 FieldIndex와 같거나 클경우
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'BoundList 빈 문자열로
                            BoundList = String.Empty
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                '첫번째 for문
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    '이후 for문
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    'BoundList 문자열 값 설정
                    ListError(FieldIndex)
                    '문자열 BoundList 리턴
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Reletionship_Id, Reletionship_Name FROM Reletionships", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Reletionships 테이블의 id, name 값 취득 후 콤보박스 속성에 설정
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Reletionship_Name"
                            .ValueMember = "Reletionship_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Reletionship_Id AS [RELETIONSHIP ID],Reletionship_Name AS [RELETIONSHIP NAME],Reletionship_Note AS [RELETIONSHIP NOTE] FROM Reletionships ORDER BY Reletionship_Name", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Reletionships 테이블에서 전건 취득 후 DataGridView DataSource에 대입 후 크기 조정
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Reletionship_Id AS [RELETIONSHIP ID],Reletionship_Name AS [RELETIONSHIP NAME],Reletionship_Note AS [RELETIONSHIP NOTE] FROM Reletionships WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Reletionships 테이블에서 SearchSyntax조건에 따라 데이터 취득 후 DataGridView DataSource에 대입 후 크기 조정
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class Profiles
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Public Property Profile_Id As String
                Public Property Profile_Name As String
                Public Property Reletionship_Id As String
                Public Property Reletionship_Name As String
                Public Property Profile_Phone As String
                Public Property Profile_Mail As String
                Public Property Profile_GST_No As String
                Public Property Profile_PAN_No As String
                Public Property Profile_Bank_Account As String
                Public Property Profile_Address As String
                Public Property Profile_Remark As String
                Public Property Profile_State As String
                Public Property Profile_Note As String
                Public Sub Clear()
                    '변수 빈문자열로
                    Profile_Id = String.Empty
                    Profile_Name = String.Empty
                    Reletionship_Id = String.Empty
                    Reletionship_Name = String.Empty
                    Profile_Phone = String.Empty
                    Profile_Mail = String.Empty
                    Profile_GST_No = String.Empty
                    Profile_PAN_No = String.Empty
                    Profile_Bank_Account = String.Empty
                    Profile_Address = String.Empty
                    Profile_Remark = String.Empty
                    Profile_State = String.Empty
                    Profile_Note = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_Profile_Id As TextBox, ByVal Txt_Profile_Name As TextBox, ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Profile_Phone As TextBox, ByVal Txt_Profile_Mail As TextBox, ByVal Txt_Profile_GST_No As TextBox, ByVal Txt_Profile_PAN_No As TextBox, ByVal Txt_Profile_Bank_Account As TextBox, ByVal Txt_Profile_Address As TextBox, ByVal Txt_Profile_Remark As TextBox, ByVal Txt_Profile_State As TextBox, ByVal Txt_Profile_Note As TextBox)
                    '변수 빈문자열 및 입력란 클리어
                    Clear()
                    Txt_Profile_Id.Clear()
                    Txt_Profile_Name.Clear()
                    Txt_Reletionship_Id.Clear()
                    Txt_Reletionship_Name.Clear()
                    Txt_Profile_Phone.Clear()
                    Txt_Profile_Mail.Clear()
                    Txt_Profile_GST_No.Clear()
                    Txt_Profile_PAN_No.Clear()
                    Txt_Profile_Bank_Account.Clear()
                    Txt_Profile_Address.Clear()
                    Txt_Profile_Remark.Clear()
                    Txt_Profile_State.Clear()
                    Txt_Profile_Note.Clear()
                End Sub
                Public Sub Add(ByVal Txt_Profile_Id As TextBox, ByVal Txt_Profile_Name As TextBox, ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Profile_Phone As TextBox, ByVal Txt_Profile_Mail As TextBox, ByVal Txt_Profile_GST_No As TextBox, ByVal Txt_Profile_PAN_No As TextBox, ByVal Txt_Profile_Bank_Account As TextBox, ByVal Txt_Profile_Address As TextBox, ByVal Txt_Profile_Remark As TextBox, ByVal Txt_Profile_State As TextBox, ByVal Txt_Profile_Note As TextBox)
                    ' 문자열 변환 후 변수에 대입
                    Profile_Id = Txt_Profile_Id.Text.Replace("'", "''")
                    Profile_Name = Txt_Profile_Name.Text.Replace("'", "''")
                    Reletionship_Id = Txt_Reletionship_Id.Text.Replace("'", "''")
                    Reletionship_Name = Txt_Reletionship_Name.Text.Replace("'", "''")
                    Profile_Phone = Txt_Profile_Phone.Text.Replace("'", "''")
                    Profile_Mail = Txt_Profile_Mail.Text.Replace("'", "''")
                    Profile_GST_No = Txt_Profile_GST_No.Text.Replace("'", "''")
                    Profile_PAN_No = Txt_Profile_PAN_No.Text.Replace("'", "''")
                    Profile_Bank_Account = Txt_Profile_Bank_Account.Text.Replace("'", "''")
                    Profile_Address = Txt_Profile_Address.Text.Replace("'", "''")
                    Profile_Remark = Txt_Profile_Remark.Text.Replace("'", "''")
                    Profile_State = Txt_Profile_State.Text.Replace("'", "''")
                    Profile_Note = Txt_Profile_Note.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        'Profile_Id 비포함 insert
                        If AutoID = True Then
                            sqlString = "INSERT INTO Profiles (Profile_Name,Reletionship_Id,Reletionship_Name,Profile_Phone,Profile_Mail,Profile_GST_No,Profile_PAN_No,Profile_Bank_Account,Profile_Address,Profile_Remark,Profile_State,Profile_Note) VALUES ('" & Profile_Name & "','" & Reletionship_Id & "','" & Reletionship_Name & "','" & Profile_Phone & "','" & Profile_Mail & "','" & Profile_GST_No & "','" & Profile_PAN_No & "','" & Profile_Bank_Account & "','" & Profile_Address & "','" & Profile_Remark & "','" & Profile_State & "','" & Profile_Note & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'Profile_Id 포함 insert
                            sqlString = "INSERT INTO Profiles (Profile_Id,Profile_Name,Reletionship_Id,Reletionship_Name,Profile_Phone,Profile_Mail,Profile_GST_No,Profile_PAN_No,Profile_Bank_Account,Profile_Address,Profile_Remark,Profile_State,Profile_Note) VALUES ('" & Profile_Id & "','" & Profile_Name & "','" & Reletionship_Id & "','" & Reletionship_Name & "','" & Profile_Phone & "','" & Profile_Mail & "','" & Profile_GST_No & "','" & Profile_PAN_No & "','" & Profile_Bank_Account & "','" & Profile_Address & "','" & Profile_Remark & "','" & Profile_State & "','" & Profile_Note & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'Profile_Id 비포함 UPDATE
                        If AutoID = True Then
                            sqlString = "UPDATE Profiles SET Profile_Name = '" & Profile_Name & "',Reletionship_Id = '" & Reletionship_Id & "',Reletionship_Name = '" & Reletionship_Name & "',Profile_Phone = '" & Profile_Phone & "',Profile_Mail = '" & Profile_Mail & "',Profile_GST_No = '" & Profile_GST_No & "',Profile_PAN_No = '" & Profile_PAN_No & "',Profile_Bank_Account = '" & Profile_Bank_Account & "',Profile_Address = '" & Profile_Address & "',Profile_Remark = '" & Profile_Remark & "',Profile_State = '" & Profile_State & "',Profile_Note = '" & Profile_Note & "' WHERE Profile_Id = " & Profile_Id
                            SQLQueryCommand(sqlString)
                        Else
                            'Profile_Id 포함 UPDATE
                            sqlString = "UPDATE Profiles SET Profile_Id = '" & Profile_Id & "',Profile_Name = '" & Profile_Name & "',Reletionship_Id = '" & Reletionship_Id & "',Reletionship_Name = '" & Reletionship_Name & "',Profile_Phone = '" & Profile_Phone & "',Profile_Mail = '" & Profile_Mail & "',Profile_GST_No = '" & Profile_GST_No & "',Profile_PAN_No = '" & Profile_PAN_No & "',Profile_Bank_Account = '" & Profile_Bank_Account & "',Profile_Address = '" & Profile_Address & "',Profile_Remark = '" & Profile_Remark & "',Profile_State = '" & Profile_State & "',Profile_Note = '" & Profile_Note & "' WHERE Profile_Id = " & Profile_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Profile_Name As TextBox, ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Profile_Phone As TextBox, ByVal Txt_Profile_Mail As TextBox, ByVal Txt_Profile_GST_No As TextBox, ByVal Txt_Profile_PAN_No As TextBox, ByVal Txt_Profile_Bank_Account As TextBox, ByVal Txt_Profile_Address As TextBox, ByVal Txt_Profile_Remark As TextBox, ByVal Txt_Profile_State As TextBox, ByVal Txt_Profile_Note As TextBox) As Boolean
                    '텍스트박스 null이나 빈문자열이면 포커스 설정 및 에러메세지 출력
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_Profile_Id.Text) Then
                            Txt_Profile_Id.Focus()
                            MessageBox.Show("TextBox(Profile_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_Profile_Name.Text) Then
                        Txt_Profile_Name.Focus()
                        MessageBox.Show("TextBox(Profile_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Reletionship_Id.Text) Then
                        Txt_Reletionship_Id.Focus()
                        MessageBox.Show("TextBox(Reletionship_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Reletionship_Name.Text) Then
                        Txt_Reletionship_Name.Focus()
                        MessageBox.Show("TextBox(Reletionship_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_Phone.Text) Then
                        Txt_Profile_Phone.Focus()
                        MessageBox.Show("TextBox(Profile_Phone) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_Mail.Text) Then
                        Txt_Profile_Mail.Focus()
                        MessageBox.Show("TextBox(Profile_Mail) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_GST_No.Text) Then
                        Txt_Profile_GST_No.Focus()
                        MessageBox.Show("TextBox(Profile_GST_No) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_PAN_No.Text) Then
                        Txt_Profile_PAN_No.Focus()
                        MessageBox.Show("TextBox(Profile_PAN_No) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_Bank_Account.Text) Then
                        Txt_Profile_Bank_Account.Focus()
                        MessageBox.Show("TextBox(Profile_Bank_Account) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_Address.Text) Then
                        Txt_Profile_Address.Focus()
                        MessageBox.Show("TextBox(Profile_Address) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_Remark.Text) Then
                        Txt_Profile_Remark.Focus()
                        MessageBox.Show("TextBox(Profile_Remark) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_State.Text) Then
                        Txt_Profile_State.Focus()
                        MessageBox.Show("TextBox(Profile_State) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_Note.Text) Then
                        Txt_Profile_Note.Focus()
                        MessageBox.Show("TextBox(Profile_Note) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Profile_Name As TextBox, ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Profile_Phone As TextBox, ByVal Txt_Profile_Mail As TextBox, ByVal Txt_Profile_GST_No As TextBox, ByVal Txt_Profile_PAN_No As TextBox, ByVal Txt_Profile_Bank_Account As TextBox, ByVal Txt_Profile_Address As TextBox, ByVal Txt_Profile_Remark As TextBox, ByVal Txt_Profile_State As TextBox, ByVal Txt_Profile_Note As TextBox)
                    '입력 체크
                    If IsTextBoxError(AutoID, Txt_Profile_Id, Txt_Profile_Name, Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Profile_Phone, Txt_Profile_Mail, Txt_Profile_GST_No, Txt_Profile_PAN_No, Txt_Profile_Bank_Account, Txt_Profile_Address, Txt_Profile_Remark, Txt_Profile_State, Txt_Profile_Note) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_Profile_Id, Txt_Profile_Name, Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Profile_Phone, Txt_Profile_Mail, Txt_Profile_GST_No, Txt_Profile_PAN_No, Txt_Profile_Bank_Account, Txt_Profile_Address, Txt_Profile_Remark, Txt_Profile_State, Txt_Profile_Note)
                    '커맨드 add 일 경우
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        'insert 성공시 메세지 출력 및 텍스트박스 클리어
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Profile_Id, Txt_Profile_Name, Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Profile_Phone, Txt_Profile_Mail, Txt_Profile_GST_No, Txt_Profile_PAN_No, Txt_Profile_Bank_Account, Txt_Profile_Address, Txt_Profile_Remark, Txt_Profile_State, Txt_Profile_Note)
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        'Update 성공시 메세지 출력 및 텍스트박스 클리어
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Profile_Id, Txt_Profile_Name, Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Profile_Phone, Txt_Profile_Mail, Txt_Profile_GST_No, Txt_Profile_PAN_No, Txt_Profile_Bank_Account, Txt_Profile_Address, Txt_Profile_Remark, Txt_Profile_State, Txt_Profile_Note)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 숫자가 아니면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Profile_Id = " & PrimaryKey에 해당하는 데이터 취득 후 변수에 대입
                            sqlString = "SELECT * FROM Profiles WHERE Profile_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            Profile_Id = sqlDataTable.Rows(0)("Profile_Id").ToString
                            Profile_Name = sqlDataTable.Rows(0)("Profile_Name").ToString
                            Reletionship_Id = sqlDataTable.Rows(0)("Reletionship_Id").ToString
                            Reletionship_Name = sqlDataTable.Rows(0)("Reletionship_Name").ToString
                            Profile_Phone = sqlDataTable.Rows(0)("Profile_Phone").ToString
                            Profile_Mail = sqlDataTable.Rows(0)("Profile_Mail").ToString
                            Profile_GST_No = sqlDataTable.Rows(0)("Profile_GST_No").ToString
                            Profile_PAN_No = sqlDataTable.Rows(0)("Profile_PAN_No").ToString
                            Profile_Bank_Account = sqlDataTable.Rows(0)("Profile_Bank_Account").ToString
                            Profile_Address = sqlDataTable.Rows(0)("Profile_Address").ToString
                            Profile_Remark = sqlDataTable.Rows(0)("Profile_Remark").ToString
                            Profile_State = sqlDataTable.Rows(0)("Profile_State").ToString
                            Profile_Note = sqlDataTable.Rows(0)("Profile_Note").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_Profile_Id As TextBox, ByVal Txt_Profile_Name As TextBox, ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Profile_Phone As TextBox, ByVal Txt_Profile_Mail As TextBox, ByVal Txt_Profile_GST_No As TextBox, ByVal Txt_Profile_PAN_No As TextBox, ByVal Txt_Profile_Bank_Account As TextBox, ByVal Txt_Profile_Address As TextBox, ByVal Txt_Profile_Remark As TextBox, ByVal Txt_Profile_State As TextBox, ByVal Txt_Profile_Note As TextBox)
                    Try
                        '텍스트박스 입력값이 숫자가 아니면
                        If Not IsNumeric(Txt_Profile_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Profile_Id = " & Txt_Profile_Id.Text에 해당하는 데이터 취득 후 변수 및 텍스트박스에 설정
                            sqlString = "SELECT * FROM Profiles WHERE Profile_Id = " & Txt_Profile_Id.Text
                            SQLQueryCommand(sqlString)
                            Profile_Id = sqlDataTable.Rows(0)("Profile_Id").ToString
                            Profile_Name = sqlDataTable.Rows(0)("Profile_Name").ToString
                            Reletionship_Id = sqlDataTable.Rows(0)("Reletionship_Id").ToString
                            Reletionship_Name = sqlDataTable.Rows(0)("Reletionship_Name").ToString
                            Profile_Phone = sqlDataTable.Rows(0)("Profile_Phone").ToString
                            Profile_Mail = sqlDataTable.Rows(0)("Profile_Mail").ToString
                            Profile_GST_No = sqlDataTable.Rows(0)("Profile_GST_No").ToString
                            Profile_PAN_No = sqlDataTable.Rows(0)("Profile_PAN_No").ToString
                            Profile_Bank_Account = sqlDataTable.Rows(0)("Profile_Bank_Account").ToString
                            Profile_Address = sqlDataTable.Rows(0)("Profile_Address").ToString
                            Profile_Remark = sqlDataTable.Rows(0)("Profile_Remark").ToString
                            Profile_State = sqlDataTable.Rows(0)("Profile_State").ToString
                            Profile_Note = sqlDataTable.Rows(0)("Profile_Note").ToString
                            Txt_Profile_Id.Text = Profile_Id
                            Txt_Profile_Name.Text = Profile_Name
                            Txt_Reletionship_Id.Text = Reletionship_Id
                            Txt_Reletionship_Name.Text = Reletionship_Name
                            Txt_Profile_Phone.Text = Profile_Phone
                            Txt_Profile_Mail.Text = Profile_Mail
                            Txt_Profile_GST_No.Text = Profile_GST_No
                            Txt_Profile_PAN_No.Text = Profile_PAN_No
                            Txt_Profile_Bank_Account.Text = Profile_Bank_Account
                            Txt_Profile_Address.Text = Profile_Address
                            Txt_Profile_Remark.Text = Profile_Remark
                            Txt_Profile_State.Text = Profile_State
                            Txt_Profile_Note.Text = Profile_Note
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 숫자가 아니면 에러메시지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'Profile_Id = " & PrimaryKey에 해당하는 데이터 삭제
                            sqlString = "DELETE FROM Profiles WHERE Profile_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_Profile_Id As TextBox, ByVal Txt_Profile_Name As TextBox, ByVal Txt_Reletionship_Id As TextBox, ByVal Txt_Reletionship_Name As TextBox, ByVal Txt_Profile_Phone As TextBox, ByVal Txt_Profile_Mail As TextBox, ByVal Txt_Profile_GST_No As TextBox, ByVal Txt_Profile_PAN_No As TextBox, ByVal Txt_Profile_Bank_Account As TextBox, ByVal Txt_Profile_Address As TextBox, ByVal Txt_Profile_Remark As TextBox, ByVal Txt_Profile_State As TextBox, ByVal Txt_Profile_Note As TextBox)
                    Try
                        '텍스트박스 값이 숫자가 아니면 에러메세지 출력
                        If Not IsNumeric(Txt_Profile_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그 yes 선택시  Profile_Id = " & Txt_Profile_Id.Text에 해당하는 데이터 삭제 및 텍스트박스 클리어, 메세지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM Profiles WHERE Profile_Id = " & Txt_Profile_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_Profile_Id, Txt_Profile_Name, Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Profile_Phone, Txt_Profile_Mail, Txt_Profile_GST_No, Txt_Profile_PAN_No, Txt_Profile_Bank_Account, Txt_Profile_Address, Txt_Profile_Remark, Txt_Profile_State, Txt_Profile_Note)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Profiles WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName 칼럼에 FilterPrimaryKey 와 같은 데이터가 있을 경우 해당 id 의 데이터 삭제
                        For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                            sqlString = "DELETE FROM Profiles WHERE Profile_Id = " & sqlDataTable.Rows(i).Item(0).ToString
                            SQLQueryCommand(sqlString)
                        Next
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Profiles", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    'Profiles 테이블에 데이터 존재하지 않을때
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        'Profiles 테이블에 데이터가 있으면
                        rowIndex = sqlDataTable.Rows.Count - 1
                        '마지막 행의 id 리턴
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Profiles", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '전체 행 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        sqlString = "SELECT * FROM Profiles WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        'FieldName칼럼에 Record.Text와 같은 데이터가 있으면 포커스 설정 및 에러메시지 출력
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Profiles", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            'for문 행의 숫자만큼 실행
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    '첫번째 for문
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                    '이후 for문
                                Else
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    'BoundList 문자열 대입 후
                    ListError(FieldIndex)
                    'BoundList리턴
                    Return BoundList
                End Function
                Private Sub FilterListError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Profiles WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Profiles테이블 칼럼수가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            'select 행 수만큼 for문
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                'for문 첫번째
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                    '첫번째 이외의 for문
                                Else
                                    BoundList &= vbNewLine & CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As String
                    'BoundList 문자열 설정
                    FilterListError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    'BoundList 리턴
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Profile_Id, Profile_Name FROM Profiles", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'Profiles 테이블의 id, name 데이터 콤보박스 설정에 추가
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Profile_Name"
                            .ValueMember = "Profile_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Profile_Id, Profile_Name FROM Profiles WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                    Try
                        'FilterFieldName 칼럼이 FilterPrimaryKey와 같은 id, name 취득
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '콤보박스 속성에 sql 실행 데이터 설정
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Profile_Name"
                            .ValueMember = "Profile_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Profile_Id AS [PROFILE ID],Profile_Name AS [PROFILE NAME],Reletionship_Id AS [RELETIONSHIP ID],Reletionship_Name AS [RELETIONSHIP NAME],Profile_Phone AS [PROFILE PHONE],Profile_Mail AS [PROFILE MAIL],Profile_GST_No AS [PROFILE GST NO],Profile_PAN_No AS [PROFILE PAN NO],Profile_Bank_Account AS [PROFILE BANK ACCOUNT],Profile_Address AS [PROFILE ADDRESS],Profile_Remark AS [PROFILE REMARK],Profile_State AS [PROFILE STATE],Profile_Note AS [PROFILE NOTE] FROM Profiles ORDER BY Profile_Name", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'BoundDataGridView속성에 Profile테이블 데이터 설정 및 BoundDataGridView크기 조정
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Profile_Id AS [PROFILE ID],Profile_Name AS [PROFILE NAME],Reletionship_Id AS [RELETIONSHIP ID],Reletionship_Name AS [RELETIONSHIP NAME],Profile_Phone AS [PROFILE PHONE],Profile_Mail AS [PROFILE MAIL],Profile_GST_No AS [PROFILE GST NO],Profile_PAN_No AS [PROFILE PAN NO],Profile_Bank_Account AS [PROFILE BANK ACCOUNT],Profile_Address AS [PROFILE ADDRESS],Profile_Remark AS [PROFILE REMARK],Profile_State AS [PROFILE STATE],Profile_Note AS [PROFILE NOTE] FROM Profiles WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'BoundDataGridView속성에 Profile테이블에 SearchSyntax조건에 해당하는 데이터 설정 및 BoundDataGridView크기 조정
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class Purchases
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Private Property TotalAmount As Double
                Public Property Purchase_Id As String
                Public Property Purchase_Date As String
                Public Property Profile_Id As String
                Public Property Purchase_CGST_Amount As String
                Public Property Purchase_SGST_Amount As String
                Public Property Purchase_IGST_Amount As String
                Public Property Purchase_Grandtotal_Amount As String
                Public Property Purchase_Payment_Amount As String
                Public Property Purchase_Due_Amount As String
                Public Sub Clear()
                    '변수에 빈문자열
                    Purchase_Id = String.Empty
                    Purchase_Date = String.Empty
                    Profile_Id = String.Empty
                    Purchase_CGST_Amount = String.Empty
                    Purchase_SGST_Amount = String.Empty
                    Purchase_IGST_Amount = String.Empty
                    Purchase_Grandtotal_Amount = String.Empty
                    Purchase_Payment_Amount = String.Empty
                    Purchase_Due_Amount = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Purchase_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Purchase_CGST_Amount As TextBox, ByVal Txt_Purchase_SGST_Amount As TextBox, ByVal Txt_Purchase_IGST_Amount As TextBox, ByVal Txt_Purchase_Grandtotal_Amount As TextBox, ByVal Txt_Purchase_Payment_Amount As TextBox, ByVal Txt_Purchase_Due_Amount As TextBox)
                    '변수에 빈문자열 및 텍스트박스 클리어
                    Clear()
                    Txt_Purchase_Id.Clear()
                    Txt_Purchase_Date.Clear()
                    Txt_Profile_Id.Clear()
                    Txt_Purchase_CGST_Amount.Clear()
                    Txt_Purchase_SGST_Amount.Clear()
                    Txt_Purchase_IGST_Amount.Clear()
                    Txt_Purchase_Grandtotal_Amount.Clear()
                    Txt_Purchase_Payment_Amount.Clear()
                    Txt_Purchase_Due_Amount.Clear()
                End Sub
                Public Sub Add(ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Purchase_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Purchase_CGST_Amount As TextBox, ByVal Txt_Purchase_SGST_Amount As TextBox, ByVal Txt_Purchase_IGST_Amount As TextBox, ByVal Txt_Purchase_Grandtotal_Amount As TextBox, ByVal Txt_Purchase_Payment_Amount As TextBox, ByVal Txt_Purchase_Due_Amount As TextBox)
                    '입력된 문자열에 '문자 ''로 변환 후 변수에 대입
                    Purchase_Id = Txt_Purchase_Id.Text.Replace("'", "''")
                    Purchase_Date = Txt_Purchase_Date.Text.Replace("'", "''")
                    Profile_Id = Txt_Profile_Id.Text.Replace("'", "''")
                    Purchase_CGST_Amount = Txt_Purchase_CGST_Amount.Text.Replace("'", "''")
                    Purchase_SGST_Amount = Txt_Purchase_SGST_Amount.Text.Replace("'", "''")
                    Purchase_IGST_Amount = Txt_Purchase_IGST_Amount.Text.Replace("'", "''")
                    Purchase_Grandtotal_Amount = Txt_Purchase_Grandtotal_Amount.Text.Replace("'", "''")
                    Purchase_Payment_Amount = Txt_Purchase_Payment_Amount.Text.Replace("'", "''")
                    Purchase_Due_Amount = Txt_Purchase_Due_Amount.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        'Purchase_Id 비포함 insert
                        If AutoID = True Then
                            sqlString = "INSERT INTO Purchases (Purchase_Date,Profile_Id,Purchase_CGST_Amount,Purchase_SGST_Amount,Purchase_IGST_Amount,Purchase_Grandtotal_Amount,Purchase_Payment_Amount,Purchase_Due_Amount) VALUES ('" & Purchase_Date & "','" & Profile_Id & "','" & Purchase_CGST_Amount & "','" & Purchase_SGST_Amount & "','" & Purchase_IGST_Amount & "','" & Purchase_Grandtotal_Amount & "','" & Purchase_Payment_Amount & "','" & Purchase_Due_Amount & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'Purchase_Id 포함 insert
                            sqlString = "INSERT INTO Purchases (Purchase_Id,Purchase_Date,Profile_Id,Purchase_CGST_Amount,Purchase_SGST_Amount,Purchase_IGST_Amount,Purchase_Grandtotal_Amount,Purchase_Payment_Amount,Purchase_Due_Amount) VALUES ('" & Purchase_Id & "','" & Purchase_Date & "','" & Profile_Id & "','" & Purchase_CGST_Amount & "','" & Purchase_SGST_Amount & "','" & Purchase_IGST_Amount & "','" & Purchase_Grandtotal_Amount & "','" & Purchase_Payment_Amount & "','" & Purchase_Due_Amount & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'Purchase_Id 비포함 update
                        If AutoID = True Then
                            sqlString = "UPDATE Purchases SET Purchase_Date = '" & Purchase_Date & "',Profile_Id = '" & Profile_Id & "',Purchase_CGST_Amount = '" & Purchase_CGST_Amount & "',Purchase_SGST_Amount = '" & Purchase_SGST_Amount & "',Purchase_IGST_Amount = '" & Purchase_IGST_Amount & "',Purchase_Grandtotal_Amount = '" & Purchase_Grandtotal_Amount & "',Purchase_Payment_Amount = '" & Purchase_Payment_Amount & "',Purchase_Due_Amount = '" & Purchase_Due_Amount & "' WHERE Purchase_Id = " & Purchase_Id
                            SQLQueryCommand(sqlString)
                        Else
                            'Purchase_Id 포함 update
                            sqlString = "UPDATE Purchases SET Purchase_Id = '" & Purchase_Id & "',Purchase_Date = '" & Purchase_Date & "',Profile_Id = '" & Profile_Id & "',Purchase_CGST_Amount = '" & Purchase_CGST_Amount & "',Purchase_SGST_Amount = '" & Purchase_SGST_Amount & "',Purchase_IGST_Amount = '" & Purchase_IGST_Amount & "',Purchase_Grandtotal_Amount = '" & Purchase_Grandtotal_Amount & "',Purchase_Payment_Amount = '" & Purchase_Payment_Amount & "',Purchase_Due_Amount = '" & Purchase_Due_Amount & "' WHERE Purchase_Id = " & Purchase_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Purchase_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Purchase_CGST_Amount As TextBox, ByVal Txt_Purchase_SGST_Amount As TextBox, ByVal Txt_Purchase_IGST_Amount As TextBox, ByVal Txt_Purchase_Grandtotal_Amount As TextBox, ByVal Txt_Purchase_Payment_Amount As TextBox, ByVal Txt_Purchase_Due_Amount As TextBox) As Boolean
                    '텍스트박스가 null 혹은 빈문자열일 경우 포커스 설정 및 에러메세지 출력
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_Purchase_Id.Text) Then
                            Txt_Purchase_Id.Focus()
                            MessageBox.Show("TextBox(Purchase_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_Purchase_Date.Text) Then
                        Txt_Purchase_Date.Focus()
                        MessageBox.Show("TextBox(Purchase_Date) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_Id.Text) Then
                        Txt_Profile_Id.Focus()
                        MessageBox.Show("TextBox(Profile_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Purchase_CGST_Amount.Text) Then
                        Txt_Purchase_CGST_Amount.Focus()
                        MessageBox.Show("TextBox(Purchase_CGST_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Purchase_SGST_Amount.Text) Then
                        Txt_Purchase_SGST_Amount.Focus()
                        MessageBox.Show("TextBox(Purchase_SGST_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Purchase_IGST_Amount.Text) Then
                        Txt_Purchase_IGST_Amount.Focus()
                        MessageBox.Show("TextBox(Purchase_IGST_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Purchase_Grandtotal_Amount.Text) Then
                        Txt_Purchase_Grandtotal_Amount.Focus()
                        MessageBox.Show("TextBox(Purchase_Grandtotal_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Purchase_Payment_Amount.Text) Then
                        Txt_Purchase_Payment_Amount.Focus()
                        MessageBox.Show("TextBox(Purchase_Payment_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Purchase_Due_Amount.Text) Then
                        Txt_Purchase_Due_Amount.Focus()
                        MessageBox.Show("TextBox(Purchase_Due_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Purchase_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Purchase_CGST_Amount As TextBox, ByVal Txt_Purchase_SGST_Amount As TextBox, ByVal Txt_Purchase_IGST_Amount As TextBox, ByVal Txt_Purchase_Grandtotal_Amount As TextBox, ByVal Txt_Purchase_Payment_Amount As TextBox, ByVal Txt_Purchase_Due_Amount As TextBox)
                    '입력 체크
                    If IsTextBoxError(AutoID, Txt_Purchase_Id, Txt_Purchase_Date, Txt_Profile_Id, Txt_Purchase_CGST_Amount, Txt_Purchase_SGST_Amount, Txt_Purchase_IGST_Amount, Txt_Purchase_Grandtotal_Amount, Txt_Purchase_Payment_Amount, Txt_Purchase_Due_Amount) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_Purchase_Id, Txt_Purchase_Date, Txt_Profile_Id, Txt_Purchase_CGST_Amount, Txt_Purchase_SGST_Amount, Txt_Purchase_IGST_Amount, Txt_Purchase_Grandtotal_Amount, Txt_Purchase_Payment_Amount, Txt_Purchase_Due_Amount)
                    '커맨드 add일 경우 insert 실행. insert 성공시 메세지 출력 및 텍스트박스 클리어
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Purchase_Id, Txt_Purchase_Date, Txt_Profile_Id, Txt_Purchase_CGST_Amount, Txt_Purchase_SGST_Amount, Txt_Purchase_IGST_Amount, Txt_Purchase_Grandtotal_Amount, Txt_Purchase_Payment_Amount, Txt_Purchase_Due_Amount)
                        '커맨드 edit일 경우 update 실행. update 성공시 메세지 출력 및 텍스트박스 클리어
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Purchase_Id, Txt_Purchase_Date, Txt_Profile_Id, Txt_Purchase_CGST_Amount, Txt_Purchase_SGST_Amount, Txt_Purchase_IGST_Amount, Txt_Purchase_Grandtotal_Amount, Txt_Purchase_Payment_Amount, Txt_Purchase_Due_Amount)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를 변수에 대입
                        Else
                            sqlString = "SELECT * FROM Purchases WHERE Purchase_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            Purchase_Id = sqlDataTable.Rows(0)("Purchase_Id").ToString
                            Purchase_Date = sqlDataTable.Rows(0)("Purchase_Date").ToString
                            Profile_Id = sqlDataTable.Rows(0)("Profile_Id").ToString
                            Purchase_CGST_Amount = sqlDataTable.Rows(0)("Purchase_CGST_Amount").ToString
                            Purchase_SGST_Amount = sqlDataTable.Rows(0)("Purchase_SGST_Amount").ToString
                            Purchase_IGST_Amount = sqlDataTable.Rows(0)("Purchase_IGST_Amount").ToString
                            Purchase_Grandtotal_Amount = sqlDataTable.Rows(0)("Purchase_Grandtotal_Amount").ToString
                            Purchase_Payment_Amount = sqlDataTable.Rows(0)("Purchase_Payment_Amount").ToString
                            Purchase_Due_Amount = sqlDataTable.Rows(0)("Purchase_Due_Amount").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Purchase_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Purchase_CGST_Amount As TextBox, ByVal Txt_Purchase_SGST_Amount As TextBox, ByVal Txt_Purchase_IGST_Amount As TextBox, ByVal Txt_Purchase_Grandtotal_Amount As TextBox, ByVal Txt_Purchase_Payment_Amount As TextBox, ByVal Txt_Purchase_Due_Amount As TextBox)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_Purchase_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를 변수 및 텍스트박스에 대입 
                            sqlString = "SELECT * FROM Purchases WHERE Purchase_Id = " & Txt_Purchase_Id.Text
                            SQLQueryCommand(sqlString)
                            Purchase_Id = sqlDataTable.Rows(0)("Purchase_Id").ToString
                            Purchase_Date = sqlDataTable.Rows(0)("Purchase_Date").ToString
                            Profile_Id = sqlDataTable.Rows(0)("Profile_Id").ToString
                            Purchase_CGST_Amount = sqlDataTable.Rows(0)("Purchase_CGST_Amount").ToString
                            Purchase_SGST_Amount = sqlDataTable.Rows(0)("Purchase_SGST_Amount").ToString
                            Purchase_IGST_Amount = sqlDataTable.Rows(0)("Purchase_IGST_Amount").ToString
                            Purchase_Grandtotal_Amount = sqlDataTable.Rows(0)("Purchase_Grandtotal_Amount").ToString
                            Purchase_Payment_Amount = sqlDataTable.Rows(0)("Purchase_Payment_Amount").ToString
                            Purchase_Due_Amount = sqlDataTable.Rows(0)("Purchase_Due_Amount").ToString
                            Txt_Purchase_Id.Text = Purchase_Id
                            Txt_Purchase_Date.Text = Purchase_Date
                            Txt_Profile_Id.Text = Profile_Id
                            Txt_Purchase_CGST_Amount.Text = Purchase_CGST_Amount
                            Txt_Purchase_SGST_Amount.Text = Purchase_SGST_Amount
                            Txt_Purchase_IGST_Amount.Text = Purchase_IGST_Amount
                            Txt_Purchase_Grandtotal_Amount.Text = Purchase_Grandtotal_Amount
                            Txt_Purchase_Payment_Amount.Text = Purchase_Payment_Amount
                            Txt_Purchase_Due_Amount.Text = Purchase_Due_Amount
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  삭제
                            sqlString = "DELETE FROM Purchases WHERE Purchase_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Purchase_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Purchase_CGST_Amount As TextBox, ByVal Txt_Purchase_SGST_Amount As TextBox, ByVal Txt_Purchase_IGST_Amount As TextBox, ByVal Txt_Purchase_Grandtotal_Amount As TextBox, ByVal Txt_Purchase_Payment_Amount As TextBox, ByVal Txt_Purchase_Due_Amount As TextBox)
                    Try
                        '텍스트박스에 입력된 값이 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_Purchase_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes선택시 텍스트박스에 입력된 값과 같은 값을 지닌 칼럼을 찾아 해당 행을 삭제. 텍스트박스 클리어 후 메시지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM Purchases WHERE Purchase_Id = " & Txt_Purchase_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_Purchase_Id, Txt_Purchase_Date, Txt_Profile_Id, Txt_Purchase_CGST_Amount, Txt_Purchase_SGST_Amount, Txt_Purchase_IGST_Amount, Txt_Purchase_Grandtotal_Amount, Txt_Purchase_Payment_Amount, Txt_Purchase_Due_Amount)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Purchases WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName 칼럼의 값이 FilterPrimaryKey 인 행을 찾아, 해당행이 존재할 경우 삭제
                        For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                            sqlString = "DELETE FROM Purchases WHERE Purchase_Id = " & sqlDataTable.Rows(i).Item(0).ToString
                            SQLQueryCommand(sqlString)
                        Next
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Purchases", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '테이블에서 전건 출력 후 0건이면 0리턴 행이 존재할 경우 마지막 행의 id값 리턴
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Purchases", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '전체 행 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Private Sub TotalAmountError(ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Purchases", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FieldIndex As Integer) As Double
                    TotalAmountError(FieldIndex)
                    Return TotalAmount
                End Function
                Private Sub FilterTotalAmountError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Purchases WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As Double
                    'TotalAmount 변수에 값 대입후 리턴
                    FilterTotalAmountError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return TotalAmount
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        sqlString = "SELECT * FROM Purchases WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        'FieldName칼럼에 텍스트박스 값과 같은 데이터가 존재하면 포커스 설정 및 에러메세지 출력
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Purchases", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    ListError(FieldIndex)
                    Return BoundList
                End Function
                Private Sub FilterListError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Purchases WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName칼럼의 값이 FilterPrimaryKey와 같은 행 테이블로부터 취득 후 칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                Else
                                    BoundList &= vbNewLine & CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As String
                    FilterListError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Purchase_Id, Purchase_Date FROM Purchases", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Purchase_Date"
                            .ValueMember = "Purchase_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Purchase_Id, Purchase_Date FROM Purchases WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName칼럼 값 = FilterPrimaryKey인 행
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Purchase_Date"
                            .ValueMember = "Purchase_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Purchase_Id AS [PURCHASE ID],Purchase_Date AS [PURCHASE DATE],Profile_Id AS [PROFILE ID],Purchase_CGST_Amount AS [PURCHASE CGST AMOUNT],Purchase_SGST_Amount AS [PURCHASE SGST AMOUNT],Purchase_IGST_Amount AS [PURCHASE IGST AMOUNT],Purchase_Grandtotal_Amount AS [PURCHASE GRANDTOTAL AMOUNT],Purchase_Payment_Amount AS [PURCHASE PAYMENT AMOUNT],Purchase_Due_Amount AS [PURCHASE DUE AMOUNT] FROM Purchases ORDER BY Purchase_Date", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Purchase_Id AS [PURCHASE ID],Purchase_Date AS [PURCHASE DATE],Profile_Id AS [PROFILE ID],Purchase_CGST_Amount AS [PURCHASE CGST AMOUNT],Purchase_SGST_Amount AS [PURCHASE SGST AMOUNT],Purchase_IGST_Amount AS [PURCHASE IGST AMOUNT],Purchase_Grandtotal_Amount AS [PURCHASE GRANDTOTAL AMOUNT],Purchase_Payment_Amount AS [PURCHASE PAYMENT AMOUNT],Purchase_Due_Amount AS [PURCHASE DUE AMOUNT] FROM Purchases WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'SearchSyntax 조건을 만족하는 행
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class PurchaseDetails
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Private Property TotalAmount As Double
                Public Property PurchaseDetail_Id As String
                Public Property Purchase_Id As String
                Public Property Product_Id As String
                Public Property Product_Name As String
                Public Property HSN_Code As String
                Public Property Purchase_Quantity As String
                Public Property Unit_Name As String
                Public Property Purchase_Rate_Amount As String
                Public Property Purchase_Subtotal_Amount As String
                Public Sub Clear()
                    '변수에 빈문자열
                    PurchaseDetail_Id = String.Empty
                    Purchase_Id = String.Empty
                    Product_Id = String.Empty
                    Product_Name = String.Empty
                    HSN_Code = String.Empty
                    Purchase_Quantity = String.Empty
                    Unit_Name = String.Empty
                    Purchase_Rate_Amount = String.Empty
                    Purchase_Subtotal_Amount = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Purchase_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Purchase_Rate_Amount As TextBox, ByVal Txt_Purchase_Subtotal_Amount As TextBox)
                    '변수에 빈문자열 및 텍스트박스 클리어
                    Clear()
                    Txt_PurchaseDetail_Id.Clear()
                    Txt_Purchase_Id.Clear()
                    Txt_Product_Id.Clear()
                    Txt_Product_Name.Clear()
                    Txt_HSN_Code.Clear()
                    Txt_Purchase_Quantity.Clear()
                    Txt_Unit_Name.Clear()
                    Txt_Purchase_Rate_Amount.Clear()
                    Txt_Purchase_Subtotal_Amount.Clear()
                End Sub
                '입력된 문자열에 '문자 ''로 변환 후 변수에 대입
                Public Sub Add(ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Purchase_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Purchase_Rate_Amount As TextBox, ByVal Txt_Purchase_Subtotal_Amount As TextBox)
                    PurchaseDetail_Id = Txt_PurchaseDetail_Id.Text.Replace("'", "''")
                    Purchase_Id = Txt_Purchase_Id.Text.Replace("'", "''")
                    Product_Id = Txt_Product_Id.Text.Replace("'", "''")
                    Product_Name = Txt_Product_Name.Text.Replace("'", "''")
                    HSN_Code = Txt_HSN_Code.Text.Replace("'", "''")
                    Purchase_Quantity = Txt_Purchase_Quantity.Text.Replace("'", "''")
                    Unit_Name = Txt_Unit_Name.Text.Replace("'", "''")
                    Purchase_Rate_Amount = Txt_Purchase_Rate_Amount.Text.Replace("'", "''")
                    Purchase_Subtotal_Amount = Txt_Purchase_Subtotal_Amount.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        'PurchaseDetail_Id 비포함 insert
                        If AutoID = True Then
                            sqlString = "INSERT INTO PurchaseDetails (Purchase_Id,Product_Id,Product_Name,HSN_Code,Purchase_Quantity,Unit_Name,Purchase_Rate_Amount,Purchase_Subtotal_Amount) VALUES ('" & Purchase_Id & "','" & Product_Id & "','" & Product_Name & "','" & HSN_Code & "','" & Purchase_Quantity & "','" & Unit_Name & "','" & Purchase_Rate_Amount & "','" & Purchase_Subtotal_Amount & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'PurchaseDetail_Id 비포함 insert
                            sqlString = "INSERT INTO PurchaseDetails (PurchaseDetail_Id,Purchase_Id,Product_Id,Product_Name,HSN_Code,Purchase_Quantity,Unit_Name,Purchase_Rate_Amount,Purchase_Subtotal_Amount) VALUES ('" & PurchaseDetail_Id & "','" & Purchase_Id & "','" & Product_Id & "','" & Product_Name & "','" & HSN_Code & "','" & Purchase_Quantity & "','" & Unit_Name & "','" & Purchase_Rate_Amount & "','" & Purchase_Subtotal_Amount & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'PurchaseDetail_Id 비포함 update
                        If AutoID = True Then
                            sqlString = "UPDATE PurchaseDetails SET Purchase_Id = '" & Purchase_Id & "',Product_Id = '" & Product_Id & "',Product_Name = '" & Product_Name & "',HSN_Code = '" & HSN_Code & "',Purchase_Quantity = '" & Purchase_Quantity & "',Unit_Name = '" & Unit_Name & "',Purchase_Rate_Amount = '" & Purchase_Rate_Amount & "',Purchase_Subtotal_Amount = '" & Purchase_Subtotal_Amount & "' WHERE PurchaseDetail_Id = " & PurchaseDetail_Id
                            SQLQueryCommand(sqlString)
                        Else
                            'PurchaseDetail_Id 포함 update
                            sqlString = "UPDATE PurchaseDetails SET PurchaseDetail_Id = '" & PurchaseDetail_Id & "',Purchase_Id = '" & Purchase_Id & "',Product_Id = '" & Product_Id & "',Product_Name = '" & Product_Name & "',HSN_Code = '" & HSN_Code & "',Purchase_Quantity = '" & Purchase_Quantity & "',Unit_Name = '" & Unit_Name & "',Purchase_Rate_Amount = '" & Purchase_Rate_Amount & "',Purchase_Subtotal_Amount = '" & Purchase_Subtotal_Amount & "' WHERE PurchaseDetail_Id = " & PurchaseDetail_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Purchase_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Purchase_Rate_Amount As TextBox, ByVal Txt_Purchase_Subtotal_Amount As TextBox) As Boolean
                    '텍스트박스가 null 혹은 빈문자열일 경우 포커스 설정 및 에러메세지 출력
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_PurchaseDetail_Id.Text) Then
                            Txt_PurchaseDetail_Id.Focus()
                            MessageBox.Show("TextBox(PurchaseDetail_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_Purchase_Id.Text) Then
                        Txt_Purchase_Id.Focus()
                        MessageBox.Show("TextBox(Purchase_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Id.Text) Then
                        Txt_Product_Id.Focus()
                        MessageBox.Show("TextBox(Product_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Name.Text) Then
                        Txt_Product_Name.Focus()
                        MessageBox.Show("TextBox(Product_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_HSN_Code.Text) Then
                        Txt_HSN_Code.Focus()
                        MessageBox.Show("TextBox(HSN_Code) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Purchase_Quantity.Text) Then
                        Txt_Purchase_Quantity.Focus()
                        MessageBox.Show("TextBox(Purchase_Quantity) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Unit_Name.Text) Then
                        Txt_Unit_Name.Focus()
                        MessageBox.Show("TextBox(Unit_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Purchase_Rate_Amount.Text) Then
                        Txt_Purchase_Rate_Amount.Focus()
                        MessageBox.Show("TextBox(Purchase_Rate_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Purchase_Subtotal_Amount.Text) Then
                        Txt_Purchase_Subtotal_Amount.Focus()
                        MessageBox.Show("TextBox(Purchase_Subtotal_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Purchase_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Purchase_Rate_Amount As TextBox, ByVal Txt_Purchase_Subtotal_Amount As TextBox)
                    '입력 체크
                    If IsTextBoxError(AutoID, Txt_PurchaseDetail_Id, Txt_Purchase_Id, Txt_Product_Id, Txt_Product_Name, Txt_HSN_Code, Txt_Purchase_Quantity, Txt_Unit_Name, Txt_Purchase_Rate_Amount, Txt_Purchase_Subtotal_Amount) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_PurchaseDetail_Id, Txt_Purchase_Id, Txt_Product_Id, Txt_Product_Name, Txt_HSN_Code, Txt_Purchase_Quantity, Txt_Unit_Name, Txt_Purchase_Rate_Amount, Txt_Purchase_Subtotal_Amount)
                    '커맨드 add일 경우 insert 실행. insert 성공시 메세지 출력 및 텍스트박스 클리어
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_PurchaseDetail_Id, Txt_Purchase_Id, Txt_Product_Id, Txt_Product_Name, Txt_HSN_Code, Txt_Purchase_Quantity, Txt_Unit_Name, Txt_Purchase_Rate_Amount, Txt_Purchase_Subtotal_Amount)
                        '커맨드 edit일 경우 update 실행. update 성공시 메세지 출력 및 텍스트박스 클리어
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_PurchaseDetail_Id, Txt_Purchase_Id, Txt_Product_Id, Txt_Product_Name, Txt_HSN_Code, Txt_Purchase_Quantity, Txt_Unit_Name, Txt_Purchase_Rate_Amount, Txt_Purchase_Subtotal_Amount)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수에 대입
                            sqlString = "SELECT * FROM PurchaseDetails WHERE PurchaseDetail_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            PurchaseDetail_Id = sqlDataTable.Rows(0)("PurchaseDetail_Id").ToString
                            Purchase_Id = sqlDataTable.Rows(0)("Purchase_Id").ToString
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            Product_Name = sqlDataTable.Rows(0)("Product_Name").ToString
                            HSN_Code = sqlDataTable.Rows(0)("HSN_Code").ToString
                            Purchase_Quantity = sqlDataTable.Rows(0)("Purchase_Quantity").ToString
                            Unit_Name = sqlDataTable.Rows(0)("Unit_Name").ToString
                            Purchase_Rate_Amount = sqlDataTable.Rows(0)("Purchase_Rate_Amount").ToString
                            Purchase_Subtotal_Amount = sqlDataTable.Rows(0)("Purchase_Subtotal_Amount").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Purchase_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Purchase_Rate_Amount As TextBox, ByVal Txt_Purchase_Subtotal_Amount As TextBox)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_PurchaseDetail_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수 및 텍스트박스에 대입
                            sqlString = "SELECT * FROM PurchaseDetails WHERE PurchaseDetail_Id = " & Txt_PurchaseDetail_Id.Text
                            SQLQueryCommand(sqlString)
                            PurchaseDetail_Id = sqlDataTable.Rows(0)("PurchaseDetail_Id").ToString
                            Purchase_Id = sqlDataTable.Rows(0)("Purchase_Id").ToString
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            Product_Name = sqlDataTable.Rows(0)("Product_Name").ToString
                            HSN_Code = sqlDataTable.Rows(0)("HSN_Code").ToString
                            Purchase_Quantity = sqlDataTable.Rows(0)("Purchase_Quantity").ToString
                            Unit_Name = sqlDataTable.Rows(0)("Unit_Name").ToString
                            Purchase_Rate_Amount = sqlDataTable.Rows(0)("Purchase_Rate_Amount").ToString
                            Purchase_Subtotal_Amount = sqlDataTable.Rows(0)("Purchase_Subtotal_Amount").ToString
                            Txt_PurchaseDetail_Id.Text = PurchaseDetail_Id
                            Txt_Purchase_Id.Text = Purchase_Id
                            Txt_Product_Id.Text = Product_Id
                            Txt_Product_Name.Text = Product_Name
                            Txt_HSN_Code.Text = HSN_Code
                            Txt_Purchase_Quantity.Text = Purchase_Quantity
                            Txt_Unit_Name.Text = Unit_Name
                            Txt_Purchase_Rate_Amount.Text = Purchase_Rate_Amount
                            Txt_Purchase_Subtotal_Amount.Text = Purchase_Subtotal_Amount
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  삭제
                            sqlString = "DELETE FROM PurchaseDetails WHERE PurchaseDetail_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Purchase_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Purchase_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Purchase_Rate_Amount As TextBox, ByVal Txt_Purchase_Subtotal_Amount As TextBox)
                    Try
                        '텍스트박스에 입력된 값이 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_PurchaseDetail_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes선택시 텍스트박스에 입력된 값과 같은 값을 지닌 칼럼을 찾아 해당 행을 삭제. 
                            '텍스트박스 클리어 후 메시지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM PurchaseDetails WHERE PurchaseDetail_Id = " & Txt_PurchaseDetail_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_PurchaseDetail_Id, Txt_Purchase_Id, Txt_Product_Id, Txt_Product_Name, Txt_HSN_Code, Txt_Purchase_Quantity, Txt_Unit_Name, Txt_Purchase_Rate_Amount, Txt_Purchase_Subtotal_Amount)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseDetails WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName 칼럼의 값이 FilterPrimaryKey 인 행을 찾아, 해당행이 존재할 경우 삭제
                        For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                            sqlString = "DELETE FROM PurchaseDetails WHERE PurchaseDetail_Id = " & sqlDataTable.Rows(i).Item(0).ToString
                            SQLQueryCommand(sqlString)
                        Next
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseDetails", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '테이블에서 전건 출력 후 0건이면 0리턴 행이 존재할 경우 마지막 행의 id값 리턴
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseDetails", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '전체 행 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Private Sub TotalAmountError(ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseDetails", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FieldIndex As Integer) As Double
                    'TotalAmount 변수에 값 대입후 리턴
                    TotalAmountError(FieldIndex)
                    Return TotalAmount
                End Function
                Private Sub FilterTotalAmountError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseDetails WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As Double
                    'TotalAmount 변수에 값 대입후 리턴
                    FilterTotalAmountError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return TotalAmount
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        'FieldName칼럼에 텍스트박스 값과 같은 데이터가 존재하면 포커스 설정 및 에러메세지 출력
                        sqlString = "SELECT * FROM PurchaseDetails WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseDetails", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    ListError(FieldIndex)
                    Return BoundList
                End Function
                Private Sub FilterListError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseDetails WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'ilterFieldName칼럼의 값이 FilterPrimaryKey와 같은 행 테이블로부터 취득 후 칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                Else
                                    BoundList &= vbNewLine & CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As String
                    FilterListError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT PurchaseDetail_Id, Purchase_Id FROM PurchaseDetails", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Purchase_Id"
                            .ValueMember = "PurchaseDetail_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT PurchaseDetail_Id, Purchase_Id FROM PurchaseDetails WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName칼럼 값 = FilterPrimaryKey인 행
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Purchase_Id"
                            .ValueMember = "PurchaseDetail_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT PurchaseDetail_Id AS [PURCHASEDETAIL ID],Purchase_Id AS [PURCHASE ID],Product_Id AS [PRODUCT ID],Product_Name AS [PRODUCT NAME],HSN_Code AS [HSN CODE],Purchase_Quantity AS [PURCHASE QUANTITY],Unit_Name AS [UNIT NAME],Purchase_Rate_Amount AS [PURCHASE RATE AMOUNT],Purchase_Subtotal_Amount AS [PURCHASE SUBTOTAL AMOUNT] FROM PurchaseDetails ORDER BY Purchase_Id", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT PurchaseDetail_Id AS [PURCHASEDETAIL ID],Purchase_Id AS [PURCHASE ID],Product_Id AS [PRODUCT ID],Product_Name AS [PRODUCT NAME],HSN_Code AS [HSN CODE],Purchase_Quantity AS [PURCHASE QUANTITY],Unit_Name AS [UNIT NAME],Purchase_Rate_Amount AS [PURCHASE RATE AMOUNT],Purchase_Subtotal_Amount AS [PURCHASE SUBTOTAL AMOUNT] FROM PurchaseDetails WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'SearchSyntax 조건을 만족하는 행
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class PurchaseBarcodes
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Public Property PurchaseBarcode_Id As String
                Public Property PurchaseDetail_Id As String
                Public Property Product_Id As String
                Public Property Product_Barcode As String
                Public Sub Clear()
                    '변수에 빈문자열
                    PurchaseBarcode_Id = String.Empty
                    PurchaseDetail_Id = String.Empty
                    Product_Id = String.Empty
                    Product_Barcode = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_PurchaseBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Barcode As TextBox)
                    '변수에 빈문자열 및 텍스트박스 클리어
                    Clear()
                    Txt_PurchaseBarcode_Id.Clear()
                    Txt_PurchaseDetail_Id.Clear()
                    Txt_Product_Id.Clear()
                    Txt_Product_Barcode.Clear()
                End Sub
                Public Sub Add(ByVal Txt_PurchaseBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Barcode As TextBox)
                    '입력된 문자열에 '문자 ''로 변환 후 변수에 대입
                    PurchaseBarcode_Id = Txt_PurchaseBarcode_Id.Text.Replace("'", "''")
                    PurchaseDetail_Id = Txt_PurchaseDetail_Id.Text.Replace("'", "''")
                    Product_Id = Txt_Product_Id.Text.Replace("'", "''")
                    Product_Barcode = Txt_Product_Barcode.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        If AutoID = True Then
                            'PurchaseBarcode_Id 비포함 insert
                            sqlString = "INSERT INTO PurchaseBarcodes (PurchaseDetail_Id,Product_Id,Product_Barcode) VALUES ('" & PurchaseDetail_Id & "','" & Product_Id & "','" & Product_Barcode & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'PurchaseBarcode_Id 비포함 insert
                            sqlString = "INSERT INTO PurchaseBarcodes (PurchaseBarcode_Id,PurchaseDetail_Id,Product_Id,Product_Barcode) VALUES ('" & PurchaseBarcode_Id & "','" & PurchaseDetail_Id & "','" & Product_Id & "','" & Product_Barcode & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'PurchaseBarcode_Id 비포함 update
                        If AutoID = True Then
                            sqlString = "UPDATE PurchaseBarcodes SET PurchaseDetail_Id = '" & PurchaseDetail_Id & "',Product_Id = '" & Product_Id & "',Product_Barcode = '" & Product_Barcode & "' WHERE PurchaseBarcode_Id = " & PurchaseBarcode_Id
                            SQLQueryCommand(sqlString)
                            'PurchaseBarcode_Id 포함 update
                        Else
                            sqlString = "UPDATE PurchaseBarcodes SET PurchaseBarcode_Id = '" & PurchaseBarcode_Id & "',PurchaseDetail_Id = '" & PurchaseDetail_Id & "',Product_Id = '" & Product_Id & "',Product_Barcode = '" & Product_Barcode & "' WHERE PurchaseBarcode_Id = " & PurchaseBarcode_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_PurchaseBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Barcode As TextBox) As Boolean
                    '텍스트박스가 null 혹은 빈문자열일 경우 포커스 설정 및 에러메세지 출력
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_PurchaseBarcode_Id.Text) Then
                            Txt_PurchaseBarcode_Id.Focus()
                            MessageBox.Show("TextBox(PurchaseBarcode_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_PurchaseDetail_Id.Text) Then
                        Txt_PurchaseDetail_Id.Focus()
                        MessageBox.Show("TextBox(PurchaseDetail_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Id.Text) Then
                        Txt_Product_Id.Focus()
                        MessageBox.Show("TextBox(Product_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Barcode.Text) Then
                        Txt_Product_Barcode.Focus()
                        MessageBox.Show("TextBox(Product_Barcode) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_PurchaseBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Barcode As TextBox)
                    '입력 체크
                    If IsTextBoxError(AutoID, Txt_PurchaseBarcode_Id, Txt_PurchaseDetail_Id, Txt_Product_Id, Txt_Product_Barcode) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_PurchaseBarcode_Id, Txt_PurchaseDetail_Id, Txt_Product_Id, Txt_Product_Barcode)
                    '커맨드 add일 경우 insert 실행. insert 성공시 메세지 출력 및 텍스트박스 클리어
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_PurchaseBarcode_Id, Txt_PurchaseDetail_Id, Txt_Product_Id, Txt_Product_Barcode)
                        '커맨드 edit일 경우 update 실행. update 성공시 메세지 출력 및 텍스트박스 클리어
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_PurchaseBarcode_Id, Txt_PurchaseDetail_Id, Txt_Product_Id, Txt_Product_Barcode)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수에 대입
                            sqlString = "SELECT * FROM PurchaseBarcodes WHERE PurchaseBarcode_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            PurchaseBarcode_Id = sqlDataTable.Rows(0)("PurchaseBarcode_Id").ToString
                            PurchaseDetail_Id = sqlDataTable.Rows(0)("PurchaseDetail_Id").ToString
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            Product_Barcode = sqlDataTable.Rows(0)("Product_Barcode").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_PurchaseBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Barcode As TextBox)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_PurchaseBarcode_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수 및 텍스트박스에 대입
                            sqlString = "SELECT * FROM PurchaseBarcodes WHERE PurchaseBarcode_Id = " & Txt_PurchaseBarcode_Id.Text
                            SQLQueryCommand(sqlString)
                            PurchaseBarcode_Id = sqlDataTable.Rows(0)("PurchaseBarcode_Id").ToString
                            PurchaseDetail_Id = sqlDataTable.Rows(0)("PurchaseDetail_Id").ToString
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            Product_Barcode = sqlDataTable.Rows(0)("Product_Barcode").ToString
                            Txt_PurchaseBarcode_Id.Text = PurchaseBarcode_Id
                            Txt_PurchaseDetail_Id.Text = PurchaseDetail_Id
                            Txt_Product_Id.Text = Product_Id
                            Txt_Product_Barcode.Text = Product_Barcode
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  삭제
                            sqlString = "DELETE FROM PurchaseBarcodes WHERE PurchaseBarcode_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_PurchaseBarcode_Id As TextBox, ByVal Txt_PurchaseDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Barcode As TextBox)
                    Try
                        '텍스트박스에 입력된 값이 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_PurchaseBarcode_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes선택시 텍스트박스에 입력된 값과 같은 값을 지닌 칼럼을 찾아 해당 행을 삭제. 
                            '텍스트박스 클리어 후 메시지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM PurchaseBarcodes WHERE PurchaseBarcode_Id = " & Txt_PurchaseBarcode_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_PurchaseBarcode_Id, Txt_PurchaseDetail_Id, Txt_Product_Id, Txt_Product_Barcode)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseBarcodes WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName 칼럼의 값이 FilterPrimaryKey 인 행을 찾아, 해당행이 존재할 경우 삭제
                        For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                            sqlString = "DELETE FROM PurchaseBarcodes WHERE PurchaseBarcode_Id = " & sqlDataTable.Rows(i).Item(0).ToString
                            SQLQueryCommand(sqlString)
                        Next
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseBarcodes", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '테이블에서 전건 출력 후 0건이면 0리턴 행이 존재할 경우 마지막 행의 id값 리턴
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseBarcodes", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '전체 행 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        'FieldName칼럼에 텍스트박스 값과 같은 데이터가 존재하면 포커스 설정 및 에러메세지 출력
                        sqlString = "SELECT * FROM PurchaseBarcodes WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseBarcodes", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    ListError(FieldIndex)
                    Return BoundList
                End Function
                Private Sub FilterListError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM PurchaseBarcodes WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'ilterFieldName칼럼의 값이 FilterPrimaryKey와 같은 행 테이블로부터 취득 후 칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                Else
                                    BoundList &= vbNewLine & CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As String
                    FilterListError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT PurchaseBarcode_Id, PurchaseDetail_Id FROM PurchaseBarcodes", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "PurchaseDetail_Id"
                            .ValueMember = "PurchaseBarcode_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT PurchaseBarcode_Id, PurchaseDetail_Id FROM PurchaseBarcodes WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName칼럼 값 = FilterPrimaryKey인 행
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "PurchaseDetail_Id"
                            .ValueMember = "PurchaseBarcode_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT PurchaseBarcode_Id AS [PURCHASEBARCODE ID],PurchaseDetail_Id AS [PURCHASEDETAIL ID],Product_Id AS [PRODUCT ID],Product_Barcode AS [PRODUCT BARCODE] FROM PurchaseBarcodes ORDER BY PurchaseDetail_Id", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT PurchaseBarcode_Id AS [PURCHASEBARCODE ID],PurchaseDetail_Id AS [PURCHASEDETAIL ID],Product_Id AS [PRODUCT ID],Product_Barcode AS [PRODUCT BARCODE] FROM PurchaseBarcodes WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'SearchSyntax 조건을 만족하는 행
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class Sales
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Private Property TotalAmount As Double
                Public Property Sale_Id As String
                Public Property Sale_Date As String
                Public Property Profile_Id As String
                Public Property Sale_CGST_Amount As String
                Public Property Sale_SGST_Amount As String
                Public Property Sale_IGST_Amount As String
                Public Property Sale_Grandtotal_Amount As String
                Public Property Sale_Recive_Amount As String
                Public Property Sale_Due_Amount As String
                Public Sub Clear()
                    '변수에 빈문자열
                    Sale_Id = String.Empty
                    Sale_Date = String.Empty
                    Profile_Id = String.Empty
                    Sale_CGST_Amount = String.Empty
                    Sale_SGST_Amount = String.Empty
                    Sale_IGST_Amount = String.Empty
                    Sale_Grandtotal_Amount = String.Empty
                    Sale_Recive_Amount = String.Empty
                    Sale_Due_Amount = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_Sale_Id As TextBox, ByVal Txt_Sale_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Sale_CGST_Amount As TextBox, ByVal Txt_Sale_SGST_Amount As TextBox, ByVal Txt_Sale_IGST_Amount As TextBox, ByVal Txt_Sale_Grandtotal_Amount As TextBox, ByVal Txt_Sale_Recive_Amount As TextBox, ByVal Txt_Sale_Due_Amount As TextBox)
                    '변수에 빈문자열 및 텍스트박스 클리어
                    Clear()
                    Txt_Sale_Id.Clear()
                    Txt_Sale_Date.Clear()
                    Txt_Profile_Id.Clear()
                    Txt_Sale_CGST_Amount.Clear()
                    Txt_Sale_SGST_Amount.Clear()
                    Txt_Sale_IGST_Amount.Clear()
                    Txt_Sale_Grandtotal_Amount.Clear()
                    Txt_Sale_Recive_Amount.Clear()
                    Txt_Sale_Due_Amount.Clear()
                End Sub
                Public Sub Add(ByVal Txt_Sale_Id As TextBox, ByVal Txt_Sale_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Sale_CGST_Amount As TextBox, ByVal Txt_Sale_SGST_Amount As TextBox, ByVal Txt_Sale_IGST_Amount As TextBox, ByVal Txt_Sale_Grandtotal_Amount As TextBox, ByVal Txt_Sale_Recive_Amount As TextBox, ByVal Txt_Sale_Due_Amount As TextBox)
                    '입력된 문자열에 '문자 ''로 변환 후 변수에 대입
                    Sale_Id = Txt_Sale_Id.Text.Replace("'", "''")
                    Sale_Date = Txt_Sale_Date.Text.Replace("'", "''")
                    Profile_Id = Txt_Profile_Id.Text.Replace("'", "''")
                    Sale_CGST_Amount = Txt_Sale_CGST_Amount.Text.Replace("'", "''")
                    Sale_SGST_Amount = Txt_Sale_SGST_Amount.Text.Replace("'", "''")
                    Sale_IGST_Amount = Txt_Sale_IGST_Amount.Text.Replace("'", "''")
                    Sale_Grandtotal_Amount = Txt_Sale_Grandtotal_Amount.Text.Replace("'", "''")
                    Sale_Recive_Amount = Txt_Sale_Recive_Amount.Text.Replace("'", "''")
                    Sale_Due_Amount = Txt_Sale_Due_Amount.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        'Sale_Id 비포함 insert
                        If AutoID = True Then
                            sqlString = "INSERT INTO Sales (Sale_Date,Profile_Id,Sale_CGST_Amount,Sale_SGST_Amount,Sale_IGST_Amount,Sale_Grandtotal_Amount,Sale_Recive_Amount,Sale_Due_Amount) VALUES ('" & Sale_Date & "','" & Profile_Id & "','" & Sale_CGST_Amount & "','" & Sale_SGST_Amount & "','" & Sale_IGST_Amount & "','" & Sale_Grandtotal_Amount & "','" & Sale_Recive_Amount & "','" & Sale_Due_Amount & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'Sale_Id 비포함 insert
                            sqlString = "INSERT INTO Sales (Sale_Id,Sale_Date,Profile_Id,Sale_CGST_Amount,Sale_SGST_Amount,Sale_IGST_Amount,Sale_Grandtotal_Amount,Sale_Recive_Amount,Sale_Due_Amount) VALUES ('" & Sale_Id & "','" & Sale_Date & "','" & Profile_Id & "','" & Sale_CGST_Amount & "','" & Sale_SGST_Amount & "','" & Sale_IGST_Amount & "','" & Sale_Grandtotal_Amount & "','" & Sale_Recive_Amount & "','" & Sale_Due_Amount & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'Sale_Id 비포함 update
                        If AutoID = True Then
                            sqlString = "UPDATE Sales SET Sale_Date = '" & Sale_Date & "',Profile_Id = '" & Profile_Id & "',Sale_CGST_Amount = '" & Sale_CGST_Amount & "',Sale_SGST_Amount = '" & Sale_SGST_Amount & "',Sale_IGST_Amount = '" & Sale_IGST_Amount & "',Sale_Grandtotal_Amount = '" & Sale_Grandtotal_Amount & "',Sale_Recive_Amount = '" & Sale_Recive_Amount & "',Sale_Due_Amount = '" & Sale_Due_Amount & "' WHERE Sale_Id = " & Sale_Id
                            SQLQueryCommand(sqlString)
                            'Sale_Id 포함 update
                        Else
                            sqlString = "UPDATE Sales SET Sale_Id = '" & Sale_Id & "',Sale_Date = '" & Sale_Date & "',Profile_Id = '" & Profile_Id & "',Sale_CGST_Amount = '" & Sale_CGST_Amount & "',Sale_SGST_Amount = '" & Sale_SGST_Amount & "',Sale_IGST_Amount = '" & Sale_IGST_Amount & "',Sale_Grandtotal_Amount = '" & Sale_Grandtotal_Amount & "',Sale_Recive_Amount = '" & Sale_Recive_Amount & "',Sale_Due_Amount = '" & Sale_Due_Amount & "' WHERE Sale_Id = " & Sale_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_Sale_Id As TextBox, ByVal Txt_Sale_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Sale_CGST_Amount As TextBox, ByVal Txt_Sale_SGST_Amount As TextBox, ByVal Txt_Sale_IGST_Amount As TextBox, ByVal Txt_Sale_Grandtotal_Amount As TextBox, ByVal Txt_Sale_Recive_Amount As TextBox, ByVal Txt_Sale_Due_Amount As TextBox) As Boolean
                    '텍스트박스가 null 혹은 빈문자열일 경우 포커스 설정 및 에러메세지 출력
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_Sale_Id.Text) Then
                            Txt_Sale_Id.Focus()
                            MessageBox.Show("TextBox(Sale_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_Sale_Date.Text) Then
                        Txt_Sale_Date.Focus()
                        MessageBox.Show("TextBox(Sale_Date) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_Id.Text) Then
                        Txt_Profile_Id.Focus()
                        MessageBox.Show("TextBox(Profile_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Sale_CGST_Amount.Text) Then
                        Txt_Sale_CGST_Amount.Focus()
                        MessageBox.Show("TextBox(Sale_CGST_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Sale_SGST_Amount.Text) Then
                        Txt_Sale_SGST_Amount.Focus()
                        MessageBox.Show("TextBox(Sale_SGST_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Sale_IGST_Amount.Text) Then
                        Txt_Sale_IGST_Amount.Focus()
                        MessageBox.Show("TextBox(Sale_IGST_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Sale_Grandtotal_Amount.Text) Then
                        Txt_Sale_Grandtotal_Amount.Focus()
                        MessageBox.Show("TextBox(Sale_Grandtotal_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Sale_Recive_Amount.Text) Then
                        Txt_Sale_Recive_Amount.Focus()
                        MessageBox.Show("TextBox(Sale_Recive_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Sale_Due_Amount.Text) Then
                        Txt_Sale_Due_Amount.Focus()
                        MessageBox.Show("TextBox(Sale_Due_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_Sale_Id As TextBox, ByVal Txt_Sale_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Sale_CGST_Amount As TextBox, ByVal Txt_Sale_SGST_Amount As TextBox, ByVal Txt_Sale_IGST_Amount As TextBox, ByVal Txt_Sale_Grandtotal_Amount As TextBox, ByVal Txt_Sale_Recive_Amount As TextBox, ByVal Txt_Sale_Due_Amount As TextBox)
                    '입력 체크
                    If IsTextBoxError(AutoID, Txt_Sale_Id, Txt_Sale_Date, Txt_Profile_Id, Txt_Sale_CGST_Amount, Txt_Sale_SGST_Amount, Txt_Sale_IGST_Amount, Txt_Sale_Grandtotal_Amount, Txt_Sale_Recive_Amount, Txt_Sale_Due_Amount) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_Sale_Id, Txt_Sale_Date, Txt_Profile_Id, Txt_Sale_CGST_Amount, Txt_Sale_SGST_Amount, Txt_Sale_IGST_Amount, Txt_Sale_Grandtotal_Amount, Txt_Sale_Recive_Amount, Txt_Sale_Due_Amount)
                    '커맨드 add일 경우 insert 실행. insert 성공시 메세지 출력 및 텍스트박스 클리어
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Sale_Id, Txt_Sale_Date, Txt_Profile_Id, Txt_Sale_CGST_Amount, Txt_Sale_SGST_Amount, Txt_Sale_IGST_Amount, Txt_Sale_Grandtotal_Amount, Txt_Sale_Recive_Amount, Txt_Sale_Due_Amount)
                        '커맨드 edit일 경우 update 실행. update 성공시 메세지 출력 및 텍스트박스 클리어
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_Sale_Id, Txt_Sale_Date, Txt_Profile_Id, Txt_Sale_CGST_Amount, Txt_Sale_SGST_Amount, Txt_Sale_IGST_Amount, Txt_Sale_Grandtotal_Amount, Txt_Sale_Recive_Amount, Txt_Sale_Due_Amount)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수에 대입
                            sqlString = "SELECT * FROM Sales WHERE Sale_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            Sale_Id = sqlDataTable.Rows(0)("Sale_Id").ToString
                            Sale_Date = sqlDataTable.Rows(0)("Sale_Date").ToString
                            Profile_Id = sqlDataTable.Rows(0)("Profile_Id").ToString
                            Sale_CGST_Amount = sqlDataTable.Rows(0)("Sale_CGST_Amount").ToString
                            Sale_SGST_Amount = sqlDataTable.Rows(0)("Sale_SGST_Amount").ToString
                            Sale_IGST_Amount = sqlDataTable.Rows(0)("Sale_IGST_Amount").ToString
                            Sale_Grandtotal_Amount = sqlDataTable.Rows(0)("Sale_Grandtotal_Amount").ToString
                            Sale_Recive_Amount = sqlDataTable.Rows(0)("Sale_Recive_Amount").ToString
                            Sale_Due_Amount = sqlDataTable.Rows(0)("Sale_Due_Amount").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_Sale_Id As TextBox, ByVal Txt_Sale_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Sale_CGST_Amount As TextBox, ByVal Txt_Sale_SGST_Amount As TextBox, ByVal Txt_Sale_IGST_Amount As TextBox, ByVal Txt_Sale_Grandtotal_Amount As TextBox, ByVal Txt_Sale_Recive_Amount As TextBox, ByVal Txt_Sale_Due_Amount As TextBox)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_Sale_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수 및 텍스트박스에 대입
                        Else
                            sqlString = "SELECT * FROM Sales WHERE Sale_Id = " & Txt_Sale_Id.Text
                            SQLQueryCommand(sqlString)
                            Sale_Id = sqlDataTable.Rows(0)("Sale_Id").ToString
                            Sale_Date = sqlDataTable.Rows(0)("Sale_Date").ToString
                            Profile_Id = sqlDataTable.Rows(0)("Profile_Id").ToString
                            Sale_CGST_Amount = sqlDataTable.Rows(0)("Sale_CGST_Amount").ToString
                            Sale_SGST_Amount = sqlDataTable.Rows(0)("Sale_SGST_Amount").ToString
                            Sale_IGST_Amount = sqlDataTable.Rows(0)("Sale_IGST_Amount").ToString
                            Sale_Grandtotal_Amount = sqlDataTable.Rows(0)("Sale_Grandtotal_Amount").ToString
                            Sale_Recive_Amount = sqlDataTable.Rows(0)("Sale_Recive_Amount").ToString
                            Sale_Due_Amount = sqlDataTable.Rows(0)("Sale_Due_Amount").ToString
                            Txt_Sale_Id.Text = Sale_Id
                            Txt_Sale_Date.Text = Sale_Date
                            Txt_Profile_Id.Text = Profile_Id
                            Txt_Sale_CGST_Amount.Text = Sale_CGST_Amount
                            Txt_Sale_SGST_Amount.Text = Sale_SGST_Amount
                            Txt_Sale_IGST_Amount.Text = Sale_IGST_Amount
                            Txt_Sale_Grandtotal_Amount.Text = Sale_Grandtotal_Amount
                            Txt_Sale_Recive_Amount.Text = Sale_Recive_Amount
                            Txt_Sale_Due_Amount.Text = Sale_Due_Amount
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  삭제
                            sqlString = "DELETE FROM Sales WHERE Sale_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_Sale_Id As TextBox, ByVal Txt_Sale_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_Sale_CGST_Amount As TextBox, ByVal Txt_Sale_SGST_Amount As TextBox, ByVal Txt_Sale_IGST_Amount As TextBox, ByVal Txt_Sale_Grandtotal_Amount As TextBox, ByVal Txt_Sale_Recive_Amount As TextBox, ByVal Txt_Sale_Due_Amount As TextBox)
                    Try
                        '텍스트박스에 입력된 값이 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_Sale_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes선택시 텍스트박스에 입력된 값과 같은 값을 지닌 칼럼을 찾아 해당 행을 삭제. 
                            '텍스트박스 클리어 후 메시지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM Sales WHERE Sale_Id = " & Txt_Sale_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_Sale_Id, Txt_Sale_Date, Txt_Profile_Id, Txt_Sale_CGST_Amount, Txt_Sale_SGST_Amount, Txt_Sale_IGST_Amount, Txt_Sale_Grandtotal_Amount, Txt_Sale_Recive_Amount, Txt_Sale_Due_Amount)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Sales WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName 칼럼의 값이 FilterPrimaryKey 인 행을 찾아, 해당행이 존재할 경우 삭제
                        For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                            sqlString = "DELETE FROM Sales WHERE Sale_Id = " & sqlDataTable.Rows(i).Item(0).ToString
                            SQLQueryCommand(sqlString)
                        Next
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Sales", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '테이블에서 전건 출력 후 0건이면 0리턴 행이 존재할 경우 마지막 행의 id값 리턴
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Sales", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '전체 행 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Private Sub TotalAmountError(ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Sales", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FieldIndex As Integer) As Double
                    'TotalAmount 변수에 값 대입후 리턴
                    TotalAmountError(FieldIndex)
                    Return TotalAmount
                End Function
                Private Sub FilterTotalAmountError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Sales WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As Double
                    'TotalAmount 변수에 값 대입후 리턴
                    FilterTotalAmountError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return TotalAmount
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        'FieldName칼럼에 텍스트박스 값과 같은 데이터가 존재하면 포커스 설정 및 에러메세지 출력
                        sqlString = "SELECT * FROM Sales WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Sales", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    ListError(FieldIndex)
                    Return BoundList
                End Function
                Private Sub FilterListError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM Sales WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'ilterFieldName칼럼의 값이 FilterPrimaryKey와 같은 행 테이블로부터 취득 후 칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                Else
                                    BoundList &= vbNewLine & CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As String
                    FilterListError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Sale_Id, Sale_Date FROM Sales", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Sale_Date"
                            .ValueMember = "Sale_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Sale_Id, Sale_Date FROM Sales WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName칼럼 값 = FilterPrimaryKey인 행
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Sale_Date"
                            .ValueMember = "Sale_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Sale_Id AS [SALE ID],Sale_Date AS [SALE DATE],Profile_Id AS [PROFILE ID],Sale_CGST_Amount AS [SALE CGST AMOUNT],Sale_SGST_Amount AS [SALE SGST AMOUNT],Sale_IGST_Amount AS [SALE IGST AMOUNT],Sale_Grandtotal_Amount AS [SALE GRANDTOTAL AMOUNT],Sale_Recive_Amount AS [SALE RECIVE AMOUNT],Sale_Due_Amount AS [SALE DUE AMOUNT] FROM Sales ORDER BY Sale_Date", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT Sale_Id AS [SALE ID],Sale_Date AS [SALE DATE],Profile_Id AS [PROFILE ID],Sale_CGST_Amount AS [SALE CGST AMOUNT],Sale_SGST_Amount AS [SALE SGST AMOUNT],Sale_IGST_Amount AS [SALE IGST AMOUNT],Sale_Grandtotal_Amount AS [SALE GRANDTOTAL AMOUNT],Sale_Recive_Amount AS [SALE RECIVE AMOUNT],Sale_Due_Amount AS [SALE DUE AMOUNT] FROM Sales WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'SearchSyntax 조건을 만족하는 행
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class SaleDetails
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Private Property TotalAmount As Double
                Public Property SaleDetail_Id As String
                Public Property Sale_Id As String
                Public Property Product_Id As String
                Public Property Product_Name As String
                Public Property HSN_Code As String
                Public Property Sale_Quantity As String
                Public Property Unit_Name As String
                Public Property Sale_Rate_Amount As String
                Public Property Sale_Subtotal_Amount As String
                Public Sub Clear()
                    '변수에 빈문자열
                    SaleDetail_Id = String.Empty
                    Sale_Id = String.Empty
                    Product_Id = String.Empty
                    Product_Name = String.Empty
                    HSN_Code = String.Empty
                    Sale_Quantity = String.Empty
                    Unit_Name = String.Empty
                    Sale_Rate_Amount = String.Empty
                    Sale_Subtotal_Amount = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Sale_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Sale_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Sale_Rate_Amount As TextBox, ByVal Txt_Sale_Subtotal_Amount As TextBox)
                    '변수에 빈문자열 및 텍스트박스 클리어
                    Clear()
                    Txt_SaleDetail_Id.Clear()
                    Txt_Sale_Id.Clear()
                    Txt_Product_Id.Clear()
                    Txt_Product_Name.Clear()
                    Txt_HSN_Code.Clear()
                    Txt_Sale_Quantity.Clear()
                    Txt_Unit_Name.Clear()
                    Txt_Sale_Rate_Amount.Clear()
                    Txt_Sale_Subtotal_Amount.Clear()
                End Sub
                Public Sub Add(ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Sale_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Sale_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Sale_Rate_Amount As TextBox, ByVal Txt_Sale_Subtotal_Amount As TextBox)
                    '입력된 문자열에 '문자 ''로 변환 후 변수에 대입
                    SaleDetail_Id = Txt_SaleDetail_Id.Text.Replace("'", "''")
                    Sale_Id = Txt_Sale_Id.Text.Replace("'", "''")
                    Product_Id = Txt_Product_Id.Text.Replace("'", "''")
                    Product_Name = Txt_Product_Name.Text.Replace("'", "''")
                    HSN_Code = Txt_HSN_Code.Text.Replace("'", "''")
                    Sale_Quantity = Txt_Sale_Quantity.Text.Replace("'", "''")
                    Unit_Name = Txt_Unit_Name.Text.Replace("'", "''")
                    Sale_Rate_Amount = Txt_Sale_Rate_Amount.Text.Replace("'", "''")
                    Sale_Subtotal_Amount = Txt_Sale_Subtotal_Amount.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        'SaleDetail_Id 비포함 insert
                        If AutoID = True Then
                            sqlString = "INSERT INTO SaleDetails (Sale_Id,Product_Id,Product_Name,HSN_Code,Sale_Quantity,Unit_Name,Sale_Rate_Amount,Sale_Subtotal_Amount) VALUES ('" & Sale_Id & "','" & Product_Id & "','" & Product_Name & "','" & HSN_Code & "','" & Sale_Quantity & "','" & Unit_Name & "','" & Sale_Rate_Amount & "','" & Sale_Subtotal_Amount & "')"
                            SQLQueryCommand(sqlString)
                            'SaleDetail_Id 비포함 insert
                        Else
                            sqlString = "INSERT INTO SaleDetails (SaleDetail_Id,Sale_Id,Product_Id,Product_Name,HSN_Code,Sale_Quantity,Unit_Name,Sale_Rate_Amount,Sale_Subtotal_Amount) VALUES ('" & SaleDetail_Id & "','" & Sale_Id & "','" & Product_Id & "','" & Product_Name & "','" & HSN_Code & "','" & Sale_Quantity & "','" & Unit_Name & "','" & Sale_Rate_Amount & "','" & Sale_Subtotal_Amount & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'SaleDetail_Id 비포함 update
                        If AutoID = True Then
                            sqlString = "UPDATE SaleDetails SET Sale_Id = '" & Sale_Id & "',Product_Id = '" & Product_Id & "',Product_Name = '" & Product_Name & "',HSN_Code = '" & HSN_Code & "',Sale_Quantity = '" & Sale_Quantity & "',Unit_Name = '" & Unit_Name & "',Sale_Rate_Amount = '" & Sale_Rate_Amount & "',Sale_Subtotal_Amount = '" & Sale_Subtotal_Amount & "' WHERE SaleDetail_Id = " & SaleDetail_Id
                            SQLQueryCommand(sqlString)
                        Else
                            'SaleDetail_Id 포함 update
                            sqlString = "UPDATE SaleDetails SET SaleDetail_Id = '" & SaleDetail_Id & "',Sale_Id = '" & Sale_Id & "',Product_Id = '" & Product_Id & "',Product_Name = '" & Product_Name & "',HSN_Code = '" & HSN_Code & "',Sale_Quantity = '" & Sale_Quantity & "',Unit_Name = '" & Unit_Name & "',Sale_Rate_Amount = '" & Sale_Rate_Amount & "',Sale_Subtotal_Amount = '" & Sale_Subtotal_Amount & "' WHERE SaleDetail_Id = " & SaleDetail_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Sale_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Sale_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Sale_Rate_Amount As TextBox, ByVal Txt_Sale_Subtotal_Amount As TextBox) As Boolean
                    '텍스트박스가 null 혹은 빈문자열일 경우 포커스 설정 및 에러메세지 출력
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_SaleDetail_Id.Text) Then
                            Txt_SaleDetail_Id.Focus()
                            MessageBox.Show("TextBox(SaleDetail_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_Sale_Id.Text) Then
                        Txt_Sale_Id.Focus()
                        MessageBox.Show("TextBox(Sale_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Id.Text) Then
                        Txt_Product_Id.Focus()
                        MessageBox.Show("TextBox(Product_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Name.Text) Then
                        Txt_Product_Name.Focus()
                        MessageBox.Show("TextBox(Product_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_HSN_Code.Text) Then
                        Txt_HSN_Code.Focus()
                        MessageBox.Show("TextBox(HSN_Code) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Sale_Quantity.Text) Then
                        Txt_Sale_Quantity.Focus()
                        MessageBox.Show("TextBox(Sale_Quantity) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Unit_Name.Text) Then
                        Txt_Unit_Name.Focus()
                        MessageBox.Show("TextBox(Unit_Name) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Sale_Rate_Amount.Text) Then
                        Txt_Sale_Rate_Amount.Focus()
                        MessageBox.Show("TextBox(Sale_Rate_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Sale_Subtotal_Amount.Text) Then
                        Txt_Sale_Subtotal_Amount.Focus()
                        MessageBox.Show("TextBox(Sale_Subtotal_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Sale_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Sale_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Sale_Rate_Amount As TextBox, ByVal Txt_Sale_Subtotal_Amount As TextBox)
                    '입력 체크
                    If IsTextBoxError(AutoID, Txt_SaleDetail_Id, Txt_Sale_Id, Txt_Product_Id, Txt_Product_Name, Txt_HSN_Code, Txt_Sale_Quantity, Txt_Unit_Name, Txt_Sale_Rate_Amount, Txt_Sale_Subtotal_Amount) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_SaleDetail_Id, Txt_Sale_Id, Txt_Product_Id, Txt_Product_Name, Txt_HSN_Code, Txt_Sale_Quantity, Txt_Unit_Name, Txt_Sale_Rate_Amount, Txt_Sale_Subtotal_Amount)
                    '커맨드 add일 경우 insert 실행. insert 성공시 메세지 출력 및 텍스트박스 클리어
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_SaleDetail_Id, Txt_Sale_Id, Txt_Product_Id, Txt_Product_Name, Txt_HSN_Code, Txt_Sale_Quantity, Txt_Unit_Name, Txt_Sale_Rate_Amount, Txt_Sale_Subtotal_Amount)
                        '커맨드 edit일 경우 update 실행. update 성공시 메세지 출력 및 텍스트박스 클리어
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_SaleDetail_Id, Txt_Sale_Id, Txt_Product_Id, Txt_Product_Name, Txt_HSN_Code, Txt_Sale_Quantity, Txt_Unit_Name, Txt_Sale_Rate_Amount, Txt_Sale_Subtotal_Amount)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수에 대입
                            sqlString = "SELECT * FROM SaleDetails WHERE SaleDetail_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            SaleDetail_Id = sqlDataTable.Rows(0)("SaleDetail_Id").ToString
                            Sale_Id = sqlDataTable.Rows(0)("Sale_Id").ToString
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            Product_Name = sqlDataTable.Rows(0)("Product_Name").ToString
                            HSN_Code = sqlDataTable.Rows(0)("HSN_Code").ToString
                            Sale_Quantity = sqlDataTable.Rows(0)("Sale_Quantity").ToString
                            Unit_Name = sqlDataTable.Rows(0)("Unit_Name").ToString
                            Sale_Rate_Amount = sqlDataTable.Rows(0)("Sale_Rate_Amount").ToString
                            Sale_Subtotal_Amount = sqlDataTable.Rows(0)("Sale_Subtotal_Amount").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Sale_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Sale_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Sale_Rate_Amount As TextBox, ByVal Txt_Sale_Subtotal_Amount As TextBox)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_SaleDetail_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수 및 텍스트박스에 대입
                            sqlString = "SELECT * FROM SaleDetails WHERE SaleDetail_Id = " & Txt_SaleDetail_Id.Text
                            SQLQueryCommand(sqlString)
                            SaleDetail_Id = sqlDataTable.Rows(0)("SaleDetail_Id").ToString
                            Sale_Id = sqlDataTable.Rows(0)("Sale_Id").ToString
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            Product_Name = sqlDataTable.Rows(0)("Product_Name").ToString
                            HSN_Code = sqlDataTable.Rows(0)("HSN_Code").ToString
                            Sale_Quantity = sqlDataTable.Rows(0)("Sale_Quantity").ToString
                            Unit_Name = sqlDataTable.Rows(0)("Unit_Name").ToString
                            Sale_Rate_Amount = sqlDataTable.Rows(0)("Sale_Rate_Amount").ToString
                            Sale_Subtotal_Amount = sqlDataTable.Rows(0)("Sale_Subtotal_Amount").ToString
                            Txt_SaleDetail_Id.Text = SaleDetail_Id
                            Txt_Sale_Id.Text = Sale_Id
                            Txt_Product_Id.Text = Product_Id
                            Txt_Product_Name.Text = Product_Name
                            Txt_HSN_Code.Text = HSN_Code
                            Txt_Sale_Quantity.Text = Sale_Quantity
                            Txt_Unit_Name.Text = Unit_Name
                            Txt_Sale_Rate_Amount.Text = Sale_Rate_Amount
                            Txt_Sale_Subtotal_Amount.Text = Sale_Subtotal_Amount
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  삭제
                            sqlString = "DELETE FROM SaleDetails WHERE SaleDetail_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Sale_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_Product_Name As TextBox, ByVal Txt_HSN_Code As TextBox, ByVal Txt_Sale_Quantity As TextBox, ByVal Txt_Unit_Name As TextBox, ByVal Txt_Sale_Rate_Amount As TextBox, ByVal Txt_Sale_Subtotal_Amount As TextBox)
                    Try
                        '텍스트박스에 입력된 값이 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_SaleDetail_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes선택시 텍스트박스에 입력된 값과 같은 값을 지닌 칼럼을 찾아 해당 행을 삭제. 
                            '텍스트박스 클리어 후 메시지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM SaleDetails WHERE SaleDetail_Id = " & Txt_SaleDetail_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_SaleDetail_Id, Txt_Sale_Id, Txt_Product_Id, Txt_Product_Name, Txt_HSN_Code, Txt_Sale_Quantity, Txt_Unit_Name, Txt_Sale_Rate_Amount, Txt_Sale_Subtotal_Amount)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleDetails WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName 칼럼의 값이 FilterPrimaryKey 인 행을 찾아, 해당행이 존재할 경우 삭제
                        For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                            sqlString = "DELETE FROM SaleDetails WHERE SaleDetail_Id = " & sqlDataTable.Rows(i).Item(0).ToString
                            SQLQueryCommand(sqlString)
                        Next
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleDetails", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '테이블에서 전건 출력 후 0건이면 0리턴 행이 존재할 경우 마지막 행의 id값 리턴
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleDetails", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '전체 행 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Private Sub TotalAmountError(ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleDetails", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FieldIndex As Integer) As Double
                    'TotalAmount 변수에 값 대입후 리턴
                    TotalAmountError(FieldIndex)
                    Return TotalAmount
                End Function
                Private Sub FilterTotalAmountError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleDetails WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As Double
                    'TotalAmount 변수에 값 대입후 리턴
                    FilterTotalAmountError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return TotalAmount
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        'FieldName칼럼에 텍스트박스 값과 같은 데이터가 존재하면 포커스 설정 및 에러메세지 출력
                        sqlString = "SELECT * FROM SaleDetails WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleDetails", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    ListError(FieldIndex)
                    Return BoundList
                End Function
                Private Sub FilterListError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleDetails WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'ilterFieldName칼럼의 값이 FilterPrimaryKey와 같은 행 테이블로부터 취득 후 칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                Else
                                    BoundList &= vbNewLine & CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As String
                    FilterListError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT SaleDetail_Id, Sale_Id FROM SaleDetails", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Sale_Id"
                            .ValueMember = "SaleDetail_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT SaleDetail_Id, Sale_Id FROM SaleDetails WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName칼럼 값 = FilterPrimaryKey인 행
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "Sale_Id"
                            .ValueMember = "SaleDetail_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT SaleDetail_Id AS [SALEDETAIL ID],Sale_Id AS [SALE ID],Product_Id AS [PRODUCT ID],Product_Name AS [PRODUCT NAME],HSN_Code AS [HSN CODE],Sale_Quantity AS [SALE QUANTITY],Unit_Name AS [UNIT NAME],Sale_Rate_Amount AS [SALE RATE AMOUNT],Sale_Subtotal_Amount AS [SALE SUBTOTAL AMOUNT] FROM SaleDetails ORDER BY Sale_Id", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT SaleDetail_Id AS [SALEDETAIL ID],Sale_Id AS [SALE ID],Product_Id AS [PRODUCT ID],Product_Name AS [PRODUCT NAME],HSN_Code AS [HSN CODE],Sale_Quantity AS [SALE QUANTITY],Unit_Name AS [UNIT NAME],Sale_Rate_Amount AS [SALE RATE AMOUNT],Sale_Subtotal_Amount AS [SALE SUBTOTAL AMOUNT] FROM SaleDetails WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'SearchSyntax 조건을 만족하는 행
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class SaleBarcodes
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Public Property SaleBarcode_Id As String
                Public Property SaleDetail_Id As String
                Public Property Product_Id As String
                Public Property SaleBarcode_Barcode As String
                Public Sub Clear()
                    '변수에 빈문자열
                    SaleBarcode_Id = String.Empty
                    SaleDetail_Id = String.Empty
                    Product_Id = String.Empty
                    SaleBarcode_Barcode = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_SaleBarcode_Id As TextBox, ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_SaleBarcode_Barcode As TextBox)
                    '변수에 빈문자열 및 텍스트박스 클리어
                    Clear()
                    Txt_SaleBarcode_Id.Clear()
                    Txt_SaleDetail_Id.Clear()
                    Txt_Product_Id.Clear()
                    Txt_SaleBarcode_Barcode.Clear()
                End Sub
                Public Sub Add(ByVal Txt_SaleBarcode_Id As TextBox, ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_SaleBarcode_Barcode As TextBox)
                    '입력된 문자열에 '문자 ''로 변환 후 변수에 대입
                    SaleBarcode_Id = Txt_SaleBarcode_Id.Text.Replace("'", "''")
                    SaleDetail_Id = Txt_SaleDetail_Id.Text.Replace("'", "''")
                    Product_Id = Txt_Product_Id.Text.Replace("'", "''")
                    SaleBarcode_Barcode = Txt_SaleBarcode_Barcode.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        'SaleBarcode_Id 비포함 insert
                        If AutoID = True Then
                            sqlString = "INSERT INTO SaleBarcodes (SaleDetail_Id,Product_Id,SaleBarcode_Barcode) VALUES ('" & SaleDetail_Id & "','" & Product_Id & "','" & SaleBarcode_Barcode & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'SaleBarcode_Id 비포함 insert
                            sqlString = "INSERT INTO SaleBarcodes (SaleBarcode_Id,SaleDetail_Id,Product_Id,SaleBarcode_Barcode) VALUES ('" & SaleBarcode_Id & "','" & SaleDetail_Id & "','" & Product_Id & "','" & SaleBarcode_Barcode & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'SaleBarcode_Id 비포함 update
                        If AutoID = True Then
                            sqlString = "UPDATE SaleBarcodes SET SaleDetail_Id = '" & SaleDetail_Id & "',Product_Id = '" & Product_Id & "',SaleBarcode_Barcode = '" & SaleBarcode_Barcode & "' WHERE SaleBarcode_Id = " & SaleBarcode_Id
                            SQLQueryCommand(sqlString)
                        Else
                            'SaleBarcode_Id 포함 update
                            sqlString = "UPDATE SaleBarcodes SET SaleBarcode_Id = '" & SaleBarcode_Id & "',SaleDetail_Id = '" & SaleDetail_Id & "',Product_Id = '" & Product_Id & "',SaleBarcode_Barcode = '" & SaleBarcode_Barcode & "' WHERE SaleBarcode_Id = " & SaleBarcode_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_SaleBarcode_Id As TextBox, ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_SaleBarcode_Barcode As TextBox) As Boolean
                    '텍스트박스가 null 혹은 빈문자열일 경우 포커스 설정 및 에러메세지 출력
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_SaleBarcode_Id.Text) Then
                            Txt_SaleBarcode_Id.Focus()
                            MessageBox.Show("TextBox(SaleBarcode_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_SaleDetail_Id.Text) Then
                        Txt_SaleDetail_Id.Focus()
                        MessageBox.Show("TextBox(SaleDetail_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Product_Id.Text) Then
                        Txt_Product_Id.Focus()
                        MessageBox.Show("TextBox(Product_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_SaleBarcode_Barcode.Text) Then
                        Txt_SaleBarcode_Barcode.Focus()
                        MessageBox.Show("TextBox(SaleBarcode_Barcode) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_SaleBarcode_Id As TextBox, ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_SaleBarcode_Barcode As TextBox)
                    '입력 체크
                    If IsTextBoxError(AutoID, Txt_SaleBarcode_Id, Txt_SaleDetail_Id, Txt_Product_Id, Txt_SaleBarcode_Barcode) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_SaleBarcode_Id, Txt_SaleDetail_Id, Txt_Product_Id, Txt_SaleBarcode_Barcode)
                    '커맨드 add일 경우 insert 실행. insert 성공시 메세지 출력 및 텍스트박스 클리어
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_SaleBarcode_Id, Txt_SaleDetail_Id, Txt_Product_Id, Txt_SaleBarcode_Barcode)
                        '커맨드 edit일 경우 update 실행. update 성공시 메세지 출력 및 텍스트박스 클리어
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_SaleBarcode_Id, Txt_SaleDetail_Id, Txt_Product_Id, Txt_SaleBarcode_Barcode)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수에 대입
                            sqlString = "SELECT * FROM SaleBarcodes WHERE SaleBarcode_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            SaleBarcode_Id = sqlDataTable.Rows(0)("SaleBarcode_Id").ToString
                            SaleDetail_Id = sqlDataTable.Rows(0)("SaleDetail_Id").ToString
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            SaleBarcode_Barcode = sqlDataTable.Rows(0)("SaleBarcode_Barcode").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_SaleBarcode_Id As TextBox, ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_SaleBarcode_Barcode As TextBox)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_SaleBarcode_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수 및 텍스트박스에 대입
                            sqlString = "SELECT * FROM SaleBarcodes WHERE SaleBarcode_Id = " & Txt_SaleBarcode_Id.Text
                            SQLQueryCommand(sqlString)
                            SaleBarcode_Id = sqlDataTable.Rows(0)("SaleBarcode_Id").ToString
                            SaleDetail_Id = sqlDataTable.Rows(0)("SaleDetail_Id").ToString
                            Product_Id = sqlDataTable.Rows(0)("Product_Id").ToString
                            SaleBarcode_Barcode = sqlDataTable.Rows(0)("SaleBarcode_Barcode").ToString
                            Txt_SaleBarcode_Id.Text = SaleBarcode_Id
                            Txt_SaleDetail_Id.Text = SaleDetail_Id
                            Txt_Product_Id.Text = Product_Id
                            Txt_SaleBarcode_Barcode.Text = SaleBarcode_Barcode
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  삭제
                            sqlString = "DELETE FROM SaleBarcodes WHERE SaleBarcode_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_SaleBarcode_Id As TextBox, ByVal Txt_SaleDetail_Id As TextBox, ByVal Txt_Product_Id As TextBox, ByVal Txt_SaleBarcode_Barcode As TextBox)
                    Try
                        '텍스트박스에 입력된 값이 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_SaleBarcode_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes선택시 텍스트박스에 입력된 값과 같은 값을 지닌 칼럼을 찾아 해당 행을 삭제. 
                            '텍스트박스 클리어 후 메시지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM SaleBarcodes WHERE SaleBarcode_Id = " & Txt_SaleBarcode_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_SaleBarcode_Id, Txt_SaleDetail_Id, Txt_Product_Id, Txt_SaleBarcode_Barcode)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleBarcodes WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName 칼럼의 값이 FilterPrimaryKey 인 행을 찾아, 해당행이 존재할 경우 삭제
                        For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                            sqlString = "DELETE FROM SaleBarcodes WHERE SaleBarcode_Id = " & sqlDataTable.Rows(i).Item(0).ToString
                            SQLQueryCommand(sqlString)
                        Next
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleBarcodes", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '테이블에서 전건 출력 후 0건이면 0리턴 행이 존재할 경우 마지막 행의 id값 리턴
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleBarcodes", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '전체 행 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        'FieldName칼럼에 텍스트박스 값과 같은 데이터가 존재하면 포커스 설정 및 에러메세지 출력
                        sqlString = "SELECT * FROM SaleBarcodes WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleBarcodes", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    ListError(FieldIndex)
                    Return BoundList
                End Function
                Private Sub FilterListError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM SaleBarcodes WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'ilterFieldName칼럼의 값이 FilterPrimaryKey와 같은 행 테이블로부터 취득 후 칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                Else
                                    BoundList &= vbNewLine & CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As String
                    FilterListError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT SaleBarcode_Id, SaleDetail_Id FROM SaleBarcodes", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "SaleDetail_Id"
                            .ValueMember = "SaleBarcode_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT SaleBarcode_Id, SaleDetail_Id FROM SaleBarcodes WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName칼럼 값 = FilterPrimaryKey인 행
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "SaleDetail_Id"
                            .ValueMember = "SaleBarcode_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT SaleBarcode_Id AS [SALEBARCODE ID],SaleDetail_Id AS [SALEDETAIL ID],Product_Id AS [PRODUCT ID],SaleBarcode_Barcode AS [SALEBARCODE BARCODE] FROM SaleBarcodes ORDER BY SaleDetail_Id", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT SaleBarcode_Id AS [SALEBARCODE ID],SaleDetail_Id AS [SALEDETAIL ID],Product_Id AS [PRODUCT ID],SaleBarcode_Barcode AS [SALEBARCODE BARCODE] FROM SaleBarcodes WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'SearchSyntax 조건을 만족하는 행
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class CashBalance
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Private Property TotalAmount As Double
                Public Property CashBalance_Id As String
                Public Property CashBalance_Date As String
                Public Property Profile_Id As String
                Public Property CashBalance_Payment_Amount As String
                Public Property CashBalance_Recive_Amount As String
                Public Sub Clear()
                    '변수에 빈문자열
                    CashBalance_Id = String.Empty
                    CashBalance_Date = String.Empty
                    Profile_Id = String.Empty
                    CashBalance_Payment_Amount = String.Empty
                    CashBalance_Recive_Amount = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_CashBalance_Id As TextBox, ByVal Txt_CashBalance_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashBalance_Payment_Amount As TextBox, ByVal Txt_CashBalance_Recive_Amount As TextBox)
                    '변수에 빈문자열 및 텍스트박스 클리어
                    Clear()
                    Txt_CashBalance_Id.Clear()
                    Txt_CashBalance_Date.Clear()
                    Txt_Profile_Id.Clear()
                    Txt_CashBalance_Payment_Amount.Clear()
                    Txt_CashBalance_Recive_Amount.Clear()
                End Sub
                Public Sub Add(ByVal Txt_CashBalance_Id As TextBox, ByVal Txt_CashBalance_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashBalance_Payment_Amount As TextBox, ByVal Txt_CashBalance_Recive_Amount As TextBox)
                    '입력된 문자열에 '문자 ''로 변환 후 변수에 대입
                    CashBalance_Id = Txt_CashBalance_Id.Text.Replace("'", "''")
                    CashBalance_Date = Txt_CashBalance_Date.Text.Replace("'", "''")
                    Profile_Id = Txt_Profile_Id.Text.Replace("'", "''")
                    CashBalance_Payment_Amount = Txt_CashBalance_Payment_Amount.Text.Replace("'", "''")
                    CashBalance_Recive_Amount = Txt_CashBalance_Recive_Amount.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        'CashBalance_Id 비포함 insert
                        If AutoID = True Then
                            sqlString = "INSERT INTO CashBalance (CashBalance_Date,Profile_Id,CashBalance_Payment_Amount,CashBalance_Recive_Amount) VALUES ('" & CashBalance_Date & "','" & Profile_Id & "','" & CashBalance_Payment_Amount & "','" & CashBalance_Recive_Amount & "')"
                            SQLQueryCommand(sqlString)
                            'CashBalance_Id 비포함 insert
                        Else
                            sqlString = "INSERT INTO CashBalance (CashBalance_Id,CashBalance_Date,Profile_Id,CashBalance_Payment_Amount,CashBalance_Recive_Amount) VALUES ('" & CashBalance_Id & "','" & CashBalance_Date & "','" & Profile_Id & "','" & CashBalance_Payment_Amount & "','" & CashBalance_Recive_Amount & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'CashBalance_Id 비포함 update
                        If AutoID = True Then
                            sqlString = "UPDATE CashBalance SET CashBalance_Date = '" & CashBalance_Date & "',Profile_Id = '" & Profile_Id & "',CashBalance_Payment_Amount = '" & CashBalance_Payment_Amount & "',CashBalance_Recive_Amount = '" & CashBalance_Recive_Amount & "' WHERE CashBalance_Id = " & CashBalance_Id
                            SQLQueryCommand(sqlString)
                        Else
                            'CashBalance_Id 비포함 update
                            sqlString = "UPDATE CashBalance SET CashBalance_Id = '" & CashBalance_Id & "',CashBalance_Date = '" & CashBalance_Date & "',Profile_Id = '" & Profile_Id & "',CashBalance_Payment_Amount = '" & CashBalance_Payment_Amount & "',CashBalance_Recive_Amount = '" & CashBalance_Recive_Amount & "' WHERE CashBalance_Id = " & CashBalance_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_CashBalance_Id As TextBox, ByVal Txt_CashBalance_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashBalance_Payment_Amount As TextBox, ByVal Txt_CashBalance_Recive_Amount As TextBox) As Boolean
                    '텍스트박스가 null 혹은 빈문자열일 경우 포커스 설정 및 에러메세지 출력
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_CashBalance_Id.Text) Then
                            Txt_CashBalance_Id.Focus()
                            MessageBox.Show("TextBox(CashBalance_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_CashBalance_Date.Text) Then
                        Txt_CashBalance_Date.Focus()
                        MessageBox.Show("TextBox(CashBalance_Date) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_Id.Text) Then
                        Txt_Profile_Id.Focus()
                        MessageBox.Show("TextBox(Profile_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_CashBalance_Payment_Amount.Text) Then
                        Txt_CashBalance_Payment_Amount.Focus()
                        MessageBox.Show("TextBox(CashBalance_Payment_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_CashBalance_Recive_Amount.Text) Then
                        Txt_CashBalance_Recive_Amount.Focus()
                        MessageBox.Show("TextBox(CashBalance_Recive_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_CashBalance_Id As TextBox, ByVal Txt_CashBalance_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashBalance_Payment_Amount As TextBox, ByVal Txt_CashBalance_Recive_Amount As TextBox)
                    '입력 체크
                    If IsTextBoxError(AutoID, Txt_CashBalance_Id, Txt_CashBalance_Date, Txt_Profile_Id, Txt_CashBalance_Payment_Amount, Txt_CashBalance_Recive_Amount) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_CashBalance_Id, Txt_CashBalance_Date, Txt_Profile_Id, Txt_CashBalance_Payment_Amount, Txt_CashBalance_Recive_Amount)
                    '커맨드 add일 경우 insert 실행. insert 성공시 메세지 출력 및 텍스트박스 클리어
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_CashBalance_Id, Txt_CashBalance_Date, Txt_Profile_Id, Txt_CashBalance_Payment_Amount, Txt_CashBalance_Recive_Amount)
                        '커맨드 edit일 경우 update 실행. update 성공시 메세지 출력 및 텍스트박스 클리어
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_CashBalance_Id, Txt_CashBalance_Date, Txt_Profile_Id, Txt_CashBalance_Payment_Amount, Txt_CashBalance_Recive_Amount)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수에 대입
                            sqlString = "SELECT * FROM CashBalance WHERE CashBalance_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            CashBalance_Id = sqlDataTable.Rows(0)("CashBalance_Id").ToString
                            CashBalance_Date = sqlDataTable.Rows(0)("CashBalance_Date").ToString
                            Profile_Id = sqlDataTable.Rows(0)("Profile_Id").ToString
                            CashBalance_Payment_Amount = sqlDataTable.Rows(0)("CashBalance_Payment_Amount").ToString
                            CashBalance_Recive_Amount = sqlDataTable.Rows(0)("CashBalance_Recive_Amount").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_CashBalance_Id As TextBox, ByVal Txt_CashBalance_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashBalance_Payment_Amount As TextBox, ByVal Txt_CashBalance_Recive_Amount As TextBox)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_CashBalance_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수 및 텍스트박스에 대입
                            sqlString = "SELECT * FROM CashBalance WHERE CashBalance_Id = " & Txt_CashBalance_Id.Text
                            SQLQueryCommand(sqlString)
                            CashBalance_Id = sqlDataTable.Rows(0)("CashBalance_Id").ToString
                            CashBalance_Date = sqlDataTable.Rows(0)("CashBalance_Date").ToString
                            Profile_Id = sqlDataTable.Rows(0)("Profile_Id").ToString
                            CashBalance_Payment_Amount = sqlDataTable.Rows(0)("CashBalance_Payment_Amount").ToString
                            CashBalance_Recive_Amount = sqlDataTable.Rows(0)("CashBalance_Recive_Amount").ToString
                            Txt_CashBalance_Id.Text = CashBalance_Id
                            Txt_CashBalance_Date.Text = CashBalance_Date
                            Txt_Profile_Id.Text = Profile_Id
                            Txt_CashBalance_Payment_Amount.Text = CashBalance_Payment_Amount
                            Txt_CashBalance_Recive_Amount.Text = CashBalance_Recive_Amount
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  삭제
                            sqlString = "DELETE FROM CashBalance WHERE CashBalance_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_CashBalance_Id As TextBox, ByVal Txt_CashBalance_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashBalance_Payment_Amount As TextBox, ByVal Txt_CashBalance_Recive_Amount As TextBox)
                    Try
                        '텍스트박스에 입력된 값이 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_CashBalance_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes선택시 텍스트박스에 입력된 값과 같은 값을 지닌 칼럼을 찾아 해당 행을 삭제. 
                            '텍스트박스 클리어 후 메시지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM CashBalance WHERE CashBalance_Id = " & Txt_CashBalance_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_CashBalance_Id, Txt_CashBalance_Date, Txt_Profile_Id, Txt_CashBalance_Payment_Amount, Txt_CashBalance_Recive_Amount)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashBalance WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName 칼럼의 값이 FilterPrimaryKey 인 행을 찾아, 해당행이 존재할 경우 삭제
                        For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                            sqlString = "DELETE FROM CashBalance WHERE CashBalance_Id = " & sqlDataTable.Rows(i).Item(0).ToString
                            SQLQueryCommand(sqlString)
                        Next
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashBalance", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '테이블에서 전건 출력 후 0건이면 0리턴 행이 존재할 경우 마지막 행의 id값 리턴
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashBalance", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '전체 행 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Private Sub TotalAmountError(ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashBalance", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FieldIndex As Integer) As Double
                    'TotalAmount 변수에 값 대입후 리턴
                    TotalAmountError(FieldIndex)
                    Return TotalAmount
                End Function
                Private Sub FilterTotalAmountError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashBalance WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As Double
                    'TotalAmount 변수에 값 대입후 리턴
                    FilterTotalAmountError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return TotalAmount
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        'FieldName칼럼에 텍스트박스 값과 같은 데이터가 존재하면 포커스 설정 및 에러메세지 출력
                        sqlString = "SELECT * FROM CashBalance WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashBalance", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    ListError(FieldIndex)
                    Return BoundList
                End Function
                Private Sub FilterListError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashBalance WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'ilterFieldName칼럼의 값이 FilterPrimaryKey와 같은 행 테이블로부터 취득 후 칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                Else
                                    BoundList &= vbNewLine & CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As String
                    FilterListError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT CashBalance_Id, CashBalance_Date FROM CashBalance", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "CashBalance_Date"
                            .ValueMember = "CashBalance_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT CashBalance_Id, CashBalance_Date FROM CashBalance WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName칼럼 값 = FilterPrimaryKey인 행
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "CashBalance_Date"
                            .ValueMember = "CashBalance_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT CashBalance_Id AS [CASHBALANCE ID],CashBalance_Date AS [CASHBALANCE DATE],Profile_Id AS [PROFILE ID],CashBalance_Payment_Amount AS [CASHBALANCE PAYMENT AMOUNT],CashBalance_Recive_Amount AS [CASHBALANCE RECIVE AMOUNT] FROM CashBalance ORDER BY CashBalance_Date", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT CashBalance_Id AS [CASHBALANCE ID],CashBalance_Date AS [CASHBALANCE DATE],Profile_Id AS [PROFILE ID],CashBalance_Payment_Amount AS [CASHBALANCE PAYMENT AMOUNT],CashBalance_Recive_Amount AS [CASHBALANCE RECIVE AMOUNT] FROM CashBalance WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'SearchSyntax 조건을 만족하는 행
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
            Public Class CashMemo
                Inherits ConnectionString
                Private Property BoundList As String
                Private Property MessageBoxOnOff As Boolean
                Private Property TotalAmount As Double
                Public Property CashMemo_Id As String
                Public Property CashMemo_Date As String
                Public Property Profile_Id As String
                Public Property CashMemo_Payment_Amount As String
                Public Property CashMemo_Recive_Amount As String
                Public Sub Clear()
                    '변수에 빈문자열
                    CashMemo_Id = String.Empty
                    CashMemo_Date = String.Empty
                    Profile_Id = String.Empty
                    CashMemo_Payment_Amount = String.Empty
                    CashMemo_Recive_Amount = String.Empty
                End Sub
                Public Sub Clear(ByVal Txt_CashMemo_Id As TextBox, ByVal Txt_CashMemo_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashMemo_Payment_Amount As TextBox, ByVal Txt_CashMemo_Recive_Amount As TextBox)
                    '변수에 빈문자열 및 텍스트박스 클리어
                    Clear()
                    Txt_CashMemo_Id.Clear()
                    Txt_CashMemo_Date.Clear()
                    Txt_Profile_Id.Clear()
                    Txt_CashMemo_Payment_Amount.Clear()
                    Txt_CashMemo_Recive_Amount.Clear()
                End Sub
                Public Sub Add(ByVal Txt_CashMemo_Id As TextBox, ByVal Txt_CashMemo_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashMemo_Payment_Amount As TextBox, ByVal Txt_CashMemo_Recive_Amount As TextBox)
                    '입력된 문자열에 '문자 ''로 변환 후 변수에 대입
                    CashMemo_Id = Txt_CashMemo_Id.Text.Replace("'", "''")
                    CashMemo_Date = Txt_CashMemo_Date.Text.Replace("'", "''")
                    Profile_Id = Txt_Profile_Id.Text.Replace("'", "''")
                    CashMemo_Payment_Amount = Txt_CashMemo_Payment_Amount.Text.Replace("'", "''")
                    CashMemo_Recive_Amount = Txt_CashMemo_Recive_Amount.Text.Replace("'", "''")
                End Sub
                Public Sub Save(ByVal AutoID As Boolean)
                    Try
                        'CashMemo_Id 비포함 insert
                        If AutoID = True Then
                            sqlString = "INSERT INTO CashMemo (CashMemo_Date,Profile_Id,CashMemo_Payment_Amount,CashMemo_Recive_Amount) VALUES ('" & CashMemo_Date & "','" & Profile_Id & "','" & CashMemo_Payment_Amount & "','" & CashMemo_Recive_Amount & "')"
                            SQLQueryCommand(sqlString)
                        Else
                            'CashMemo_Id 비포함 insert
                            sqlString = "INSERT INTO CashMemo (CashMemo_Id,CashMemo_Date,Profile_Id,CashMemo_Payment_Amount,CashMemo_Recive_Amount) VALUES ('" & CashMemo_Id & "','" & CashMemo_Date & "','" & Profile_Id & "','" & CashMemo_Payment_Amount & "','" & CashMemo_Recive_Amount & "')"
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Update(ByVal AutoID As Boolean)
                    Try
                        'CashMemo_Id 비포함 update
                        If AutoID = True Then
                            sqlString = "UPDATE CashMemo SET CashMemo_Date = '" & CashMemo_Date & "',Profile_Id = '" & Profile_Id & "',CashMemo_Payment_Amount = '" & CashMemo_Payment_Amount & "',CashMemo_Recive_Amount = '" & CashMemo_Recive_Amount & "' WHERE CashMemo_Id = " & CashMemo_Id
                            SQLQueryCommand(sqlString)
                        Else
                            'CashMemo_Id 비포함 update
                            sqlString = "UPDATE CashMemo SET CashMemo_Id = '" & CashMemo_Id & "',CashMemo_Date = '" & CashMemo_Date & "',Profile_Id = '" & Profile_Id & "',CashMemo_Payment_Amount = '" & CashMemo_Payment_Amount & "',CashMemo_Recive_Amount = '" & CashMemo_Recive_Amount & "' WHERE CashMemo_Id = " & CashMemo_Id
                            SQLQueryCommand(sqlString)
                        End If
                        MessageBoxOnOff = True
                    Catch ex As Exception
                        MessageBoxOnOff = False
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function IsTextBoxError(ByVal AutoID As Boolean, ByVal Txt_CashMemo_Id As TextBox, ByVal Txt_CashMemo_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashMemo_Payment_Amount As TextBox, ByVal Txt_CashMemo_Recive_Amount As TextBox) As Boolean
                    '텍스트박스가 null 혹은 빈문자열일 경우 포커스 설정 및 에러메세지 출력
                    If AutoID = False Then
                        If String.IsNullOrEmpty(Txt_CashMemo_Id.Text) Then
                            Txt_CashMemo_Id.Focus()
                            MessageBox.Show("TextBox(CashMemo_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return True
                        End If
                    End If
                    If String.IsNullOrEmpty(Txt_CashMemo_Date.Text) Then
                        Txt_CashMemo_Date.Focus()
                        MessageBox.Show("TextBox(CashMemo_Date) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_Profile_Id.Text) Then
                        Txt_Profile_Id.Focus()
                        MessageBox.Show("TextBox(Profile_Id) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_CashMemo_Payment_Amount.Text) Then
                        Txt_CashMemo_Payment_Amount.Focus()
                        MessageBox.Show("TextBox(CashMemo_Payment_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    ElseIf String.IsNullOrEmpty(Txt_CashMemo_Recive_Amount.Text) Then
                        Txt_CashMemo_Recive_Amount.Focus()
                        MessageBox.Show("TextBox(CashMemo_Recive_Amount) is empty, please insert data to save into database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Public Sub Auto(ByVal AutoID As Boolean, ByVal Command As String, ByVal Txt_CashMemo_Id As TextBox, ByVal Txt_CashMemo_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashMemo_Payment_Amount As TextBox, ByVal Txt_CashMemo_Recive_Amount As TextBox)
                    '입력 체크
                    If IsTextBoxError(AutoID, Txt_CashMemo_Id, Txt_CashMemo_Date, Txt_Profile_Id, Txt_CashMemo_Payment_Amount, Txt_CashMemo_Recive_Amount) = True Then Exit Sub
                    '문자열 변환
                    Add(Txt_CashMemo_Id, Txt_CashMemo_Date, Txt_Profile_Id, Txt_CashMemo_Payment_Amount, Txt_CashMemo_Recive_Amount)
                    '커맨드 add일 경우 insert 실행. insert 성공시 메세지 출력 및 텍스트박스 클리어
                    If Command.ToLower.Equals("add") = True Then
                        Save(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully save to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_CashMemo_Id, Txt_CashMemo_Date, Txt_Profile_Id, Txt_CashMemo_Payment_Amount, Txt_CashMemo_Recive_Amount)
                        '커맨드 edit일 경우 update 실행. update 성공시 메세지 출력 및 텍스트박스 클리어
                    ElseIf Command.ToLower.Equals("edit") = True Then
                        Update(AutoID)
                        If MessageBoxOnOff = True Then MessageBox.Show("Record sucessfully update to database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If MessageBoxOnOff = True Then Clear(Txt_CashMemo_Id, Txt_CashMemo_Date, Txt_Profile_Id, Txt_CashMemo_Payment_Amount, Txt_CashMemo_Recive_Amount)
                    End If
                End Sub
                Public Sub Load(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수에 대입
                            sqlString = "SELECT * FROM CashMemo WHERE CashMemo_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                            CashMemo_Id = sqlDataTable.Rows(0)("CashMemo_Id").ToString
                            CashMemo_Date = sqlDataTable.Rows(0)("CashMemo_Date").ToString
                            Profile_Id = sqlDataTable.Rows(0)("Profile_Id").ToString
                            CashMemo_Payment_Amount = sqlDataTable.Rows(0)("CashMemo_Payment_Amount").ToString
                            CashMemo_Recive_Amount = sqlDataTable.Rows(0)("CashMemo_Recive_Amount").ToString
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Load(ByVal Txt_CashMemo_Id As TextBox, ByVal Txt_CashMemo_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashMemo_Payment_Amount As TextBox, ByVal Txt_CashMemo_Recive_Amount As TextBox)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_CashMemo_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  변수 및 텍스트박스에 대입
                            sqlString = "SELECT * FROM CashMemo WHERE CashMemo_Id = " & Txt_CashMemo_Id.Text
                            SQLQueryCommand(sqlString)
                            CashMemo_Id = sqlDataTable.Rows(0)("CashMemo_Id").ToString
                            CashMemo_Date = sqlDataTable.Rows(0)("CashMemo_Date").ToString
                            Profile_Id = sqlDataTable.Rows(0)("Profile_Id").ToString
                            CashMemo_Payment_Amount = sqlDataTable.Rows(0)("CashMemo_Payment_Amount").ToString
                            CashMemo_Recive_Amount = sqlDataTable.Rows(0)("CashMemo_Recive_Amount").ToString
                            Txt_CashMemo_Id.Text = CashMemo_Id
                            Txt_CashMemo_Date.Text = CashMemo_Date
                            Txt_Profile_Id.Text = Profile_Id
                            Txt_CashMemo_Payment_Amount.Text = CashMemo_Payment_Amount
                            Txt_CashMemo_Recive_Amount.Text = CashMemo_Recive_Amount
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to load record details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal PrimaryKey As String)
                    Try
                        'PrimaryKey 가 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(PrimaryKey) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '칼럼에 매개변수 PrimaryKey 와 같은 데이터가 있을 경우 해당 행의 데이터를  삭제
                            sqlString = "DELETE FROM CashMemo WHERE CashMemo_Id = " & PrimaryKey
                            SQLQueryCommand(sqlString)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal Txt_CashMemo_Id As TextBox, ByVal Txt_CashMemo_Date As TextBox, ByVal Txt_Profile_Id As TextBox, ByVal Txt_CashMemo_Payment_Amount As TextBox, ByVal Txt_CashMemo_Recive_Amount As TextBox)
                    Try
                        '텍스트박스에 입력된 값이 숫자로 변환 가능하지않으면 에러메세지 출력
                        If Not IsNumeric(Txt_CashMemo_Id.Text) Then
                            MessageBox.Show("Primary key is not valided, try a new primary key in numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            '다이어로그에서 yes선택시 텍스트박스에 입력된 값과 같은 값을 지닌 칼럼을 찾아 해당 행을 삭제. 
                            '텍스트박스 클리어 후 메시지 출력
                            Dim result As Integer = MessageBox.Show("Do you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If result = DialogResult.Yes Then
                                sqlString = "DELETE FROM CashMemo WHERE CashMemo_Id = " & Txt_CashMemo_Id.Text
                                SQLQueryCommand(sqlString)
                                Clear(Txt_CashMemo_Id, Txt_CashMemo_Date, Txt_Profile_Id, Txt_CashMemo_Payment_Amount, Txt_CashMemo_Recive_Amount)
                                MessageBox.Show("The record is sucessfully deleted form database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("The record id not exits, try a new record id to delete record form database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub Delete(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashMemo WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName 칼럼의 값이 FilterPrimaryKey 인 행을 찾아, 해당행이 존재할 경우 삭제
                        For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                            sqlString = "DELETE FROM CashMemo WHERE CashMemo_Id = " & sqlDataTable.Rows(i).Item(0).ToString
                            SQLQueryCommand(sqlString)
                        Next
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetLastRecordId() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashMemo", sqlOleDbConnection)
                    Dim rowIndex As Integer
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '테이블에서 전건 출력 후 0건이면 0리턴 행이 존재할 경우 마지막 행의 id값 리턴
                    If sqlDataTable.Rows.Count = 0 Then
                        Return 0
                        sqlOleDbConnection.Close()
                        Exit Function
                    Else
                        rowIndex = sqlDataTable.Rows.Count - 1
                        Return CType(sqlDataTable.Rows(rowIndex).Item(0), Integer)
                        sqlOleDbConnection.Close()
                    End If
                End Function
                Public Function GetTotalRecord() As Integer
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashMemo", sqlOleDbConnection)
                    sqlOleDbConnection.Open()
                    sqlDataTable.Reset()
                    sqlOleDbDataAdapter.Fill(sqlDataTable)
                    '전체 행 수 리턴
                    Return sqlDataTable.Rows.Count
                    sqlOleDbConnection.Close()
                End Function
                Private Sub TotalAmountError(ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashMemo", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FieldIndex As Integer) As Double
                    'TotalAmount 변수에 값 대입후 리턴
                    TotalAmountError(FieldIndex)
                    Return TotalAmount
                End Function
                Private Sub FilterTotalAmountError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        TotalAmount = 0
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashMemo WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            'for문 행의 숫자만큼 실행. TotalAmount에 FieldIndex번째 칼럼 값 더해주기
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                TotalAmount += CType(sqlDataTable.Rows(i).Item(FieldIndex), Double)
                            Next
                            sqlOleDbConnection.Close()
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        TotalAmount = 0
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetTotalAmount(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As Double
                    'TotalAmount 변수에 값 대입후 리턴
                    FilterTotalAmountError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return TotalAmount
                End Function
                Public Sub DuplicateAlert(ByVal FieldName As String, ByVal Record As TextBox)
                    Try
                        'FieldName칼럼에 텍스트박스 값과 같은 데이터가 존재하면 포커스 설정 및 에러메세지 출력
                        sqlString = "SELECT * FROM CashMemo WHERE " & FieldName & " = '" & Record.Text.Replace("'", "''") & "'"
                        SQLQueryCommand(sqlString)
                        If sqlDataTable.Rows.Count > 0 Then
                            Record.Focus()
                            MessageBox.Show("The record already exits try a new record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Field name is not vailded, try new field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Private Sub ListError(ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashMemo", sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        '칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                Else
                                    BoundList &= vbNewLine & sqlDataTable.Rows(i).Item(FieldIndex).ToString
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FieldIndex As Integer) As String
                    ListError(FieldIndex)
                    Return BoundList
                End Function
                Private Sub FilterListError(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer)
                    Try
                        Dim sqlDataTable As New DataTable
                        Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                        Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT * FROM CashMemo WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'ilterFieldName칼럼의 값이 FilterPrimaryKey와 같은 행 테이블로부터 취득 후 칼럼의 숫자가 FieldIndex와 같거나 크면
                        If sqlDataTable.Columns.Count - 1 >= FieldIndex Then
                            BoundList = String.Empty
                            '행의 수만큼 for문 실행. BoundList가 null 혹은 빈문자열이면 첫번째 for문 실행. 이후 실행되는 for문은 계속해서 BoundList에 문자열 더해준다.
                            For i As Integer = 0 To sqlDataTable.Rows.Count - 1
                                If String.IsNullOrWhiteSpace(BoundList) Then
                                    BoundList = CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                Else
                                    BoundList &= vbNewLine & CType(sqlDataTable.Rows(i).Item(FieldIndex), String)
                                End If
                            Next
                        Else
                            MessageBox.Show("Field index is not vailded, try new field index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        BoundList = String.Empty
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Function GetList(ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String, ByVal FieldIndex As Integer) As String
                    FilterListError(FilterFieldName, FilterPrimaryKey, FieldIndex)
                    Return BoundList
                End Function
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT CashMemo_Id, CashMemo_Date FROM CashMemo", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "CashMemo_Date"
                            .ValueMember = "CashMemo_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundComboBox(ByVal ComboBox As ComboBox, ByVal FilterFieldName As String, ByVal FilterPrimaryKey As String)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT CashMemo_Id, CashMemo_Date FROM CashMemo WHERE " & FilterFieldName & " = " & FilterPrimaryKey, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'FilterFieldName칼럼 값 = FilterPrimaryKey인 행
                        'select로 데이터 취득후 콤보박스 속성에 대입
                        With ComboBox
                            .DataSource = sqlDataTable
                            .DisplayMember = "CashMemo_Date"
                            .ValueMember = "CashMemo_Id"
                            .SelectedIndex = -1
                            .Text = String.Empty
                        End With
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView)
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT CashMemo_Id AS [CASHMEMO ID],CashMemo_Date AS [CASHMEMO DATE],Profile_Id AS [PROFILE ID],CashMemo_Payment_Amount AS [CASHMEMO PAYMENT AMOUNT],CashMemo_Recive_Amount AS [CASHMEMO RECIVE AMOUNT] FROM CashMemo ORDER BY CashMemo_Date", sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
                Public Sub BoundDataGridView(ByVal DataGridView As DataGridView, Optional ByVal SearchSyntax As String = "")
                    Dim sqlDataTable As New DataTable
                    Dim sqlOleDbConnection As New OleDbConnection(sqlConnectionString)
                    Dim sqlOleDbDataAdapter As New OleDbDataAdapter("SELECT CashMemo_Id AS [CASHMEMO ID],CashMemo_Date AS [CASHMEMO DATE],Profile_Id AS [PROFILE ID],CashMemo_Payment_Amount AS [CASHMEMO PAYMENT AMOUNT],CashMemo_Recive_Amount AS [CASHMEMO RECIVE AMOUNT] FROM CashMemo WHERE " & SearchSyntax, sqlOleDbConnection)
                    Try
                        sqlOleDbConnection.Open()
                        sqlDataTable.Reset()
                        sqlOleDbDataAdapter.Fill(sqlDataTable)
                        'SearchSyntax 조건을 만족하는 행
                        'select로 데이터 취득후 DataGridView 속성에 대입 및 사이즈 조절
                        With DataGridView
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                            .DataSource = sqlDataTable
                            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                            .ReadOnly = True
                            .RowHeadersWidth = 30
                            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                        End With
                        '첫번째 칼럼 invisible
                        If DataGridView.Columns.Count - 1 >= 1 Then DataGridView.Columns(0).Visible = False
                        sqlOleDbConnection.Close()
                    Catch ex As Exception
                        sqlOleDbConnection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Sub
            End Class
        End Class
    End Namespace
End Namespace
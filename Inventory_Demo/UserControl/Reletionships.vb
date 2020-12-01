Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(Reletionships), "Reletionships.ico"), ToolboxItem(False)>
    Public Class Reletionships
        Inherits UserControl
#Region " Component Designer generated code "
        Public Sub New()
            MyBase.New()
            ' This call is required by the Component Designer.
            InitializeComponent()
            'Add any initialization after the InitializeComponent() call
            ' This draws the control whenever it is resized
            SetStyle(ControlStyles.ResizeRedraw, True)
            ' This supports mouse movement such as the mouse wheel
            SetStyle(ControlStyles.UserMouse, True)
            ' This allows the control to be transparent
            SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            ' This helps with drawing the control so that it doesn't flicker
            Me.SetStyle(ControlStyles.DoubleBuffer _
            Or ControlStyles.UserPaint _
            Or ControlStyles.AllPaintingInWmPaint,
            True)
            ' This updates the styles
            Me.UpdateStyles()
            ' Sets the hover time to 30 milliseconds. This is used
            ' to trigger the control to change the backcolor back to the
            ' original value due to the mouse no longer being over
            ' the control. 
            '
            ' The time is used because it's more reliable than using the
            ' MouseLeave or MouseEnter events, which depending on the speed
            ' of the mouse, may or may not get fired.
        End Sub
        'Control overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Friend WithEvents Lbl_Reletionship_Id As Label
        Friend WithEvents Cbo_Reletionship_Id As ComboBox
        Friend WithEvents Txt_Reletionship_Id As TextBox
        Friend WithEvents Btn_Add_Reletionship_Id As Button
        Friend WithEvents Btn_Edit_Reletionship_Id As Button
        Friend WithEvents Btn_Del_Reletionship_Id As Button
        Friend WithEvents Lbl_Reletionship_Name As Label
        Friend WithEvents Txt_Reletionship_Name As TextBox
        Friend WithEvents Lbl_Reletionship_Note As Label
        Friend WithEvents Txt_Reletionship_Note As TextBox
        Friend WithEvents Lbl_Header As Label
        Friend WithEvents UIFormTips As ToolTip
        Friend WithEvents Pnl_Top As Panel
        Friend WithEvents Pnl_Bottom As Panel
        Friend WithEvents Btn_Exit As Button
        Friend WithEvents Btn_Save As Button
        Friend WithEvents Btn_New As Button
        'Required by the Control Designer
        Private components As IContainer
        ' NOTE: The following procedure is required by the Component Designer
        ' It can be modified using the Component Designer.Do not modify it
        ' using the code editor.
        <DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reletionships))
            Me.Lbl_Reletionship_Id = New System.Windows.Forms.Label()
            Me.Cbo_Reletionship_Id = New System.Windows.Forms.ComboBox()
            Me.Txt_Reletionship_Id = New System.Windows.Forms.TextBox()
            Me.Btn_Add_Reletionship_Id = New System.Windows.Forms.Button()
            Me.Btn_Edit_Reletionship_Id = New System.Windows.Forms.Button()
            Me.Btn_Del_Reletionship_Id = New System.Windows.Forms.Button()
            Me.Lbl_Reletionship_Name = New System.Windows.Forms.Label()
            Me.Txt_Reletionship_Name = New System.Windows.Forms.TextBox()
            Me.Lbl_Reletionship_Note = New System.Windows.Forms.Label()
            Me.Txt_Reletionship_Note = New System.Windows.Forms.TextBox()
            Me.Lbl_Header = New System.Windows.Forms.Label()
            Me.UIFormTips = New System.Windows.Forms.ToolTip(Me.components)
            Me.Btn_Exit = New System.Windows.Forms.Button()
            Me.Btn_Save = New System.Windows.Forms.Button()
            Me.Btn_New = New System.Windows.Forms.Button()
            Me.Pnl_Top = New System.Windows.Forms.Panel()
            Me.Pnl_Bottom = New System.Windows.Forms.Panel()
            Me.Pnl_Top.SuspendLayout()
            Me.Pnl_Bottom.SuspendLayout()
            Me.SuspendLayout()
            '
            'Lbl_Reletionship_Id
            '
            Me.Lbl_Reletionship_Id.AutoSize = True
            Me.Lbl_Reletionship_Id.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Reletionship_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Reletionship_Id.ForeColor = System.Drawing.Color.White
            Me.Lbl_Reletionship_Id.Location = New System.Drawing.Point(18, 62)
            Me.Lbl_Reletionship_Id.Name = "Lbl_Reletionship_Id"
            Me.Lbl_Reletionship_Id.Size = New System.Drawing.Size(26, 14)
            Me.Lbl_Reletionship_Id.TabIndex = 0
            Me.Lbl_Reletionship_Id.Text = "Id:"
            '
            'Cbo_Reletionship_Id
            '
            Me.Cbo_Reletionship_Id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.Cbo_Reletionship_Id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.Cbo_Reletionship_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Cbo_Reletionship_Id.FormattingEnabled = True
            Me.Cbo_Reletionship_Id.Location = New System.Drawing.Point(71, 59)
            Me.Cbo_Reletionship_Id.Name = "Cbo_Reletionship_Id"
            Me.Cbo_Reletionship_Id.Size = New System.Drawing.Size(200, 22)
            Me.Cbo_Reletionship_Id.TabIndex = 0
            '
            'Txt_Reletionship_Id
            '
            Me.Txt_Reletionship_Id.BackColor = System.Drawing.SystemColors.Window
            Me.Txt_Reletionship_Id.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Reletionship_Id.ForeColor = System.Drawing.Color.Black
            Me.Txt_Reletionship_Id.Location = New System.Drawing.Point(279, 59)
            Me.Txt_Reletionship_Id.Name = "Txt_Reletionship_Id"
            Me.Txt_Reletionship_Id.ReadOnly = True
            Me.Txt_Reletionship_Id.Size = New System.Drawing.Size(40, 22)
            Me.Txt_Reletionship_Id.TabIndex = 0
            Me.Txt_Reletionship_Id.TabStop = False
            Me.Txt_Reletionship_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Btn_Add_Reletionship_Id
            '
            Me.Btn_Add_Reletionship_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Add_Reletionship_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Add_Reletionship_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Add_Reletionship_Id.Image = CType(resources.GetObject("Btn_Add_Reletionship_Id.Image"), System.Drawing.Image)
            Me.Btn_Add_Reletionship_Id.Location = New System.Drawing.Point(327, 56)
            Me.Btn_Add_Reletionship_Id.Name = "Btn_Add_Reletionship_Id"
            Me.Btn_Add_Reletionship_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Add_Reletionship_Id.TabIndex = 0
            Me.Btn_Add_Reletionship_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Add_Reletionship_Id, "Add")
            Me.Btn_Add_Reletionship_Id.UseVisualStyleBackColor = True
            '
            'Btn_Edit_Reletionship_Id
            '
            Me.Btn_Edit_Reletionship_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Edit_Reletionship_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Edit_Reletionship_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Edit_Reletionship_Id.Image = CType(resources.GetObject("Btn_Edit_Reletionship_Id.Image"), System.Drawing.Image)
            Me.Btn_Edit_Reletionship_Id.Location = New System.Drawing.Point(363, 56)
            Me.Btn_Edit_Reletionship_Id.Name = "Btn_Edit_Reletionship_Id"
            Me.Btn_Edit_Reletionship_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Edit_Reletionship_Id.TabIndex = 0
            Me.Btn_Edit_Reletionship_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Edit_Reletionship_Id, "Edit")
            Me.Btn_Edit_Reletionship_Id.UseVisualStyleBackColor = True
            '
            'Btn_Del_Reletionship_Id
            '
            Me.Btn_Del_Reletionship_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Del_Reletionship_Id.FlatAppearance.BorderSize = 0
            Me.Btn_Del_Reletionship_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Del_Reletionship_Id.Image = CType(resources.GetObject("Btn_Del_Reletionship_Id.Image"), System.Drawing.Image)
            Me.Btn_Del_Reletionship_Id.Location = New System.Drawing.Point(399, 56)
            Me.Btn_Del_Reletionship_Id.Name = "Btn_Del_Reletionship_Id"
            Me.Btn_Del_Reletionship_Id.Size = New System.Drawing.Size(28, 28)
            Me.Btn_Del_Reletionship_Id.TabIndex = 0
            Me.Btn_Del_Reletionship_Id.TabStop = False
            Me.UIFormTips.SetToolTip(Me.Btn_Del_Reletionship_Id, "Delete")
            Me.Btn_Del_Reletionship_Id.UseVisualStyleBackColor = True
            '
            'Lbl_Reletionship_Name
            '
            Me.Lbl_Reletionship_Name.AutoSize = True
            Me.Lbl_Reletionship_Name.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Reletionship_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Reletionship_Name.ForeColor = System.Drawing.Color.White
            Me.Lbl_Reletionship_Name.Location = New System.Drawing.Point(18, 88)
            Me.Lbl_Reletionship_Name.Name = "Lbl_Reletionship_Name"
            Me.Lbl_Reletionship_Name.Size = New System.Drawing.Size(50, 14)
            Me.Lbl_Reletionship_Name.TabIndex = 1
            Me.Lbl_Reletionship_Name.Text = "Name:"
            '
            'Txt_Reletionship_Name
            '
            Me.Txt_Reletionship_Name.BackColor = System.Drawing.Color.White
            Me.Txt_Reletionship_Name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Reletionship_Name.ForeColor = System.Drawing.Color.Black
            Me.Txt_Reletionship_Name.Location = New System.Drawing.Point(71, 85)
            Me.Txt_Reletionship_Name.Name = "Txt_Reletionship_Name"
            Me.Txt_Reletionship_Name.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Reletionship_Name.TabIndex = 1
            '
            'Lbl_Reletionship_Note
            '
            Me.Lbl_Reletionship_Note.AutoSize = True
            Me.Lbl_Reletionship_Note.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Reletionship_Note.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Reletionship_Note.ForeColor = System.Drawing.Color.White
            Me.Lbl_Reletionship_Note.Location = New System.Drawing.Point(18, 114)
            Me.Lbl_Reletionship_Note.Name = "Lbl_Reletionship_Note"
            Me.Lbl_Reletionship_Note.Size = New System.Drawing.Size(43, 14)
            Me.Lbl_Reletionship_Note.TabIndex = 2
            Me.Lbl_Reletionship_Note.Text = "Note:"
            '
            'Txt_Reletionship_Note
            '
            Me.Txt_Reletionship_Note.BackColor = System.Drawing.Color.White
            Me.Txt_Reletionship_Note.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Txt_Reletionship_Note.ForeColor = System.Drawing.Color.Black
            Me.Txt_Reletionship_Note.Location = New System.Drawing.Point(71, 111)
            Me.Txt_Reletionship_Note.Name = "Txt_Reletionship_Note"
            Me.Txt_Reletionship_Note.Size = New System.Drawing.Size(200, 22)
            Me.Txt_Reletionship_Note.TabIndex = 2
            '
            'Lbl_Header
            '
            Me.Lbl_Header.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Header.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Lbl_Header.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Header.ForeColor = System.Drawing.Color.White
            Me.Lbl_Header.Image = CType(resources.GetObject("Lbl_Header.Image"), System.Drawing.Image)
            Me.Lbl_Header.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Lbl_Header.Location = New System.Drawing.Point(0, 0)
            Me.Lbl_Header.Name = "Lbl_Header"
            Me.Lbl_Header.Size = New System.Drawing.Size(447, 48)
            Me.Lbl_Header.TabIndex = 28
            Me.Lbl_Header.Text = "       Add Reletionships Here !!!"
            Me.Lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Btn_Exit
            '
            Me.Btn_Exit.BackgroundImage = CType(resources.GetObject("Btn_Exit.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Exit.FlatAppearance.BorderSize = 0
            Me.Btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Exit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Exit.ForeColor = System.Drawing.Color.White
            Me.Btn_Exit.Image = CType(resources.GetObject("Btn_Exit.Image"), System.Drawing.Image)
            Me.Btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Exit.Location = New System.Drawing.Point(357, 0)
            Me.Btn_Exit.Name = "Btn_Exit"
            Me.Btn_Exit.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Exit.TabIndex = 6
            Me.Btn_Exit.Text = "EXIT"
            Me.Btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_Exit, "Exit")
            Me.Btn_Exit.UseVisualStyleBackColor = True
            '
            'Btn_Save
            '
            Me.Btn_Save.BackgroundImage = CType(resources.GetObject("Btn_Save.BackgroundImage"), System.Drawing.Image)
            Me.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_Save.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_Save.FlatAppearance.BorderSize = 0
            Me.Btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_Save.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Save.ForeColor = System.Drawing.Color.White
            Me.Btn_Save.Image = CType(resources.GetObject("Btn_Save.Image"), System.Drawing.Image)
            Me.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_Save.Location = New System.Drawing.Point(267, 0)
            Me.Btn_Save.Name = "Btn_Save"
            Me.Btn_Save.Size = New System.Drawing.Size(90, 48)
            Me.Btn_Save.TabIndex = 5
            Me.Btn_Save.Text = "SAVE"
            Me.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_Save, "Save")
            Me.Btn_Save.UseVisualStyleBackColor = True
            '
            'Btn_New
            '
            Me.Btn_New.BackgroundImage = CType(resources.GetObject("Btn_New.BackgroundImage"), System.Drawing.Image)
            Me.Btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Btn_New.Dock = System.Windows.Forms.DockStyle.Right
            Me.Btn_New.FlatAppearance.BorderSize = 0
            Me.Btn_New.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
            Me.Btn_New.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
            Me.Btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Btn_New.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_New.ForeColor = System.Drawing.Color.White
            Me.Btn_New.Image = CType(resources.GetObject("Btn_New.Image"), System.Drawing.Image)
            Me.Btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Btn_New.Location = New System.Drawing.Point(177, 0)
            Me.Btn_New.Name = "Btn_New"
            Me.Btn_New.Size = New System.Drawing.Size(90, 48)
            Me.Btn_New.TabIndex = 4
            Me.Btn_New.Text = "NEW"
            Me.Btn_New.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.UIFormTips.SetToolTip(Me.Btn_New, "New")
            Me.Btn_New.UseVisualStyleBackColor = True
            '
            'Pnl_Top
            '
            Me.Pnl_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Top.BackgroundImage = CType(resources.GetObject("Pnl_Top.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Top.Controls.Add(Me.Lbl_Header)
            Me.Pnl_Top.Dock = System.Windows.Forms.DockStyle.Top
            Me.Pnl_Top.Location = New System.Drawing.Point(0, 0)
            Me.Pnl_Top.Name = "Pnl_Top"
            Me.Pnl_Top.Size = New System.Drawing.Size(447, 48)
            Me.Pnl_Top.TabIndex = 61
            '
            'Pnl_Bottom
            '
            Me.Pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.Pnl_Bottom.BackgroundImage = CType(resources.GetObject("Pnl_Bottom.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Pnl_Bottom.Controls.Add(Me.Btn_New)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Save)
            Me.Pnl_Bottom.Controls.Add(Me.Btn_Exit)
            Me.Pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Pnl_Bottom.Location = New System.Drawing.Point(0, 144)
            Me.Pnl_Bottom.Name = "Pnl_Bottom"
            Me.Pnl_Bottom.Size = New System.Drawing.Size(447, 48)
            Me.Pnl_Bottom.TabIndex = 74
            '
            'Reletionships
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.Controls.Add(Me.Lbl_Reletionship_Id)
            Me.Controls.Add(Me.Cbo_Reletionship_Id)
            Me.Controls.Add(Me.Txt_Reletionship_Id)
            Me.Controls.Add(Me.Btn_Add_Reletionship_Id)
            Me.Controls.Add(Me.Btn_Edit_Reletionship_Id)
            Me.Controls.Add(Me.Btn_Del_Reletionship_Id)
            Me.Controls.Add(Me.Lbl_Reletionship_Name)
            Me.Controls.Add(Me.Txt_Reletionship_Name)
            Me.Controls.Add(Me.Lbl_Reletionship_Note)
            Me.Controls.Add(Me.Txt_Reletionship_Note)
            Me.Controls.Add(Me.Pnl_Bottom)
            Me.Controls.Add(Me.Pnl_Top)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.Black
            Me.Name = "Reletionships"
            Me.Size = New System.Drawing.Size(447, 192)
            Me.Pnl_Top.ResumeLayout(False)
            Me.Pnl_Bottom.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
#Region " Component Events "
        <DefaultValue(False)>
        Public Property SizeLock As Boolean
        Public Property FormTitle As String
        Private Property ComboBoxUpdate As Boolean
        Private m_AddEdit As String = String.Empty
        Public Property AddEdit As String
            Get
                Return m_AddEdit
            End Get
            Set(value As String)
                m_AddEdit = value
                If m_AddEdit = "Add" Then
                    Lbl_Header.Text = Lbl_Header.Text.Replace("Edit", "Add")
                ElseIf m_AddEdit = "Edit" Then
                    Lbl_Header.Text = Lbl_Header.Text.Replace("Add", "Edit")
                End If
            End Set
        End Property
        Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal specified As System.Windows.Forms.BoundsSpecified)
            MyBase.SetBoundsCore(x, y, 447, 192, specified)
        End Sub
        Private Sub Reletionships_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FormTitle = "Reletionships"
            clsFeature.SizeLock(SizeLock, ParentForm, FormTitle, Me)
            Cbo_Reletionship_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub Reletionships_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
            clsReletionships.BoundComboBox(Cbo_Reletionship_Id)
        End Sub
        Private Sub Reletionships_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            ucReletionships = Nothing
            frmReletionships = Nothing
        End Sub
        Private Sub Btn_Add_Reletionship_Id_Click(sender As Object, e As EventArgs) Handles Btn_Add_Reletionship_Id.Click
            Btn_New.PerformClick()
        End Sub
        Private Sub Btn_Edit_Reletionship_Id_Click(sender As Object, e As EventArgs) Handles Btn_Edit_Reletionship_Id.Click
            clsReletionships.Load(Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Reletionship_Note)
            If Not String.IsNullOrWhiteSpace(Txt_Reletionship_Id.Text) Then AddEdit = "Edit"
            If Not String.IsNullOrWhiteSpace(Txt_Reletionship_Id.Text) Then Cbo_Reletionship_Id.SelectedValue = Txt_Reletionship_Id.Text
        End Sub
        Private Sub Btn_Del_Reletionship_Id_Click(sender As Object, e As EventArgs) Handles Btn_Del_Reletionship_Id.Click
            clsReletionships.Delete(Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Reletionship_Note)
            clsReletionships.BoundComboBox(Cbo_Reletionship_Id)
        End Sub
        Private Sub Cbo_Reletionship_Id_GotFocus(sender As Object, e As EventArgs) Handles Cbo_Reletionship_Id.GotFocus
            If Cbo_Reletionship_Id.SelectedIndex = -1 Then ComboBoxUpdate = True
        End Sub
        Private Sub Cbo_Reletionship_Id_DropDown(sender As Object, e As EventArgs) Handles Cbo_Reletionship_Id.DropDown
            clsReletionships.BoundComboBox(Cbo_Reletionship_Id)
        End Sub
        Private Sub Cbo_Reletionship_Id_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cbo_Reletionship_Id.PreviewKeyDown
            If ComboBoxUpdate = True Then
                clsReletionships.BoundComboBox(Cbo_Reletionship_Id)
                ComboBoxUpdate = False
            End If
        End Sub
        Private Sub Cbo_Reletionship_Id_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_Reletionship_Id.SelectionChangeCommitted
            If Not Cbo_Reletionship_Id.SelectedIndex = -1 Then Txt_Reletionship_Id.Text = Cbo_Reletionship_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Reletionship_Id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Reletionship_Id.SelectedIndexChanged
            If Not Cbo_Reletionship_Id.SelectedIndex = -1 Then Txt_Reletionship_Id.Text = Cbo_Reletionship_Id.SelectedValue.ToString
        End Sub
        Private Sub Cbo_Reletionship_Id_LostFocus(sender As Object, e As EventArgs) Handles Cbo_Reletionship_Id.LostFocus
            If Cbo_Reletionship_Id.SelectedIndex = -1 Then
                Cbo_Reletionship_Id.Text = String.Empty
                Txt_Reletionship_Id.Clear()
            End If
        End Sub
        Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
            clsReletionships.Clear(Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Reletionship_Note)
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
            clsReletionships.Auto(True, AddEdit, Txt_Reletionship_Id, Txt_Reletionship_Name, Txt_Reletionship_Note)
            Cbo_Reletionship_Id.SelectedIndex = -1
            AddEdit = "Add"
        End Sub
        Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
            Me.ParentForm.Close()
        End Sub
#End Region
    End Class
End Namespace
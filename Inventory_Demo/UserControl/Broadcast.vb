Imports System.ComponentModel
Namespace UIForm
    ' Build Action Embedded Resource
    <ToolboxBitmap(GetType(Broadcast), "Broadcast.ico"), ToolboxItem(True)>
    Public Class Broadcast
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
        Friend WithEvents Trm_Broadcast As Timer
        Friend WithEvents Lbl_Message As Label
        Friend WithEvents Pnl_Left As Panel
        Friend WithEvents Lbl_Datetime As Label
        'Required by the Control Designer
        Private components As IContainer
        ' NOTE: The following procedure is required by the Component Designer
        ' It can be modified using the Component Designer.Do not modify it
        ' using the code editor.
        <DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Broadcast))
            Me.Trm_Broadcast = New System.Windows.Forms.Timer(Me.components)
            Me.Lbl_Message = New System.Windows.Forms.Label()
            Me.Pnl_Left = New System.Windows.Forms.Panel()
            Me.Lbl_Datetime = New System.Windows.Forms.Label()
            Me.Pnl_Left.SuspendLayout()
            Me.SuspendLayout()
            '
            'Trm_Broadcast
            '
            Me.Trm_Broadcast.Interval = 50
            '
            'Lbl_Message
            '
            Me.Lbl_Message.AutoSize = True
            Me.Lbl_Message.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Message.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Message.Location = New System.Drawing.Point(151, 6)
            Me.Lbl_Message.Name = "Lbl_Message"
            Me.Lbl_Message.Size = New System.Drawing.Size(85, 18)
            Me.Lbl_Message.TabIndex = 0
            Me.Lbl_Message.Text = "Message"
            '
            'Pnl_Left
            '
            Me.Pnl_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Pnl_Left.BackgroundImage = CType(resources.GetObject("Pnl_Left.BackgroundImage"), System.Drawing.Image)
            Me.Pnl_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Pnl_Left.Controls.Add(Me.Lbl_Datetime)
            Me.Pnl_Left.Location = New System.Drawing.Point(1222, 0)
            Me.Pnl_Left.Name = "Pnl_Left"
            Me.Pnl_Left.Size = New System.Drawing.Size(116, 30)
            Me.Pnl_Left.TabIndex = 2
            '
            'Lbl_Datetime
            '
            Me.Lbl_Datetime.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Datetime.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Lbl_Datetime.Location = New System.Drawing.Point(0, 0)
            Me.Lbl_Datetime.Name = "Lbl_Datetime"
            Me.Lbl_Datetime.Size = New System.Drawing.Size(116, 30)
            Me.Lbl_Datetime.TabIndex = 2
            Me.Lbl_Datetime.Text = "00/00/0000 00:00:00 AM"
            Me.Lbl_Datetime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Broadcast
            '
            Me.BackColor = System.Drawing.Color.Teal
            Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Controls.Add(Me.Pnl_Left)
            Me.Controls.Add(Me.Lbl_Message)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.White
            Me.Name = "Broadcast"
            Me.Size = New System.Drawing.Size(1360, 30)
            Me.Pnl_Left.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        Private _MoveLeft As Long = 0
        Private _Width As Integer = 0
        <DefaultValue(False)>
        Public Property Start As Boolean
            Get
                Return Trm_Broadcast.Enabled
            End Get
            Set(value As Boolean)
                Trm_Broadcast.Enabled = value
            End Set
        End Property
        Public Property Message As String
            Get
                Return Lbl_Message.Text
            End Get
            Set(value As String)
                Lbl_Message.Text = value
                Trm_Broadcast.Enabled = False
                _Width = Lbl_Message.Width
                _MoveLeft = 0
                Lbl_Message.Left = 1360
                Trm_Broadcast.Enabled = True
            End Set
        End Property
        Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal [width] As Integer, ByVal height As Integer, ByVal specified As System.Windows.Forms.BoundsSpecified)
            MyBase.SetBoundsCore(x, y, 1360, 30, specified)
        End Sub
        Private Sub Trm_Broadcast_Tick(sender As Object, e As EventArgs) Handles Trm_Broadcast.Tick
            _MoveLeft += 1
            If _MoveLeft = 1360 + _Width Then
                _MoveLeft = 0
                Lbl_Message.Left = 1360
            Else
                Lbl_Message.Left -= 1
            End If
            Lbl_Datetime.Text = DateTime.Now
        End Sub
    End Class
End Namespace
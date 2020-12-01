Namespace UIForm
    Public Class SplashScreen
        Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "
        Public Sub New()
            MyBase.New()
            'This call is required by the Windows Form Designer.
            InitializeComponent()
            'Add any initialization after the InitializeComponent() call
        End Sub
        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Friend WithEvents Lbl_PLT As Label
        Friend WithEvents Lbl_Product As Label
        Friend WithEvents Trm_Count As Timer
        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
            Me.Lbl_PLT = New System.Windows.Forms.Label()
            Me.Lbl_Product = New System.Windows.Forms.Label()
            Me.Trm_Count = New System.Windows.Forms.Timer(Me.components)
            Me.SuspendLayout()
            '
            'Lbl_PLT
            '
            Me.Lbl_PLT.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_PLT.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Lbl_PLT.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_PLT.ForeColor = System.Drawing.Color.OrangeRed
            Me.Lbl_PLT.Location = New System.Drawing.Point(0, 95)
            Me.Lbl_PLT.Name = "Lbl_PLT"
            Me.Lbl_PLT.Size = New System.Drawing.Size(561, 56)
            Me.Lbl_PLT.TabIndex = 1
            Me.Lbl_PLT.Text = "PROWER BY HALDER PRIVATE LIMITED"
            Me.Lbl_PLT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Lbl_Product
            '
            Me.Lbl_Product.BackColor = System.Drawing.Color.Transparent
            Me.Lbl_Product.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Lbl_Product.Font = New System.Drawing.Font("Algerian", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Lbl_Product.Location = New System.Drawing.Point(0, 0)
            Me.Lbl_Product.Name = "Lbl_Product"
            Me.Lbl_Product.Size = New System.Drawing.Size(561, 95)
            Me.Lbl_Product.TabIndex = 3
            Me.Lbl_Product.Text = "Inventory"
            Me.Lbl_Product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Trm_Count
            '
            Me.Trm_Count.Enabled = True
            Me.Trm_Count.Interval = 1000
            '
            'SplashScreen
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(561, 151)
            Me.Controls.Add(Me.Lbl_Product)
            Me.Controls.Add(Me.Lbl_PLT)
            Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.Teal
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "SplashScreen"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SplashScreen"
            Me.ResumeLayout(False)

        End Sub
#End Region
#Region " SplashScreen Events "
        Dim _Count As Long
        Private Sub Trm_Tick(sender As Object, e As EventArgs) Handles Trm_Count.Tick
            _Count += 1
            If _Count = 10 Then
                MainForm.ShowInTaskbar = True
                MainForm.WindowState = FormWindowState.Maximized
                MainForm.Show()
                Me.Hide()
                Trm_Count.Enabled = False
            End If
        End Sub
        Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
            MainForm.ShowInTaskbar = False
            MainForm.WindowState = FormWindowState.Minimized
            MainForm.Show()
            MainForm.Hide()
        End Sub
#End Region
    End Class
End Namespace
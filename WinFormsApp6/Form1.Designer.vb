<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        Panel2 = New Panel()
        DataGridView2 = New DataGridView()
        MenuStrip1 = New MenuStrip()
        ListarCiudadesYPaisesToolStripMenuItem = New ToolStripMenuItem()
        ListarConsultaSQLToolStripMenuItem = New ToolStripMenuItem()
        ComboBox2 = New ComboBox()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 422)
        Panel1.TabIndex = 0
        Panel1.Visible = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 17)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(396, 28)
        ComboBox1.TabIndex = 2
        ComboBox1.ValueMember = "Id"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 61)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(776, 290)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(DataGridView2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 28)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 422)
        Panel2.TabIndex = 0
        Panel2.Visible = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(12, 61)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(776, 188)
        DataGridView2.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ListarCiudadesYPaisesToolStripMenuItem, ListarConsultaSQLToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ListarCiudadesYPaisesToolStripMenuItem
        ' 
        ListarCiudadesYPaisesToolStripMenuItem.Name = "ListarCiudadesYPaisesToolStripMenuItem"
        ListarCiudadesYPaisesToolStripMenuItem.Size = New Size(166, 24)
        ListarCiudadesYPaisesToolStripMenuItem.Text = "ListarCiudadesYPaises"
        ' 
        ' ListarConsultaSQLToolStripMenuItem
        ' 
        ListarConsultaSQLToolStripMenuItem.Name = "ListarConsultaSQLToolStripMenuItem"
        ListarConsultaSQLToolStripMenuItem.Size = New Size(141, 24)
        ListarConsultaSQLToolStripMenuItem.Text = "ListarConsultaSQL"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DisplayMember = "Nombre"
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(36, 13)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(649, 28)
        ComboBox2.TabIndex = 1
        ComboBox2.ValueMember = "Id"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListarCiudadesYPaisesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ListarConsultaSQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
